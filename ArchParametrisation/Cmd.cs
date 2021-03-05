using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;

namespace ArchParametrisation
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            List<Room> rooms = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfClass(typeof(Autodesk.Revit.DB.SpatialElement))
                .OfCategoryId(new ElementId(BuiltInCategory.OST_Rooms))
                .Cast<Room>()
                .Where(r => r.Area > 0)
                .ToList();

            Dictionary<string, RoomInfo> roomInfos = new Dictionary<string, RoomInfo>();

            foreach(Room r in rooms)
            {
                string roomName = r.Name;
                if(!roomInfos.ContainsKey(r.Name))
                {
                    roomInfos.Add(roomName, new RoomInfo(r));
                }
            }

            List<RoomInfo> roomInfosList = roomInfos.Values.ToList();

            FormSettings form = new FormSettings(roomInfosList);
            if(form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return Result.Cancelled;
            }

            return Result.Succeeded;
        }
    }
}
