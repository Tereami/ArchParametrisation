using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace ArchParametrisation
{
    [Serializable]
    public class Settings
    {
        private static string xmlPath = "";

        public bool enableMirrored = false;
        public string mirroredParamName = "Мрк.НаименованиеСоставноеСуффикс";

        public bool enableOpeningsArea = false;
        public string openingsAreaParamName = "АР_ПлощПроемов";

        public bool enableNumbersOfFloorTypes = false;
        public string numbersOfFloorTypesParamName = "АР_НомераПомещенийПоТипуПола";

        public bool enableNumbersOfFinishings = false;
        public string numbersOfFinishingsParamName = "АР_НомераПомещенийВедОтделки";

        public bool enableFlatography = false;

        public List<string[]> roomParameters = new List<string[]>
        {
            new string[]{ "Номер", "АР_Номер" },
            new string[]{ "Номер квартиры", "АР_НомерКвартиры" },
            new string[]{ "Площадь квартиры", "АР_ПлощКвартиры" },
            new string[]{ "Площадь квартиры общая", "АР_ПлощКвОбщая" },
            new string[]{ "Площадь квартиры жилая", "АР_ПлощКвЖилая" },
            new string[]{ "Количество комнат", "АР_КолвоКомнат" },
            new string[]{ "Коэффициент площади", "АР_КоэффПлощади" }
        };

        public List<RoomInfo> roomInfos = new List<RoomInfo>
        {
            new RoomInfo("Прихожая", 1, false),
            new RoomInfo("Кухня", 1, false),
            new RoomInfo("Спальня", 1, true),
            new RoomInfo("Гостиная", 1, true),
            new RoomInfo("Ванная", 1, false),
            new RoomInfo("Туалет", 1, false),
            new RoomInfo("Лоджия", 0.8, false),
            new RoomInfo("Балкон", 0.5, false)
        };


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
            FormSettings form = new FormSettings(s, xmlPath);
            Debug.WriteLine("Show settings form");
            form.ShowDialog();
            if (form.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                Debug.WriteLine("Setting form cancelled");
                throw new Exception("Отменено");
            }
            s = form.newSets;
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
