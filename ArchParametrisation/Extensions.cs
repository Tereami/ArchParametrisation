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
    public static class Extensions
    {
        public static List<FamilyInstance> GetMirroredElements(this Document doc)
        {
            List<FamilyInstance> col = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfClass(typeof(FamilyInstance))
                .Cast<FamilyInstance>()
                .Where(i => i.Mirrored)
                .ToList();

            return col;
        }

        public static Dictionary<int, List<FamilyInstance>> GetOpenings(this Document doc)
        {
            List<ElementId> openingsCategories = new List<ElementId>
                {
                    new ElementId(BuiltInCategory.OST_Windows),
                    new ElementId(BuiltInCategory.OST_Doors),
                };
            ElementMulticategoryFilter openingsFilter = new ElementMulticategoryFilter(openingsCategories);
            List<FamilyInstance> openings = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .WherePasses(openingsFilter)
                .OfClass(typeof(FamilyInstance))
                .Cast<FamilyInstance>()
                .ToList();

            Dictionary<int, List<FamilyInstance>> roomIdsAndOpenings =
                new Dictionary<int, List<FamilyInstance>>();

            foreach (FamilyInstance fi in openings)
            {
                List<Room> curRooms = new List<Room>();
                curRooms.Add(fi.Room);
                curRooms.Add(fi.FromRoom);
                foreach (Room r in curRooms)
                {
                    if (r == null) continue;
                    int roomId = r.Id.IntegerValue;
                    if (roomIdsAndOpenings.ContainsKey(roomId))
                        roomIdsAndOpenings[roomId].Add(fi);
                    else
                        roomIdsAndOpenings.Add(roomId, new List<FamilyInstance> { fi });
                }
            }

            return roomIdsAndOpenings;
        }

        public static double GetOpeningArea(this FamilyInstance fi, Settings sets)
        {
            Parameter widthParam = SuperGetParameter(fi, sets.openingsWidthParamName);
            Parameter heightParam = SuperGetParameter(fi, sets.openingsHeightParamName);
            if (widthParam == null || heightParam == null)
                return 0;
            if (!widthParam.HasValue || !heightParam.HasValue)
                return 0;

            double width = widthParam.AsDouble();
            double height = heightParam.AsDouble();
            double openingArea = width * height;
            return openingArea;
        }

        public static Parameter SuperGetParameter(this Element Elem, string ParamName)
        {
            Parameter param = Elem.LookupParameter(ParamName);
            if (param == null)
            {
                Element eltype = Elem.Document.GetElement(Elem.GetTypeId());
                param = eltype.LookupParameter(ParamName);
            }
            return param;
        }

        public static void SetStringParameterValue(this Element elem, string paramName, string value)
        {
            Parameter p = elem.LookupParameter(paramName);
            if (p == null)
                throw new Exception("Нет параметра " + paramName + " в элементе " + elem.Id.IntegerValue.ToString());
            if (p.IsReadOnly)
                throw new Exception("Параметр недоступен: " + paramName + " в элементе " + elem.Id.IntegerValue.ToString());
            p.Set(value);
        }

        public static List<Element> GetBoundaryRoomsElements(this Room r)
        {
            List<Element> elems = new List<Element>();

            SpatialElementBoundaryOptions opts = new SpatialElementBoundaryOptions();
            opts.StoreFreeBoundaryFaces = false;

            foreach (IList<BoundarySegment> boundary in r.GetBoundarySegments(opts))
            {
                foreach (BoundarySegment segment in boundary)
                {
                    ElementId elemId = segment.ElementId;
                    if (elemId == ElementId.InvalidElementId)
                        continue;
                    Element e = r.Document.GetElement(elemId);
                    elems.Add(e);
                }
            }

            return elems;
        }
    }
}
