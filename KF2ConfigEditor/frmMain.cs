using KF2ConfigEditor.lib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KF2ConfigEditor
{
    public partial class frmMain : Form
    {
        private Settings mySettings;

        private string _steamCMDPath;
        private string _kfGamePath;
        private string _kfEnginePath;
        private string _kfWebPath;
        private string _kfDediPath;
        private string _kfMapsFolder;
        private string _kfConfigFolder;
        private string _kfCacheFolder;
        private string _kfStartBat;
        private string _kfDefaultBat;
        private int _mapCyclesIndex;
        private List<string> _lines;
        private List<CustomMap> _customMaps;

        public void LoadSettings()
        {
            mySettings = new Settings();

            if (File.Exists("settings.json"))
            {
                string settingsJson = File.ReadAllText("settings.json");
                Settings settings = JsonConvert.DeserializeObject<Settings>(settingsJson);
                if (settings != null)
                {
                    _kfConfigFolder = settings.ConfigFolder;
                    _kfCacheFolder = settings.ConfigFolder;
                    _kfGamePath = settings.GamePath;
                    _kfEnginePath = settings.EnginePath;
                    _kfWebPath = settings.WebPath;
                    _kfDediPath = settings.DediPath;
                    _kfMapsFolder = settings.MapsFolder;
                    _kfStartBat = settings.StartBatPath;
                    _kfDefaultBat = settings.DefaultBatPath;
                    _customMaps = settings.CustomMaps;

                    foreach (var map in _customMaps)
                        comboMapList.Items.Add(map.Name);
                }
            }
            else
            {
                _steamCMDPath = @":\SteamCMD";
                _kfConfigFolder = _steamCMDPath + @"\KF2Server\KFGame\Config";
                _kfCacheFolder = _steamCMDPath + @"\KF2Server\KFGame\Cache";
                _kfWebPath = Path.Combine(_kfConfigFolder, "KFWeb.ini");
                _kfGamePath = Path.Combine(_kfConfigFolder, "PCServer-KFGame.ini");
                _kfEnginePath = Path.Combine(_kfConfigFolder, "PCServer-KFEngine.ini");
                //_kfDediPath = @"G:\KF2Server.lnk";
                _kfDediPath = Path.Combine(_steamCMDPath, @"\KF2Server\Binaries\Win64\KFServer.exe");
                _kfMapsFolder = _steamCMDPath + @"\KF2Server\KFGame\BrewedPC\Maps";
                _kfDefaultBat = Path.Combine(_steamCMDPath, "KF2Server", "KF2ServerStartEmpty.bat");
                _kfStartBat = Path.Combine(_steamCMDPath, "KF2Server", "KF2ServerStart.bat");
                _customMaps = new List<CustomMap>();
            }

            GetAllMaps();

            comboMapType.SelectedIndex = 0;
            comboDifficulty.SelectedIndex = 0;
            comboGameType.SelectedIndex = 0;
            comboLength.SelectedIndex = 0;
            comboMapList.SelectedIndex = 0;
            comboMapType.SelectedIndex = 0;
            comboAllMaps.SelectedIndex = 1;
        }

        public void SaveSettings()
        {
            _steamCMDPath = @":\SteamCMD";
            mySettings.SteamCMDPath = _steamCMDPath;
            mySettings.GamePath = _kfGamePath;
            mySettings.EnginePath = _kfEnginePath;
            mySettings.WebPath = _kfWebPath;
            mySettings.DediPath = _kfDediPath;
            mySettings.MapsFolder = _kfMapsFolder;
            mySettings.ConfigFolder = _kfConfigFolder;
            mySettings.CacheFolder = _kfCacheFolder;
            mySettings.CustomMaps = _customMaps;
            mySettings.DefaultBatPath = _kfDefaultBat;
            mySettings.StartBatPath = _kfStartBat;

            string settingsJson = JsonConvert.SerializeObject(mySettings, Formatting.Indented);

            using (StreamWriter file = new StreamWriter("settings.json"))
            {
                file.Write(settingsJson);
            }
        }

        private KeyValuePair<string, string> GetMapCycle()
        {
            var cycle = ReadIniSection(_kfGamePath, "KFGame.KFGameInfo").FirstOrDefault(i => i.Key.Contains("GameMapCycles"));
            _mapCyclesIndex = File.ReadAllLines(_kfGamePath).ToList().FindIndex(c => c.Contains("GameMapCycles"));
            return cycle;
        }

        private void GetAllMaps()
        {
            var mapz = GetMapCycle();
            var allMaps = mapz.Value.Split(new char[] { '\"', ',' }).Where(m => m.Contains("KF") || m.Contains("Maps-")).ToList();

            comboAllMaps.Items.Clear();
            allMaps.ForEach(a => comboAllMaps.Items.Add(a));
        }

        private string GetArgs()
        {
            string mapName = comboAllMaps.Items[comboAllMaps.SelectedIndex].ToString();
            string gameDifficulty = comboDifficulty.SelectedIndex.ToString();
            string adminPass = "";
            string maxPlayers = 6.ToString();
            string gameLength = comboLength.SelectedIndex.ToString();
            string gameMode = comboGameType.SelectedIndex.ToString();

            //  string args = string.Format("{0}?adminpass={1}?difficulty={2}?maxplayers={3}?game_mode={4}?game_length={5}", mapName, adminPass, gameDifficulty, maxPlayers, gameMode, gameLength);
            string args = string.Format("{0}?adminpassword={1}?difficulty={2}?maxplayers={3}?game_mode={4}?game_length={5}", mapName, adminPass, gameDifficulty, maxPlayers, gameMode, gameLength);
            return args;
        }

        public List<KeyValuePair<string, string>> ReadIniSection(string Path, string Section, bool Duplicates = true)
        {
            var pairs = new List<KeyValuePair<string, string>>();
            if (!File.Exists(Path))
                return pairs;

            _lines = File.ReadAllLines(Path).ToList();
            var lines = _lines.Where(l => l != string.Empty).ToList();
            int idx = lines.FindIndex(l => l == "[" + Section + "]");

            for (int i = idx + 1; i < lines.Count(); i++)
            {
                string line = lines[i];

                if (line[0] == '[')
                    break;
                var parts = line.Split(new char[] { '=' }, 2);
                pairs.Add(new KeyValuePair<string, string>(parts[0], parts[1]));
            }

            return pairs;
        }

        public void AddWorkshopKey(string Key)
        {
            if (!File.Exists(_kfEnginePath))
                return;

            var lines = File.ReadAllLines(_kfEnginePath).ToList();
            int idx = lines.FindIndex(l => l.Contains("OnlineSubsystemSteamworks.KFWorkshopSteamworks"));

            lines.Insert(idx + 1, "ServerSubscribedWorkshopItems=" + Key);
            File.WriteAllLines(_kfEnginePath, lines);
        }

        public void AddMapInfo(string Name, string Type)
        {
            if (!File.Exists(_kfGamePath))
                return;

            var lines = File.ReadAllLines(_kfGamePath).ToList();//.Where(l => l != string.Empty).ToList();
            int idx = lines.FindIndex(l => l.Contains("GameMapCycles="));

            if (Type == "KF1")
            {
                int typeIdx = lines[idx].IndexOf("-------KF2 Maps-------");
                lines[idx] = lines[idx].Insert(typeIdx-2, ",\"" + Name + "\"");
            }
            else
            {
                int typeIdx = lines[idx].IndexOf("-------Custom Maps-------") + 2 + ("-------Custom Maps-------").Length;
                lines[idx] = lines[idx].Insert(typeIdx, "\"" + Name + "\",");
            }

            lines.Add("[" + Name + " KFMapSummary]");
            lines.Add("MapName=" + Name);

            File.WriteAllLines(_kfGamePath, lines);

            MessageBox.Show("A OK!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateComboBoxes(CustomMap map, bool Add)
        {
            if (Add)
            {
                comboAllMaps.Items.Add(map.Name);

                int idx = 1;
                if (map.Type == "KF2")
                    idx = comboMapList.Items.IndexOf("-------Custom Maps-------") + 1;

                comboMapList.Items.Insert(idx, map.Name);
            }
            else
            {
                comboMapList.Items.Remove(map.Name);
                comboAllMaps.Items.Remove(map.Name);
            }
        }

        public void AddMap(string Name, string WSKey, string Type)
        {
            var data = ReadIniSection(_kfEnginePath, "OnlineSubsystemSteamworks.KFWorkshopSteamworks", true);

            //if (_customMaps.Where(m => m.Name == Name && m.Type == Type).Count() != 0)
            if (_customMaps.Where(m => m.WSKey == WSKey).Count() != 0)
            {
                statusBar.Text = "Map already on the list!";
                return;
            }

            BackupSettings();

            AddWorkshopKey(WSKey);
            AddMapInfo(Name, Type);

            var map = new CustomMap { Name = Name, WSKey = WSKey, Type = Type };

            _customMaps.Add(map);
            UpdateComboBoxes(map, true);
        }

        public void RemoveMap()
        {
            if (comboAllMaps.SelectedIndex == -1)
            {
                statusBar.Text = "No map selected!";
                return;
            }

            var selectedMap = _customMaps.FirstOrDefault(m => m.Name == comboAllMaps.Items[comboAllMaps.SelectedIndex]);
            EditMapEngineIni(selectedMap.Name, "", true);
            EditMapGameIni(selectedMap.Name, "", selectedMap.Type, "", true);

            UpdateComboBoxes(selectedMap, false);
        }

        public void StartServer()
        {
            //if (File.Exists(_kfStartBat))
            //    File.Delete(_kfStartBat);

            //  File.Copy(_kfDefaultBat, _kfStartBat, true);
            // var lines = File.ReadAllLines(_kfStartBat);
            //  lines[0] = lines[0].Replace("args", GetArgs());
            //  File.WriteAllLines(_kfStartBat, lines);

            //Process.Start(_kfStartBat);

            using (Process proc = new Process())
            {
                proc.StartInfo.FileName = _kfDediPath;
                proc.StartInfo.Arguments = GetArgs();

                proc.Start();
            }
            MessageBox.Show(GetArgs());
        }

        public void BackupSettings()
        {
            if (!Directory.Exists("backups"))
                Directory.CreateDirectory("backups");

            string bkPath = Path.Combine("backups", DateTime.Now.ToString()).Replace(":", "");
            Directory.CreateDirectory(bkPath);

            if (File.Exists(_kfEnginePath))
                File.Copy(_kfEnginePath, Path.Combine(bkPath, "PCServer-KFEngine.ini"), true);
            if (File.Exists(_kfGamePath))
                File.Copy(_kfGamePath, Path.Combine(bkPath, "PCServer-KFGame.ini"), true);
            if (File.Exists(_kfWebPath))
                File.Copy(_kfWebPath, Path.Combine(bkPath, "KFWeb.ini"), true);
        }

        private void EditMapCycles()
        {
            var mapCycle = GetMapCycle();
            string oldMapCycle = mapCycle.Key + "=" + mapCycle.Value;

            using (var form = new frmEditMapCycles(oldMapCycle))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string newMapCycle = form.MapCycle;

                    if (oldMapCycle != newMapCycle)
                    {
                        _lines[_mapCyclesIndex] = newMapCycle;
                        File.WriteAllLines(_kfGamePath, _lines);
                    }
                }
            }
        }

        private string FixCycles(string cycles)
        {
            return cycles.Replace("KF2Maps", "KF2 Maps").Replace("CustomMaps", "Custom Maps").Replace("KF1Maps", "KF1 Maps");
        }
        private void EditMapGameIni(string oldName, string newName = "", string oldMapType = "", string newMapType = "", bool remove = false)
        {
            if (!File.Exists(_kfGamePath))
                return;
            BackupSettings();

            _lines = File.ReadAllLines(_kfGamePath).ToList();
            int idx = _lines.FindIndex(l => l.Contains("GameMapCycles"));
            int mapEntry_idx = _lines.FindIndex(l => l.Contains("[" + oldMapType));
            int map_idx = _customMaps.FindIndex(m => m.Name == oldName);
            string oldCycles = FixCycles(Regex.Replace(_lines[idx], @"\s", ""));

            if (remove)
            {
                if (oldMapType == "KF1")
                    oldCycles = oldCycles.Replace("\"" + oldName + "\",", "");
                else
                    oldCycles = oldCycles.Replace(",\"" + oldName + "\"", "");

                //TODO: add ScreenshotPathName support and ...

                _lines.RemoveAt(mapEntry_idx);
                if (_lines[mapEntry_idx + 1].Contains("MapName"))
                    _lines.RemoveAt(mapEntry_idx + 1);

                _customMaps.RemoveAt(map_idx);

                //TODO:delete the actual file
                statusBar.Text = "Map deleted";
            }
            else
            {
                if (oldName != newName)
                {
                    oldCycles = oldCycles.Replace(oldName, newName);
                    _lines[mapEntry_idx] = _lines[mapEntry_idx].Replace(oldName, newName);
                    _lines[mapEntry_idx + 1] = _lines[mapEntry_idx + 1].Replace(oldName, newName);
                }


                if (oldMapType != newMapType)
                {
                    if (newMapType == "KF1")
                    {
                        int typeIdx = oldCycles.IndexOf("-------KF2 Maps-------");

                        oldCycles = oldCycles.Replace(",\"" + oldName + "\"", ""); //Remove from custom maps list

                        oldCycles = oldCycles.Insert(typeIdx, "\"" + oldName + "\","); //Add to KF1 maps
                    }
                    else
                    {
                        int typeIdx = oldCycles.IndexOf("-------Custom Maps-------") + 2 + ("-------Custom Maps-------").Length;

                        oldCycles = oldCycles.Replace("\"" + oldName + "\",", "");

                        oldCycles = oldCycles.Insert(typeIdx, "\"" + oldName + "\",");
                    }
                }

                _customMaps[map_idx].Name = newName;
                _customMaps[map_idx].Type = newMapType;
            }

            _lines[idx] = oldCycles;
            statusBar.Text = "Map info changed";

            File.WriteAllLines(_kfGamePath, _lines);
        }

        private void EditMapEngineIni(string oldWSNumber, string newWSNumber, bool remove = false)
        {
            if (!File.Exists(_kfEnginePath))
                return;

            _lines = File.ReadAllLines(_kfGamePath).ToList();

            int idx = _lines.FindIndex(l => l.Contains("OnlineSubsystemSteamworks.KFWorkshopSteamworks"));
            int WS_idx = _lines.Skip(idx).ToList().IndexOf("ServerSubscribedWorkshopItems=" + oldWSNumber);

            if (remove)
                _lines.RemoveAt(WS_idx);
            else
                _lines[WS_idx] = _lines[WS_idx].Replace(oldWSNumber, newWSNumber);

            statusBar.Text = "Map info changed";

            File.WriteAllLines(_kfEnginePath, _lines);
        }

        private void EditSong()
        {
            if (comboMapList.SelectedIndex == 0)
            {
                statusBar.Text = "No song selected!";
                return;
            }

            var oldMap = _customMaps.FirstOrDefault(m => m.Name == comboMapList.Items[comboMapList.SelectedIndex].ToString()); //TODO: Change to databound, WS key
            using (var form = new frmEditSong(oldMap))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var newMap = form.Map;

                    if (newMap.Name != oldMap.Name || newMap.Type != oldMap.Type)
                        EditMapGameIni(oldMap.Name, newMap.Name, oldMap.Type, newMap.Type);

                    if (newMap.WSKey != oldMap.WSKey)
                        EditMapEngineIni(oldMap.WSKey, newMap.WSKey);
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMap(tbName.Text, tbWorkshopNumber.Text, comboMapType.SelectedIndex == 0 ? "KF1" : "KF2");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove the map?", "KF2 Dedi Tool", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            RemoveMap();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Backup?", "KF2 Dedi Tool", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            BackupSettings();
        }

        private void btnOpenGame_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                //p.Exited += new EventHandler(p_Exited);
                p.StartInfo.FileName = _kfGamePath;
                //p.EnableRaisingEvents = true;
                p.Start();
            }

        }
        private void p_Exited(object sender, EventArgs e)
        {
            //GetAllMaps();
        }

        private void btnOpenEngine_Click(object sender, EventArgs e)
        {
            Process.Start(_kfEnginePath);
        }

        private void btnStartDedi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Start a dedi server?", "KF2 Dedi Tool", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            StartServer();
        }

        private void btnEditMapCycles_Click(object sender, EventArgs e)
        {
            EditMapCycles();
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        {
            EditSong();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}