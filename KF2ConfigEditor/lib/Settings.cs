using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF2ConfigEditor.lib
{
    public class CustomMap
    {
        public string Name { get; set; }
        public string WSKey { get; set; }
        public string Type { get; set; }
    }

    public class Settings
    {
        public string SteamCMDPath;
        public string GamePath;
        public string EnginePath;
        public string DediPath;
        public string MapsFolder;
        public string ConfigFolder;
        public string CacheFolder;
        public string WebPath;
        public string DefaultBatPath;
        public string StartBatPath;

        public List<CustomMap> CustomMaps;
    }
}
