#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2020, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2020, all rigths reserved.*/
#endregion
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
#endregion

namespace ArchParametrisation
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class CmdArchParametrisation : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            Settings sets = Settings.Activate();


            List<Room> rooms = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfClass(typeof(Autodesk.Revit.DB.SpatialElement))
                .OfCategoryId(new ElementId(BuiltInCategory.OST_Rooms))
                .Cast<Room>()
                .Where(r => r.Area > 0)
                .ToList();

            Dictionary<string, RoomInfo> roomInfosDraft = new Dictionary<string, RoomInfo>();

            foreach (Room r in rooms)
            {
                string roomName = r.get_Parameter(BuiltInParameter.ROOM_NAME).AsString();
                if (!roomInfosDraft.ContainsKey(r.Name))
                {
                    RoomInfo ri = new RoomInfo(r);
                    ri.Name = roomName;

                    List<RoomInfo> checkHaveDefaultInfo = sets.defaultRoomInfos
                        .Where(i => i.Name == roomName).ToList();
                    if (checkHaveDefaultInfo.Count() > 0)
                        ri = checkHaveDefaultInfo[0];

                    if (!roomInfosDraft.ContainsKey(roomName))
                        roomInfosDraft.Add(roomName, ri);
                }
            }


            foreach (RoomInfo ri in roomInfosDraft.Values)
            {
                List<RoomInfo> inSettingsRoomInfo = sets.RoomInfos
                    .Where(i => i.Name == ri.Name).ToList();
                if (inSettingsRoomInfo.Count == 0)
                {
                    sets.RoomInfos.Add(ri);
                }
            }


            FormArchParametrisation form = new FormArchParametrisation(sets);
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return Result.Cancelled;
            }

            sets = form.curSettings;

            List<string> messages = new List<string>();

            int mirroredCount = 0;
            if (sets.enableMirrored)
            {
                using (Transaction t = new Transaction(doc))
                {
                    t.Start("Поиск отзеркаленных");
                    List<FamilyInstance> mirroredElems = doc.GetMirroredElements();
                    foreach (FamilyInstance e in mirroredElems)
                    {
                        e.SetStringParameterValue(sets.mirroredParamName, sets.mirroredText);
                        mirroredCount++;
                    }
                    t.Commit();
                }

                messages.Add("Найдено отзеркаленных элементов: " + mirroredCount.ToString());
            }

            int openingsCount = 0;
            if (sets.enableOpeningsArea)
            {
                using (Transaction t = new Transaction(doc))
                {
                    t.Start("Площади проемов");
                    Dictionary<int, List<FamilyInstance>> roomIdsAndOpenings = doc.GetOpenings();

                    foreach (Room r in rooms)
                    {
                        int roomId = r.Id.IntegerValue;



                        double sumOpeningsArea = 0;
                        if (roomIdsAndOpenings.ContainsKey(roomId))
                        {
                            foreach (FamilyInstance fi in roomIdsAndOpenings[roomId])
                            {
                                double curOpeningArea = fi.GetOpeningArea(sets);
                                if (curOpeningArea > 0)
                                {
                                    sumOpeningsArea += curOpeningArea;
                                    openingsCount++;
                                }
                            }
                        }

                        Parameter openingAreaParam = r.LookupParameter(sets.openingsAreaParamName);
                        if (openingAreaParam == null)
                        {
                            message = "В помещениях нет параметра " + sets.openingsAreaParamName;
                            return Result.Failed;
                        }
                        openingAreaParam.Set(sumOpeningsArea);
                    }
                    t.Commit();
                }
                messages.Add("Найдено проёмов: " + openingsCount.ToString());
            }

            int wallCount = 0;
            if (sets.enableNumbersOfFinishings)
            {
                using (Transaction t = new Transaction(doc))
                {
                    t.Start("Ведомость отделки");

                    foreach (Room r in rooms)
                    {
                        string roomNumber = r.Number;
                        List<Element> walls = r.GetBoundaryRoomsElements();
                        foreach (Element e in walls)
                        {
                            e.SetStringParameterValue(sets.roomNumberParamName, roomNumber);
                            wallCount++;
                        }
                    }

                    t.Commit();
                }
                messages.Add("Обработано элементов отделки: " + openingsCount.ToString());
            }

            int flatsCount = 0;
            if (sets.enableFlatography)
            {
                List<string> livingRooms = sets.RoomInfos.Where(i => i.IsLiving).Select(i => i.Name).ToList();
                Dictionary<string, double> roomCoefs = new Dictionary<string, double>();
                foreach (RoomInfo ri in sets.RoomInfos)
                {
                    roomCoefs.Add(ri.Name, ri.Coeff);
                }

                Dictionary<string, FlatInfo> flats = new Dictionary<string, FlatInfo>();
                foreach (Room room in rooms)
                {
                    string flatNumber = room.LookupParameter(sets.flatNumberParamName).AsString();
                    double roomArea = room.get_Parameter(BuiltInParameter.ROOM_AREA).AsDouble();
                    string roomName = room.get_Parameter(BuiltInParameter.ROOM_NAME).AsString();

                    bool isLiving = false;
                    if (livingRooms.Contains(roomName))
                        isLiving = true;

                    double coeff = 1;
                    if (flats.ContainsKey(roomName))
                        coeff = roomCoefs[roomName];
                    double areaWithCoeff = roomArea * coeff;

                    FlatInfo curFlat = null;
                    if (flats.ContainsKey(flatNumber))
                        curFlat = flats[flatNumber];
                    else
                        curFlat = new FlatInfo();

                    curFlat.FullArea += roomArea;
                    curFlat.AreaWithCoeff += areaWithCoeff;
                    if (isLiving)
                    {
                        curFlat.LivingArea += roomArea;
                        curFlat.RoomsCount++;
                    }

                    if (!flats.ContainsKey(flatNumber))
                        flats.Add(flatNumber, curFlat);
                }

                using (Transaction t = new Transaction(doc))
                {
                    t.Start("Квартирография");

                    foreach (KeyValuePair<string, FlatInfo> kvp in flats)
                    {
                        FlatInfo flat = kvp.Value;
                        foreach (Room r in flat.rooms)
                        {
                            string roomName = r.get_Parameter(BuiltInParameter.ROOM_NAME).AsString();
                            double coeff = roomCoefs[roomName];
                            r.LookupParameter(sets.flatRoomAreaCoeffParamName).Set(coeff);
                            r.LookupParameter(sets.flatRoomsCountParamName).Set(flat.RoomsCount);
                            r.LookupParameter(sets.flatSumAreaParamName).Set(flat.FullArea);
                            r.LookupParameter(sets.flatLivingAreaParamName).Set(flat.LivingArea);
                            r.LookupParameter(sets.flatAreaParamName).Set(flat.AreaWithCoeff);
                        }
                        flatsCount++;
                    }

                    t.Commit();
                }
                messages.Add("Обработано квартир: " + flatsCount.ToString());
            }

            sets.Save();

            string msg = string.Join(System.Environment.NewLine, messages);

            BalloonTip.Show("АР параметризация выполнена!", msg);
            return Result.Succeeded;
        }
    }
}
