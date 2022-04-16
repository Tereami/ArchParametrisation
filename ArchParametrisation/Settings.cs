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
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
#endregion

namespace ArchParametrisation
{
    [Serializable]
    public class Settings
    {
        private static string xmlPath = "";

        public bool enableMirrored = false;
        public string mirroredText = "Л";
        public string mirroredParamName = "Комментарии";

        public bool enableOpeningsArea = false;
        public string openingsWidthParamName = "Ширина";
        public string openingsHeightParamName = "Высота";
        public string openingsAreaParamName = "АР_ПлощадьПроемов";

        public bool enableNumbersOfFinishings = false;
        public string roomNumberParamName = "АР_НомерПомещения";
        public string numbersOfFloorTypesParamName = "АР_НомераПомещенийПоТипуПола";
        public string numbersOfWallsParamName = "АР_НомераПомещенийВедОтделки";
        public string numbersOfCeilingTypesParamName = "АР_НомераПомещенийПоТипуПотолка";

        public bool enableFlatography = false;
        public string flatNumberParamName = "АР_НомерКвартиры";
        public string flatAreaParamName = "АР_ПлощКвартиры";
        public string flatSumAreaParamName = "АР_ПлощКвОбщая";
        public string flatLivingAreaParamName = "АР_ПлощКвЖилая";
        public string flatRoomsCountParamName = "АР_КолвоКомнат";
        public string flatRoomAreaCoeffParamName = "АР_КоэффПлощади";

        public List<RoomInfo> defaultRoomInfos = new List<RoomInfo>
        {
            new RoomInfo("Спальная", 1, true),
            new RoomInfo("Кухня", 1, false),
            new RoomInfo("Лоджия", 0.5, false),
            new RoomInfo("Балкон", 0.3, false)
        };

        public List<RoomInfo> RoomInfos = new List<RoomInfo>();


        public static Settings Activate()
        {
            Debug.WriteLine("Start activate settins");
            string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rbspath = Path.Combine(appdataPath, "bim-starter");
            if (!Directory.Exists(rbspath))
            {
                Debug.WriteLine("Create directory " + rbspath);
                Directory.CreateDirectory(rbspath);
            }
            string solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string solutionFolder = Path.Combine(rbspath, solutionName);
            if (!Directory.Exists(solutionFolder))
            {
                Directory.CreateDirectory(solutionFolder);
                Debug.WriteLine("Create directory " + solutionFolder);
            }
            xmlPath = Path.Combine(solutionFolder, "settings.xml");
            Settings s = null;

            if (File.Exists(xmlPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (StreamReader reader = new StreamReader(xmlPath))
                {
                    try
                    {
                        s = (Settings)serializer.Deserialize(reader);
                        Debug.WriteLine("Settings deserialize success");
                    }
                    catch { }
                }
            }
            if (s == null)
            {
                s = new Settings();
                Debug.WriteLine("Settings is null, create new one");
            }


            Debug.WriteLine("Settings success");
            return s;
        }

        public void Save()
        {
            Debug.WriteLine("Start save settins to file " + xmlPath);
            if (File.Exists(xmlPath)) File.Delete(xmlPath);
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            using (FileStream writer = new FileStream(xmlPath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, this);
            }
            Debug.WriteLine("Save settings success");
        }

    }
}
