using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMDFileWatcher
{
    [Serializable]
    public class Settings
    {
        public string MMLPath { set; get; } = String.Empty;
        public bool MSDOSEnable { set; get; } = false;
        public string MSDOSPath { set; get; } = String.Empty;
        public string MCPath { set; get; } = String.Empty;
        public string MCOption { set; get; } = String.Empty;
        public bool ResultFormEnable { set; get; } = true;
        public bool AutoPlay { set; get; } = true;
        public string PlayerPath { set; get; } = String.Empty;

        public static Settings Load()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                path = Path.Combine(path, Common.AssemblyCompany, Common.AssemblyTitle);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, "Settings.xml");

                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                using (var sr = new StreamReader(path, new UTF8Encoding(false)))
                {
                    return (Settings)serializer.Deserialize(sr);
                }
            }
            catch
            {
                return new Settings();
            }
        }

        public void Save()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                path = Path.Combine(path, Common.AssemblyCompany, Common.AssemblyTitle);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, "Settings.xml");

                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                using (var sw = new StreamWriter(path, false, new UTF8Encoding(false)))
                {
                    serializer.Serialize(sw, this);
                }
            }
            catch
            {
                // Fail to save setings
            }
        }
    }
}
