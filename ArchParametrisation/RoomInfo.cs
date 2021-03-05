using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchParametrisation
{
    public class RoomInfo
    {
        public string Name;
        public double Coeff;
        public bool IsLive;

        public RoomInfo(Autodesk.Revit.DB.Architecture.Room room)
        {
            Name = room.Name;
            Coeff = 1;
            IsLive = true;
            roomIds = new List<Autodesk.Revit.DB.ElementId> { room.Id };
        }

        public RoomInfo(string name, double coeff, bool isLive)
        {
            Name = name;
            Coeff = coeff;
            IsLive = isLive;
        }
    }
}
