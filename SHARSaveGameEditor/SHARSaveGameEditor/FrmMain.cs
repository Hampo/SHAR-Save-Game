using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SHARSaveGameEditor
{
    public partial class FrmMain : Form
    {
        private const string RegistrySettings = @"Software\SHARSaveGameEditor";
        private static readonly Microsoft.Win32.RegistryKey RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistrySettings, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

        private SaveGame SaveGame = new();
        private string LastPath = string.Empty;
        private string _Text = string.Empty;
        private bool _unsavedChanges = false;
        private bool UnsavedChanges
        {
            get
            {
                return _unsavedChanges;
            }
            set
            {
                if (_unsavedChanges == value)
                    return;

                _unsavedChanges = value;
                if (value)
                    Text = $"*{_Text}";
                else
                    Text = _Text;
            }
        }
        private readonly List<string> RecentFiles = [];

        private bool ConfirmPurchaseTotals()
        {
            for (int i = 0; i < SaveGame.CharacterSheet.Levels.Length; i++)
            {
                var level = SaveGame.CharacterSheet.Levels[i];

                int savedTotal = level.NumCarsPurchased + level.NumSkinsPurchased;
                int actualTotal = 0;
                foreach (var purchasedReward in level.PurchasedRewards)
                {
                    if (purchasedReward)
                        actualTotal++;
                }
                if (savedTotal != actualTotal)
                {
                    MessageBox.Show($"The sum of \"Num Cars Purchased\" and \"Num Skins Purchased\" in Level {i + 1} ({savedTotal}) does not equal the number of \"Purchased Rewards\" ({actualTotal}).", "Invalid save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void AddRecentFile(string filePath)
        {
            int index = RecentFiles.IndexOf(filePath);
            if (index != -1)
                RecentFiles.RemoveAt(index);
            RecentFiles.Insert(0, Path.GetFullPath(filePath));
            while (RecentFiles.Count > 10)
                RecentFiles.RemoveAt(RecentFiles.Count - 1);
            TSMIRecentFiles.DropDownItems.Clear();
            foreach (var recentFile in RecentFiles)
            {
                var tsmi = TSMIRecentFiles.DropDownItems.Add(recentFile);
                tsmi.Click += TSMIRecentFile_Click;
                tsmi.Image = Properties.Resources.OpenFile_16x;
            }
            RegistryKey?.SetValue("RecentFiles", RecentFiles.ToArray(), Microsoft.Win32.RegistryValueKind.MultiString);
        }

        private void TSMIRecentFile_Click(object sender, EventArgs e)
        {
            if (sender is not ToolStripItem menuItem)
                return;

            if (UnsavedChanges)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        TSMISave.PerformClick();
                        break;
                }
            }

            LoadSave(menuItem.Text);
        }

        private CharacterSheet.Level.MissionRecord GetMissionRecordFromIndex(CharacterSheet.Level level, int index) => index switch
        {
            0 or 1 or 2 or 3 or 4 or 5 or 6 or 7 => level.Missions[index],
            8 => level.BonusMission,
            9 or 10 or 11 => level.StreetRaces[index - 9],
            12 => level.GambleRace,
            _ => throw new ArgumentOutOfRangeException(nameof(index)),
        };

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string version = Application.ProductVersion;
            while (version.EndsWith(".0"))
                version = version.Substring(0, version.Length - 2);
            _Text = $"{Text} - v{version}";
            Text = _Text;

            if (RegistryKey != null)
            {
                string[] names = RegistryKey.GetValueNames();

                if (Array.IndexOf(names, "AutoUpdateSaveDate") >= 0 && RegistryKey.GetValueKind("AutoUpdateSaveDate") == Microsoft.Win32.RegistryValueKind.DWord)
                {
                    CBAutoSaveDate.Checked = (int)RegistryKey.GetValue("AutoUpdateSaveDate", 1) != 0;
                }

                if (Array.IndexOf(names, "RecentFiles") >= 0 && RegistryKey.GetValueKind("RecentFiles") == Microsoft.Win32.RegistryValueKind.MultiString)
                {
                    RecentFiles.AddRange((string[])RegistryKey.GetValue("RecentFiles"));

                    foreach (var recentFile in RecentFiles)
                    {
                        var tsmi = TSMIRecentFiles.DropDownItems.Add(recentFile);
                        tsmi.Click += TSMIRecentFile_Click;
                        tsmi.Image = Properties.Resources.OpenFile_16x;
                    }
                }
            }
            else
            {
                CBAutoSaveDate.Checked = true;
            }

            TCMain.Enabled = false;

            CBCurrentMissionInfoLevel.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Levels));
            CBCurrentMissionInfoMission.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Missions));
            CBHighestMissionInfoLevel.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Levels));
            CBHighestMissionInfoMission.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Missions));

            foreach (var value in Names.PersistentObjectStates)
                CLBPersistentObjectStates.Items.Add(value);

            foreach (var value in Names.Level1PurchasedRewards)
                CLBLevel1PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level1Gags)
                CLBLevel1Gags.Items.Add(value);
            foreach (var value in Names.Level1Missions)
                LBLevel1Missions.Items.Add(value);
            LBLevel1Missions.SelectedIndex = 0;
            for (int i = 0; i < 7; i++)
                LBLevel1Cards.Items.Add(Names.Cards[i]);
            LBLevel1Cards.SelectedIndex = 0;

            foreach (var value in Names.Level2PurchasedRewards)
                CLBLevel2PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level2Gags)
                CLBLevel2Gags.Items.Add(value);
            foreach (var value in Names.Level2Missions)
                LBLevel2Missions.Items.Add(value);
            LBLevel2Missions.SelectedIndex = 0;
            for (int i = 8; i < 15; i++)
                LBLevel2Cards.Items.Add(Names.Cards[i]);
            LBLevel2Cards.SelectedIndex = 0;

            foreach (var value in Names.Level3PurchasedRewards)
                CLBLevel3PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level3Gags)
                CLBLevel3Gags.Items.Add(value);
            foreach (var value in Names.Level3Missions)
                LBLevel3Missions.Items.Add(value);
            LBLevel3Missions.SelectedIndex = 0;
            for (int i = 16; i < 23; i++)
                LBLevel3Cards.Items.Add(Names.Cards[i]);
            LBLevel3Cards.SelectedIndex = 0;

            foreach (var value in Names.Level4PurchasedRewards)
                CLBLevel4PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level4Gags)
                CLBLevel4Gags.Items.Add(value);
            foreach (var value in Names.Level4Missions)
                LBLevel4Missions.Items.Add(value);
            LBLevel4Missions.SelectedIndex = 0;
            for (int i = 24; i < 31; i++)
                LBLevel4Cards.Items.Add(Names.Cards[i]);
            LBLevel4Cards.SelectedIndex = 0;

            foreach (var value in Names.Level5PurchasedRewards)
                CLBLevel5PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level5Gags)
                CLBLevel5Gags.Items.Add(value);
            foreach (var value in Names.Level5Missions)
                LBLevel5Missions.Items.Add(value);
            LBLevel5Missions.SelectedIndex = 0;
            for (int i = 32; i < 39; i++)
                LBLevel5Cards.Items.Add(Names.Cards[i]);
            LBLevel5Cards.SelectedIndex = 0;

            foreach (var value in Names.Level6PurchasedRewards)
                CLBLevel6PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level6Gags)
                CLBLevel6Gags.Items.Add(value);
            foreach (var value in Names.Level6Missions)
                LBLevel6Missions.Items.Add(value);
            LBLevel6Missions.SelectedIndex = 0;
            for (int i = 40; i < 47; i++)
                LBLevel6Cards.Items.Add(Names.Cards[i]);
            LBLevel6Cards.SelectedIndex = 0;

            foreach (var value in Names.Level7PurchasedRewards)
                CLBLevel7PurchasedRewards.Items.Add(value);
            foreach (var value in Names.Level7Gags)
                CLBLevel7Gags.Items.Add(value);
            foreach (var value in Names.Level7Missions)
                LBLevel7Missions.Items.Add(value);
            LBLevel7Missions.SelectedIndex = 0;
            for (int i = 48; i < 55; i++)
                LBLevel7Cards.Items.Add(Names.Cards[i]);
            LBLevel7Cards.SelectedIndex = 0;

            CBPreferredFollowCam1.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));
            CBPreferredFollowCam2.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));
            CBPreferredFollowCam3.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));
            CBPreferredFollowCam4.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));

            foreach (var value in Enum.GetValues(typeof(TutorialManager.TutorialMode)))
                CLBTutorialsSeen.Items.Add(value);

            foreach (var card in Names.Cards)
                CLBCollectedCardIDs.Items.Add(card);

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                string file = args[1];
                if (File.Exists(file))
                {
                    LoadSave(file);
                }
            }

            PopulateData();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChanges)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (result)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                    case DialogResult.Yes:
                        TSMISave.PerformClick();
                        break;
                }
            }
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length < 1)
                return;

            if (files.Length > 1)
            {
                MessageBox.Show("Application can only handle 1 file at a time.", "File Drop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UnsavedChanges)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        TSMISave.PerformClick();
                        break;
                }
            }

            LoadSave(files[0]);
        }

        private void LoadSave(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Could not find save file: {filePath}", "Error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var fileStream = File.OpenRead(filePath);
                using var binaryReader = new BinaryReader(fileStream);
                SaveGame saveGame = new(binaryReader);
                SaveGame = saveGame;
                LastPath = filePath;
                PopulateData();
                AddRecentFile(LastPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading save file: {ex}", "Error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateData()
        {
            TCMain.Enabled = false;

            CLBLevel1PurchasedRewards.BeginUpdate();
            CLBLevel2PurchasedRewards.BeginUpdate();
            CLBLevel3PurchasedRewards.BeginUpdate();
            CLBLevel4PurchasedRewards.BeginUpdate();
            CLBLevel5PurchasedRewards.BeginUpdate();
            CLBLevel6PurchasedRewards.BeginUpdate();
            CLBLevel7PurchasedRewards.BeginUpdate();
            CLBLevel1PurchasedRewards.Items.Clear();
            CLBLevel1PurchasedRewards.Items.AddRange(Names.Level1PurchasedRewards);
            CLBLevel2PurchasedRewards.Items.Clear();
            CLBLevel2PurchasedRewards.Items.AddRange(Names.Level2PurchasedRewards);
            CLBLevel3PurchasedRewards.Items.Clear();
            CLBLevel3PurchasedRewards.Items.AddRange(Names.Level3PurchasedRewards);
            CLBLevel4PurchasedRewards.Items.Clear();
            CLBLevel4PurchasedRewards.Items.AddRange(Names.Level4PurchasedRewards);
            CLBLevel5PurchasedRewards.Items.Clear();
            CLBLevel5PurchasedRewards.Items.AddRange(Names.Level5PurchasedRewards);
            CLBLevel6PurchasedRewards.Items.Clear();
            CLBLevel6PurchasedRewards.Items.AddRange(Names.Level6PurchasedRewards);
            CLBLevel7PurchasedRewards.Items.Clear();
            CLBLevel7PurchasedRewards.Items.AddRange(Names.Level7PurchasedRewards);

            CustomSaveData customSaveData = SaveGame.CustomSaveData;
            if (customSaveData.Data.Length == 0 && customSaveData.LucasModLauncherData == null)
            {
                TCCustomSaveData.Visible = false;
                LblCustomSaveData.Visible = true;
            }
            else
            {
                TCCustomSaveData.Visible = true;
                LblCustomSaveData.Visible = false;
            }

            if (customSaveData.Data.Length == 0)
            {
                if (TCCustomSaveData.TabPages.Contains(TPCustomSaveDataUnknown))
                    TCCustomSaveData.TabPages.Remove(TPCustomSaveDataUnknown);
            }
            else
            {
                if (!TCCustomSaveData.TabPages.Contains(TPCustomSaveDataUnknown))
                    TCCustomSaveData.TabPages.Insert(0, TPCustomSaveDataUnknown);

                LblCustomSaveDataUnknownData.Text = $"Unknown Data Length: {customSaveData.Data.Length} bytes";
                // Add HexControl or something
            }
            if (customSaveData.LucasModLauncherData == null)
            {
                if (TCCustomSaveData.TabPages.Contains(TPLucasModLauncherData))
                    TCCustomSaveData.TabPages.Remove(TPLucasModLauncherData);
            }
            else
            {
                if (!TCCustomSaveData.TabPages.Contains(TPLucasModLauncherData))
                    TCCustomSaveData.TabPages.Add(TPLucasModLauncherData);

                var lucasModLauncherData = customSaveData.LucasModLauncherData;

                var merchandiseNames = lucasModLauncherData.HackCustomSaveDataMerchandiseNames;
                if (merchandiseNames != null && merchandiseNames.Names.Length == 7)
                {
                    for (int i = 0; i < merchandiseNames.Names[0].Count; i++)
                    {
                        if (i < CLBLevel1PurchasedRewards.Items.Count)
                            CLBLevel1PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[0][i]}]";
                        else
                            CLBLevel1PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[0][i]}]");
                    }

                    for (int i = 0; i < merchandiseNames.Names[1].Count; i++)
                    {
                        if (i < CLBLevel2PurchasedRewards.Items.Count)
                            CLBLevel2PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[1][i]}]";
                        else
                            CLBLevel2PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[1][i]}]");
                    }

                    for (int i = 0; i < merchandiseNames.Names[2].Count; i++)
                    {
                        if (i < CLBLevel3PurchasedRewards.Items.Count)
                            CLBLevel3PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[2][i]}]";
                        else
                            CLBLevel3PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[2][i]}]");
                    }

                    for (int i = 0; i < merchandiseNames.Names[3].Count; i++)
                    {
                        if (i < CLBLevel4PurchasedRewards.Items.Count)
                            CLBLevel4PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[3][i]}]";
                        else
                            CLBLevel4PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[3][i]}]");
                    }

                    for (int i = 0; i < merchandiseNames.Names[4].Count; i++)
                    {
                        if (i < CLBLevel5PurchasedRewards.Items.Count)
                            CLBLevel5PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[4][i]}]";
                        else
                            CLBLevel5PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[4][i]}]");
                    }

                    for (int i = 0; i < merchandiseNames.Names[5].Count; i++)
                    {
                        if (i < CLBLevel6PurchasedRewards.Items.Count)
                            CLBLevel6PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[5][i]}]";
                        else
                            CLBLevel6PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[5][i]}]");
                    }

                    for (int i = 0; i < merchandiseNames.Names[6].Count; i++)
                    {
                        if (i < CLBLevel7PurchasedRewards.Items.Count)
                            CLBLevel7PurchasedRewards.Items[i] += $" [{merchandiseNames.Names[6][i]}]";
                        else
                            CLBLevel7PurchasedRewards.Items.Add($"Reward {i} (Unused) [{merchandiseNames.Names[6][i]}]");
                    }
                }

                var merchandiseUnlocked = lucasModLauncherData.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked;
                if (merchandiseUnlocked != null && merchandiseUnlocked.Indices.Length == 7)
                {
                    for (int i = 0; i < CLBLevel1PurchasedRewards.Items.Count; i++)
                        CLBLevel1PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[0].Contains(i));

                    for (int i = 0; i < CLBLevel2PurchasedRewards.Items.Count; i++)
                        CLBLevel2PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[1].Contains(i));

                    for (int i = 0; i < CLBLevel3PurchasedRewards.Items.Count; i++)
                        CLBLevel3PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[2].Contains(i));

                    for (int i = 0; i < CLBLevel4PurchasedRewards.Items.Count; i++)
                        CLBLevel4PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[3].Contains(i));

                    for (int i = 0; i < CLBLevel5PurchasedRewards.Items.Count; i++)
                        CLBLevel5PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[4].Contains(i));

                    for (int i = 0; i < CLBLevel6PurchasedRewards.Items.Count; i++)
                        CLBLevel6PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[5].Contains(i));

                    for (int i = 0; i < CLBLevel7PurchasedRewards.Items.Count; i++)
                        CLBLevel7PurchasedRewards.SetItemChecked(i, merchandiseUnlocked.Indices[6].Contains(i));
                }

                var launcherVersion = lucasModLauncherData.HackCustomSaveDataLauncherVersion;
                if (launcherVersion?.Version3 == null)
                {
                    TxtModLauncherVersion.Text = "Not Included In Save";
                    TxtModLauncherVersion.Enabled = false;
                }
                else
                {
                    TxtModLauncherVersion.Text = launcherVersion.Version3;
                    TxtModLauncherVersion.Enabled = true;
                }

                var mainMod = lucasModLauncherData.HackCustomSaveDataMainMod;
                if (mainMod?.MainMod2 == null)
                {
                    TxtMainMod.Text = "Not Included In Save";
                    TxtMainMod.Enabled = false;
                }
                else
                {
                    TxtMainMod.Text = mainMod.MainMod2;
                    TxtMainMod.Enabled = true;
                }
            }
            CLBLevel1PurchasedRewards.EndUpdate();
            CLBLevel2PurchasedRewards.EndUpdate();
            CLBLevel3PurchasedRewards.EndUpdate();
            CLBLevel4PurchasedRewards.EndUpdate();
            CLBLevel5PurchasedRewards.EndUpdate();
            CLBLevel6PurchasedRewards.EndUpdate();
            CLBLevel7PurchasedRewards.EndUpdate();

            SaveGameInfo saveGameInfo = SaveGame.SaveGameInfo;
            DTPSaveDate.Value = saveGameInfo.SaveDate;
            NUDSaveHour.Value = saveGameInfo.Hour;
            NUDSaveMinute.Value = saveGameInfo.Minute;
            NUDSaveSecond.Value = saveGameInfo.Second;
            NUDDisplayLevel.Value = saveGameInfo.DisplayLevel;
            NUDDisplayMission.Value = saveGameInfo.DisplayMission;

            InputManager inputManager = SaveGame.InputManager;
            CBIsRumbleEnabled.Checked = inputManager.IsRumbleEnabled;

            CharacterSheet characterSheet = SaveGame.CharacterSheet;
            TxtPlayerName.Text = characterSheet.PlayerName;
            CBCurrentMissionInfoLevel.SelectedItem = characterSheet.CurrentMissionInfo.Level;
            CBCurrentMissionInfoMission.SelectedItem = characterSheet.CurrentMissionInfo.Mission;
            CBHighestMissionInfoLevel.SelectedItem = characterSheet.HighestMissionInfo.Level;
            CBHighestMissionInfoMission.SelectedItem = characterSheet.HighestMissionInfo.Mission;
            CBIsNavSystemEnabled.Checked = characterSheet.IsNavSystemEnabled;
            NUDCoins.Value = characterSheet.Coins;
            CBItchyScratchyCBGFirst.Checked = characterSheet.ItchyScratchyCBGFirst;
            CBItchyScratchyTicket.Checked = characterSheet.ItchyScratchyTicket;
            CLBPersistentObjectStates.BeginUpdate();
            for (int i = 0; i < characterSheet.PersistentObjectStates.Length; i++)
                CLBPersistentObjectStates.SetItemChecked(i, !characterSheet.PersistentObjectStates[i]);
            CLBPersistentObjectStates.EndUpdate();
            LBCars.BeginUpdate();
            LBCars.Items.Clear();
            foreach (var car in characterSheet.Cars.Cars)
                LBCars.Items.Add(car.Name);
            LBCars.SelectedIndex = 0;
            LBCars.EndUpdate();
            NUDCounter.Value = characterSheet.Cars.Counter;
            CBLevel1FMVUnlocked.Checked = characterSheet.Levels[0].FMVUnlocked;
            NUDLevel1NumCarsPurchased.Value = characterSheet.Levels[0].NumCarsPurchased;
            NUDLevel1NumSkinsPurchased.Value = characterSheet.Levels[0].NumSkinsPurchased;
            NUDLevel1WaspsDestroyed.Value = characterSheet.Levels[0].WaspsDestroyed;
            CBLevel1CurrentSkin.Text = characterSheet.Levels[0].CurrentSkin;
            CLBLevel1PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[0].PurchasedRewards.Length; i++)
                CLBLevel1PurchasedRewards.SetItemChecked(i, characterSheet.Levels[0].PurchasedRewards[i]);
            CLBLevel1PurchasedRewards.EndUpdate();
            CLBLevel1Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel1Gags.Items.Count; i++)
                CLBLevel1Gags.SetItemChecked(i, characterSheet.Levels[0].GagsCompleted[i] || (characterSheet.Levels[0].GagMask & (1 << i)) > 0);
            CLBLevel1Gags.EndUpdate();
            LBLevel1Missions_SelectedIndexChanged(LBLevel1Missions, EventArgs.Empty);
            LBLevel1Cards_SelectedIndexChanged(LBLevel1Cards, EventArgs.Empty);
            CBLevel2FMVUnlocked.Checked = characterSheet.Levels[1].FMVUnlocked;
            NUDLevel2NumCarsPurchased.Value = characterSheet.Levels[1].NumCarsPurchased;
            NUDLevel2NumSkinsPurchased.Value = characterSheet.Levels[1].NumSkinsPurchased;
            NUDLevel2WaspsDestroyed.Value = characterSheet.Levels[1].WaspsDestroyed;
            CBLevel2CurrentSkin.Text = characterSheet.Levels[1].CurrentSkin;
            CLBLevel2PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[1].PurchasedRewards.Length; i++)
                CLBLevel2PurchasedRewards.SetItemChecked(i, characterSheet.Levels[1].PurchasedRewards[i]);
            CLBLevel2PurchasedRewards.EndUpdate();
            CLBLevel2Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel2Gags.Items.Count; i++)
                CLBLevel2Gags.SetItemChecked(i, characterSheet.Levels[1].GagsCompleted[i] || (characterSheet.Levels[1].GagMask & (1 << i)) > 0);
            CLBLevel2Gags.EndUpdate();
            LBLevel2Missions_SelectedIndexChanged(LBLevel2Missions, EventArgs.Empty);
            LBLevel2Cards_SelectedIndexChanged(LBLevel2Cards, EventArgs.Empty);
            CBLevel3FMVUnlocked.Checked = characterSheet.Levels[2].FMVUnlocked;
            NUDLevel3NumCarsPurchased.Value = characterSheet.Levels[2].NumCarsPurchased;
            NUDLevel3NumSkinsPurchased.Value = characterSheet.Levels[2].NumSkinsPurchased;
            NUDLevel3WaspsDestroyed.Value = characterSheet.Levels[2].WaspsDestroyed;
            CBLevel3CurrentSkin.Text = characterSheet.Levels[2].CurrentSkin;
            CLBLevel3PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[2].PurchasedRewards.Length; i++)
                CLBLevel3PurchasedRewards.SetItemChecked(i, characterSheet.Levels[2].PurchasedRewards[i]);
            CLBLevel3PurchasedRewards.EndUpdate();
            CLBLevel3Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel3Gags.Items.Count; i++)
                CLBLevel3Gags.SetItemChecked(i, characterSheet.Levels[2].GagsCompleted[i] || (characterSheet.Levels[2].GagMask & (1 << i)) > 0);
            CLBLevel3Gags.EndUpdate();
            LBLevel3Missions_SelectedIndexChanged(LBLevel3Missions, EventArgs.Empty);
            LBLevel3Cards_SelectedIndexChanged(LBLevel3Cards, EventArgs.Empty);
            CBLevel4FMVUnlocked.Checked = characterSheet.Levels[3].FMVUnlocked;
            NUDLevel4NumCarsPurchased.Value = characterSheet.Levels[3].NumCarsPurchased;
            NUDLevel4NumSkinsPurchased.Value = characterSheet.Levels[3].NumSkinsPurchased;
            NUDLevel4WaspsDestroyed.Value = characterSheet.Levels[3].WaspsDestroyed;
            CBLevel4CurrentSkin.Text = characterSheet.Levels[3].CurrentSkin;
            CLBLevel4PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[3].PurchasedRewards.Length; i++)
                CLBLevel4PurchasedRewards.SetItemChecked(i, characterSheet.Levels[3].PurchasedRewards[i]);
            CLBLevel4PurchasedRewards.EndUpdate();
            CLBLevel4Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel4Gags.Items.Count; i++)
                CLBLevel4Gags.SetItemChecked(i, characterSheet.Levels[3].GagsCompleted[i] || (characterSheet.Levels[3].GagMask & (1 << i)) > 0);
            CLBLevel4Gags.EndUpdate();
            LBLevel4Missions_SelectedIndexChanged(LBLevel4Missions, EventArgs.Empty);
            LBLevel4Cards_SelectedIndexChanged(LBLevel4Cards, EventArgs.Empty);
            CBLevel5FMVUnlocked.Checked = characterSheet.Levels[4].FMVUnlocked;
            NUDLevel5NumCarsPurchased.Value = characterSheet.Levels[4].NumCarsPurchased;
            NUDLevel5NumSkinsPurchased.Value = characterSheet.Levels[4].NumSkinsPurchased;
            NUDLevel5WaspsDestroyed.Value = characterSheet.Levels[4].WaspsDestroyed;
            CBLevel5CurrentSkin.Text = characterSheet.Levels[4].CurrentSkin;
            CLBLevel5PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[4].PurchasedRewards.Length; i++)
                CLBLevel5PurchasedRewards.SetItemChecked(i, characterSheet.Levels[4].PurchasedRewards[i]);
            CLBLevel5PurchasedRewards.EndUpdate();
            CLBLevel5Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel5Gags.Items.Count; i++)
                CLBLevel5Gags.SetItemChecked(i, characterSheet.Levels[4].GagsCompleted[i] || (characterSheet.Levels[4].GagMask & (1 << i)) > 0);
            CLBLevel5Gags.EndUpdate();
            LBLevel5Missions_SelectedIndexChanged(LBLevel5Missions, EventArgs.Empty);
            LBLevel5Cards_SelectedIndexChanged(LBLevel5Cards, EventArgs.Empty);
            CBLevel6FMVUnlocked.Checked = characterSheet.Levels[5].FMVUnlocked;
            NUDLevel6NumCarsPurchased.Value = characterSheet.Levels[5].NumCarsPurchased;
            NUDLevel6NumSkinsPurchased.Value = characterSheet.Levels[5].NumSkinsPurchased;
            NUDLevel6WaspsDestroyed.Value = characterSheet.Levels[5].WaspsDestroyed;
            CBLevel6CurrentSkin.Text = characterSheet.Levels[5].CurrentSkin;
            CLBLevel6PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[5].PurchasedRewards.Length; i++)
                CLBLevel6PurchasedRewards.SetItemChecked(i, characterSheet.Levels[5].PurchasedRewards[i]);
            CLBLevel6PurchasedRewards.EndUpdate();
            CLBLevel6Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel6Gags.Items.Count; i++)
                CLBLevel6Gags.SetItemChecked(i, characterSheet.Levels[5].GagsCompleted[i] || (characterSheet.Levels[5].GagMask & (1 << i)) > 0);
            CLBLevel6Gags.EndUpdate();
            LBLevel6Missions_SelectedIndexChanged(LBLevel6Missions, EventArgs.Empty);
            LBLevel6Cards_SelectedIndexChanged(LBLevel6Cards, EventArgs.Empty);
            CBLevel7FMVUnlocked.Checked = characterSheet.Levels[6].FMVUnlocked;
            NUDLevel7NumCarsPurchased.Value = characterSheet.Levels[6].NumCarsPurchased;
            NUDLevel7NumSkinsPurchased.Value = characterSheet.Levels[6].NumSkinsPurchased;
            NUDLevel7WaspsDestroyed.Value = characterSheet.Levels[6].WaspsDestroyed;
            CBLevel7CurrentSkin.Text = characterSheet.Levels[6].CurrentSkin;
            CLBLevel7PurchasedRewards.BeginUpdate();
            for (int i = 0; i < characterSheet.Levels[6].PurchasedRewards.Length; i++)
                CLBLevel7PurchasedRewards.SetItemChecked(i, characterSheet.Levels[6].PurchasedRewards[i]);
            CLBLevel7PurchasedRewards.EndUpdate();
            CLBLevel7Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel7Gags.Items.Count; i++)
                CLBLevel7Gags.SetItemChecked(i, characterSheet.Levels[6].GagsCompleted[i] || (characterSheet.Levels[6].GagMask & (1 << i)) > 0);
            CLBLevel7Gags.EndUpdate();
            LBLevel7Missions_SelectedIndexChanged(LBLevel7Missions, EventArgs.Empty);
            LBLevel7Cards_SelectedIndexChanged(LBLevel7Cards, EventArgs.Empty);

            SoundSettings soundSettings = SaveGame.SoundSettings;
            TBMusicVolume.Value = (int)(soundSettings.MusicVolume * 100);
            TBSFXVolume.Value = (int)(soundSettings.SFXVolume * 100);
            TBCarVolume.Value = (int)(soundSettings.CarVolume * 100);
            TBDialogVolume.Value = (int)(soundSettings.DialogVolume * 100);
            CBIsSurround.Checked = soundSettings.IsSurround;

            SuperCamCentral superCamCentral1 = SaveGame.SuperCamCentrals[0];
            CBJumpCamsEnabled1.Checked = superCamCentral1.JumpCamsEnabled;
            CBIsInvertedCameraEnabled1.Checked = superCamCentral1.IsInvertedCameraEnabled;
            CBPreferredFollowCam1.SelectedItem = superCamCentral1.PreferredFollowCam;

            SuperCamCentral superCamCentral2 = SaveGame.SuperCamCentrals[1];
            CBJumpCamsEnabled2.Checked = superCamCentral2.JumpCamsEnabled;
            CBIsInvertedCameraEnabled2.Checked = superCamCentral2.IsInvertedCameraEnabled;
            CBPreferredFollowCam2.SelectedItem = superCamCentral2.PreferredFollowCam;

            SuperCamCentral superCamCentral3 = SaveGame.SuperCamCentrals[2];
            CBJumpCamsEnabled3.Checked = superCamCentral3.JumpCamsEnabled;
            CBIsInvertedCameraEnabled3.Checked = superCamCentral3.IsInvertedCameraEnabled;
            CBPreferredFollowCam3.SelectedItem = superCamCentral3.PreferredFollowCam;

            SuperCamCentral superCamCentral4 = SaveGame.SuperCamCentrals[3];
            CBJumpCamsEnabled4.Checked = superCamCentral4.JumpCamsEnabled;
            CBIsInvertedCameraEnabled4.Checked = superCamCentral4.IsInvertedCameraEnabled;
            CBPreferredFollowCam4.SelectedItem = superCamCentral4.PreferredFollowCam;

            TutorialManager tutorialManager = SaveGame.TutorialManager;
            CBEnableTutorialEvents.Checked = tutorialManager.EnableTutorialEvents;
            CLBTutorialsSeen.BeginUpdate();
            for (int i = 0; i < CLBTutorialsSeen.Items.Count; i++)
            {
                TutorialManager.TutorialMode tutorialMode = (TutorialManager.TutorialMode)CLBTutorialsSeen.Items[i];
                CLBTutorialsSeen.SetItemChecked(i, (tutorialManager.TutorialsSeen & tutorialMode) > 0);
            }
            CLBTutorialsSeen.EndUpdate();

            GUISystem guiSystem = SaveGame.GUISystem;
            CBIsRadarEnabled.Checked = guiSystem.IsRadarEnabled;

            CardGallery cardGallery = SaveGame.CardGallery;
            CLBCollectedCardIDs.BeginUpdate();
            for (int i = 0; i < cardGallery.CollectedCardIDs.Length; i++)
                CLBCollectedCardIDs.SetItemChecked(i, cardGallery.CollectedCardIDs[i]);
            CLBCollectedCardIDs.EndUpdate();

            TCMain.Enabled = true;
            UnsavedChanges = false;
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Control) == 0)
                return;
            switch (e.KeyCode)
            {
                case Keys.N:
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    TSMINew.PerformClick();
                    break;
                case Keys.O:
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    TSMIOpen.PerformClick();
                    break;
                case Keys.S:
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    if ((e.Modifiers & Keys.Shift) == 0)
                        TSMISave.PerformClick();
                    else
                        TSMISaveAs.PerformClick();
                    break;
            }
        }

        private void TSMINew_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        TSMISave.PerformClick();
                        break;
                }
            }

            SaveGame = new SaveGame();
            LastPath = string.Empty;
            PopulateData();
        }

        private void TSMIOpen_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
            {
                var result = MessageBox.Show("There are unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        TSMISave.PerformClick();
                        break;
                }
            }

            using var ofd = new OpenFileDialog() { Title = "Open Save File", Filter = "Save files (Save1; Save2; Save3; Save4; Save5; Save6; Save7; Save8)|Save1;Save2;Save3;Save4;Save5;Save6;Save7;Save8|All files (*.*)|*.*" };
            if (!string.IsNullOrEmpty(LastPath))
                ofd.InitialDirectory = Path.GetDirectoryName(LastPath);
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            LoadSave(ofd.FileName);
        }

        private void TSMISave_Click(object sender, EventArgs e)
        {
            if (!ConfirmPurchaseTotals())
                return;

            if (!string.IsNullOrEmpty(LastPath))
            {
                try
                {
                    if (CBAutoSaveDate.Checked)
                    {
                        var now = DateTime.Now;
                        DTPSaveDate.Value = now;
                        NUDSaveHour.Value = now.Hour;
                        NUDSaveMinute.Value = now.Minute;
                        NUDSaveSecond.Value = now.Second;
                    }
                    using (var fileStream = File.Open(LastPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (var binaryWriter = new BinaryWriter(fileStream))
                        SaveGame.Write(binaryWriter);
                    UnsavedChanges = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing save file: {ex}", "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            using var sfd = new SaveFileDialog() { Title = "Save File", FileName = "Save1", Filter = "Save files|Save1;Save2;Save3;Save4;Save5;Save6;Save7;Save8|All files|*.*" };
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (CBAutoSaveDate.Checked)
                {
                    var now = DateTime.Now;
                    DTPSaveDate.Value = now;
                    NUDSaveHour.Value = now.Hour;
                    NUDSaveMinute.Value = now.Minute;
                    NUDSaveSecond.Value = now.Second;
                }
                using (var fileStream = File.Open(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var binaryWriter = new BinaryWriter(fileStream))
                    SaveGame.Write(binaryWriter);
                UnsavedChanges = false;
                LastPath = sfd.FileName;
                AddRecentFile(LastPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing save file: {ex}", "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMISaveAs_Click(object sender, EventArgs e)
        {
            if (!ConfirmPurchaseTotals())
                return;

            using var sfd = new SaveFileDialog() { Title = "Save File", Filter = "Save files|Save1;Save2;Save3;Save4;Save5;Save6;Save7;Save8|All files|*.*" };
            if (string.IsNullOrEmpty(LastPath))
            {
                sfd.FileName = "Save1";
            }
            else
            {
                sfd.InitialDirectory = Path.GetDirectoryName(LastPath);
                sfd.FileName = Path.GetFileName(LastPath);
                if (Path.GetExtension(LastPath).Length > 0)
                    sfd.FilterIndex = 2;
            }
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (CBAutoSaveDate.Checked)
                {
                    var now = DateTime.Now;
                    DTPSaveDate.Value = now;
                    NUDSaveHour.Value = now.Hour;
                    NUDSaveMinute.Value = now.Minute;
                    NUDSaveSecond.Value = now.Second;
                }
                using (var fileStream = File.Open(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var binaryWriter = new BinaryWriter(fileStream))
                    SaveGame.Write(binaryWriter);
                UnsavedChanges = false;
                LastPath = sfd.FileName;
                AddRecentFile(LastPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing save file: {ex}", "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMIExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBAutoSaveDate_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !CBAutoSaveDate.Checked;
            DTPSaveDate.Enabled = enabled;
            NUDSaveHour.Enabled = enabled;
            NUDSaveMinute.Enabled = enabled;
            NUDSaveSecond.Enabled = enabled;

            RegistryKey?.SetValue("AutoUpdateSaveDate", CBAutoSaveDate.Checked ? 1 : 0, Microsoft.Win32.RegistryValueKind.DWord);
        }

        private void DTPSaveDate_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SaveGameInfo.SaveDate = DTPSaveDate.Value;
        }

        private void NUDSaveHour_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SaveGameInfo.Hour = (byte)NUDSaveHour.Value;
        }

        private void NUDSaveMinute_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SaveGameInfo.Minute = (byte)NUDSaveMinute.Value;
        }

        private void NUDSaveSecond_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SaveGameInfo.Second = (byte)NUDSaveSecond.Value;
        }

        private void NUDDisplayLevel_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SaveGameInfo.DisplayLevel = (byte)NUDDisplayLevel.Value;
        }

        private void NUDDisplayMission_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SaveGameInfo.DisplayMission = (byte)NUDDisplayMission.Value;
        }

        private void CBIsRumbleEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.InputManager.IsRumbleEnabled = CBIsRumbleEnabled.Checked;
        }

        private void TxtPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.PlayerName = TxtPlayerName.Text;
        }

        private void CBCurrentMissionInfoLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.CurrentMissionInfo.Level = (CharacterSheet.CurrentMission.Levels)CBCurrentMissionInfoLevel.SelectedItem;
        }

        private void CBCurrentMissionInfoMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.CurrentMissionInfo.Mission = (CharacterSheet.CurrentMission.Missions)CBCurrentMissionInfoMission.SelectedItem;
        }

        private void CBHighestMissionInfoLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.HighestMissionInfo.Level = (CharacterSheet.CurrentMission.Levels)CBHighestMissionInfoLevel.SelectedItem;
        }

        private void CBHighestMissionInfoMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.HighestMissionInfo.Mission = (CharacterSheet.CurrentMission.Missions)CBHighestMissionInfoMission.SelectedItem;
        }

        private void CBIsNavSystemEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.IsNavSystemEnabled = CBIsNavSystemEnabled.Checked;
        }

        private void NUDCoins_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Coins = (int)NUDCoins.Value;
        }

        private void CBItchyScratchyCBGFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.ItchyScratchyCBGFirst = CBItchyScratchyCBGFirst.Checked;
        }

        private void CBItchyScratchyTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.ItchyScratchyTicket = CBItchyScratchyTicket.Checked;
        }

        private void CLBPersistentObjectStates_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.PersistentObjectStates[e.Index] = e.NewValue != CheckState.Checked;
        }

        private void CBLevel1FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].FMVUnlocked = CBLevel1FMVUnlocked.Checked;
        }

        private void NUDLevel1NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].NumCarsPurchased = (int)NUDLevel1NumCarsPurchased.Value;
        }

        private void NUDLevel1NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].NumSkinsPurchased = (int)NUDLevel1NumSkinsPurchased.Value;
        }

        private void NUDLevel1WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].WaspsDestroyed = (int)NUDLevel1WaspsDestroyed.Value;
        }

        private void CBLevel1CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].CurrentSkin = CBLevel1CurrentSkin.Text;
        }

        private void CLBLevel1PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[0].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[0].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(0, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel1Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[0].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[0].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[0].GagsViewed = CLBLevel1Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel1Missions = false;
        private void LBLevel1Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel1Missions.SelectedIndex;
            UpdatingLevel1Missions = true;
            if (index == -1)
            {
                TxtLevel1MissionName.Text = "NULL";
                TxtLevel1MissionName.Enabled = false;
                CBLevel1Completed.Checked = false;
                CBLevel1Completed.Enabled = true;
                CBLevel1BonusObjective.Checked = false;
                CBLevel1BonusObjective.Enabled = true;
                NUDLevel1NumAttempts.Value = 0;
                NUDLevel1NumAttempts.Enabled = true;
                CBLevel1SkippedMission.Checked = false;
                CBLevel1SkippedMission.Enabled = true;
                NUDLevel1BestTime.Value = -1;
                NUDLevel1BestTime.Enabled = true;

                UpdatingLevel1Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], index);

            TxtLevel1MissionName.Text = mission.Name;
            TxtLevel1MissionName.Enabled = true;
            CBLevel1Completed.Checked = mission.Completed;
            CBLevel1Completed.Enabled = true;
            CBLevel1BonusObjective.Checked = mission.BonusObjective;
            CBLevel1BonusObjective.Enabled = true;
            NUDLevel1NumAttempts.Value = mission.NumAttempts;
            NUDLevel1NumAttempts.Enabled = true;
            CBLevel1SkippedMission.Checked = mission.SkippedMission;
            CBLevel1SkippedMission.Enabled = true;
            NUDLevel1BestTime.Value = mission.BestTime;
            NUDLevel1BestTime.Enabled = true;

            UpdatingLevel1Missions = false;
        }

        private void TxtLevel1MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).Name = TxtLevel1MissionName.Text;
        }

        private void CBLevel1Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).Completed = CBLevel1Completed.Checked;
        }

        private void CBLevel1BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).BonusObjective = CBLevel1BonusObjective.Checked;
        }

        private void NUDLevel1NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).NumAttempts = (uint)NUDLevel1NumAttempts.Value;
        }

        private void CBLevel1SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).SkippedMission = CBLevel1SkippedMission.Checked;
        }

        private void NUDLevel1BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).BestTime = (int)NUDLevel1BestTime.Value;
        }

        private bool UpdatingLevel1Cards = false;
        private void LBLevel1Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel1Cards.SelectedIndex;
            UpdatingLevel1Cards = true;
            if (index == -1)
            {
                TxtLevel1CardName.Text = "Cardx";
                TxtLevel1CardName.Enabled = false;
                CBLevel1CardCollected.Checked = false;
                CBLevel1CardCollected.Enabled = true;

                UpdatingLevel1Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel1CardName.Text = card.Name;
            TxtLevel1CardName.Enabled = true;
            CBLevel1CardCollected.Checked = card.Collected;
            CBLevel1CardCollected.Enabled = true;

            UpdatingLevel1Cards = false;
        }

        private void TxtLevel1CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Cards || LBLevel1Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel1Cards.SelectedIndex].Name = TxtLevel1CardName.Text;
        }

        private void CBLevel1CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel1Cards || LBLevel1Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel1Cards.SelectedIndex].Collected = CBLevel1CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(LBLevel1Cards.SelectedIndex, CBLevel1CardCollected.Checked);
        }

        private void CBLevel2FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].FMVUnlocked = CBLevel2FMVUnlocked.Checked;
        }

        private void NUDLevel2NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].NumCarsPurchased = (int)NUDLevel2NumCarsPurchased.Value;
        }

        private void NUDLevel2NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].NumSkinsPurchased = (int)NUDLevel2NumSkinsPurchased.Value;
        }

        private void NUDLevel2WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].WaspsDestroyed = (int)NUDLevel2WaspsDestroyed.Value;
        }

        private void CBLevel2CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].CurrentSkin = CBLevel2CurrentSkin.Text;
        }

        private void CLBLevel2PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[1].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[1].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(1, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel2Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[1].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[1].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[1].GagsViewed = CLBLevel2Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel2Missions = false;
        private void LBLevel2Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel2Missions.SelectedIndex;
            UpdatingLevel2Missions = true;
            if (index == -1)
            {
                TxtLevel2MissionName.Text = "NULL";
                TxtLevel2MissionName.Enabled = false;
                CBLevel2Completed.Checked = false;
                CBLevel2Completed.Enabled = true;
                CBLevel2BonusObjective.Checked = false;
                CBLevel2BonusObjective.Enabled = true;
                NUDLevel2NumAttempts.Value = 0;
                NUDLevel2NumAttempts.Enabled = true;
                CBLevel2SkippedMission.Checked = false;
                CBLevel2SkippedMission.Enabled = true;
                NUDLevel2BestTime.Value = -1;
                NUDLevel2BestTime.Enabled = true;

                UpdatingLevel2Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], index);

            TxtLevel2MissionName.Text = mission.Name;
            TxtLevel2MissionName.Enabled = true;
            CBLevel2Completed.Checked = mission.Completed;
            CBLevel2Completed.Enabled = true;
            CBLevel2BonusObjective.Checked = mission.BonusObjective;
            CBLevel2BonusObjective.Enabled = true;
            NUDLevel2NumAttempts.Value = mission.NumAttempts;
            NUDLevel2NumAttempts.Enabled = true;
            CBLevel2SkippedMission.Checked = mission.SkippedMission;
            CBLevel2SkippedMission.Enabled = true;
            NUDLevel2BestTime.Value = mission.BestTime;
            NUDLevel2BestTime.Enabled = true;

            UpdatingLevel2Missions = false;
        }

        private void TxtLevel2MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).Name = TxtLevel2MissionName.Text;
        }

        private void CBLevel2Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Missions|| LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).Completed = CBLevel2Completed.Checked;
        }

        private void CBLevel2BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).BonusObjective = CBLevel2BonusObjective.Checked;
        }

        private void NUDLevel2NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).NumAttempts = (uint)NUDLevel2NumAttempts.Value;
        }

        private void CBLevel2SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).SkippedMission = CBLevel2SkippedMission.Checked;
        }

        private void NUDLevel2BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).BestTime = (int)NUDLevel2BestTime.Value;
        }

        private bool UpdatingLevel2Cards = false;
        private void LBLevel2Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel2Cards.SelectedIndex;
            UpdatingLevel2Cards = true;
            if (index == -1)
            {
                TxtLevel2CardName.Text = "Cardx";
                TxtLevel2CardName.Enabled = false;
                CBLevel2CardCollected.Checked = false;
                CBLevel2CardCollected.Enabled = true;

                UpdatingLevel2Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel2CardName.Text = card.Name;
            TxtLevel2CardName.Enabled = true;
            CBLevel2CardCollected.Checked = card.Collected;
            CBLevel2CardCollected.Enabled = true;

            UpdatingLevel2Cards = false;
        }

        private void TxtLevel2CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Cards || LBLevel2Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel2Cards.SelectedIndex].Name = TxtLevel2CardName.Text;
        }

        private void CBLevel2CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel2Cards || LBLevel2Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel2Cards.SelectedIndex].Collected = CBLevel2CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(8 + LBLevel2Cards.SelectedIndex, CBLevel2CardCollected.Checked);
        }

        private void CBLevel3FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].FMVUnlocked = CBLevel3FMVUnlocked.Checked;
        }

        private void NUDLevel3NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].NumCarsPurchased = (int)NUDLevel3NumCarsPurchased.Value;
        }

        private void NUDLevel3NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].NumSkinsPurchased = (int)NUDLevel3NumSkinsPurchased.Value;
        }

        private void NUDLevel3WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].WaspsDestroyed = (int)NUDLevel3WaspsDestroyed.Value;
        }

        private void CBLevel3CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].CurrentSkin = CBLevel3CurrentSkin.Text;
        }

        private void CLBLevel3PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[2].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[2].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(2, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel3Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[2].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[2].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[2].GagsViewed = CLBLevel3Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel3Missions = false;
        private void LBLevel3Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel3Missions.SelectedIndex;
            UpdatingLevel3Missions = true;
            if (index == -1)
            {
                TxtLevel3MissionName.Text = "NULL";
                TxtLevel3MissionName.Enabled = false;
                CBLevel3Completed.Checked = false;
                CBLevel3Completed.Enabled = true;
                CBLevel3BonusObjective.Checked = false;
                CBLevel3BonusObjective.Enabled = true;
                NUDLevel3NumAttempts.Value = 0;
                NUDLevel3NumAttempts.Enabled = true;
                CBLevel3SkippedMission.Checked = false;
                CBLevel3SkippedMission.Enabled = true;
                NUDLevel3BestTime.Value = -1;
                NUDLevel3BestTime.Enabled = true;

                UpdatingLevel3Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], index);

            TxtLevel3MissionName.Text = mission.Name;
            TxtLevel3MissionName.Enabled = true;
            CBLevel3Completed.Checked = mission.Completed;
            CBLevel3Completed.Enabled = true;
            CBLevel3BonusObjective.Checked = mission.BonusObjective;
            CBLevel3BonusObjective.Enabled = true;
            NUDLevel3NumAttempts.Value = mission.NumAttempts;
            NUDLevel3NumAttempts.Enabled = true;
            CBLevel3SkippedMission.Checked = mission.SkippedMission;
            CBLevel3SkippedMission.Enabled = true;
            NUDLevel3BestTime.Value = mission.BestTime;
            NUDLevel3BestTime.Enabled = true;

            UpdatingLevel3Missions = false;
        }

        private void TxtLevel3MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).Name = TxtLevel3MissionName.Text;
        }

        private void CBLevel3Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).Completed = CBLevel3Completed.Checked;
        }

        private void CBLevel3BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).BonusObjective = CBLevel3BonusObjective.Checked;
        }

        private void NUDLevel3NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).NumAttempts = (uint)NUDLevel3NumAttempts.Value;
        }

        private void CBLevel3SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).SkippedMission = CBLevel3SkippedMission.Checked;
        }

        private void NUDLevel3BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).BestTime = (int)NUDLevel3BestTime.Value;
        }

        private bool UpdatingLevel3Cards = false;
        private void LBLevel3Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel3Cards.SelectedIndex;
            UpdatingLevel3Cards = true;
            if (index == -1)
            {
                TxtLevel3CardName.Text = "Cardx";
                TxtLevel3CardName.Enabled = false;
                CBLevel3CardCollected.Checked = false;
                CBLevel3CardCollected.Enabled = true;

                UpdatingLevel3Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel3CardName.Text = card.Name;
            TxtLevel3CardName.Enabled = true;
            CBLevel3CardCollected.Checked = card.Collected;
            CBLevel3CardCollected.Enabled = true;

            UpdatingLevel3Cards = false;
        }

        private void TxtLevel3CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Cards || LBLevel3Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel3Cards.SelectedIndex].Name = TxtLevel3CardName.Text;
        }

        private void CBLevel3CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel3Cards || LBLevel3Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel3Cards.SelectedIndex].Collected = CBLevel3CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(16 + LBLevel3Cards.SelectedIndex, CBLevel3CardCollected.Checked);
        }

        private void CBLevel4FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].FMVUnlocked = CBLevel4FMVUnlocked.Checked;
        }

        private void NUDLevel4NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].NumCarsPurchased = (int)NUDLevel4NumCarsPurchased.Value;
        }

        private void NUDLevel4NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].NumSkinsPurchased = (int)NUDLevel4NumSkinsPurchased.Value;
        }

        private void NUDLevel4WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].WaspsDestroyed = (int)NUDLevel4WaspsDestroyed.Value;
        }

        private void CBLevel4CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].CurrentSkin = CBLevel4CurrentSkin.Text;
        }

        private void CLBLevel4PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[3].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[3].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(3, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel4Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[3].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[3].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[3].GagsViewed = CLBLevel4Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel4Missions = false;
        private void LBLevel4Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel4Missions.SelectedIndex;
            UpdatingLevel4Missions = true;
            if (index == -1)
            {
                TxtLevel4MissionName.Text = "NULL";
                TxtLevel4MissionName.Enabled = false;
                CBLevel4Completed.Checked = false;
                CBLevel4Completed.Enabled = true;
                CBLevel4BonusObjective.Checked = false;
                CBLevel4BonusObjective.Enabled = true;
                NUDLevel4NumAttempts.Value = 0;
                NUDLevel4NumAttempts.Enabled = true;
                CBLevel4SkippedMission.Checked = false;
                CBLevel4SkippedMission.Enabled = true;
                NUDLevel4BestTime.Value = -1;
                NUDLevel4BestTime.Enabled = true;

                UpdatingLevel4Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], index);

            TxtLevel4MissionName.Text = mission.Name;
            TxtLevel4MissionName.Enabled = true;
            CBLevel4Completed.Checked = mission.Completed;
            CBLevel4Completed.Enabled = true;
            CBLevel4BonusObjective.Checked = mission.BonusObjective;
            CBLevel4BonusObjective.Enabled = true;
            NUDLevel4NumAttempts.Value = mission.NumAttempts;
            NUDLevel4NumAttempts.Enabled = true;
            CBLevel4SkippedMission.Checked = mission.SkippedMission;
            CBLevel4SkippedMission.Enabled = true;
            NUDLevel4BestTime.Value = mission.BestTime;
            NUDLevel4BestTime.Enabled = true;

            UpdatingLevel4Missions = false;
        }

        private void TxtLevel4MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).Name = TxtLevel4MissionName.Text;
        }

        private void CBLevel4Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).Completed = CBLevel4Completed.Checked;
        }

        private void CBLevel4BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).BonusObjective = CBLevel4BonusObjective.Checked;
        }

        private void NUDLevel4NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).NumAttempts = (uint)NUDLevel4NumAttempts.Value;
        }

        private void CBLevel4SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).SkippedMission = CBLevel4SkippedMission.Checked;
        }

        private void NUDLevel4BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).BestTime = (int)NUDLevel4BestTime.Value;
        }

        private bool UpdatingLevel4Cards = false;
        private void LBLevel4Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel4Cards.SelectedIndex;
            UpdatingLevel4Cards = true;
            if (index == -1)
            {
                TxtLevel4CardName.Text = "Cardx";
                TxtLevel4CardName.Enabled = false;
                CBLevel4CardCollected.Checked = false;
                CBLevel4CardCollected.Enabled = true;

                UpdatingLevel4Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel4CardName.Text = card.Name;
            TxtLevel4CardName.Enabled = true;
            CBLevel4CardCollected.Checked = card.Collected;
            CBLevel4CardCollected.Enabled = true;

            UpdatingLevel4Cards = false;
        }

        private void TxtLevel4CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Cards || LBLevel4Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel4Cards.SelectedIndex].Name = TxtLevel4CardName.Text;
        }

        private void CBLevel4CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel4Cards || LBLevel4Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel4Cards.SelectedIndex].Collected = CBLevel4CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(24 + LBLevel4Cards.SelectedIndex, CBLevel4CardCollected.Checked);
        }

        private void CBLevel5FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].FMVUnlocked = CBLevel5FMVUnlocked.Checked;
        }

        private void NUDLevel5NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].NumCarsPurchased = (int)NUDLevel5NumCarsPurchased.Value;
        }

        private void NUDLevel5NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].NumSkinsPurchased = (int)NUDLevel5NumSkinsPurchased.Value;
        }

        private void NUDLevel5WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].WaspsDestroyed = (int)NUDLevel5WaspsDestroyed.Value;
        }

        private void CBLevel5CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].CurrentSkin = CBLevel5CurrentSkin.Text;
        }

        private void CLBLevel5PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[4].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[4].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(4, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel5Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[4].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[4].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[4].GagsViewed = CLBLevel5Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel5Missions = false;
        private void LBLevel5Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel5Missions.SelectedIndex;
            UpdatingLevel5Missions = true;
            if (index == -1)
            {
                TxtLevel5MissionName.Text = "NULL";
                TxtLevel5MissionName.Enabled = false;
                CBLevel5Completed.Checked = false;
                CBLevel5Completed.Enabled = true;
                CBLevel5BonusObjective.Checked = false;
                CBLevel5BonusObjective.Enabled = true;
                NUDLevel5NumAttempts.Value = 0;
                NUDLevel5NumAttempts.Enabled = true;
                CBLevel5SkippedMission.Checked = false;
                CBLevel5SkippedMission.Enabled = true;
                NUDLevel5BestTime.Value = -1;
                NUDLevel5BestTime.Enabled = true;

                UpdatingLevel5Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], index);

            TxtLevel5MissionName.Text = mission.Name;
            TxtLevel5MissionName.Enabled = true;
            CBLevel5Completed.Checked = mission.Completed;
            CBLevel5Completed.Enabled = true;
            CBLevel5BonusObjective.Checked = mission.BonusObjective;
            CBLevel5BonusObjective.Enabled = true;
            NUDLevel5NumAttempts.Value = mission.NumAttempts;
            NUDLevel5NumAttempts.Enabled = true;
            CBLevel5SkippedMission.Checked = mission.SkippedMission;
            CBLevel5SkippedMission.Enabled = true;
            NUDLevel5BestTime.Value = mission.BestTime;
            NUDLevel5BestTime.Enabled = true;

            UpdatingLevel5Missions = false;
        }

        private void TxtLevel5MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).Name = TxtLevel5MissionName.Text;
        }

        private void CBLevel5Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).Completed = CBLevel5Completed.Checked;
        }

        private void CBLevel5BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).BonusObjective = CBLevel5BonusObjective.Checked;
        }

        private void NUDLevel5NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).NumAttempts = (uint)NUDLevel5NumAttempts.Value;
        }

        private void CBLevel5SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).SkippedMission = CBLevel5SkippedMission.Checked;
        }

        private void NUDLevel5BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).BestTime = (int)NUDLevel5BestTime.Value;
        }

        private bool UpdatingLevel5Cards = false;
        private void LBLevel5Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel5Cards.SelectedIndex;
            UpdatingLevel5Cards = true;
            if (index == -1)
            {
                TxtLevel5CardName.Text = "Cardx";
                TxtLevel5CardName.Enabled = false;
                CBLevel5CardCollected.Checked = false;
                CBLevel5CardCollected.Enabled = true;

                UpdatingLevel5Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel5CardName.Text = card.Name;
            TxtLevel5CardName.Enabled = true;
            CBLevel5CardCollected.Checked = card.Collected;
            CBLevel5CardCollected.Enabled = true;

            UpdatingLevel5Cards = false;
        }

        private void TxtLevel5CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Cards || LBLevel5Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel5Cards.SelectedIndex].Name = TxtLevel5CardName.Text;
        }

        private void CBLevel5CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel5Cards || LBLevel5Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel5Cards.SelectedIndex].Collected = CBLevel5CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(32 + LBLevel5Cards.SelectedIndex, CBLevel5CardCollected.Checked);
        }

        private void CBLevel6FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].FMVUnlocked = CBLevel6FMVUnlocked.Checked;
        }

        private void NUDLevel6NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].NumCarsPurchased = (int)NUDLevel6NumCarsPurchased.Value;
        }

        private void NUDLevel6NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].NumSkinsPurchased = (int)NUDLevel6NumSkinsPurchased.Value;
        }

        private void NUDLevel6WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].WaspsDestroyed = (int)NUDLevel6WaspsDestroyed.Value;
        }

        private void CBLevel6CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].CurrentSkin = CBLevel6CurrentSkin.Text;
        }

        private void CLBLevel6PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[5].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[5].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(5, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel6Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[5].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[5].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[5].GagsViewed = CLBLevel6Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel6Missions = false;
        private void LBLevel6Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel6Missions.SelectedIndex;
            UpdatingLevel6Missions = true;
            if (index == -1)
            {
                TxtLevel6MissionName.Text = "NULL";
                TxtLevel6MissionName.Enabled = false;
                CBLevel6Completed.Checked = false;
                CBLevel6Completed.Enabled = true;
                CBLevel6BonusObjective.Checked = false;
                CBLevel6BonusObjective.Enabled = true;
                NUDLevel6NumAttempts.Value = 0;
                NUDLevel6NumAttempts.Enabled = true;
                CBLevel6SkippedMission.Checked = false;
                CBLevel6SkippedMission.Enabled = true;
                NUDLevel6BestTime.Value = -1;
                NUDLevel6BestTime.Enabled = true;

                UpdatingLevel6Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], index);

            TxtLevel6MissionName.Text = mission.Name;
            TxtLevel6MissionName.Enabled = true;
            CBLevel6Completed.Checked = mission.Completed;
            CBLevel6Completed.Enabled = true;
            CBLevel6BonusObjective.Checked = mission.BonusObjective;
            CBLevel6BonusObjective.Enabled = true;
            NUDLevel6NumAttempts.Value = mission.NumAttempts;
            NUDLevel6NumAttempts.Enabled = true;
            CBLevel6SkippedMission.Checked = mission.SkippedMission;
            CBLevel6SkippedMission.Enabled = true;
            NUDLevel6BestTime.Value = mission.BestTime;
            NUDLevel6BestTime.Enabled = true;

            UpdatingLevel6Missions = false;
        }

        private void TxtLevel6MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).Name = TxtLevel6MissionName.Text;
        }

        private void CBLevel6Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).Completed = CBLevel6Completed.Checked;
        }

        private void CBLevel6BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).BonusObjective = CBLevel6BonusObjective.Checked;
        }

        private void NUDLevel6NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).NumAttempts = (uint)NUDLevel6NumAttempts.Value;
        }

        private void CBLevel6SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).SkippedMission = CBLevel6SkippedMission.Checked;
        }

        private void NUDLevel6BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).BestTime = (int)NUDLevel6BestTime.Value;
        }

        private bool UpdatingLevel6Cards = false;
        private void LBLevel6Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel6Cards.SelectedIndex;
            UpdatingLevel6Cards = true;
            if (index == -1)
            {
                TxtLevel6CardName.Text = "Cardx";
                TxtLevel6CardName.Enabled = false;
                CBLevel6CardCollected.Checked = false;
                CBLevel6CardCollected.Enabled = true;

                UpdatingLevel6Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel6CardName.Text = card.Name;
            TxtLevel6CardName.Enabled = true;
            CBLevel6CardCollected.Checked = card.Collected;
            CBLevel6CardCollected.Enabled = true;

            UpdatingLevel6Cards = false;
        }

        private void TxtLevel6CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Cards || LBLevel6Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel6Cards.SelectedIndex].Name = TxtLevel6CardName.Text;
        }

        private void CBLevel6CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel6Cards || LBLevel6Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel6Cards.SelectedIndex].Collected = CBLevel6CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(40 + LBLevel6Cards.SelectedIndex, CBLevel6CardCollected.Checked);
        }

        private void CBLevel7FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].FMVUnlocked = CBLevel7FMVUnlocked.Checked;
        }

        private void NUDLevel7NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].NumCarsPurchased = (int)NUDLevel7NumCarsPurchased.Value;
        }

        private void NUDLevel7NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].NumSkinsPurchased = (int)NUDLevel7NumSkinsPurchased.Value;
        }

        private void NUDLevel7WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].WaspsDestroyed = (int)NUDLevel7WaspsDestroyed.Value;
        }

        private void CBLevel7CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].CurrentSkin = CBLevel7CurrentSkin.Text;
        }

        private void CLBLevel7PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            if (e.Index < SaveGame.CharacterSheet.Levels[6].PurchasedRewards.Length)
                SaveGame.CharacterSheet.Levels[6].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
            else
                SaveGame.CustomSaveData.LucasModLauncherData?.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked?.Set(6, e.Index, e.NewValue == CheckState.Checked);
        }

        private void CLBLevel7Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[6].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[6].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[6].GagsViewed = CLBLevel7Gags.CheckedItems.Count + (value ? 1 : -1);
        }

        private bool UpdatingLevel7Missions = false;
        private void LBLevel7Missions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel7Missions.SelectedIndex;
            UpdatingLevel7Missions = true;
            if (index == -1)
            {
                TxtLevel7MissionName.Text = "NULL";
                TxtLevel7MissionName.Enabled = false;
                CBLevel7Completed.Checked = false;
                CBLevel7Completed.Enabled = true;
                CBLevel7BonusObjective.Checked = false;
                CBLevel7BonusObjective.Enabled = true;
                NUDLevel7NumAttempts.Value = 0;
                NUDLevel7NumAttempts.Enabled = true;
                CBLevel7SkippedMission.Checked = false;
                CBLevel7SkippedMission.Enabled = true;
                NUDLevel7BestTime.Value = -1;
                NUDLevel7BestTime.Enabled = true;

                UpdatingLevel7Missions = true;
                return;
            }

            var mission = GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], index);

            TxtLevel7MissionName.Text = mission.Name;
            TxtLevel7MissionName.Enabled = true;
            CBLevel7Completed.Checked = mission.Completed;
            CBLevel7Completed.Enabled = true;
            CBLevel7BonusObjective.Checked = mission.BonusObjective;
            CBLevel7BonusObjective.Enabled = true;
            NUDLevel7NumAttempts.Value = mission.NumAttempts;
            NUDLevel7NumAttempts.Enabled = true;
            CBLevel7SkippedMission.Checked = mission.SkippedMission;
            CBLevel7SkippedMission.Enabled = true;
            NUDLevel7BestTime.Value = mission.BestTime;
            NUDLevel7BestTime.Enabled = true;

            UpdatingLevel7Missions = false;
        }

        private void TxtLevel7MissionName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).Name = TxtLevel7MissionName.Text;
        }

        private void CBLevel7Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).Completed = CBLevel7Completed.Checked;
        }

        private void CBLevel7BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).BonusObjective = CBLevel7BonusObjective.Checked;
        }

        private void NUDLevel7NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).NumAttempts = (uint)NUDLevel7NumAttempts.Value;
        }

        private void CBLevel7SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).SkippedMission = CBLevel7SkippedMission.Checked;
        }

        private void NUDLevel7BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).BestTime = (int)NUDLevel7BestTime.Value;
        }

        private bool UpdatingLevel7Cards = false;
        private void LBLevel7Cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBLevel7Cards.SelectedIndex;
            UpdatingLevel7Cards = true;
            if (index == -1)
            {
                TxtLevel7CardName.Text = "Cardx";
                TxtLevel7CardName.Enabled = false;
                CBLevel7CardCollected.Checked = false;
                CBLevel7CardCollected.Enabled = true;

                UpdatingLevel7Cards = true;
                return;
            }

            var card = SaveGame.CharacterSheet.Levels[0].Cards[index];

            TxtLevel7CardName.Text = card.Name;
            TxtLevel7CardName.Enabled = true;
            CBLevel7CardCollected.Checked = card.Collected;
            CBLevel7CardCollected.Enabled = true;

            UpdatingLevel7Cards = false;
        }

        private void TxtLevel7CardName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Cards || LBLevel7Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel7Cards.SelectedIndex].Name = TxtLevel7CardName.Text;
        }

        private void CBLevel7CardCollected_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingLevel7Cards || LBLevel7Cards.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].Cards[LBLevel7Cards.SelectedIndex].Collected = CBLevel7CardCollected.Checked;
            CLBCollectedCardIDs.SetItemChecked(48 + LBLevel7Cards.SelectedIndex, CBLevel7CardCollected.Checked);
        }

        private bool UpdatingCars = false;
        private void LBCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBCars.SelectedIndex;
            UpdatingCars = true;
            if (index == -1)
            {
                TxtCarName.Text = "n/a";
                TxtCarName.Enabled = false;
                NUDCurrentHealth.Value = -100;
                NUDCurrentHealth.Enabled = false;
                NUDMaxHealth.Value = -100;
                NUDMaxHealth.Enabled = false;
            }
            else
            {
                var car = SaveGame.CharacterSheet.Cars.Cars[index];
                TxtCarName.Text = car.Name;
                TxtCarName.Enabled = true;
                NUDCurrentHealth.Value = (decimal)(car.CurrentHealth * 100d);
                NUDCurrentHealth.Enabled = true;
                NUDMaxHealth.Value = (decimal)car.MaxHealth;
                NUDMaxHealth.Enabled = true;
            }
            UpdatingCars = false;
        }

        private void TxtCarName_TextChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingCars || LBCars.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Cars[LBCars.SelectedIndex].Name = TxtCarName.Text;
        }

        private void NUDCurrentHealth_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingCars || LBCars.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Cars[LBCars.SelectedIndex].CurrentHealth = (float)(NUDCurrentHealth.Value / 100);
        }

        private void NUDMaxHealth_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled || UpdatingCars || LBCars.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Cars[LBCars.SelectedIndex].MaxHealth = (float)(NUDMaxHealth.Value);
        }

        private void NUDCounter_ValueChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Counter = (int)NUDCounter.Value;
        }

        private void TBMusicVolume_ValueChanged(object sender, EventArgs e)
        {
            LblMusicVolumeValue.Text = $"{TBMusicVolume.Value}%";
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SoundSettings.MusicVolume = TBMusicVolume.Value / 100f;
        }

        private void TBSFXVolume_ValueChanged(object sender, EventArgs e)
        {
            LblSFXVolumeValue.Text = $"{TBSFXVolume.Value}%";
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SoundSettings.SFXVolume = TBSFXVolume.Value / 100f;
        }

        private void TBCarVolume_ValueChanged(object sender, EventArgs e)
        {
            LblCarVolumeValue.Text = $"{TBCarVolume.Value}%";
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SoundSettings.CarVolume = TBCarVolume.Value / 100f;
        }

        private void TBDialogVolume_ValueChanged(object sender, EventArgs e)
        {
            LblDialogVolumeValue.Text = $"{TBDialogVolume.Value}%";
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SoundSettings.DialogVolume = TBDialogVolume.Value / 100f;
        }

        private void CBJumpCamsEnabled1_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[0].JumpCamsEnabled = CBJumpCamsEnabled1.Checked;
        }

        private void CBIsInvertedCameraEnabled1_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[0].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled1.Checked;
        }

        private void CBPreferredFollowCam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[0].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam1.SelectedItem;
        }

        private void CBJumpCamsEnabled2_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[1].JumpCamsEnabled = CBJumpCamsEnabled2.Checked;
        }

        private void CBIsInvertedCameraEnabled2_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[1].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled2.Checked;
        }

        private void CBPreferredFollowCam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[1].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam2.SelectedItem;
        }

        private void CBJumpCamsEnabled3_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[2].JumpCamsEnabled = CBJumpCamsEnabled3.Checked;
        }

        private void CBIsInvertedCameraEnabled3_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[2].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled3.Checked;
        }

        private void CBPreferredFollowCam3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[2].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam3.SelectedItem;
        }

        private void CBJumpCamsEnabled4_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[3].JumpCamsEnabled = CBJumpCamsEnabled4.Checked;
        }

        private void CBIsInvertedCameraEnabled4_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[3].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled4.Checked;
        }

        private void CBPreferredFollowCam4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[3].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam4.SelectedItem;
        }

        private void CBEnableTutorialEvents_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.TutorialManager.EnableTutorialEvents = CBEnableTutorialEvents.Checked;
        }

        private void CLBTutorialsSeen_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            TutorialManager.TutorialMode tutorialMode = (TutorialManager.TutorialMode)CLBTutorialsSeen.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                SaveGame.TutorialManager.TutorialsSeen |= tutorialMode;
            }
            else
            {
                SaveGame.TutorialManager.TutorialsSeen &= ~tutorialMode;
            }
        }

        private void CBIsRadarEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            SaveGame.GUISystem.IsRadarEnabled = CBIsRadarEnabled.Checked;
        }

        private void CLBCollectedCardIDs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!TCMain.Enabled)
                return;

            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CardGallery.CollectedCardIDs[e.Index] = value;
            int level = e.Index / 8;
            int card = e.Index % 8;
            if (card == 7)
                return;
            SaveGame.CharacterSheet.Levels[level].Cards[card].Collected = value;

            ListBox lb;
            CheckBox cb;
            switch (level)
            {
                case 0:
                    lb = LBLevel1Cards;
                    cb = CBLevel1CardCollected;
                    break;
                case 1:
                    lb = LBLevel2Cards;
                    cb = CBLevel2CardCollected;
                    break;
                case 2:
                    lb = LBLevel3Cards;
                    cb = CBLevel3CardCollected;
                    break;
                case 3:
                    lb = LBLevel4Cards;
                    cb = CBLevel4CardCollected;
                    break;
                case 4:
                    lb = LBLevel5Cards;
                    cb = CBLevel5CardCollected;
                    break;
                case 5:
                    lb = LBLevel6Cards;
                    cb = CBLevel6CardCollected;
                    break;
                case 6:
                    lb = LBLevel7Cards;
                    cb = CBLevel7CardCollected;
                    break;
                default:
                    return;
            }
            if (lb.SelectedIndex != card)
                return;
            cb.Checked = value;
        }

        private void TCCharacterSheetLevel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel1.SelectedIndex;
            TCCharacterSheetLevel2.SelectedIndex = index;
            TCCharacterSheetLevel3.SelectedIndex = index;
            TCCharacterSheetLevel4.SelectedIndex = index;
            TCCharacterSheetLevel5.SelectedIndex = index;
            TCCharacterSheetLevel6.SelectedIndex = index;
            TCCharacterSheetLevel7.SelectedIndex = index;
        }

        private void TCCharacterSheetLevel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel2.SelectedIndex;
            TCCharacterSheetLevel1.SelectedIndex = index;
            TCCharacterSheetLevel3.SelectedIndex = index;
            TCCharacterSheetLevel4.SelectedIndex = index;
            TCCharacterSheetLevel5.SelectedIndex = index;
            TCCharacterSheetLevel6.SelectedIndex = index;
            TCCharacterSheetLevel7.SelectedIndex = index;
        }

        private void TCCharacterSheetLevel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel3.SelectedIndex;
            TCCharacterSheetLevel1.SelectedIndex = index;
            TCCharacterSheetLevel2.SelectedIndex = index;
            TCCharacterSheetLevel4.SelectedIndex = index;
            TCCharacterSheetLevel5.SelectedIndex = index;
            TCCharacterSheetLevel6.SelectedIndex = index;
            TCCharacterSheetLevel7.SelectedIndex = index;
        }

        private void TCCharacterSheetLevel4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel4.SelectedIndex;
            TCCharacterSheetLevel1.SelectedIndex = index;
            TCCharacterSheetLevel2.SelectedIndex = index;
            TCCharacterSheetLevel3.SelectedIndex = index;
            TCCharacterSheetLevel5.SelectedIndex = index;
            TCCharacterSheetLevel6.SelectedIndex = index;
            TCCharacterSheetLevel7.SelectedIndex = index;
        }

        private void TCCharacterSheetLevel5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel5.SelectedIndex;
            TCCharacterSheetLevel1.SelectedIndex = index;
            TCCharacterSheetLevel2.SelectedIndex = index;
            TCCharacterSheetLevel3.SelectedIndex = index;
            TCCharacterSheetLevel4.SelectedIndex = index;
            TCCharacterSheetLevel6.SelectedIndex = index;
            TCCharacterSheetLevel7.SelectedIndex = index;
        }

        private void TCCharacterSheetLevel6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel6.SelectedIndex;
            TCCharacterSheetLevel1.SelectedIndex = index;
            TCCharacterSheetLevel2.SelectedIndex = index;
            TCCharacterSheetLevel3.SelectedIndex = index;
            TCCharacterSheetLevel4.SelectedIndex = index;
            TCCharacterSheetLevel5.SelectedIndex = index;
            TCCharacterSheetLevel7.SelectedIndex = index;
        }

        private void TCCharacterSheetLevel7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TCCharacterSheetLevel7.SelectedIndex;
            TCCharacterSheetLevel1.SelectedIndex = index;
            TCCharacterSheetLevel2.SelectedIndex = index;
            TCCharacterSheetLevel3.SelectedIndex = index;
            TCCharacterSheetLevel4.SelectedIndex = index;
            TCCharacterSheetLevel5.SelectedIndex = index;
            TCCharacterSheetLevel6.SelectedIndex = index;
        }

        private void TSMISelectAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to select all?\nThis action cannot be reversed.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            if (sender is not ToolStripItem menuItem)
                return;
            if (menuItem.Owner is not ContextMenuStrip owner)
                return;
            if (owner.SourceControl is not CheckedListBox clb)
                return;

            clb.BeginUpdate();
            for (int i = 0; i < clb.Items.Count; i++)
                clb.SetItemChecked(i, true);
            clb.EndUpdate();
        }

        private void TSMIDeselectAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to deselect all?\nThis action cannot be reversed.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            if (sender is not ToolStripItem menuItem)
                return;
            if (menuItem.Owner is not ContextMenuStrip owner)
                return;
            if (owner.SourceControl is not CheckedListBox clb)
                return;

            clb.BeginUpdate();
            for (int i = 0; i < clb.Items.Count; i++)
                clb.SetItemChecked(i, false);
            clb.EndUpdate();
        }
    }
}
