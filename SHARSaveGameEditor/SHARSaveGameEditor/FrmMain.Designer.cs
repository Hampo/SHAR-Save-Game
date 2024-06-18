namespace SHARSaveGameEditor
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.TSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMINew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TCMain = new System.Windows.Forms.TabControl();
            this.TPSaveGameInfo = new System.Windows.Forms.TabPage();
            this.NUDSaveSecond = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDSaveMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDSaveHour = new System.Windows.Forms.NumericUpDown();
            this.LblSaveTime = new System.Windows.Forms.Label();
            this.NUDDisplayMission = new System.Windows.Forms.NumericUpDown();
            this.LblDisplayMission = new System.Windows.Forms.Label();
            this.NUDDisplayLevel = new System.Windows.Forms.NumericUpDown();
            this.LblDisplayLevel = new System.Windows.Forms.Label();
            this.CBAutoSaveDate = new System.Windows.Forms.CheckBox();
            this.DTPSaveDate = new System.Windows.Forms.DateTimePicker();
            this.LblSaveDate = new System.Windows.Forms.Label();
            this.TPInputManager = new System.Windows.Forms.TabPage();
            this.CBIsRumbleEnabled = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheet = new System.Windows.Forms.TabPage();
            this.TCCharacterSheet = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetMiscellaneous = new System.Windows.Forms.TabPage();
            this.CLBPersistentObjectStates = new System.Windows.Forms.CheckedListBox();
            this.CMSCheckedListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMISelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIDeselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.LblPersistentObjectStates = new System.Windows.Forms.Label();
            this.CBItchyScratchyTicket = new System.Windows.Forms.CheckBox();
            this.CBItchyScratchyCBGFirst = new System.Windows.Forms.CheckBox();
            this.NUDCoins = new System.Windows.Forms.NumericUpDown();
            this.LblCoins = new System.Windows.Forms.Label();
            this.CBIsNavSystemEnabled = new System.Windows.Forms.CheckBox();
            this.CBHighestMissionInfoMission = new System.Windows.Forms.ComboBox();
            this.CBHighestMissionInfoLevel = new System.Windows.Forms.ComboBox();
            this.LblHighestMissionInfo = new System.Windows.Forms.Label();
            this.CBCurrentMissionInfoMission = new System.Windows.Forms.ComboBox();
            this.CBCurrentMissionInfoLevel = new System.Windows.Forms.ComboBox();
            this.LblCurrentMissionInfo = new System.Windows.Forms.Label();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.TPCharacterSheetLevels = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevels = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel1 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel1 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel1Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel1PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel1PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel1Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel1Gags = new System.Windows.Forms.Label();
            this.CBLevel1CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel1CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel1WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel1WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel1NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel1NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel1NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel1NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel1FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel1Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel1BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel1BestTime = new System.Windows.Forms.Label();
            this.CBLevel1SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel1NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel1NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel1BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel1Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel1MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel1MissionName = new System.Windows.Forms.Label();
            this.LBLevel1Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel1Cards = new System.Windows.Forms.TabPage();
            this.CBLevel1CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel1CardName = new System.Windows.Forms.TextBox();
            this.LblLevel1CardName = new System.Windows.Forms.Label();
            this.LBLevel1Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel2 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel2 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel2Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel2PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel2PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel2Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel2Gags = new System.Windows.Forms.Label();
            this.CBLevel2CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel2CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel2WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel2WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel2NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel2NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel2NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel2NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel2FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel2Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel2BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel2BestTime = new System.Windows.Forms.Label();
            this.CBLevel2SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel2NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel2NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel2BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel2Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel2MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel2MissionName = new System.Windows.Forms.Label();
            this.LBLevel2Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel2Cards = new System.Windows.Forms.TabPage();
            this.CBLevel2CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel2CardName = new System.Windows.Forms.TextBox();
            this.LblLevel2CardName = new System.Windows.Forms.Label();
            this.LBLevel2Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel3 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel3 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel3Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel3PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel3PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel3Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel3Gags = new System.Windows.Forms.Label();
            this.CBLevel3CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel3CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel3WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel3WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel3NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel3NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel3NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel3NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel3FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel3Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel3BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel3BestTime = new System.Windows.Forms.Label();
            this.CBLevel3SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel3NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel3NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel3BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel3Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel3MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel3MissionName = new System.Windows.Forms.Label();
            this.LBLevel3Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel3Cards = new System.Windows.Forms.TabPage();
            this.CBLevel3CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel3CardName = new System.Windows.Forms.TextBox();
            this.LblLevel3CardName = new System.Windows.Forms.Label();
            this.LBLevel3Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel4 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel4 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel4Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel4PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel4PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel4Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel4Gags = new System.Windows.Forms.Label();
            this.CBLevel4CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel4CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel4WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel4WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel4NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel4NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel4NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel4NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel4FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel4Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel4BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel4BestTime = new System.Windows.Forms.Label();
            this.CBLevel4SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel4NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel4NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel4BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel4Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel4MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel4MissionName = new System.Windows.Forms.Label();
            this.LBLevel4Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel4Cards = new System.Windows.Forms.TabPage();
            this.CBLevel4CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel4CardName = new System.Windows.Forms.TextBox();
            this.LblLevel4CardName = new System.Windows.Forms.Label();
            this.LBLevel4Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel5 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel5 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel5Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel5PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel5PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel5Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel5Gags = new System.Windows.Forms.Label();
            this.CBLevel5CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel5CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel5WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel5WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel5NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel5NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel5NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel5NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel5FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel5Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel5BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel5BestTime = new System.Windows.Forms.Label();
            this.CBLevel5SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel5NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel5NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel5BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel5Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel5MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel5MissionName = new System.Windows.Forms.Label();
            this.LBLevel5Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel5Cards = new System.Windows.Forms.TabPage();
            this.CBLevel5CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel5CardName = new System.Windows.Forms.TextBox();
            this.LblLevel5CardName = new System.Windows.Forms.Label();
            this.LBLevel5Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel6 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel6 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel6Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel6PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel6PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel6Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel6Gags = new System.Windows.Forms.Label();
            this.CBLevel6CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel6CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel6WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel6WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel6NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel6NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel6NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel6NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel6FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel6Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel6BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel6BestTime = new System.Windows.Forms.Label();
            this.CBLevel6SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel6NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel6NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel6BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel6Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel6MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel6MissionName = new System.Windows.Forms.Label();
            this.LBLevel6Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel6Cards = new System.Windows.Forms.TabPage();
            this.CBLevel6CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel6CardName = new System.Windows.Forms.TextBox();
            this.LblLevel6CardName = new System.Windows.Forms.Label();
            this.LBLevel6Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel7 = new System.Windows.Forms.TabPage();
            this.TCCharacterSheetLevel7 = new System.Windows.Forms.TabControl();
            this.TPCharacterSheetLevel7Miscellaneous = new System.Windows.Forms.TabPage();
            this.CLBLevel7PurchasedRewards = new System.Windows.Forms.CheckedListBox();
            this.LblLevel7PurchasedRewards = new System.Windows.Forms.Label();
            this.CLBLevel7Gags = new System.Windows.Forms.CheckedListBox();
            this.LblLevel7Gags = new System.Windows.Forms.Label();
            this.CBLevel7CurrentSkin = new System.Windows.Forms.ComboBox();
            this.LblLevel7CurrentSkin = new System.Windows.Forms.Label();
            this.NUDLevel7WaspsDestroyed = new System.Windows.Forms.NumericUpDown();
            this.LblLevel7WaspsDestroyed = new System.Windows.Forms.Label();
            this.NUDLevel7NumSkinsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel7NumSkinsPurchased = new System.Windows.Forms.Label();
            this.NUDLevel7NumCarsPurchased = new System.Windows.Forms.NumericUpDown();
            this.LblLevel7NumCarsPurchased = new System.Windows.Forms.Label();
            this.CBLevel7FMVUnlocked = new System.Windows.Forms.CheckBox();
            this.TPCharacterSheetLevel7Missions = new System.Windows.Forms.TabPage();
            this.NUDLevel7BestTime = new System.Windows.Forms.NumericUpDown();
            this.LblLevel7BestTime = new System.Windows.Forms.Label();
            this.CBLevel7SkippedMission = new System.Windows.Forms.CheckBox();
            this.NUDLevel7NumAttempts = new System.Windows.Forms.NumericUpDown();
            this.LblLevel7NumAttempts = new System.Windows.Forms.Label();
            this.CBLevel7BonusObjective = new System.Windows.Forms.CheckBox();
            this.CBLevel7Completed = new System.Windows.Forms.CheckBox();
            this.TxtLevel7MissionName = new System.Windows.Forms.TextBox();
            this.LblLevel7MissionName = new System.Windows.Forms.Label();
            this.LBLevel7Missions = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetLevel7Cards = new System.Windows.Forms.TabPage();
            this.CBLevel7CardCollected = new System.Windows.Forms.CheckBox();
            this.TxtLevel7CardName = new System.Windows.Forms.TextBox();
            this.LblLevel7CardName = new System.Windows.Forms.Label();
            this.LBLevel7Cards = new System.Windows.Forms.ListBox();
            this.TPCharacterSheetCars = new System.Windows.Forms.TabPage();
            this.NUDCounter = new System.Windows.Forms.NumericUpDown();
            this.LblCounter = new System.Windows.Forms.Label();
            this.GBCars = new System.Windows.Forms.GroupBox();
            this.NUDMaxHealth = new System.Windows.Forms.NumericUpDown();
            this.LblMaxHealth = new System.Windows.Forms.Label();
            this.NUDCurrentHealth = new System.Windows.Forms.NumericUpDown();
            this.LblCurrentHealth = new System.Windows.Forms.Label();
            this.TxtCarName = new System.Windows.Forms.TextBox();
            this.LblCarName = new System.Windows.Forms.Label();
            this.LBCars = new System.Windows.Forms.ListBox();
            this.TPSoundSettings = new System.Windows.Forms.TabPage();
            this.CBIsSurround = new System.Windows.Forms.CheckBox();
            this.TBDialogVolume = new System.Windows.Forms.TrackBar();
            this.LblDialogVolumeValue = new System.Windows.Forms.Label();
            this.LblDialogVolume = new System.Windows.Forms.Label();
            this.TBCarVolume = new System.Windows.Forms.TrackBar();
            this.LblCarVolumeValue = new System.Windows.Forms.Label();
            this.LblCarVolume = new System.Windows.Forms.Label();
            this.TBSFXVolume = new System.Windows.Forms.TrackBar();
            this.LblSFXVolumeValue = new System.Windows.Forms.Label();
            this.LblSFXVolume = new System.Windows.Forms.Label();
            this.TBMusicVolume = new System.Windows.Forms.TrackBar();
            this.LblMusicVolumeValue = new System.Windows.Forms.Label();
            this.LblMusicVolume = new System.Windows.Forms.Label();
            this.TPSuperCamCentral = new System.Windows.Forms.TabPage();
            this.GBSuperCamCentral4 = new System.Windows.Forms.GroupBox();
            this.CBPreferredFollowCam4 = new System.Windows.Forms.ComboBox();
            this.CBIsInvertedCameraEnabled4 = new System.Windows.Forms.CheckBox();
            this.CBJumpCamsEnabled4 = new System.Windows.Forms.CheckBox();
            this.LblPreferredFollowCam4 = new System.Windows.Forms.Label();
            this.GBSuperCamCentral3 = new System.Windows.Forms.GroupBox();
            this.CBPreferredFollowCam3 = new System.Windows.Forms.ComboBox();
            this.CBIsInvertedCameraEnabled3 = new System.Windows.Forms.CheckBox();
            this.CBJumpCamsEnabled3 = new System.Windows.Forms.CheckBox();
            this.LblPreferredFollowCam3 = new System.Windows.Forms.Label();
            this.GBSuperCamCentral2 = new System.Windows.Forms.GroupBox();
            this.CBPreferredFollowCam2 = new System.Windows.Forms.ComboBox();
            this.CBIsInvertedCameraEnabled2 = new System.Windows.Forms.CheckBox();
            this.CBJumpCamsEnabled2 = new System.Windows.Forms.CheckBox();
            this.LblPreferredFollowCam2 = new System.Windows.Forms.Label();
            this.GBSuperCamCentral1 = new System.Windows.Forms.GroupBox();
            this.CBPreferredFollowCam1 = new System.Windows.Forms.ComboBox();
            this.CBIsInvertedCameraEnabled1 = new System.Windows.Forms.CheckBox();
            this.CBJumpCamsEnabled1 = new System.Windows.Forms.CheckBox();
            this.LblPreferredFollowCam1 = new System.Windows.Forms.Label();
            this.TPTutorialManager = new System.Windows.Forms.TabPage();
            this.CLBTutorialsSeen = new System.Windows.Forms.CheckedListBox();
            this.LblTutorialsSeen = new System.Windows.Forms.Label();
            this.CBEnableTutorialEvents = new System.Windows.Forms.CheckBox();
            this.TPGUISystem = new System.Windows.Forms.TabPage();
            this.CBIsRadarEnabled = new System.Windows.Forms.CheckBox();
            this.TPCardGallery = new System.Windows.Forms.TabPage();
            this.CLBCollectedCardIDs = new System.Windows.Forms.CheckedListBox();
            this.LblCollectedCardIDs = new System.Windows.Forms.Label();
            this.TPCustomSaveData = new System.Windows.Forms.TabPage();
            this.LblCustomSaveDataLength = new System.Windows.Forms.Label();
            this.LblCustomSaveData = new System.Windows.Forms.Label();
            this.CHPersistentObjectStatesIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHPersistentObjectStatesValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TTSettingInfo = new System.Windows.Forms.ToolTip(this.components);
            this.MSMain.SuspendLayout();
            this.TCMain.SuspendLayout();
            this.TPSaveGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSaveSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSaveMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSaveHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDisplayMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDisplayLevel)).BeginInit();
            this.TPInputManager.SuspendLayout();
            this.TPCharacterSheet.SuspendLayout();
            this.TCCharacterSheet.SuspendLayout();
            this.TPCharacterSheetMiscellaneous.SuspendLayout();
            this.CMSCheckedListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCoins)).BeginInit();
            this.TPCharacterSheetLevels.SuspendLayout();
            this.TCCharacterSheetLevels.SuspendLayout();
            this.TPCharacterSheetLevel1.SuspendLayout();
            this.TCCharacterSheetLevel1.SuspendLayout();
            this.TPCharacterSheetLevel1Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel1Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel1Cards.SuspendLayout();
            this.TPCharacterSheetLevel2.SuspendLayout();
            this.TCCharacterSheetLevel2.SuspendLayout();
            this.TPCharacterSheetLevel2Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel2Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel2Cards.SuspendLayout();
            this.TPCharacterSheetLevel3.SuspendLayout();
            this.TCCharacterSheetLevel3.SuspendLayout();
            this.TPCharacterSheetLevel3Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel3Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel3Cards.SuspendLayout();
            this.TPCharacterSheetLevel4.SuspendLayout();
            this.TCCharacterSheetLevel4.SuspendLayout();
            this.TPCharacterSheetLevel4Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel4Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel4Cards.SuspendLayout();
            this.TPCharacterSheetLevel5.SuspendLayout();
            this.TCCharacterSheetLevel5.SuspendLayout();
            this.TPCharacterSheetLevel5Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel5Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel5Cards.SuspendLayout();
            this.TPCharacterSheetLevel6.SuspendLayout();
            this.TCCharacterSheetLevel6.SuspendLayout();
            this.TPCharacterSheetLevel6Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel6Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel6Cards.SuspendLayout();
            this.TPCharacterSheetLevel7.SuspendLayout();
            this.TCCharacterSheetLevel7.SuspendLayout();
            this.TPCharacterSheetLevel7Miscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7WaspsDestroyed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7NumSkinsPurchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7NumCarsPurchased)).BeginInit();
            this.TPCharacterSheetLevel7Missions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7BestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7NumAttempts)).BeginInit();
            this.TPCharacterSheetLevel7Cards.SuspendLayout();
            this.TPCharacterSheetCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCounter)).BeginInit();
            this.GBCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaxHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCurrentHealth)).BeginInit();
            this.TPSoundSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBDialogVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSFXVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMusicVolume)).BeginInit();
            this.TPSuperCamCentral.SuspendLayout();
            this.GBSuperCamCentral4.SuspendLayout();
            this.GBSuperCamCentral3.SuspendLayout();
            this.GBSuperCamCentral2.SuspendLayout();
            this.GBSuperCamCentral1.SuspendLayout();
            this.TPTutorialManager.SuspendLayout();
            this.TPGUISystem.SuspendLayout();
            this.TPCardGallery.SuspendLayout();
            this.TPCustomSaveData.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFile});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(784, 24);
            this.MSMain.TabIndex = 0;
            this.MSMain.Text = "MSMain";
            // 
            // TSMIFile
            // 
            this.TSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMINew,
            this.TSMIOpen,
            this.TSMISave,
            this.TSMISaveAs,
            this.TSS1,
            this.TSMIExit});
            this.TSMIFile.Name = "TSMIFile";
            this.TSMIFile.Size = new System.Drawing.Size(37, 20);
            this.TSMIFile.Text = "File";
            // 
            // TSMINew
            // 
            this.TSMINew.Image = global::SHARSaveGameEditor.Properties.Resources.NewFile_16x;
            this.TSMINew.Name = "TSMINew";
            this.TSMINew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMINew.Size = new System.Drawing.Size(195, 22);
            this.TSMINew.Text = "New";
            this.TSMINew.Click += new System.EventHandler(this.TSMINew_Click);
            // 
            // TSMIOpen
            // 
            this.TSMIOpen.Image = global::SHARSaveGameEditor.Properties.Resources.OpenFile_16x;
            this.TSMIOpen.Name = "TSMIOpen";
            this.TSMIOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMIOpen.Size = new System.Drawing.Size(195, 22);
            this.TSMIOpen.Text = "Open";
            this.TSMIOpen.Click += new System.EventHandler(this.TSMIOpen_Click);
            // 
            // TSMISave
            // 
            this.TSMISave.Image = global::SHARSaveGameEditor.Properties.Resources.Save_16x;
            this.TSMISave.Name = "TSMISave";
            this.TSMISave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMISave.Size = new System.Drawing.Size(195, 22);
            this.TSMISave.Text = "Save";
            this.TSMISave.Click += new System.EventHandler(this.TSMISave_Click);
            // 
            // TSMISaveAs
            // 
            this.TSMISaveAs.Image = global::SHARSaveGameEditor.Properties.Resources.SaveAs_16x;
            this.TSMISaveAs.Name = "TSMISaveAs";
            this.TSMISaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMISaveAs.Size = new System.Drawing.Size(195, 22);
            this.TSMISaveAs.Text = "Save As...";
            this.TSMISaveAs.Click += new System.EventHandler(this.TSMISaveAs_Click);
            // 
            // TSS1
            // 
            this.TSS1.Name = "TSS1";
            this.TSS1.Size = new System.Drawing.Size(192, 6);
            // 
            // TSMIExit
            // 
            this.TSMIExit.Image = global::SHARSaveGameEditor.Properties.Resources.Exit_16x;
            this.TSMIExit.Name = "TSMIExit";
            this.TSMIExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMIExit.Size = new System.Drawing.Size(195, 22);
            this.TSMIExit.Text = "Exit";
            this.TSMIExit.Click += new System.EventHandler(this.TSMIExit_Click);
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.TPSaveGameInfo);
            this.TCMain.Controls.Add(this.TPInputManager);
            this.TCMain.Controls.Add(this.TPCharacterSheet);
            this.TCMain.Controls.Add(this.TPSoundSettings);
            this.TCMain.Controls.Add(this.TPSuperCamCentral);
            this.TCMain.Controls.Add(this.TPTutorialManager);
            this.TCMain.Controls.Add(this.TPGUISystem);
            this.TCMain.Controls.Add(this.TPCardGallery);
            this.TCMain.Controls.Add(this.TPCustomSaveData);
            this.TCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMain.Location = new System.Drawing.Point(0, 24);
            this.TCMain.Multiline = true;
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.Size = new System.Drawing.Size(784, 437);
            this.TCMain.TabIndex = 1;
            // 
            // TPSaveGameInfo
            // 
            this.TPSaveGameInfo.Controls.Add(this.NUDSaveSecond);
            this.TPSaveGameInfo.Controls.Add(this.label2);
            this.TPSaveGameInfo.Controls.Add(this.NUDSaveMinute);
            this.TPSaveGameInfo.Controls.Add(this.label1);
            this.TPSaveGameInfo.Controls.Add(this.NUDSaveHour);
            this.TPSaveGameInfo.Controls.Add(this.LblSaveTime);
            this.TPSaveGameInfo.Controls.Add(this.NUDDisplayMission);
            this.TPSaveGameInfo.Controls.Add(this.LblDisplayMission);
            this.TPSaveGameInfo.Controls.Add(this.NUDDisplayLevel);
            this.TPSaveGameInfo.Controls.Add(this.LblDisplayLevel);
            this.TPSaveGameInfo.Controls.Add(this.CBAutoSaveDate);
            this.TPSaveGameInfo.Controls.Add(this.DTPSaveDate);
            this.TPSaveGameInfo.Controls.Add(this.LblSaveDate);
            this.TPSaveGameInfo.Location = new System.Drawing.Point(4, 22);
            this.TPSaveGameInfo.Name = "TPSaveGameInfo";
            this.TPSaveGameInfo.Size = new System.Drawing.Size(776, 411);
            this.TPSaveGameInfo.TabIndex = 0;
            this.TPSaveGameInfo.Text = "Save Game Info";
            this.TPSaveGameInfo.UseVisualStyleBackColor = true;
            // 
            // NUDSaveSecond
            // 
            this.NUDSaveSecond.Location = new System.Drawing.Point(114, 59);
            this.NUDSaveSecond.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDSaveSecond.Name = "NUDSaveSecond";
            this.NUDSaveSecond.Size = new System.Drawing.Size(38, 20);
            this.NUDSaveSecond.TabIndex = 12;
            this.TTSettingInfo.SetToolTip(this.NUDSaveSecond, resources.GetString("NUDSaveSecond.ToolTip"));
            this.NUDSaveSecond.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDSaveSecond.ValueChanged += new System.EventHandler(this.NUDSaveSecond_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = ":";
            this.TTSettingInfo.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // NUDSaveMinute
            // 
            this.NUDSaveMinute.Location = new System.Drawing.Point(64, 59);
            this.NUDSaveMinute.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDSaveMinute.Name = "NUDSaveMinute";
            this.NUDSaveMinute.Size = new System.Drawing.Size(38, 20);
            this.NUDSaveMinute.TabIndex = 10;
            this.TTSettingInfo.SetToolTip(this.NUDSaveMinute, resources.GetString("NUDSaveMinute.ToolTip"));
            this.NUDSaveMinute.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDSaveMinute.ValueChanged += new System.EventHandler(this.NUDSaveMinute_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            this.TTSettingInfo.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // NUDSaveHour
            // 
            this.NUDSaveHour.Location = new System.Drawing.Point(12, 59);
            this.NUDSaveHour.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDSaveHour.Name = "NUDSaveHour";
            this.NUDSaveHour.Size = new System.Drawing.Size(38, 20);
            this.NUDSaveHour.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDSaveHour, resources.GetString("NUDSaveHour.ToolTip"));
            this.NUDSaveHour.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDSaveHour.ValueChanged += new System.EventHandler(this.NUDSaveHour_ValueChanged);
            // 
            // LblSaveTime
            // 
            this.LblSaveTime.AutoSize = true;
            this.LblSaveTime.Location = new System.Drawing.Point(9, 43);
            this.LblSaveTime.Name = "LblSaveTime";
            this.LblSaveTime.Size = new System.Drawing.Size(61, 13);
            this.LblSaveTime.TabIndex = 7;
            this.LblSaveTime.Text = "Save Time:";
            this.TTSettingInfo.SetToolTip(this.LblSaveTime, resources.GetString("LblSaveTime.ToolTip"));
            // 
            // NUDDisplayMission
            // 
            this.NUDDisplayMission.Location = new System.Drawing.Point(12, 137);
            this.NUDDisplayMission.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDDisplayMission.Name = "NUDDisplayMission";
            this.NUDDisplayMission.Size = new System.Drawing.Size(275, 20);
            this.NUDDisplayMission.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.NUDDisplayMission, resources.GetString("NUDDisplayMission.ToolTip"));
            this.NUDDisplayMission.ValueChanged += new System.EventHandler(this.NUDDisplayMission_ValueChanged);
            // 
            // LblDisplayMission
            // 
            this.LblDisplayMission.AutoSize = true;
            this.LblDisplayMission.Location = new System.Drawing.Point(9, 121);
            this.LblDisplayMission.Name = "LblDisplayMission";
            this.LblDisplayMission.Size = new System.Drawing.Size(82, 13);
            this.LblDisplayMission.TabIndex = 5;
            this.LblDisplayMission.Text = "Display Mission:";
            this.TTSettingInfo.SetToolTip(this.LblDisplayMission, resources.GetString("LblDisplayMission.ToolTip"));
            // 
            // NUDDisplayLevel
            // 
            this.NUDDisplayLevel.Location = new System.Drawing.Point(12, 98);
            this.NUDDisplayLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDDisplayLevel.Name = "NUDDisplayLevel";
            this.NUDDisplayLevel.Size = new System.Drawing.Size(275, 20);
            this.NUDDisplayLevel.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.NUDDisplayLevel, resources.GetString("NUDDisplayLevel.ToolTip"));
            this.NUDDisplayLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDDisplayLevel.ValueChanged += new System.EventHandler(this.NUDDisplayLevel_ValueChanged);
            // 
            // LblDisplayLevel
            // 
            this.LblDisplayLevel.AutoSize = true;
            this.LblDisplayLevel.Location = new System.Drawing.Point(9, 82);
            this.LblDisplayLevel.Name = "LblDisplayLevel";
            this.LblDisplayLevel.Size = new System.Drawing.Size(73, 13);
            this.LblDisplayLevel.TabIndex = 3;
            this.LblDisplayLevel.Text = "Display Level:";
            this.TTSettingInfo.SetToolTip(this.LblDisplayLevel, resources.GetString("LblDisplayLevel.ToolTip"));
            // 
            // CBAutoSaveDate
            // 
            this.CBAutoSaveDate.AutoSize = true;
            this.CBAutoSaveDate.Location = new System.Drawing.Point(76, 3);
            this.CBAutoSaveDate.Name = "CBAutoSaveDate";
            this.CBAutoSaveDate.Size = new System.Drawing.Size(84, 17);
            this.CBAutoSaveDate.TabIndex = 2;
            this.CBAutoSaveDate.Text = "Auto update";
            this.TTSettingInfo.SetToolTip(this.CBAutoSaveDate, "The last saved date of the file. Displays in the Load Game and Save Game screens." +
        "\r\nIf \"Auto update\" is checked, this will auto update to the current time on save" +
        ".");
            this.CBAutoSaveDate.UseVisualStyleBackColor = true;
            this.CBAutoSaveDate.CheckedChanged += new System.EventHandler(this.CBAutoSaveDate_CheckedChanged);
            // 
            // DTPSaveDate
            // 
            this.DTPSaveDate.CustomFormat = "dd MMM yyyy - HH:mm:ss";
            this.DTPSaveDate.Location = new System.Drawing.Point(12, 20);
            this.DTPSaveDate.Name = "DTPSaveDate";
            this.DTPSaveDate.Size = new System.Drawing.Size(275, 20);
            this.DTPSaveDate.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.DTPSaveDate, "The last saved date of the file. Displays in the Load Game and Save Game screens." +
        "\r\nIf \"Auto update\" is checked, this will auto update to the current time on save" +
        ".");
            this.DTPSaveDate.ValueChanged += new System.EventHandler(this.DTPSaveDate_ValueChanged);
            // 
            // LblSaveDate
            // 
            this.LblSaveDate.AutoSize = true;
            this.LblSaveDate.Location = new System.Drawing.Point(9, 4);
            this.LblSaveDate.Name = "LblSaveDate";
            this.LblSaveDate.Size = new System.Drawing.Size(61, 13);
            this.LblSaveDate.TabIndex = 0;
            this.LblSaveDate.Text = "Save Date:";
            this.TTSettingInfo.SetToolTip(this.LblSaveDate, "The last saved date of the file. Displays in the Load Game and Save Game screens." +
        "\r\nIf \"Auto update\" is checked, this will auto update to the current time on save" +
        ".");
            // 
            // TPInputManager
            // 
            this.TPInputManager.Controls.Add(this.CBIsRumbleEnabled);
            this.TPInputManager.Location = new System.Drawing.Point(4, 22);
            this.TPInputManager.Name = "TPInputManager";
            this.TPInputManager.Size = new System.Drawing.Size(776, 411);
            this.TPInputManager.TabIndex = 2;
            this.TPInputManager.Text = "Input Manager";
            this.TPInputManager.UseVisualStyleBackColor = true;
            // 
            // CBIsRumbleEnabled
            // 
            this.CBIsRumbleEnabled.AutoSize = true;
            this.CBIsRumbleEnabled.Location = new System.Drawing.Point(12, 3);
            this.CBIsRumbleEnabled.Name = "CBIsRumbleEnabled";
            this.CBIsRumbleEnabled.Size = new System.Drawing.Size(115, 17);
            this.CBIsRumbleEnabled.TabIndex = 0;
            this.CBIsRumbleEnabled.Text = "Is Rumble Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsRumbleEnabled, "If controller rumble is enabled.");
            this.CBIsRumbleEnabled.UseVisualStyleBackColor = true;
            this.CBIsRumbleEnabled.CheckedChanged += new System.EventHandler(this.CBIsRumbleEnabled_CheckedChanged);
            // 
            // TPCharacterSheet
            // 
            this.TPCharacterSheet.Controls.Add(this.TCCharacterSheet);
            this.TPCharacterSheet.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheet.Name = "TPCharacterSheet";
            this.TPCharacterSheet.Size = new System.Drawing.Size(776, 411);
            this.TPCharacterSheet.TabIndex = 1;
            this.TPCharacterSheet.Text = "Character Sheet";
            this.TPCharacterSheet.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheet
            // 
            this.TCCharacterSheet.Controls.Add(this.TPCharacterSheetMiscellaneous);
            this.TCCharacterSheet.Controls.Add(this.TPCharacterSheetLevels);
            this.TCCharacterSheet.Controls.Add(this.TPCharacterSheetCars);
            this.TCCharacterSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheet.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheet.Name = "TCCharacterSheet";
            this.TCCharacterSheet.SelectedIndex = 0;
            this.TCCharacterSheet.Size = new System.Drawing.Size(776, 411);
            this.TCCharacterSheet.TabIndex = 0;
            // 
            // TPCharacterSheetMiscellaneous
            // 
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CLBPersistentObjectStates);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.LblPersistentObjectStates);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBItchyScratchyTicket);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBItchyScratchyCBGFirst);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.NUDCoins);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.LblCoins);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBIsNavSystemEnabled);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBHighestMissionInfoMission);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBHighestMissionInfoLevel);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.LblHighestMissionInfo);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBCurrentMissionInfoMission);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.CBCurrentMissionInfoLevel);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.LblCurrentMissionInfo);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.TxtPlayerName);
            this.TPCharacterSheetMiscellaneous.Controls.Add(this.LblPlayerName);
            this.TPCharacterSheetMiscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetMiscellaneous.Name = "TPCharacterSheetMiscellaneous";
            this.TPCharacterSheetMiscellaneous.Size = new System.Drawing.Size(768, 385);
            this.TPCharacterSheetMiscellaneous.TabIndex = 0;
            this.TPCharacterSheetMiscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetMiscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBPersistentObjectStates
            // 
            this.CLBPersistentObjectStates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBPersistentObjectStates.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBPersistentObjectStates.FormattingEnabled = true;
            this.CLBPersistentObjectStates.Location = new System.Drawing.Point(12, 247);
            this.CLBPersistentObjectStates.Name = "CLBPersistentObjectStates";
            this.CLBPersistentObjectStates.Size = new System.Drawing.Size(550, 124);
            this.CLBPersistentObjectStates.TabIndex = 18;
            this.TTSettingInfo.SetToolTip(this.CLBPersistentObjectStates, "Breaksable objects, world coins and wasps.\r\nNames in brackets are the vanilla gam" +
        "e objects.");
            this.CLBPersistentObjectStates.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBPersistentObjectStates_ItemCheck);
            // 
            // CMSCheckedListBox
            // 
            this.CMSCheckedListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMISelectAll,
            this.TSMIDeselectAll});
            this.CMSCheckedListBox.Name = "CMSPersistentObjectStates";
            this.CMSCheckedListBox.Size = new System.Drawing.Size(136, 48);
            // 
            // TSMISelectAll
            // 
            this.TSMISelectAll.Name = "TSMISelectAll";
            this.TSMISelectAll.Size = new System.Drawing.Size(135, 22);
            this.TSMISelectAll.Text = "Select All";
            this.TSMISelectAll.Click += new System.EventHandler(this.TSMISelectAll_Click);
            // 
            // TSMIDeselectAll
            // 
            this.TSMIDeselectAll.Name = "TSMIDeselectAll";
            this.TSMIDeselectAll.Size = new System.Drawing.Size(135, 22);
            this.TSMIDeselectAll.Text = "Deselect All";
            this.TSMIDeselectAll.Click += new System.EventHandler(this.TSMIDeselectAll_Click);
            // 
            // LblPersistentObjectStates
            // 
            this.LblPersistentObjectStates.AutoSize = true;
            this.LblPersistentObjectStates.Location = new System.Drawing.Point(9, 231);
            this.LblPersistentObjectStates.Name = "LblPersistentObjectStates";
            this.LblPersistentObjectStates.Size = new System.Drawing.Size(123, 13);
            this.LblPersistentObjectStates.TabIndex = 17;
            this.LblPersistentObjectStates.Text = "Persistent Object States:";
            this.TTSettingInfo.SetToolTip(this.LblPersistentObjectStates, "Breaksable objects, world coins and wasps.\r\nNames in brackets are the vanilla gam" +
        "e objects.");
            // 
            // CBItchyScratchyTicket
            // 
            this.CBItchyScratchyTicket.AutoSize = true;
            this.CBItchyScratchyTicket.Location = new System.Drawing.Point(12, 211);
            this.CBItchyScratchyTicket.Name = "CBItchyScratchyTicket";
            this.CBItchyScratchyTicket.Size = new System.Drawing.Size(127, 17);
            this.CBItchyScratchyTicket.TabIndex = 13;
            this.CBItchyScratchyTicket.Text = "Itchy Scratchy Ticket";
            this.TTSettingInfo.SetToolTip(this.CBItchyScratchyTicket, "Related to Comic Book Guy to get the movie ticket after collecting all cards.");
            this.CBItchyScratchyTicket.UseVisualStyleBackColor = true;
            this.CBItchyScratchyTicket.CheckedChanged += new System.EventHandler(this.CBItchyScratchyTicket_CheckedChanged);
            // 
            // CBItchyScratchyCBGFirst
            // 
            this.CBItchyScratchyCBGFirst.AutoSize = true;
            this.CBItchyScratchyCBGFirst.Location = new System.Drawing.Point(12, 188);
            this.CBItchyScratchyCBGFirst.Name = "CBItchyScratchyCBGFirst";
            this.CBItchyScratchyCBGFirst.Size = new System.Drawing.Size(141, 17);
            this.CBItchyScratchyCBGFirst.TabIndex = 12;
            this.CBItchyScratchyCBGFirst.Text = "Itchy Scratchy CBG First";
            this.TTSettingInfo.SetToolTip(this.CBItchyScratchyCBGFirst, "Related to Comic Book Guy to get the movie ticket after collecting all cards.");
            this.CBItchyScratchyCBGFirst.UseVisualStyleBackColor = true;
            this.CBItchyScratchyCBGFirst.CheckedChanged += new System.EventHandler(this.CBItchyScratchyCBGFirst_CheckedChanged);
            // 
            // NUDCoins
            // 
            this.NUDCoins.Location = new System.Drawing.Point(12, 162);
            this.NUDCoins.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDCoins.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDCoins.Name = "NUDCoins";
            this.NUDCoins.Size = new System.Drawing.Size(275, 20);
            this.NUDCoins.TabIndex = 11;
            this.NUDCoins.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDCoins, "The number of coins the character currently has.");
            this.NUDCoins.ValueChanged += new System.EventHandler(this.NUDCoins_ValueChanged);
            // 
            // LblCoins
            // 
            this.LblCoins.AutoSize = true;
            this.LblCoins.Location = new System.Drawing.Point(9, 146);
            this.LblCoins.Name = "LblCoins";
            this.LblCoins.Size = new System.Drawing.Size(36, 13);
            this.LblCoins.TabIndex = 10;
            this.LblCoins.Text = "Coins:";
            this.TTSettingInfo.SetToolTip(this.LblCoins, "The number of coins the character currently has.");
            // 
            // CBIsNavSystemEnabled
            // 
            this.CBIsNavSystemEnabled.AutoSize = true;
            this.CBIsNavSystemEnabled.Location = new System.Drawing.Point(12, 126);
            this.CBIsNavSystemEnabled.Name = "CBIsNavSystemEnabled";
            this.CBIsNavSystemEnabled.Size = new System.Drawing.Size(136, 17);
            this.CBIsNavSystemEnabled.TabIndex = 9;
            this.CBIsNavSystemEnabled.Text = "Is Nav System Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsNavSystemEnabled, "Enables/Disables navigation road arrows.");
            this.CBIsNavSystemEnabled.UseVisualStyleBackColor = true;
            this.CBIsNavSystemEnabled.CheckedChanged += new System.EventHandler(this.CBIsNavSystemEnabled_CheckedChanged);
            // 
            // CBHighestMissionInfoMission
            // 
            this.CBHighestMissionInfoMission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBHighestMissionInfoMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBHighestMissionInfoMission.FormattingEnabled = true;
            this.CBHighestMissionInfoMission.Location = new System.Drawing.Point(155, 99);
            this.CBHighestMissionInfoMission.Name = "CBHighestMissionInfoMission";
            this.CBHighestMissionInfoMission.Size = new System.Drawing.Size(132, 21);
            this.CBHighestMissionInfoMission.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.CBHighestMissionInfoMission, "The last unlocked mission. All missions up to and including this one will be avai" +
        "lable for mission warping.");
            this.CBHighestMissionInfoMission.SelectedIndexChanged += new System.EventHandler(this.CBHighestMissionInfoMission_SelectedIndexChanged);
            // 
            // CBHighestMissionInfoLevel
            // 
            this.CBHighestMissionInfoLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBHighestMissionInfoLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBHighestMissionInfoLevel.FormattingEnabled = true;
            this.CBHighestMissionInfoLevel.Location = new System.Drawing.Point(12, 99);
            this.CBHighestMissionInfoLevel.Name = "CBHighestMissionInfoLevel";
            this.CBHighestMissionInfoLevel.Size = new System.Drawing.Size(132, 21);
            this.CBHighestMissionInfoLevel.TabIndex = 7;
            this.TTSettingInfo.SetToolTip(this.CBHighestMissionInfoLevel, "The last unlocked mission. All missions up to and including this one will be avai" +
        "lable for mission warping.");
            this.CBHighestMissionInfoLevel.SelectedIndexChanged += new System.EventHandler(this.CBHighestMissionInfoLevel_SelectedIndexChanged);
            // 
            // LblHighestMissionInfo
            // 
            this.LblHighestMissionInfo.AutoSize = true;
            this.LblHighestMissionInfo.Location = new System.Drawing.Point(9, 83);
            this.LblHighestMissionInfo.Name = "LblHighestMissionInfo";
            this.LblHighestMissionInfo.Size = new System.Drawing.Size(105, 13);
            this.LblHighestMissionInfo.TabIndex = 6;
            this.LblHighestMissionInfo.Text = "Highest Mission Info:";
            this.TTSettingInfo.SetToolTip(this.LblHighestMissionInfo, "The last unlocked mission. All missions up to and including this one will be avai" +
        "lable for mission warping.");
            // 
            // CBCurrentMissionInfoMission
            // 
            this.CBCurrentMissionInfoMission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBCurrentMissionInfoMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurrentMissionInfoMission.FormattingEnabled = true;
            this.CBCurrentMissionInfoMission.Location = new System.Drawing.Point(155, 59);
            this.CBCurrentMissionInfoMission.Name = "CBCurrentMissionInfoMission";
            this.CBCurrentMissionInfoMission.Size = new System.Drawing.Size(132, 21);
            this.CBCurrentMissionInfoMission.TabIndex = 5;
            this.TTSettingInfo.SetToolTip(this.CBCurrentMissionInfoMission, "The mission to launch on \"Resume Game\".");
            this.CBCurrentMissionInfoMission.SelectedIndexChanged += new System.EventHandler(this.CBCurrentMissionInfoMission_SelectedIndexChanged);
            // 
            // CBCurrentMissionInfoLevel
            // 
            this.CBCurrentMissionInfoLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBCurrentMissionInfoLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurrentMissionInfoLevel.FormattingEnabled = true;
            this.CBCurrentMissionInfoLevel.Location = new System.Drawing.Point(12, 59);
            this.CBCurrentMissionInfoLevel.Name = "CBCurrentMissionInfoLevel";
            this.CBCurrentMissionInfoLevel.Size = new System.Drawing.Size(132, 21);
            this.CBCurrentMissionInfoLevel.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.CBCurrentMissionInfoLevel, "The mission to launch on \"Resume Game\".");
            this.CBCurrentMissionInfoLevel.SelectedIndexChanged += new System.EventHandler(this.CBCurrentMissionInfoLevel_SelectedIndexChanged);
            // 
            // LblCurrentMissionInfo
            // 
            this.LblCurrentMissionInfo.AutoSize = true;
            this.LblCurrentMissionInfo.Location = new System.Drawing.Point(9, 43);
            this.LblCurrentMissionInfo.Name = "LblCurrentMissionInfo";
            this.LblCurrentMissionInfo.Size = new System.Drawing.Size(103, 13);
            this.LblCurrentMissionInfo.TabIndex = 3;
            this.LblCurrentMissionInfo.Text = "Current Mission Info:";
            this.TTSettingInfo.SetToolTip(this.LblCurrentMissionInfo, "The mission to launch on \"Resume Game\".");
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.Location = new System.Drawing.Point(12, 20);
            this.TxtPlayerName.MaxLength = 16;
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(275, 20);
            this.TxtPlayerName.TabIndex = 2;
            this.TTSettingInfo.SetToolTip(this.TxtPlayerName, "Entirely useless, game always set it to \"Player 1\".\r\nProbably a relic from when t" +
        "he game supported split screen in story mode.");
            this.TxtPlayerName.TextChanged += new System.EventHandler(this.TxtPlayerName_TextChanged);
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Location = new System.Drawing.Point(9, 4);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.LblPlayerName.TabIndex = 1;
            this.LblPlayerName.Text = "Player Name:";
            this.TTSettingInfo.SetToolTip(this.LblPlayerName, "Entirely useless, game always set it to \"Player 1\".\r\nProbably a relic from when t" +
        "he game supported split screen in story mode.");
            // 
            // TPCharacterSheetLevels
            // 
            this.TPCharacterSheetLevels.Controls.Add(this.TCCharacterSheetLevels);
            this.TPCharacterSheetLevels.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevels.Name = "TPCharacterSheetLevels";
            this.TPCharacterSheetLevels.Size = new System.Drawing.Size(768, 385);
            this.TPCharacterSheetLevels.TabIndex = 1;
            this.TPCharacterSheetLevels.Text = "Levels";
            this.TPCharacterSheetLevels.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevels
            // 
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel1);
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel2);
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel3);
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel4);
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel5);
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel6);
            this.TCCharacterSheetLevels.Controls.Add(this.TPCharacterSheetLevel7);
            this.TCCharacterSheetLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevels.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevels.Name = "TCCharacterSheetLevels";
            this.TCCharacterSheetLevels.SelectedIndex = 0;
            this.TCCharacterSheetLevels.Size = new System.Drawing.Size(768, 385);
            this.TCCharacterSheetLevels.TabIndex = 0;
            // 
            // TPCharacterSheetLevel1
            // 
            this.TPCharacterSheetLevel1.Controls.Add(this.TCCharacterSheetLevel1);
            this.TPCharacterSheetLevel1.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel1.Name = "TPCharacterSheetLevel1";
            this.TPCharacterSheetLevel1.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel1.TabIndex = 0;
            this.TPCharacterSheetLevel1.Text = "Level 1";
            this.TPCharacterSheetLevel1.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel1
            // 
            this.TCCharacterSheetLevel1.Controls.Add(this.TPCharacterSheetLevel1Miscellaneous);
            this.TCCharacterSheetLevel1.Controls.Add(this.TPCharacterSheetLevel1Missions);
            this.TCCharacterSheetLevel1.Controls.Add(this.TPCharacterSheetLevel1Cards);
            this.TCCharacterSheetLevel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel1.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel1.Name = "TCCharacterSheetLevel1";
            this.TCCharacterSheetLevel1.SelectedIndex = 0;
            this.TCCharacterSheetLevel1.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel1.TabIndex = 0;
            this.TCCharacterSheetLevel1.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel1_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel1Miscellaneous
            // 
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.CLBLevel1PurchasedRewards);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.LblLevel1PurchasedRewards);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.CLBLevel1Gags);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.LblLevel1Gags);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.CBLevel1CurrentSkin);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.LblLevel1CurrentSkin);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.NUDLevel1WaspsDestroyed);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.LblLevel1WaspsDestroyed);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.NUDLevel1NumSkinsPurchased);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.LblLevel1NumSkinsPurchased);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.NUDLevel1NumCarsPurchased);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.LblLevel1NumCarsPurchased);
            this.TPCharacterSheetLevel1Miscellaneous.Controls.Add(this.CBLevel1FMVUnlocked);
            this.TPCharacterSheetLevel1Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel1Miscellaneous.Name = "TPCharacterSheetLevel1Miscellaneous";
            this.TPCharacterSheetLevel1Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel1Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel1Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel1Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel1PurchasedRewards
            // 
            this.CLBLevel1PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel1PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel1PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel1PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel1PurchasedRewards.Name = "CLBLevel1PurchasedRewards";
            this.CLBLevel1PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel1PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel1PurchasedRewards, resources.GetString("CLBLevel1PurchasedRewards.ToolTip"));
            this.CLBLevel1PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel1PurchasedRewards_ItemCheck);
            // 
            // LblLevel1PurchasedRewards
            // 
            this.LblLevel1PurchasedRewards.AutoSize = true;
            this.LblLevel1PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel1PurchasedRewards.Name = "LblLevel1PurchasedRewards";
            this.LblLevel1PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel1PurchasedRewards.TabIndex = 24;
            this.LblLevel1PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1PurchasedRewards, resources.GetString("LblLevel1PurchasedRewards.ToolTip"));
            // 
            // CLBLevel1Gags
            // 
            this.CLBLevel1Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel1Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel1Gags.FormattingEnabled = true;
            this.CLBLevel1Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel1Gags.Name = "CLBLevel1Gags";
            this.CLBLevel1Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel1Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel1Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel1Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel1Gags_ItemCheck);
            // 
            // LblLevel1Gags
            // 
            this.LblLevel1Gags.AutoSize = true;
            this.LblLevel1Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel1Gags.Name = "LblLevel1Gags";
            this.LblLevel1Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel1Gags.TabIndex = 22;
            this.LblLevel1Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            // 
            // CBLevel1CurrentSkin
            // 
            this.CBLevel1CurrentSkin.FormattingEnabled = true;
            this.CBLevel1CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel1CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel1CurrentSkin.MaxLength = 16;
            this.CBLevel1CurrentSkin.Name = "CBLevel1CurrentSkin";
            this.CBLevel1CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel1CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel1CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel1CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel1CurrentSkin_TextChanged);
            // 
            // LblLevel1CurrentSkin
            // 
            this.LblLevel1CurrentSkin.AutoSize = true;
            this.LblLevel1CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel1CurrentSkin.Name = "LblLevel1CurrentSkin";
            this.LblLevel1CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel1CurrentSkin.TabIndex = 20;
            this.LblLevel1CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel1WaspsDestroyed
            // 
            this.NUDLevel1WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel1WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel1WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel1WaspsDestroyed.Name = "NUDLevel1WaspsDestroyed";
            this.NUDLevel1WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel1WaspsDestroyed.TabIndex = 17;
            this.NUDLevel1WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel1WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel1WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel1WaspsDestroyed_ValueChanged);
            // 
            // LblLevel1WaspsDestroyed
            // 
            this.LblLevel1WaspsDestroyed.AutoSize = true;
            this.LblLevel1WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel1WaspsDestroyed.Name = "LblLevel1WaspsDestroyed";
            this.LblLevel1WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel1WaspsDestroyed.TabIndex = 16;
            this.LblLevel1WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel1NumSkinsPurchased
            // 
            this.NUDLevel1NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel1NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel1NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel1NumSkinsPurchased.Name = "NUDLevel1NumSkinsPurchased";
            this.NUDLevel1NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel1NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel1NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel1NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel1NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel1NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel1NumSkinsPurchased
            // 
            this.LblLevel1NumSkinsPurchased.AutoSize = true;
            this.LblLevel1NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel1NumSkinsPurchased.Name = "LblLevel1NumSkinsPurchased";
            this.LblLevel1NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel1NumSkinsPurchased.TabIndex = 14;
            this.LblLevel1NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel1NumCarsPurchased
            // 
            this.NUDLevel1NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel1NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel1NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel1NumCarsPurchased.Name = "NUDLevel1NumCarsPurchased";
            this.NUDLevel1NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel1NumCarsPurchased.TabIndex = 13;
            this.NUDLevel1NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel1NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel1NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel1NumCarsPurchased_ValueChanged);
            // 
            // LblLevel1NumCarsPurchased
            // 
            this.LblLevel1NumCarsPurchased.AutoSize = true;
            this.LblLevel1NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel1NumCarsPurchased.Name = "LblLevel1NumCarsPurchased";
            this.LblLevel1NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel1NumCarsPurchased.TabIndex = 12;
            this.LblLevel1NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel1FMVUnlocked
            // 
            this.CBLevel1FMVUnlocked.AutoSize = true;
            this.CBLevel1FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel1FMVUnlocked.Name = "CBLevel1FMVUnlocked";
            this.CBLevel1FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel1FMVUnlocked.TabIndex = 2;
            this.CBLevel1FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel1FMVUnlocked, "If the level\'s video has been watched. If checked, you\'re able to skip the video " +
        "playback in the level.");
            this.CBLevel1FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel1FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel1FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel1Missions
            // 
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.NUDLevel1BestTime);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.LblLevel1BestTime);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.CBLevel1SkippedMission);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.NUDLevel1NumAttempts);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.LblLevel1NumAttempts);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.CBLevel1BonusObjective);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.CBLevel1Completed);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.TxtLevel1MissionName);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.LblLevel1MissionName);
            this.TPCharacterSheetLevel1Missions.Controls.Add(this.LBLevel1Missions);
            this.TPCharacterSheetLevel1Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel1Missions.Name = "TPCharacterSheetLevel1Missions";
            this.TPCharacterSheetLevel1Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel1Missions.TabIndex = 1;
            this.TPCharacterSheetLevel1Missions.Text = "Missions";
            this.TPCharacterSheetLevel1Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel1BestTime
            // 
            this.NUDLevel1BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel1BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel1BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel1BestTime.Name = "NUDLevel1BestTime";
            this.NUDLevel1BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel1BestTime.TabIndex = 17;
            this.NUDLevel1BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel1BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel1BestTime.ValueChanged += new System.EventHandler(this.NUDLevel1BestTime_ValueChanged);
            // 
            // LblLevel1BestTime
            // 
            this.LblLevel1BestTime.AutoSize = true;
            this.LblLevel1BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel1BestTime.Name = "LblLevel1BestTime";
            this.LblLevel1BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel1BestTime.TabIndex = 16;
            this.LblLevel1BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel1SkippedMission
            // 
            this.CBLevel1SkippedMission.AutoSize = true;
            this.CBLevel1SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel1SkippedMission.Name = "CBLevel1SkippedMission";
            this.CBLevel1SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel1SkippedMission.TabIndex = 9;
            this.CBLevel1SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel1SkippedMission, "If the mission was skipped.");
            this.CBLevel1SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel1SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel1SkippedMission_CheckedChanged);
            // 
            // NUDLevel1NumAttempts
            // 
            this.NUDLevel1NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel1NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel1NumAttempts.Name = "NUDLevel1NumAttempts";
            this.NUDLevel1NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel1NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel1NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel1NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel1NumAttempts_ValueChanged);
            // 
            // LblLevel1NumAttempts
            // 
            this.LblLevel1NumAttempts.AutoSize = true;
            this.LblLevel1NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel1NumAttempts.Name = "LblLevel1NumAttempts";
            this.LblLevel1NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel1NumAttempts.TabIndex = 7;
            this.LblLevel1NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel1BonusObjective
            // 
            this.CBLevel1BonusObjective.AutoSize = true;
            this.CBLevel1BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel1BonusObjective.Name = "CBLevel1BonusObjective";
            this.CBLevel1BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel1BonusObjective.TabIndex = 6;
            this.CBLevel1BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel1BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel1BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel1BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel1BonusObjective_CheckedChanged);
            // 
            // CBLevel1Completed
            // 
            this.CBLevel1Completed.AutoSize = true;
            this.CBLevel1Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel1Completed.Name = "CBLevel1Completed";
            this.CBLevel1Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel1Completed.TabIndex = 5;
            this.CBLevel1Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel1Completed, "If the mission has been completed.");
            this.CBLevel1Completed.UseVisualStyleBackColor = true;
            this.CBLevel1Completed.CheckedChanged += new System.EventHandler(this.CBLevel1Completed_CheckedChanged);
            // 
            // TxtLevel1MissionName
            // 
            this.TxtLevel1MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel1MissionName.MaxLength = 16;
            this.TxtLevel1MissionName.Name = "TxtLevel1MissionName";
            this.TxtLevel1MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel1MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel1MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel1MissionName.TextChanged += new System.EventHandler(this.TxtLevel1MissionName_TextChanged);
            // 
            // LblLevel1MissionName
            // 
            this.LblLevel1MissionName.AutoSize = true;
            this.LblLevel1MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel1MissionName.Name = "LblLevel1MissionName";
            this.LblLevel1MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel1MissionName.TabIndex = 3;
            this.LblLevel1MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel1Missions
            // 
            this.LBLevel1Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel1Missions.FormattingEnabled = true;
            this.LBLevel1Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel1Missions.Name = "LBLevel1Missions";
            this.LBLevel1Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel1Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel1Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel1Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel1Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel1Cards
            // 
            this.TPCharacterSheetLevel1Cards.Controls.Add(this.CBLevel1CardCollected);
            this.TPCharacterSheetLevel1Cards.Controls.Add(this.TxtLevel1CardName);
            this.TPCharacterSheetLevel1Cards.Controls.Add(this.LblLevel1CardName);
            this.TPCharacterSheetLevel1Cards.Controls.Add(this.LBLevel1Cards);
            this.TPCharacterSheetLevel1Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel1Cards.Name = "TPCharacterSheetLevel1Cards";
            this.TPCharacterSheetLevel1Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel1Cards.TabIndex = 2;
            this.TPCharacterSheetLevel1Cards.Text = "Cards";
            this.TPCharacterSheetLevel1Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel1CardCollected
            // 
            this.CBLevel1CardCollected.AutoSize = true;
            this.CBLevel1CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel1CardCollected.Name = "CBLevel1CardCollected";
            this.CBLevel1CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel1CardCollected.TabIndex = 9;
            this.CBLevel1CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel1CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel1CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel1CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel1CardCollected_CheckedChanged);
            // 
            // TxtLevel1CardName
            // 
            this.TxtLevel1CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel1CardName.MaxLength = 16;
            this.TxtLevel1CardName.Name = "TxtLevel1CardName";
            this.TxtLevel1CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel1CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel1CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel1CardName.TextChanged += new System.EventHandler(this.TxtLevel1CardName_TextChanged);
            // 
            // LblLevel1CardName
            // 
            this.LblLevel1CardName.AutoSize = true;
            this.LblLevel1CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel1CardName.Name = "LblLevel1CardName";
            this.LblLevel1CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel1CardName.TabIndex = 7;
            this.LblLevel1CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel1CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel1Cards
            // 
            this.LBLevel1Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel1Cards.FormattingEnabled = true;
            this.LBLevel1Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel1Cards.Name = "LBLevel1Cards";
            this.LBLevel1Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel1Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel1Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel1Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel1Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel2
            // 
            this.TPCharacterSheetLevel2.Controls.Add(this.TCCharacterSheetLevel2);
            this.TPCharacterSheetLevel2.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel2.Name = "TPCharacterSheetLevel2";
            this.TPCharacterSheetLevel2.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel2.TabIndex = 1;
            this.TPCharacterSheetLevel2.Text = "Level 2";
            this.TPCharacterSheetLevel2.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel2
            // 
            this.TCCharacterSheetLevel2.Controls.Add(this.TPCharacterSheetLevel2Miscellaneous);
            this.TCCharacterSheetLevel2.Controls.Add(this.TPCharacterSheetLevel2Missions);
            this.TCCharacterSheetLevel2.Controls.Add(this.TPCharacterSheetLevel2Cards);
            this.TCCharacterSheetLevel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel2.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel2.Name = "TCCharacterSheetLevel2";
            this.TCCharacterSheetLevel2.SelectedIndex = 0;
            this.TCCharacterSheetLevel2.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel2.TabIndex = 0;
            this.TCCharacterSheetLevel2.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel2_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel2Miscellaneous
            // 
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.CLBLevel2PurchasedRewards);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.LblLevel2PurchasedRewards);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.CLBLevel2Gags);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.LblLevel2Gags);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.CBLevel2CurrentSkin);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.LblLevel2CurrentSkin);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.NUDLevel2WaspsDestroyed);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.LblLevel2WaspsDestroyed);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.NUDLevel2NumSkinsPurchased);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.LblLevel2NumSkinsPurchased);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.NUDLevel2NumCarsPurchased);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.LblLevel2NumCarsPurchased);
            this.TPCharacterSheetLevel2Miscellaneous.Controls.Add(this.CBLevel2FMVUnlocked);
            this.TPCharacterSheetLevel2Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel2Miscellaneous.Name = "TPCharacterSheetLevel2Miscellaneous";
            this.TPCharacterSheetLevel2Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel2Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel2Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel2Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel2PurchasedRewards
            // 
            this.CLBLevel2PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel2PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel2PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel2PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel2PurchasedRewards.Name = "CLBLevel2PurchasedRewards";
            this.CLBLevel2PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel2PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel2PurchasedRewards, resources.GetString("CLBLevel2PurchasedRewards.ToolTip"));
            this.CLBLevel2PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel2PurchasedRewards_ItemCheck);
            // 
            // LblLevel2PurchasedRewards
            // 
            this.LblLevel2PurchasedRewards.AutoSize = true;
            this.LblLevel2PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel2PurchasedRewards.Name = "LblLevel2PurchasedRewards";
            this.LblLevel2PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel2PurchasedRewards.TabIndex = 24;
            this.LblLevel2PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2PurchasedRewards, resources.GetString("LblLevel2PurchasedRewards.ToolTip"));
            // 
            // CLBLevel2Gags
            // 
            this.CLBLevel2Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel2Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel2Gags.FormattingEnabled = true;
            this.CLBLevel2Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel2Gags.Name = "CLBLevel2Gags";
            this.CLBLevel2Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel2Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel2Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel2Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel2Gags_ItemCheck);
            // 
            // LblLevel2Gags
            // 
            this.LblLevel2Gags.AutoSize = true;
            this.LblLevel2Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel2Gags.Name = "LblLevel2Gags";
            this.LblLevel2Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel2Gags.TabIndex = 22;
            this.LblLevel2Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.\r\n");
            // 
            // CBLevel2CurrentSkin
            // 
            this.CBLevel2CurrentSkin.FormattingEnabled = true;
            this.CBLevel2CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel2CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel2CurrentSkin.MaxLength = 16;
            this.CBLevel2CurrentSkin.Name = "CBLevel2CurrentSkin";
            this.CBLevel2CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel2CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel2CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel2CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel2CurrentSkin_TextChanged);
            // 
            // LblLevel2CurrentSkin
            // 
            this.LblLevel2CurrentSkin.AutoSize = true;
            this.LblLevel2CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel2CurrentSkin.Name = "LblLevel2CurrentSkin";
            this.LblLevel2CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel2CurrentSkin.TabIndex = 20;
            this.LblLevel2CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel2WaspsDestroyed
            // 
            this.NUDLevel2WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel2WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel2WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel2WaspsDestroyed.Name = "NUDLevel2WaspsDestroyed";
            this.NUDLevel2WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel2WaspsDestroyed.TabIndex = 17;
            this.NUDLevel2WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel2WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel2WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel2WaspsDestroyed_ValueChanged);
            // 
            // LblLevel2WaspsDestroyed
            // 
            this.LblLevel2WaspsDestroyed.AutoSize = true;
            this.LblLevel2WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel2WaspsDestroyed.Name = "LblLevel2WaspsDestroyed";
            this.LblLevel2WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel2WaspsDestroyed.TabIndex = 16;
            this.LblLevel2WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel2NumSkinsPurchased
            // 
            this.NUDLevel2NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel2NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel2NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel2NumSkinsPurchased.Name = "NUDLevel2NumSkinsPurchased";
            this.NUDLevel2NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel2NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel2NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel2NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel2NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel2NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel2NumSkinsPurchased
            // 
            this.LblLevel2NumSkinsPurchased.AutoSize = true;
            this.LblLevel2NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel2NumSkinsPurchased.Name = "LblLevel2NumSkinsPurchased";
            this.LblLevel2NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel2NumSkinsPurchased.TabIndex = 14;
            this.LblLevel2NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel2NumCarsPurchased
            // 
            this.NUDLevel2NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel2NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel2NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel2NumCarsPurchased.Name = "NUDLevel2NumCarsPurchased";
            this.NUDLevel2NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel2NumCarsPurchased.TabIndex = 13;
            this.NUDLevel2NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel2NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel2NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel2NumCarsPurchased_ValueChanged);
            // 
            // LblLevel2NumCarsPurchased
            // 
            this.LblLevel2NumCarsPurchased.AutoSize = true;
            this.LblLevel2NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel2NumCarsPurchased.Name = "LblLevel2NumCarsPurchased";
            this.LblLevel2NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel2NumCarsPurchased.TabIndex = 12;
            this.LblLevel2NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel2FMVUnlocked
            // 
            this.CBLevel2FMVUnlocked.AutoSize = true;
            this.CBLevel2FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel2FMVUnlocked.Name = "CBLevel2FMVUnlocked";
            this.CBLevel2FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel2FMVUnlocked.TabIndex = 2;
            this.CBLevel2FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel2FMVUnlocked, "If the level\'s video has been watched. If checked, you\'re able to skip the video " +
        "playback in the level.");
            this.CBLevel2FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel2FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel2FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel2Missions
            // 
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.NUDLevel2BestTime);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.LblLevel2BestTime);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.CBLevel2SkippedMission);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.NUDLevel2NumAttempts);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.LblLevel2NumAttempts);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.CBLevel2BonusObjective);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.CBLevel2Completed);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.TxtLevel2MissionName);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.LblLevel2MissionName);
            this.TPCharacterSheetLevel2Missions.Controls.Add(this.LBLevel2Missions);
            this.TPCharacterSheetLevel2Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel2Missions.Name = "TPCharacterSheetLevel2Missions";
            this.TPCharacterSheetLevel2Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel2Missions.TabIndex = 1;
            this.TPCharacterSheetLevel2Missions.Text = "Missions";
            this.TPCharacterSheetLevel2Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel2BestTime
            // 
            this.NUDLevel2BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel2BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel2BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel2BestTime.Name = "NUDLevel2BestTime";
            this.NUDLevel2BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel2BestTime.TabIndex = 17;
            this.NUDLevel2BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel2BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel2BestTime.ValueChanged += new System.EventHandler(this.NUDLevel2BestTime_ValueChanged);
            // 
            // LblLevel2BestTime
            // 
            this.LblLevel2BestTime.AutoSize = true;
            this.LblLevel2BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel2BestTime.Name = "LblLevel2BestTime";
            this.LblLevel2BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel2BestTime.TabIndex = 16;
            this.LblLevel2BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel2SkippedMission
            // 
            this.CBLevel2SkippedMission.AutoSize = true;
            this.CBLevel2SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel2SkippedMission.Name = "CBLevel2SkippedMission";
            this.CBLevel2SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel2SkippedMission.TabIndex = 9;
            this.CBLevel2SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel2SkippedMission, "If the mission was skipped.");
            this.CBLevel2SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel2SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel2SkippedMission_CheckedChanged);
            // 
            // NUDLevel2NumAttempts
            // 
            this.NUDLevel2NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel2NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel2NumAttempts.Name = "NUDLevel2NumAttempts";
            this.NUDLevel2NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel2NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel2NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel2NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel2NumAttempts_ValueChanged);
            // 
            // LblLevel2NumAttempts
            // 
            this.LblLevel2NumAttempts.AutoSize = true;
            this.LblLevel2NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel2NumAttempts.Name = "LblLevel2NumAttempts";
            this.LblLevel2NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel2NumAttempts.TabIndex = 7;
            this.LblLevel2NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel2BonusObjective
            // 
            this.CBLevel2BonusObjective.AutoSize = true;
            this.CBLevel2BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel2BonusObjective.Name = "CBLevel2BonusObjective";
            this.CBLevel2BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel2BonusObjective.TabIndex = 6;
            this.CBLevel2BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel2BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel2BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel2BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel2BonusObjective_CheckedChanged);
            // 
            // CBLevel2Completed
            // 
            this.CBLevel2Completed.AutoSize = true;
            this.CBLevel2Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel2Completed.Name = "CBLevel2Completed";
            this.CBLevel2Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel2Completed.TabIndex = 5;
            this.CBLevel2Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel2Completed, "If the mission has been completed.");
            this.CBLevel2Completed.UseVisualStyleBackColor = true;
            this.CBLevel2Completed.CheckedChanged += new System.EventHandler(this.CBLevel2Completed_CheckedChanged);
            // 
            // TxtLevel2MissionName
            // 
            this.TxtLevel2MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel2MissionName.MaxLength = 16;
            this.TxtLevel2MissionName.Name = "TxtLevel2MissionName";
            this.TxtLevel2MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel2MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel2MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel2MissionName.TextChanged += new System.EventHandler(this.TxtLevel2MissionName_TextChanged);
            // 
            // LblLevel2MissionName
            // 
            this.LblLevel2MissionName.AutoSize = true;
            this.LblLevel2MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel2MissionName.Name = "LblLevel2MissionName";
            this.LblLevel2MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel2MissionName.TabIndex = 3;
            this.LblLevel2MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel2Missions
            // 
            this.LBLevel2Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel2Missions.FormattingEnabled = true;
            this.LBLevel2Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel2Missions.Name = "LBLevel2Missions";
            this.LBLevel2Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel2Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel2Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel2Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel2Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel2Cards
            // 
            this.TPCharacterSheetLevel2Cards.Controls.Add(this.CBLevel2CardCollected);
            this.TPCharacterSheetLevel2Cards.Controls.Add(this.TxtLevel2CardName);
            this.TPCharacterSheetLevel2Cards.Controls.Add(this.LblLevel2CardName);
            this.TPCharacterSheetLevel2Cards.Controls.Add(this.LBLevel2Cards);
            this.TPCharacterSheetLevel2Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel2Cards.Name = "TPCharacterSheetLevel2Cards";
            this.TPCharacterSheetLevel2Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel2Cards.TabIndex = 2;
            this.TPCharacterSheetLevel2Cards.Text = "Cards";
            this.TPCharacterSheetLevel2Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel2CardCollected
            // 
            this.CBLevel2CardCollected.AutoSize = true;
            this.CBLevel2CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel2CardCollected.Name = "CBLevel2CardCollected";
            this.CBLevel2CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel2CardCollected.TabIndex = 9;
            this.CBLevel2CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel2CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel2CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel2CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel2CardCollected_CheckedChanged);
            // 
            // TxtLevel2CardName
            // 
            this.TxtLevel2CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel2CardName.MaxLength = 16;
            this.TxtLevel2CardName.Name = "TxtLevel2CardName";
            this.TxtLevel2CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel2CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel2CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel2CardName.TextChanged += new System.EventHandler(this.TxtLevel2CardName_TextChanged);
            // 
            // LblLevel2CardName
            // 
            this.LblLevel2CardName.AutoSize = true;
            this.LblLevel2CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel2CardName.Name = "LblLevel2CardName";
            this.LblLevel2CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel2CardName.TabIndex = 7;
            this.LblLevel2CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel2CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel2Cards
            // 
            this.LBLevel2Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel2Cards.FormattingEnabled = true;
            this.LBLevel2Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel2Cards.Name = "LBLevel2Cards";
            this.LBLevel2Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel2Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel2Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel2Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel2Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel3
            // 
            this.TPCharacterSheetLevel3.Controls.Add(this.TCCharacterSheetLevel3);
            this.TPCharacterSheetLevel3.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel3.Name = "TPCharacterSheetLevel3";
            this.TPCharacterSheetLevel3.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel3.TabIndex = 2;
            this.TPCharacterSheetLevel3.Text = "Level 3";
            this.TPCharacterSheetLevel3.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel3
            // 
            this.TCCharacterSheetLevel3.Controls.Add(this.TPCharacterSheetLevel3Miscellaneous);
            this.TCCharacterSheetLevel3.Controls.Add(this.TPCharacterSheetLevel3Missions);
            this.TCCharacterSheetLevel3.Controls.Add(this.TPCharacterSheetLevel3Cards);
            this.TCCharacterSheetLevel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel3.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel3.Name = "TCCharacterSheetLevel3";
            this.TCCharacterSheetLevel3.SelectedIndex = 0;
            this.TCCharacterSheetLevel3.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel3.TabIndex = 0;
            this.TCCharacterSheetLevel3.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel3_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel3Miscellaneous
            // 
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.CLBLevel3PurchasedRewards);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.LblLevel3PurchasedRewards);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.CLBLevel3Gags);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.LblLevel3Gags);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.CBLevel3CurrentSkin);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.LblLevel3CurrentSkin);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.NUDLevel3WaspsDestroyed);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.LblLevel3WaspsDestroyed);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.NUDLevel3NumSkinsPurchased);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.LblLevel3NumSkinsPurchased);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.NUDLevel3NumCarsPurchased);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.LblLevel3NumCarsPurchased);
            this.TPCharacterSheetLevel3Miscellaneous.Controls.Add(this.CBLevel3FMVUnlocked);
            this.TPCharacterSheetLevel3Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel3Miscellaneous.Name = "TPCharacterSheetLevel3Miscellaneous";
            this.TPCharacterSheetLevel3Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel3Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel3Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel3Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel3PurchasedRewards
            // 
            this.CLBLevel3PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel3PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel3PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel3PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel3PurchasedRewards.Name = "CLBLevel3PurchasedRewards";
            this.CLBLevel3PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel3PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel3PurchasedRewards, resources.GetString("CLBLevel3PurchasedRewards.ToolTip"));
            this.CLBLevel3PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel3PurchasedRewards_ItemCheck);
            // 
            // LblLevel3PurchasedRewards
            // 
            this.LblLevel3PurchasedRewards.AutoSize = true;
            this.LblLevel3PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel3PurchasedRewards.Name = "LblLevel3PurchasedRewards";
            this.LblLevel3PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel3PurchasedRewards.TabIndex = 24;
            this.LblLevel3PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3PurchasedRewards, resources.GetString("LblLevel3PurchasedRewards.ToolTip"));
            // 
            // CLBLevel3Gags
            // 
            this.CLBLevel3Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel3Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel3Gags.FormattingEnabled = true;
            this.CLBLevel3Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel3Gags.Name = "CLBLevel3Gags";
            this.CLBLevel3Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel3Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel3Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel3Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel3Gags_ItemCheck);
            // 
            // LblLevel3Gags
            // 
            this.LblLevel3Gags.AutoSize = true;
            this.LblLevel3Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel3Gags.Name = "LblLevel3Gags";
            this.LblLevel3Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel3Gags.TabIndex = 22;
            this.LblLevel3Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            // 
            // CBLevel3CurrentSkin
            // 
            this.CBLevel3CurrentSkin.FormattingEnabled = true;
            this.CBLevel3CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel3CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel3CurrentSkin.MaxLength = 16;
            this.CBLevel3CurrentSkin.Name = "CBLevel3CurrentSkin";
            this.CBLevel3CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel3CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel3CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel3CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel3CurrentSkin_TextChanged);
            // 
            // LblLevel3CurrentSkin
            // 
            this.LblLevel3CurrentSkin.AutoSize = true;
            this.LblLevel3CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel3CurrentSkin.Name = "LblLevel3CurrentSkin";
            this.LblLevel3CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel3CurrentSkin.TabIndex = 20;
            this.LblLevel3CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel3WaspsDestroyed
            // 
            this.NUDLevel3WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel3WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel3WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel3WaspsDestroyed.Name = "NUDLevel3WaspsDestroyed";
            this.NUDLevel3WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel3WaspsDestroyed.TabIndex = 17;
            this.NUDLevel3WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel3WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel3WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel3WaspsDestroyed_ValueChanged);
            // 
            // LblLevel3WaspsDestroyed
            // 
            this.LblLevel3WaspsDestroyed.AutoSize = true;
            this.LblLevel3WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel3WaspsDestroyed.Name = "LblLevel3WaspsDestroyed";
            this.LblLevel3WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel3WaspsDestroyed.TabIndex = 16;
            this.LblLevel3WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel3NumSkinsPurchased
            // 
            this.NUDLevel3NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel3NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel3NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel3NumSkinsPurchased.Name = "NUDLevel3NumSkinsPurchased";
            this.NUDLevel3NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel3NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel3NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel3NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel3NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel3NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel3NumSkinsPurchased
            // 
            this.LblLevel3NumSkinsPurchased.AutoSize = true;
            this.LblLevel3NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel3NumSkinsPurchased.Name = "LblLevel3NumSkinsPurchased";
            this.LblLevel3NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel3NumSkinsPurchased.TabIndex = 14;
            this.LblLevel3NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel3NumCarsPurchased
            // 
            this.NUDLevel3NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel3NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel3NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel3NumCarsPurchased.Name = "NUDLevel3NumCarsPurchased";
            this.NUDLevel3NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel3NumCarsPurchased.TabIndex = 13;
            this.NUDLevel3NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel3NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel3NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel3NumCarsPurchased_ValueChanged);
            // 
            // LblLevel3NumCarsPurchased
            // 
            this.LblLevel3NumCarsPurchased.AutoSize = true;
            this.LblLevel3NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel3NumCarsPurchased.Name = "LblLevel3NumCarsPurchased";
            this.LblLevel3NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel3NumCarsPurchased.TabIndex = 12;
            this.LblLevel3NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel3FMVUnlocked
            // 
            this.CBLevel3FMVUnlocked.AutoSize = true;
            this.CBLevel3FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel3FMVUnlocked.Name = "CBLevel3FMVUnlocked";
            this.CBLevel3FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel3FMVUnlocked.TabIndex = 2;
            this.CBLevel3FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel3FMVUnlocked, "Different to other levels, this is if the Itchy & Scratchy movie has been watched" +
        ".\r\nRadical did this as this level doesn\'t have another video and they like bodgi" +
        "ng things.");
            this.CBLevel3FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel3FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel3FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel3Missions
            // 
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.NUDLevel3BestTime);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.LblLevel3BestTime);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.CBLevel3SkippedMission);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.NUDLevel3NumAttempts);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.LblLevel3NumAttempts);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.CBLevel3BonusObjective);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.CBLevel3Completed);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.TxtLevel3MissionName);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.LblLevel3MissionName);
            this.TPCharacterSheetLevel3Missions.Controls.Add(this.LBLevel3Missions);
            this.TPCharacterSheetLevel3Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel3Missions.Name = "TPCharacterSheetLevel3Missions";
            this.TPCharacterSheetLevel3Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel3Missions.TabIndex = 1;
            this.TPCharacterSheetLevel3Missions.Text = "Missions";
            this.TPCharacterSheetLevel3Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel3BestTime
            // 
            this.NUDLevel3BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel3BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel3BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel3BestTime.Name = "NUDLevel3BestTime";
            this.NUDLevel3BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel3BestTime.TabIndex = 17;
            this.NUDLevel3BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel3BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel3BestTime.ValueChanged += new System.EventHandler(this.NUDLevel3BestTime_ValueChanged);
            // 
            // LblLevel3BestTime
            // 
            this.LblLevel3BestTime.AutoSize = true;
            this.LblLevel3BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel3BestTime.Name = "LblLevel3BestTime";
            this.LblLevel3BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel3BestTime.TabIndex = 16;
            this.LblLevel3BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel3SkippedMission
            // 
            this.CBLevel3SkippedMission.AutoSize = true;
            this.CBLevel3SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel3SkippedMission.Name = "CBLevel3SkippedMission";
            this.CBLevel3SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel3SkippedMission.TabIndex = 9;
            this.CBLevel3SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel3SkippedMission, "If the mission was skipped.");
            this.CBLevel3SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel3SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel3SkippedMission_CheckedChanged);
            // 
            // NUDLevel3NumAttempts
            // 
            this.NUDLevel3NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel3NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel3NumAttempts.Name = "NUDLevel3NumAttempts";
            this.NUDLevel3NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel3NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel3NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel3NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel3NumAttempts_ValueChanged);
            // 
            // LblLevel3NumAttempts
            // 
            this.LblLevel3NumAttempts.AutoSize = true;
            this.LblLevel3NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel3NumAttempts.Name = "LblLevel3NumAttempts";
            this.LblLevel3NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel3NumAttempts.TabIndex = 7;
            this.LblLevel3NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel3BonusObjective
            // 
            this.CBLevel3BonusObjective.AutoSize = true;
            this.CBLevel3BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel3BonusObjective.Name = "CBLevel3BonusObjective";
            this.CBLevel3BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel3BonusObjective.TabIndex = 6;
            this.CBLevel3BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel3BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel3BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel3BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel3BonusObjective_CheckedChanged);
            // 
            // CBLevel3Completed
            // 
            this.CBLevel3Completed.AutoSize = true;
            this.CBLevel3Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel3Completed.Name = "CBLevel3Completed";
            this.CBLevel3Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel3Completed.TabIndex = 5;
            this.CBLevel3Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel3Completed, "If the mission has been completed.");
            this.CBLevel3Completed.UseVisualStyleBackColor = true;
            this.CBLevel3Completed.CheckedChanged += new System.EventHandler(this.CBLevel3Completed_CheckedChanged);
            // 
            // TxtLevel3MissionName
            // 
            this.TxtLevel3MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel3MissionName.MaxLength = 16;
            this.TxtLevel3MissionName.Name = "TxtLevel3MissionName";
            this.TxtLevel3MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel3MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel3MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel3MissionName.TextChanged += new System.EventHandler(this.TxtLevel3MissionName_TextChanged);
            // 
            // LblLevel3MissionName
            // 
            this.LblLevel3MissionName.AutoSize = true;
            this.LblLevel3MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel3MissionName.Name = "LblLevel3MissionName";
            this.LblLevel3MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel3MissionName.TabIndex = 3;
            this.LblLevel3MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel3Missions
            // 
            this.LBLevel3Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel3Missions.FormattingEnabled = true;
            this.LBLevel3Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel3Missions.Name = "LBLevel3Missions";
            this.LBLevel3Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel3Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel3Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel3Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel3Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel3Cards
            // 
            this.TPCharacterSheetLevel3Cards.Controls.Add(this.CBLevel3CardCollected);
            this.TPCharacterSheetLevel3Cards.Controls.Add(this.TxtLevel3CardName);
            this.TPCharacterSheetLevel3Cards.Controls.Add(this.LblLevel3CardName);
            this.TPCharacterSheetLevel3Cards.Controls.Add(this.LBLevel3Cards);
            this.TPCharacterSheetLevel3Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel3Cards.Name = "TPCharacterSheetLevel3Cards";
            this.TPCharacterSheetLevel3Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel3Cards.TabIndex = 2;
            this.TPCharacterSheetLevel3Cards.Text = "Cards";
            this.TPCharacterSheetLevel3Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel3CardCollected
            // 
            this.CBLevel3CardCollected.AutoSize = true;
            this.CBLevel3CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel3CardCollected.Name = "CBLevel3CardCollected";
            this.CBLevel3CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel3CardCollected.TabIndex = 9;
            this.CBLevel3CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel3CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel3CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel3CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel3CardCollected_CheckedChanged);
            // 
            // TxtLevel3CardName
            // 
            this.TxtLevel3CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel3CardName.MaxLength = 16;
            this.TxtLevel3CardName.Name = "TxtLevel3CardName";
            this.TxtLevel3CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel3CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel3CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel3CardName.TextChanged += new System.EventHandler(this.TxtLevel3CardName_TextChanged);
            // 
            // LblLevel3CardName
            // 
            this.LblLevel3CardName.AutoSize = true;
            this.LblLevel3CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel3CardName.Name = "LblLevel3CardName";
            this.LblLevel3CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel3CardName.TabIndex = 7;
            this.LblLevel3CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel3CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel3Cards
            // 
            this.LBLevel3Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel3Cards.FormattingEnabled = true;
            this.LBLevel3Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel3Cards.Name = "LBLevel3Cards";
            this.LBLevel3Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel3Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel3Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel3Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel3Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel4
            // 
            this.TPCharacterSheetLevel4.Controls.Add(this.TCCharacterSheetLevel4);
            this.TPCharacterSheetLevel4.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel4.Name = "TPCharacterSheetLevel4";
            this.TPCharacterSheetLevel4.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel4.TabIndex = 3;
            this.TPCharacterSheetLevel4.Text = "Level 4";
            this.TPCharacterSheetLevel4.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel4
            // 
            this.TCCharacterSheetLevel4.Controls.Add(this.TPCharacterSheetLevel4Miscellaneous);
            this.TCCharacterSheetLevel4.Controls.Add(this.TPCharacterSheetLevel4Missions);
            this.TCCharacterSheetLevel4.Controls.Add(this.TPCharacterSheetLevel4Cards);
            this.TCCharacterSheetLevel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel4.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel4.Name = "TCCharacterSheetLevel4";
            this.TCCharacterSheetLevel4.SelectedIndex = 0;
            this.TCCharacterSheetLevel4.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel4.TabIndex = 0;
            this.TCCharacterSheetLevel4.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel4_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel4Miscellaneous
            // 
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.CLBLevel4PurchasedRewards);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.LblLevel4PurchasedRewards);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.CLBLevel4Gags);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.LblLevel4Gags);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.CBLevel4CurrentSkin);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.LblLevel4CurrentSkin);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.NUDLevel4WaspsDestroyed);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.LblLevel4WaspsDestroyed);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.NUDLevel4NumSkinsPurchased);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.LblLevel4NumSkinsPurchased);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.NUDLevel4NumCarsPurchased);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.LblLevel4NumCarsPurchased);
            this.TPCharacterSheetLevel4Miscellaneous.Controls.Add(this.CBLevel4FMVUnlocked);
            this.TPCharacterSheetLevel4Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel4Miscellaneous.Name = "TPCharacterSheetLevel4Miscellaneous";
            this.TPCharacterSheetLevel4Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel4Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel4Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel4Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel4PurchasedRewards
            // 
            this.CLBLevel4PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel4PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel4PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel4PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel4PurchasedRewards.Name = "CLBLevel4PurchasedRewards";
            this.CLBLevel4PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel4PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel4PurchasedRewards, resources.GetString("CLBLevel4PurchasedRewards.ToolTip"));
            this.CLBLevel4PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel4PurchasedRewards_ItemCheck);
            // 
            // LblLevel4PurchasedRewards
            // 
            this.LblLevel4PurchasedRewards.AutoSize = true;
            this.LblLevel4PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel4PurchasedRewards.Name = "LblLevel4PurchasedRewards";
            this.LblLevel4PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel4PurchasedRewards.TabIndex = 24;
            this.LblLevel4PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4PurchasedRewards, resources.GetString("LblLevel4PurchasedRewards.ToolTip"));
            // 
            // CLBLevel4Gags
            // 
            this.CLBLevel4Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel4Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel4Gags.FormattingEnabled = true;
            this.CLBLevel4Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel4Gags.Name = "CLBLevel4Gags";
            this.CLBLevel4Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel4Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel4Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel4Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel4Gags_ItemCheck);
            // 
            // LblLevel4Gags
            // 
            this.LblLevel4Gags.AutoSize = true;
            this.LblLevel4Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel4Gags.Name = "LblLevel4Gags";
            this.LblLevel4Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel4Gags.TabIndex = 22;
            this.LblLevel4Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            // 
            // CBLevel4CurrentSkin
            // 
            this.CBLevel4CurrentSkin.FormattingEnabled = true;
            this.CBLevel4CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel4CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel4CurrentSkin.MaxLength = 16;
            this.CBLevel4CurrentSkin.Name = "CBLevel4CurrentSkin";
            this.CBLevel4CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel4CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel4CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel4CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel4CurrentSkin_TextChanged);
            // 
            // LblLevel4CurrentSkin
            // 
            this.LblLevel4CurrentSkin.AutoSize = true;
            this.LblLevel4CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel4CurrentSkin.Name = "LblLevel4CurrentSkin";
            this.LblLevel4CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel4CurrentSkin.TabIndex = 20;
            this.LblLevel4CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel4WaspsDestroyed
            // 
            this.NUDLevel4WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel4WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel4WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel4WaspsDestroyed.Name = "NUDLevel4WaspsDestroyed";
            this.NUDLevel4WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel4WaspsDestroyed.TabIndex = 17;
            this.NUDLevel4WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel4WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel4WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel4WaspsDestroyed_ValueChanged);
            // 
            // LblLevel4WaspsDestroyed
            // 
            this.LblLevel4WaspsDestroyed.AutoSize = true;
            this.LblLevel4WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel4WaspsDestroyed.Name = "LblLevel4WaspsDestroyed";
            this.LblLevel4WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel4WaspsDestroyed.TabIndex = 16;
            this.LblLevel4WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel4NumSkinsPurchased
            // 
            this.NUDLevel4NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel4NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel4NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel4NumSkinsPurchased.Name = "NUDLevel4NumSkinsPurchased";
            this.NUDLevel4NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel4NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel4NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel4NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel4NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel4NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel4NumSkinsPurchased
            // 
            this.LblLevel4NumSkinsPurchased.AutoSize = true;
            this.LblLevel4NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel4NumSkinsPurchased.Name = "LblLevel4NumSkinsPurchased";
            this.LblLevel4NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel4NumSkinsPurchased.TabIndex = 14;
            this.LblLevel4NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel4NumCarsPurchased
            // 
            this.NUDLevel4NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel4NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel4NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel4NumCarsPurchased.Name = "NUDLevel4NumCarsPurchased";
            this.NUDLevel4NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel4NumCarsPurchased.TabIndex = 13;
            this.NUDLevel4NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel4NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel4NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel4NumCarsPurchased_ValueChanged);
            // 
            // LblLevel4NumCarsPurchased
            // 
            this.LblLevel4NumCarsPurchased.AutoSize = true;
            this.LblLevel4NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel4NumCarsPurchased.Name = "LblLevel4NumCarsPurchased";
            this.LblLevel4NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel4NumCarsPurchased.TabIndex = 12;
            this.LblLevel4NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel4FMVUnlocked
            // 
            this.CBLevel4FMVUnlocked.AutoSize = true;
            this.CBLevel4FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel4FMVUnlocked.Name = "CBLevel4FMVUnlocked";
            this.CBLevel4FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel4FMVUnlocked.TabIndex = 2;
            this.CBLevel4FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel4FMVUnlocked, "If the level\'s video has been watched. If checked, you\'re able to skip the video " +
        "playback in the level.");
            this.CBLevel4FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel4FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel4FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel4Missions
            // 
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.NUDLevel4BestTime);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.LblLevel4BestTime);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.CBLevel4SkippedMission);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.NUDLevel4NumAttempts);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.LblLevel4NumAttempts);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.CBLevel4BonusObjective);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.CBLevel4Completed);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.TxtLevel4MissionName);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.LblLevel4MissionName);
            this.TPCharacterSheetLevel4Missions.Controls.Add(this.LBLevel4Missions);
            this.TPCharacterSheetLevel4Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel4Missions.Name = "TPCharacterSheetLevel4Missions";
            this.TPCharacterSheetLevel4Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel4Missions.TabIndex = 1;
            this.TPCharacterSheetLevel4Missions.Text = "Missions";
            this.TPCharacterSheetLevel4Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel4BestTime
            // 
            this.NUDLevel4BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel4BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel4BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel4BestTime.Name = "NUDLevel4BestTime";
            this.NUDLevel4BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel4BestTime.TabIndex = 17;
            this.NUDLevel4BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel4BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel4BestTime.ValueChanged += new System.EventHandler(this.NUDLevel4BestTime_ValueChanged);
            // 
            // LblLevel4BestTime
            // 
            this.LblLevel4BestTime.AutoSize = true;
            this.LblLevel4BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel4BestTime.Name = "LblLevel4BestTime";
            this.LblLevel4BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel4BestTime.TabIndex = 16;
            this.LblLevel4BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel4SkippedMission
            // 
            this.CBLevel4SkippedMission.AutoSize = true;
            this.CBLevel4SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel4SkippedMission.Name = "CBLevel4SkippedMission";
            this.CBLevel4SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel4SkippedMission.TabIndex = 9;
            this.CBLevel4SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel4SkippedMission, "If the mission was skipped.");
            this.CBLevel4SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel4SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel4SkippedMission_CheckedChanged);
            // 
            // NUDLevel4NumAttempts
            // 
            this.NUDLevel4NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel4NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel4NumAttempts.Name = "NUDLevel4NumAttempts";
            this.NUDLevel4NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel4NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel4NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel4NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel4NumAttempts_ValueChanged);
            // 
            // LblLevel4NumAttempts
            // 
            this.LblLevel4NumAttempts.AutoSize = true;
            this.LblLevel4NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel4NumAttempts.Name = "LblLevel4NumAttempts";
            this.LblLevel4NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel4NumAttempts.TabIndex = 7;
            this.LblLevel4NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel4BonusObjective
            // 
            this.CBLevel4BonusObjective.AutoSize = true;
            this.CBLevel4BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel4BonusObjective.Name = "CBLevel4BonusObjective";
            this.CBLevel4BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel4BonusObjective.TabIndex = 6;
            this.CBLevel4BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel4BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel4BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel4BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel4BonusObjective_CheckedChanged);
            // 
            // CBLevel4Completed
            // 
            this.CBLevel4Completed.AutoSize = true;
            this.CBLevel4Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel4Completed.Name = "CBLevel4Completed";
            this.CBLevel4Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel4Completed.TabIndex = 5;
            this.CBLevel4Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel4Completed, "If the mission has been completed.");
            this.CBLevel4Completed.UseVisualStyleBackColor = true;
            this.CBLevel4Completed.CheckedChanged += new System.EventHandler(this.CBLevel4Completed_CheckedChanged);
            // 
            // TxtLevel4MissionName
            // 
            this.TxtLevel4MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel4MissionName.MaxLength = 16;
            this.TxtLevel4MissionName.Name = "TxtLevel4MissionName";
            this.TxtLevel4MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel4MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel4MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel4MissionName.TextChanged += new System.EventHandler(this.TxtLevel4MissionName_TextChanged);
            // 
            // LblLevel4MissionName
            // 
            this.LblLevel4MissionName.AutoSize = true;
            this.LblLevel4MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel4MissionName.Name = "LblLevel4MissionName";
            this.LblLevel4MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel4MissionName.TabIndex = 3;
            this.LblLevel4MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel4Missions
            // 
            this.LBLevel4Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel4Missions.FormattingEnabled = true;
            this.LBLevel4Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel4Missions.Name = "LBLevel4Missions";
            this.LBLevel4Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel4Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel4Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel4Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel4Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel4Cards
            // 
            this.TPCharacterSheetLevel4Cards.Controls.Add(this.CBLevel4CardCollected);
            this.TPCharacterSheetLevel4Cards.Controls.Add(this.TxtLevel4CardName);
            this.TPCharacterSheetLevel4Cards.Controls.Add(this.LblLevel4CardName);
            this.TPCharacterSheetLevel4Cards.Controls.Add(this.LBLevel4Cards);
            this.TPCharacterSheetLevel4Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel4Cards.Name = "TPCharacterSheetLevel4Cards";
            this.TPCharacterSheetLevel4Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel4Cards.TabIndex = 2;
            this.TPCharacterSheetLevel4Cards.Text = "Cards";
            this.TPCharacterSheetLevel4Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel4CardCollected
            // 
            this.CBLevel4CardCollected.AutoSize = true;
            this.CBLevel4CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel4CardCollected.Name = "CBLevel4CardCollected";
            this.CBLevel4CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel4CardCollected.TabIndex = 9;
            this.CBLevel4CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel4CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel4CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel4CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel4CardCollected_CheckedChanged);
            // 
            // TxtLevel4CardName
            // 
            this.TxtLevel4CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel4CardName.MaxLength = 16;
            this.TxtLevel4CardName.Name = "TxtLevel4CardName";
            this.TxtLevel4CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel4CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel4CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel4CardName.TextChanged += new System.EventHandler(this.TxtLevel4CardName_TextChanged);
            // 
            // LblLevel4CardName
            // 
            this.LblLevel4CardName.AutoSize = true;
            this.LblLevel4CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel4CardName.Name = "LblLevel4CardName";
            this.LblLevel4CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel4CardName.TabIndex = 7;
            this.LblLevel4CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel4CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel4Cards
            // 
            this.LBLevel4Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel4Cards.FormattingEnabled = true;
            this.LBLevel4Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel4Cards.Name = "LBLevel4Cards";
            this.LBLevel4Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel4Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel4Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel4Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel4Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel5
            // 
            this.TPCharacterSheetLevel5.Controls.Add(this.TCCharacterSheetLevel5);
            this.TPCharacterSheetLevel5.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel5.Name = "TPCharacterSheetLevel5";
            this.TPCharacterSheetLevel5.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel5.TabIndex = 4;
            this.TPCharacterSheetLevel5.Text = "Level 5";
            this.TPCharacterSheetLevel5.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel5
            // 
            this.TCCharacterSheetLevel5.Controls.Add(this.TPCharacterSheetLevel5Miscellaneous);
            this.TCCharacterSheetLevel5.Controls.Add(this.TPCharacterSheetLevel5Missions);
            this.TCCharacterSheetLevel5.Controls.Add(this.TPCharacterSheetLevel5Cards);
            this.TCCharacterSheetLevel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel5.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel5.Name = "TCCharacterSheetLevel5";
            this.TCCharacterSheetLevel5.SelectedIndex = 0;
            this.TCCharacterSheetLevel5.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel5.TabIndex = 0;
            this.TCCharacterSheetLevel5.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel5_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel5Miscellaneous
            // 
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.CLBLevel5PurchasedRewards);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.LblLevel5PurchasedRewards);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.CLBLevel5Gags);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.LblLevel5Gags);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.CBLevel5CurrentSkin);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.LblLevel5CurrentSkin);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.NUDLevel5WaspsDestroyed);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.LblLevel5WaspsDestroyed);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.NUDLevel5NumSkinsPurchased);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.LblLevel5NumSkinsPurchased);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.NUDLevel5NumCarsPurchased);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.LblLevel5NumCarsPurchased);
            this.TPCharacterSheetLevel5Miscellaneous.Controls.Add(this.CBLevel5FMVUnlocked);
            this.TPCharacterSheetLevel5Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel5Miscellaneous.Name = "TPCharacterSheetLevel5Miscellaneous";
            this.TPCharacterSheetLevel5Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel5Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel5Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel5Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel5PurchasedRewards
            // 
            this.CLBLevel5PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel5PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel5PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel5PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel5PurchasedRewards.Name = "CLBLevel5PurchasedRewards";
            this.CLBLevel5PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel5PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel5PurchasedRewards, resources.GetString("CLBLevel5PurchasedRewards.ToolTip"));
            this.CLBLevel5PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel5PurchasedRewards_ItemCheck);
            // 
            // LblLevel5PurchasedRewards
            // 
            this.LblLevel5PurchasedRewards.AutoSize = true;
            this.LblLevel5PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel5PurchasedRewards.Name = "LblLevel5PurchasedRewards";
            this.LblLevel5PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel5PurchasedRewards.TabIndex = 24;
            this.LblLevel5PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5PurchasedRewards, resources.GetString("LblLevel5PurchasedRewards.ToolTip"));
            // 
            // CLBLevel5Gags
            // 
            this.CLBLevel5Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel5Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel5Gags.FormattingEnabled = true;
            this.CLBLevel5Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel5Gags.Name = "CLBLevel5Gags";
            this.CLBLevel5Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel5Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel5Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel5Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel5Gags_ItemCheck);
            // 
            // LblLevel5Gags
            // 
            this.LblLevel5Gags.AutoSize = true;
            this.LblLevel5Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel5Gags.Name = "LblLevel5Gags";
            this.LblLevel5Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel5Gags.TabIndex = 22;
            this.LblLevel5Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            // 
            // CBLevel5CurrentSkin
            // 
            this.CBLevel5CurrentSkin.FormattingEnabled = true;
            this.CBLevel5CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel5CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel5CurrentSkin.MaxLength = 16;
            this.CBLevel5CurrentSkin.Name = "CBLevel5CurrentSkin";
            this.CBLevel5CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel5CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel5CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel5CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel5CurrentSkin_TextChanged);
            // 
            // LblLevel5CurrentSkin
            // 
            this.LblLevel5CurrentSkin.AutoSize = true;
            this.LblLevel5CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel5CurrentSkin.Name = "LblLevel5CurrentSkin";
            this.LblLevel5CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel5CurrentSkin.TabIndex = 20;
            this.LblLevel5CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel5WaspsDestroyed
            // 
            this.NUDLevel5WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel5WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel5WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel5WaspsDestroyed.Name = "NUDLevel5WaspsDestroyed";
            this.NUDLevel5WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel5WaspsDestroyed.TabIndex = 17;
            this.NUDLevel5WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel5WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel5WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel5WaspsDestroyed_ValueChanged);
            // 
            // LblLevel5WaspsDestroyed
            // 
            this.LblLevel5WaspsDestroyed.AutoSize = true;
            this.LblLevel5WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel5WaspsDestroyed.Name = "LblLevel5WaspsDestroyed";
            this.LblLevel5WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel5WaspsDestroyed.TabIndex = 16;
            this.LblLevel5WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel5NumSkinsPurchased
            // 
            this.NUDLevel5NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel5NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel5NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel5NumSkinsPurchased.Name = "NUDLevel5NumSkinsPurchased";
            this.NUDLevel5NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel5NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel5NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel5NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel5NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel5NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel5NumSkinsPurchased
            // 
            this.LblLevel5NumSkinsPurchased.AutoSize = true;
            this.LblLevel5NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel5NumSkinsPurchased.Name = "LblLevel5NumSkinsPurchased";
            this.LblLevel5NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel5NumSkinsPurchased.TabIndex = 14;
            this.LblLevel5NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel5NumCarsPurchased
            // 
            this.NUDLevel5NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel5NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel5NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel5NumCarsPurchased.Name = "NUDLevel5NumCarsPurchased";
            this.NUDLevel5NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel5NumCarsPurchased.TabIndex = 13;
            this.NUDLevel5NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel5NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel5NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel5NumCarsPurchased_ValueChanged);
            // 
            // LblLevel5NumCarsPurchased
            // 
            this.LblLevel5NumCarsPurchased.AutoSize = true;
            this.LblLevel5NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel5NumCarsPurchased.Name = "LblLevel5NumCarsPurchased";
            this.LblLevel5NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel5NumCarsPurchased.TabIndex = 12;
            this.LblLevel5NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel5FMVUnlocked
            // 
            this.CBLevel5FMVUnlocked.AutoSize = true;
            this.CBLevel5FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel5FMVUnlocked.Name = "CBLevel5FMVUnlocked";
            this.CBLevel5FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel5FMVUnlocked.TabIndex = 2;
            this.CBLevel5FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel5FMVUnlocked, "If the level\'s video has been watched. If checked, you\'re able to skip the video " +
        "playback in the level.");
            this.CBLevel5FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel5FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel5FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel5Missions
            // 
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.NUDLevel5BestTime);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.LblLevel5BestTime);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.CBLevel5SkippedMission);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.NUDLevel5NumAttempts);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.LblLevel5NumAttempts);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.CBLevel5BonusObjective);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.CBLevel5Completed);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.TxtLevel5MissionName);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.LblLevel5MissionName);
            this.TPCharacterSheetLevel5Missions.Controls.Add(this.LBLevel5Missions);
            this.TPCharacterSheetLevel5Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel5Missions.Name = "TPCharacterSheetLevel5Missions";
            this.TPCharacterSheetLevel5Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel5Missions.TabIndex = 1;
            this.TPCharacterSheetLevel5Missions.Text = "Missions";
            this.TPCharacterSheetLevel5Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel5BestTime
            // 
            this.NUDLevel5BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel5BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel5BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel5BestTime.Name = "NUDLevel5BestTime";
            this.NUDLevel5BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel5BestTime.TabIndex = 17;
            this.NUDLevel5BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel5BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel5BestTime.ValueChanged += new System.EventHandler(this.NUDLevel5BestTime_ValueChanged);
            // 
            // LblLevel5BestTime
            // 
            this.LblLevel5BestTime.AutoSize = true;
            this.LblLevel5BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel5BestTime.Name = "LblLevel5BestTime";
            this.LblLevel5BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel5BestTime.TabIndex = 16;
            this.LblLevel5BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel5SkippedMission
            // 
            this.CBLevel5SkippedMission.AutoSize = true;
            this.CBLevel5SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel5SkippedMission.Name = "CBLevel5SkippedMission";
            this.CBLevel5SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel5SkippedMission.TabIndex = 9;
            this.CBLevel5SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel5SkippedMission, "If the mission was skipped.");
            this.CBLevel5SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel5SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel5SkippedMission_CheckedChanged);
            // 
            // NUDLevel5NumAttempts
            // 
            this.NUDLevel5NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel5NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel5NumAttempts.Name = "NUDLevel5NumAttempts";
            this.NUDLevel5NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel5NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel5NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel5NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel5NumAttempts_ValueChanged);
            // 
            // LblLevel5NumAttempts
            // 
            this.LblLevel5NumAttempts.AutoSize = true;
            this.LblLevel5NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel5NumAttempts.Name = "LblLevel5NumAttempts";
            this.LblLevel5NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel5NumAttempts.TabIndex = 7;
            this.LblLevel5NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel5BonusObjective
            // 
            this.CBLevel5BonusObjective.AutoSize = true;
            this.CBLevel5BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel5BonusObjective.Name = "CBLevel5BonusObjective";
            this.CBLevel5BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel5BonusObjective.TabIndex = 6;
            this.CBLevel5BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel5BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel5BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel5BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel5BonusObjective_CheckedChanged);
            // 
            // CBLevel5Completed
            // 
            this.CBLevel5Completed.AutoSize = true;
            this.CBLevel5Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel5Completed.Name = "CBLevel5Completed";
            this.CBLevel5Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel5Completed.TabIndex = 5;
            this.CBLevel5Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel5Completed, "If the mission has been completed.");
            this.CBLevel5Completed.UseVisualStyleBackColor = true;
            this.CBLevel5Completed.CheckedChanged += new System.EventHandler(this.CBLevel5Completed_CheckedChanged);
            // 
            // TxtLevel5MissionName
            // 
            this.TxtLevel5MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel5MissionName.MaxLength = 16;
            this.TxtLevel5MissionName.Name = "TxtLevel5MissionName";
            this.TxtLevel5MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel5MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel5MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel5MissionName.TextChanged += new System.EventHandler(this.TxtLevel5MissionName_TextChanged);
            // 
            // LblLevel5MissionName
            // 
            this.LblLevel5MissionName.AutoSize = true;
            this.LblLevel5MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel5MissionName.Name = "LblLevel5MissionName";
            this.LblLevel5MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel5MissionName.TabIndex = 3;
            this.LblLevel5MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel5Missions
            // 
            this.LBLevel5Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel5Missions.FormattingEnabled = true;
            this.LBLevel5Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel5Missions.Name = "LBLevel5Missions";
            this.LBLevel5Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel5Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel5Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel5Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel5Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel5Cards
            // 
            this.TPCharacterSheetLevel5Cards.Controls.Add(this.CBLevel5CardCollected);
            this.TPCharacterSheetLevel5Cards.Controls.Add(this.TxtLevel5CardName);
            this.TPCharacterSheetLevel5Cards.Controls.Add(this.LblLevel5CardName);
            this.TPCharacterSheetLevel5Cards.Controls.Add(this.LBLevel5Cards);
            this.TPCharacterSheetLevel5Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel5Cards.Name = "TPCharacterSheetLevel5Cards";
            this.TPCharacterSheetLevel5Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel5Cards.TabIndex = 2;
            this.TPCharacterSheetLevel5Cards.Text = "Cards";
            this.TPCharacterSheetLevel5Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel5CardCollected
            // 
            this.CBLevel5CardCollected.AutoSize = true;
            this.CBLevel5CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel5CardCollected.Name = "CBLevel5CardCollected";
            this.CBLevel5CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel5CardCollected.TabIndex = 9;
            this.CBLevel5CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel5CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel5CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel5CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel5CardCollected_CheckedChanged);
            // 
            // TxtLevel5CardName
            // 
            this.TxtLevel5CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel5CardName.MaxLength = 16;
            this.TxtLevel5CardName.Name = "TxtLevel5CardName";
            this.TxtLevel5CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel5CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel5CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel5CardName.TextChanged += new System.EventHandler(this.TxtLevel5CardName_TextChanged);
            // 
            // LblLevel5CardName
            // 
            this.LblLevel5CardName.AutoSize = true;
            this.LblLevel5CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel5CardName.Name = "LblLevel5CardName";
            this.LblLevel5CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel5CardName.TabIndex = 7;
            this.LblLevel5CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel5CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel5Cards
            // 
            this.LBLevel5Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel5Cards.FormattingEnabled = true;
            this.LBLevel5Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel5Cards.Name = "LBLevel5Cards";
            this.LBLevel5Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel5Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel5Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel5Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel5Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel6
            // 
            this.TPCharacterSheetLevel6.Controls.Add(this.TCCharacterSheetLevel6);
            this.TPCharacterSheetLevel6.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel6.Name = "TPCharacterSheetLevel6";
            this.TPCharacterSheetLevel6.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel6.TabIndex = 5;
            this.TPCharacterSheetLevel6.Text = "Level 6";
            this.TPCharacterSheetLevel6.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel6
            // 
            this.TCCharacterSheetLevel6.Controls.Add(this.TPCharacterSheetLevel6Miscellaneous);
            this.TCCharacterSheetLevel6.Controls.Add(this.TPCharacterSheetLevel6Missions);
            this.TCCharacterSheetLevel6.Controls.Add(this.TPCharacterSheetLevel6Cards);
            this.TCCharacterSheetLevel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel6.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel6.Name = "TCCharacterSheetLevel6";
            this.TCCharacterSheetLevel6.SelectedIndex = 0;
            this.TCCharacterSheetLevel6.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel6.TabIndex = 0;
            this.TCCharacterSheetLevel6.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel6_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel6Miscellaneous
            // 
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.CLBLevel6PurchasedRewards);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.LblLevel6PurchasedRewards);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.CLBLevel6Gags);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.LblLevel6Gags);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.CBLevel6CurrentSkin);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.LblLevel6CurrentSkin);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.NUDLevel6WaspsDestroyed);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.LblLevel6WaspsDestroyed);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.NUDLevel6NumSkinsPurchased);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.LblLevel6NumSkinsPurchased);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.NUDLevel6NumCarsPurchased);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.LblLevel6NumCarsPurchased);
            this.TPCharacterSheetLevel6Miscellaneous.Controls.Add(this.CBLevel6FMVUnlocked);
            this.TPCharacterSheetLevel6Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel6Miscellaneous.Name = "TPCharacterSheetLevel6Miscellaneous";
            this.TPCharacterSheetLevel6Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel6Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel6Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel6Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel6PurchasedRewards
            // 
            this.CLBLevel6PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel6PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel6PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel6PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel6PurchasedRewards.Name = "CLBLevel6PurchasedRewards";
            this.CLBLevel6PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel6PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel6PurchasedRewards, resources.GetString("CLBLevel6PurchasedRewards.ToolTip"));
            this.CLBLevel6PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel6PurchasedRewards_ItemCheck);
            // 
            // LblLevel6PurchasedRewards
            // 
            this.LblLevel6PurchasedRewards.AutoSize = true;
            this.LblLevel6PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel6PurchasedRewards.Name = "LblLevel6PurchasedRewards";
            this.LblLevel6PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel6PurchasedRewards.TabIndex = 24;
            this.LblLevel6PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6PurchasedRewards, resources.GetString("LblLevel6PurchasedRewards.ToolTip"));
            // 
            // CLBLevel6Gags
            // 
            this.CLBLevel6Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel6Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel6Gags.FormattingEnabled = true;
            this.CLBLevel6Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel6Gags.Name = "CLBLevel6Gags";
            this.CLBLevel6Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel6Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel6Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel6Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel6Gags_ItemCheck);
            // 
            // LblLevel6Gags
            // 
            this.LblLevel6Gags.AutoSize = true;
            this.LblLevel6Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel6Gags.Name = "LblLevel6Gags";
            this.LblLevel6Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel6Gags.TabIndex = 22;
            this.LblLevel6Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            // 
            // CBLevel6CurrentSkin
            // 
            this.CBLevel6CurrentSkin.FormattingEnabled = true;
            this.CBLevel6CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel6CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel6CurrentSkin.MaxLength = 16;
            this.CBLevel6CurrentSkin.Name = "CBLevel6CurrentSkin";
            this.CBLevel6CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel6CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel6CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel6CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel6CurrentSkin_TextChanged);
            // 
            // LblLevel6CurrentSkin
            // 
            this.LblLevel6CurrentSkin.AutoSize = true;
            this.LblLevel6CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel6CurrentSkin.Name = "LblLevel6CurrentSkin";
            this.LblLevel6CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel6CurrentSkin.TabIndex = 20;
            this.LblLevel6CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel6WaspsDestroyed
            // 
            this.NUDLevel6WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel6WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel6WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel6WaspsDestroyed.Name = "NUDLevel6WaspsDestroyed";
            this.NUDLevel6WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel6WaspsDestroyed.TabIndex = 17;
            this.NUDLevel6WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel6WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel6WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel6WaspsDestroyed_ValueChanged);
            // 
            // LblLevel6WaspsDestroyed
            // 
            this.LblLevel6WaspsDestroyed.AutoSize = true;
            this.LblLevel6WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel6WaspsDestroyed.Name = "LblLevel6WaspsDestroyed";
            this.LblLevel6WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel6WaspsDestroyed.TabIndex = 16;
            this.LblLevel6WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel6NumSkinsPurchased
            // 
            this.NUDLevel6NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel6NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel6NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel6NumSkinsPurchased.Name = "NUDLevel6NumSkinsPurchased";
            this.NUDLevel6NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel6NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel6NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel6NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel6NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel6NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel6NumSkinsPurchased
            // 
            this.LblLevel6NumSkinsPurchased.AutoSize = true;
            this.LblLevel6NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel6NumSkinsPurchased.Name = "LblLevel6NumSkinsPurchased";
            this.LblLevel6NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel6NumSkinsPurchased.TabIndex = 14;
            this.LblLevel6NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel6NumCarsPurchased
            // 
            this.NUDLevel6NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel6NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel6NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel6NumCarsPurchased.Name = "NUDLevel6NumCarsPurchased";
            this.NUDLevel6NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel6NumCarsPurchased.TabIndex = 13;
            this.NUDLevel6NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel6NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel6NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel6NumCarsPurchased_ValueChanged);
            // 
            // LblLevel6NumCarsPurchased
            // 
            this.LblLevel6NumCarsPurchased.AutoSize = true;
            this.LblLevel6NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel6NumCarsPurchased.Name = "LblLevel6NumCarsPurchased";
            this.LblLevel6NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel6NumCarsPurchased.TabIndex = 12;
            this.LblLevel6NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel6FMVUnlocked
            // 
            this.CBLevel6FMVUnlocked.AutoSize = true;
            this.CBLevel6FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel6FMVUnlocked.Name = "CBLevel6FMVUnlocked";
            this.CBLevel6FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel6FMVUnlocked.TabIndex = 2;
            this.CBLevel6FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel6FMVUnlocked, "If the level\'s video has been watched. If checked, you\'re able to skip the video " +
        "playback in the level.");
            this.CBLevel6FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel6FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel6FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel6Missions
            // 
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.NUDLevel6BestTime);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.LblLevel6BestTime);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.CBLevel6SkippedMission);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.NUDLevel6NumAttempts);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.LblLevel6NumAttempts);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.CBLevel6BonusObjective);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.CBLevel6Completed);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.TxtLevel6MissionName);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.LblLevel6MissionName);
            this.TPCharacterSheetLevel6Missions.Controls.Add(this.LBLevel6Missions);
            this.TPCharacterSheetLevel6Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel6Missions.Name = "TPCharacterSheetLevel6Missions";
            this.TPCharacterSheetLevel6Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel6Missions.TabIndex = 1;
            this.TPCharacterSheetLevel6Missions.Text = "Missions";
            this.TPCharacterSheetLevel6Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel6BestTime
            // 
            this.NUDLevel6BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel6BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel6BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel6BestTime.Name = "NUDLevel6BestTime";
            this.NUDLevel6BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel6BestTime.TabIndex = 17;
            this.NUDLevel6BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel6BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel6BestTime.ValueChanged += new System.EventHandler(this.NUDLevel6BestTime_ValueChanged);
            // 
            // LblLevel6BestTime
            // 
            this.LblLevel6BestTime.AutoSize = true;
            this.LblLevel6BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel6BestTime.Name = "LblLevel6BestTime";
            this.LblLevel6BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel6BestTime.TabIndex = 16;
            this.LblLevel6BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel6SkippedMission
            // 
            this.CBLevel6SkippedMission.AutoSize = true;
            this.CBLevel6SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel6SkippedMission.Name = "CBLevel6SkippedMission";
            this.CBLevel6SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel6SkippedMission.TabIndex = 9;
            this.CBLevel6SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel6SkippedMission, "If the mission was skipped.");
            this.CBLevel6SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel6SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel6SkippedMission_CheckedChanged);
            // 
            // NUDLevel6NumAttempts
            // 
            this.NUDLevel6NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel6NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel6NumAttempts.Name = "NUDLevel6NumAttempts";
            this.NUDLevel6NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel6NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel6NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel6NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel6NumAttempts_ValueChanged);
            // 
            // LblLevel6NumAttempts
            // 
            this.LblLevel6NumAttempts.AutoSize = true;
            this.LblLevel6NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel6NumAttempts.Name = "LblLevel6NumAttempts";
            this.LblLevel6NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel6NumAttempts.TabIndex = 7;
            this.LblLevel6NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel6BonusObjective
            // 
            this.CBLevel6BonusObjective.AutoSize = true;
            this.CBLevel6BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel6BonusObjective.Name = "CBLevel6BonusObjective";
            this.CBLevel6BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel6BonusObjective.TabIndex = 6;
            this.CBLevel6BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel6BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel6BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel6BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel6BonusObjective_CheckedChanged);
            // 
            // CBLevel6Completed
            // 
            this.CBLevel6Completed.AutoSize = true;
            this.CBLevel6Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel6Completed.Name = "CBLevel6Completed";
            this.CBLevel6Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel6Completed.TabIndex = 5;
            this.CBLevel6Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel6Completed, "If the mission has been completed.");
            this.CBLevel6Completed.UseVisualStyleBackColor = true;
            this.CBLevel6Completed.CheckedChanged += new System.EventHandler(this.CBLevel6Completed_CheckedChanged);
            // 
            // TxtLevel6MissionName
            // 
            this.TxtLevel6MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel6MissionName.MaxLength = 16;
            this.TxtLevel6MissionName.Name = "TxtLevel6MissionName";
            this.TxtLevel6MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel6MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel6MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel6MissionName.TextChanged += new System.EventHandler(this.TxtLevel6MissionName_TextChanged);
            // 
            // LblLevel6MissionName
            // 
            this.LblLevel6MissionName.AutoSize = true;
            this.LblLevel6MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel6MissionName.Name = "LblLevel6MissionName";
            this.LblLevel6MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel6MissionName.TabIndex = 3;
            this.LblLevel6MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel6Missions
            // 
            this.LBLevel6Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel6Missions.FormattingEnabled = true;
            this.LBLevel6Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel6Missions.Name = "LBLevel6Missions";
            this.LBLevel6Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel6Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel6Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel6Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel6Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel6Cards
            // 
            this.TPCharacterSheetLevel6Cards.Controls.Add(this.CBLevel6CardCollected);
            this.TPCharacterSheetLevel6Cards.Controls.Add(this.TxtLevel6CardName);
            this.TPCharacterSheetLevel6Cards.Controls.Add(this.LblLevel6CardName);
            this.TPCharacterSheetLevel6Cards.Controls.Add(this.LBLevel6Cards);
            this.TPCharacterSheetLevel6Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel6Cards.Name = "TPCharacterSheetLevel6Cards";
            this.TPCharacterSheetLevel6Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel6Cards.TabIndex = 2;
            this.TPCharacterSheetLevel6Cards.Text = "Cards";
            this.TPCharacterSheetLevel6Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel6CardCollected
            // 
            this.CBLevel6CardCollected.AutoSize = true;
            this.CBLevel6CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel6CardCollected.Name = "CBLevel6CardCollected";
            this.CBLevel6CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel6CardCollected.TabIndex = 9;
            this.CBLevel6CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel6CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel6CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel6CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel6CardCollected_CheckedChanged);
            // 
            // TxtLevel6CardName
            // 
            this.TxtLevel6CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel6CardName.MaxLength = 16;
            this.TxtLevel6CardName.Name = "TxtLevel6CardName";
            this.TxtLevel6CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel6CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel6CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel6CardName.TextChanged += new System.EventHandler(this.TxtLevel6CardName_TextChanged);
            // 
            // LblLevel6CardName
            // 
            this.LblLevel6CardName.AutoSize = true;
            this.LblLevel6CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel6CardName.Name = "LblLevel6CardName";
            this.LblLevel6CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel6CardName.TabIndex = 7;
            this.LblLevel6CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel6CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel6Cards
            // 
            this.LBLevel6Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel6Cards.FormattingEnabled = true;
            this.LBLevel6Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel6Cards.Name = "LBLevel6Cards";
            this.LBLevel6Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel6Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel6Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel6Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel6Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel7
            // 
            this.TPCharacterSheetLevel7.Controls.Add(this.TCCharacterSheetLevel7);
            this.TPCharacterSheetLevel7.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel7.Name = "TPCharacterSheetLevel7";
            this.TPCharacterSheetLevel7.Size = new System.Drawing.Size(760, 359);
            this.TPCharacterSheetLevel7.TabIndex = 6;
            this.TPCharacterSheetLevel7.Text = "Level 7";
            this.TPCharacterSheetLevel7.UseVisualStyleBackColor = true;
            // 
            // TCCharacterSheetLevel7
            // 
            this.TCCharacterSheetLevel7.Controls.Add(this.TPCharacterSheetLevel7Miscellaneous);
            this.TCCharacterSheetLevel7.Controls.Add(this.TPCharacterSheetLevel7Missions);
            this.TCCharacterSheetLevel7.Controls.Add(this.TPCharacterSheetLevel7Cards);
            this.TCCharacterSheetLevel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCharacterSheetLevel7.Location = new System.Drawing.Point(0, 0);
            this.TCCharacterSheetLevel7.Name = "TCCharacterSheetLevel7";
            this.TCCharacterSheetLevel7.SelectedIndex = 0;
            this.TCCharacterSheetLevel7.Size = new System.Drawing.Size(760, 359);
            this.TCCharacterSheetLevel7.TabIndex = 0;
            this.TCCharacterSheetLevel7.SelectedIndexChanged += new System.EventHandler(this.TCCharacterSheetLevel7_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel7Miscellaneous
            // 
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.CLBLevel7PurchasedRewards);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.LblLevel7PurchasedRewards);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.CLBLevel7Gags);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.LblLevel7Gags);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.CBLevel7CurrentSkin);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.LblLevel7CurrentSkin);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.NUDLevel7WaspsDestroyed);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.LblLevel7WaspsDestroyed);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.NUDLevel7NumSkinsPurchased);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.LblLevel7NumSkinsPurchased);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.NUDLevel7NumCarsPurchased);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.LblLevel7NumCarsPurchased);
            this.TPCharacterSheetLevel7Miscellaneous.Controls.Add(this.CBLevel7FMVUnlocked);
            this.TPCharacterSheetLevel7Miscellaneous.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel7Miscellaneous.Name = "TPCharacterSheetLevel7Miscellaneous";
            this.TPCharacterSheetLevel7Miscellaneous.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel7Miscellaneous.TabIndex = 0;
            this.TPCharacterSheetLevel7Miscellaneous.Text = "Miscellaneous";
            this.TPCharacterSheetLevel7Miscellaneous.UseVisualStyleBackColor = true;
            // 
            // CLBLevel7PurchasedRewards
            // 
            this.CLBLevel7PurchasedRewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel7PurchasedRewards.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel7PurchasedRewards.FormattingEnabled = true;
            this.CLBLevel7PurchasedRewards.Location = new System.Drawing.Point(12, 196);
            this.CLBLevel7PurchasedRewards.Name = "CLBLevel7PurchasedRewards";
            this.CLBLevel7PurchasedRewards.Size = new System.Drawing.Size(275, 124);
            this.CLBLevel7PurchasedRewards.TabIndex = 25;
            this.TTSettingInfo.SetToolTip(this.CLBLevel7PurchasedRewards, resources.GetString("CLBLevel7PurchasedRewards.ToolTip"));
            this.CLBLevel7PurchasedRewards.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel7PurchasedRewards_ItemCheck);
            // 
            // LblLevel7PurchasedRewards
            // 
            this.LblLevel7PurchasedRewards.AutoSize = true;
            this.LblLevel7PurchasedRewards.Location = new System.Drawing.Point(9, 180);
            this.LblLevel7PurchasedRewards.Name = "LblLevel7PurchasedRewards";
            this.LblLevel7PurchasedRewards.Size = new System.Drawing.Size(106, 13);
            this.LblLevel7PurchasedRewards.TabIndex = 24;
            this.LblLevel7PurchasedRewards.Text = "Purchased Rewards:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7PurchasedRewards, resources.GetString("LblLevel7PurchasedRewards.ToolTip"));
            // 
            // CLBLevel7Gags
            // 
            this.CLBLevel7Gags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBLevel7Gags.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBLevel7Gags.FormattingEnabled = true;
            this.CLBLevel7Gags.Location = new System.Drawing.Point(311, 20);
            this.CLBLevel7Gags.Name = "CLBLevel7Gags";
            this.CLBLevel7Gags.Size = new System.Drawing.Size(275, 304);
            this.CLBLevel7Gags.TabIndex = 23;
            this.TTSettingInfo.SetToolTip(this.CLBLevel7Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            this.CLBLevel7Gags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBLevel7Gags_ItemCheck);
            // 
            // LblLevel7Gags
            // 
            this.LblLevel7Gags.AutoSize = true;
            this.LblLevel7Gags.Location = new System.Drawing.Point(308, 4);
            this.LblLevel7Gags.Name = "LblLevel7Gags";
            this.LblLevel7Gags.Size = new System.Drawing.Size(73, 13);
            this.LblLevel7Gags.TabIndex = 22;
            this.LblLevel7Gags.Text = "Gags Viewed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7Gags, "The gags in current level.\r\nThe names in brackets are the vanilla game gags.");
            // 
            // CBLevel7CurrentSkin
            // 
            this.CBLevel7CurrentSkin.FormattingEnabled = true;
            this.CBLevel7CurrentSkin.Items.AddRange(new object[] {
            "homer",
            "h_undrwr",
            "h_fat",
            "h_stcrobe"});
            this.CBLevel7CurrentSkin.Location = new System.Drawing.Point(12, 156);
            this.CBLevel7CurrentSkin.MaxLength = 16;
            this.CBLevel7CurrentSkin.Name = "CBLevel7CurrentSkin";
            this.CBLevel7CurrentSkin.Size = new System.Drawing.Size(275, 21);
            this.CBLevel7CurrentSkin.TabIndex = 21;
            this.TTSettingInfo.SetToolTip(this.CBLevel7CurrentSkin, "The current skin/costume in the level.");
            this.CBLevel7CurrentSkin.TextChanged += new System.EventHandler(this.CBLevel7CurrentSkin_TextChanged);
            // 
            // LblLevel7CurrentSkin
            // 
            this.LblLevel7CurrentSkin.AutoSize = true;
            this.LblLevel7CurrentSkin.Location = new System.Drawing.Point(9, 140);
            this.LblLevel7CurrentSkin.Name = "LblLevel7CurrentSkin";
            this.LblLevel7CurrentSkin.Size = new System.Drawing.Size(68, 13);
            this.LblLevel7CurrentSkin.TabIndex = 20;
            this.LblLevel7CurrentSkin.Text = "Current Skin:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7CurrentSkin, "The current skin/costume in the level.");
            // 
            // NUDLevel7WaspsDestroyed
            // 
            this.NUDLevel7WaspsDestroyed.Location = new System.Drawing.Point(12, 117);
            this.NUDLevel7WaspsDestroyed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel7WaspsDestroyed.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel7WaspsDestroyed.Name = "NUDLevel7WaspsDestroyed";
            this.NUDLevel7WaspsDestroyed.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel7WaspsDestroyed.TabIndex = 17;
            this.NUDLevel7WaspsDestroyed.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel7WaspsDestroyed, "The number of wasps destroyed in the level.");
            this.NUDLevel7WaspsDestroyed.ValueChanged += new System.EventHandler(this.NUDLevel7WaspsDestroyed_ValueChanged);
            // 
            // LblLevel7WaspsDestroyed
            // 
            this.LblLevel7WaspsDestroyed.AutoSize = true;
            this.LblLevel7WaspsDestroyed.Location = new System.Drawing.Point(9, 101);
            this.LblLevel7WaspsDestroyed.Name = "LblLevel7WaspsDestroyed";
            this.LblLevel7WaspsDestroyed.Size = new System.Drawing.Size(94, 13);
            this.LblLevel7WaspsDestroyed.TabIndex = 16;
            this.LblLevel7WaspsDestroyed.Text = "Wasps Destroyed:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7WaspsDestroyed, "The number of wasps destroyed in the level.");
            // 
            // NUDLevel7NumSkinsPurchased
            // 
            this.NUDLevel7NumSkinsPurchased.Location = new System.Drawing.Point(12, 78);
            this.NUDLevel7NumSkinsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel7NumSkinsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel7NumSkinsPurchased.Name = "NUDLevel7NumSkinsPurchased";
            this.NUDLevel7NumSkinsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel7NumSkinsPurchased.TabIndex = 15;
            this.NUDLevel7NumSkinsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel7NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            this.NUDLevel7NumSkinsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel7NumSkinsPurchased_ValueChanged);
            // 
            // LblLevel7NumSkinsPurchased
            // 
            this.LblLevel7NumSkinsPurchased.AutoSize = true;
            this.LblLevel7NumSkinsPurchased.Location = new System.Drawing.Point(9, 62);
            this.LblLevel7NumSkinsPurchased.Name = "LblLevel7NumSkinsPurchased";
            this.LblLevel7NumSkinsPurchased.Size = new System.Drawing.Size(115, 13);
            this.LblLevel7NumSkinsPurchased.TabIndex = 14;
            this.LblLevel7NumSkinsPurchased.Text = "Num Skins Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7NumSkinsPurchased, "The number of \"Purchased Rewards\" that are costumes/skins.");
            // 
            // NUDLevel7NumCarsPurchased
            // 
            this.NUDLevel7NumCarsPurchased.Location = new System.Drawing.Point(12, 39);
            this.NUDLevel7NumCarsPurchased.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel7NumCarsPurchased.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel7NumCarsPurchased.Name = "NUDLevel7NumCarsPurchased";
            this.NUDLevel7NumCarsPurchased.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel7NumCarsPurchased.TabIndex = 13;
            this.NUDLevel7NumCarsPurchased.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel7NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            this.NUDLevel7NumCarsPurchased.ValueChanged += new System.EventHandler(this.NUDLevel7NumCarsPurchased_ValueChanged);
            // 
            // LblLevel7NumCarsPurchased
            // 
            this.LblLevel7NumCarsPurchased.AutoSize = true;
            this.LblLevel7NumCarsPurchased.Location = new System.Drawing.Point(9, 23);
            this.LblLevel7NumCarsPurchased.Name = "LblLevel7NumCarsPurchased";
            this.LblLevel7NumCarsPurchased.Size = new System.Drawing.Size(110, 13);
            this.LblLevel7NumCarsPurchased.TabIndex = 12;
            this.LblLevel7NumCarsPurchased.Text = "Num Cars Purchased:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7NumCarsPurchased, "The number of \"Purchased Rewards\" that are cars.");
            // 
            // CBLevel7FMVUnlocked
            // 
            this.CBLevel7FMVUnlocked.AutoSize = true;
            this.CBLevel7FMVUnlocked.Location = new System.Drawing.Point(12, 3);
            this.CBLevel7FMVUnlocked.Name = "CBLevel7FMVUnlocked";
            this.CBLevel7FMVUnlocked.Size = new System.Drawing.Size(97, 17);
            this.CBLevel7FMVUnlocked.TabIndex = 2;
            this.CBLevel7FMVUnlocked.Text = "FMV Unlocked";
            this.TTSettingInfo.SetToolTip(this.CBLevel7FMVUnlocked, "If the level\'s video has been watched. If checked, you\'re able to skip the video " +
        "playback in the level.");
            this.CBLevel7FMVUnlocked.UseVisualStyleBackColor = true;
            this.CBLevel7FMVUnlocked.CheckedChanged += new System.EventHandler(this.CBLevel7FMVUnlocked_CheckedChanged);
            // 
            // TPCharacterSheetLevel7Missions
            // 
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.NUDLevel7BestTime);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.LblLevel7BestTime);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.CBLevel7SkippedMission);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.NUDLevel7NumAttempts);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.LblLevel7NumAttempts);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.CBLevel7BonusObjective);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.CBLevel7Completed);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.TxtLevel7MissionName);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.LblLevel7MissionName);
            this.TPCharacterSheetLevel7Missions.Controls.Add(this.LBLevel7Missions);
            this.TPCharacterSheetLevel7Missions.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel7Missions.Name = "TPCharacterSheetLevel7Missions";
            this.TPCharacterSheetLevel7Missions.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel7Missions.TabIndex = 1;
            this.TPCharacterSheetLevel7Missions.Text = "Missions";
            this.TPCharacterSheetLevel7Missions.UseVisualStyleBackColor = true;
            // 
            // NUDLevel7BestTime
            // 
            this.NUDLevel7BestTime.Location = new System.Drawing.Point(267, 167);
            this.NUDLevel7BestTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDLevel7BestTime.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDLevel7BestTime.Name = "NUDLevel7BestTime";
            this.NUDLevel7BestTime.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel7BestTime.TabIndex = 17;
            this.NUDLevel7BestTime.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDLevel7BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            this.NUDLevel7BestTime.ValueChanged += new System.EventHandler(this.NUDLevel7BestTime_ValueChanged);
            // 
            // LblLevel7BestTime
            // 
            this.LblLevel7BestTime.AutoSize = true;
            this.LblLevel7BestTime.Location = new System.Drawing.Point(264, 151);
            this.LblLevel7BestTime.Name = "LblLevel7BestTime";
            this.LblLevel7BestTime.Size = new System.Drawing.Size(57, 13);
            this.LblLevel7BestTime.TabIndex = 16;
            this.LblLevel7BestTime.Text = "Best Time:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7BestTime, "Really only used by \"Race 1 (Time Trial)\". The best time fo the trial.");
            // 
            // CBLevel7SkippedMission
            // 
            this.CBLevel7SkippedMission.AutoSize = true;
            this.CBLevel7SkippedMission.Location = new System.Drawing.Point(267, 131);
            this.CBLevel7SkippedMission.Name = "CBLevel7SkippedMission";
            this.CBLevel7SkippedMission.Size = new System.Drawing.Size(103, 17);
            this.CBLevel7SkippedMission.TabIndex = 9;
            this.CBLevel7SkippedMission.Text = "Skipped Mission";
            this.TTSettingInfo.SetToolTip(this.CBLevel7SkippedMission, "If the mission was skipped.");
            this.CBLevel7SkippedMission.UseVisualStyleBackColor = true;
            this.CBLevel7SkippedMission.CheckedChanged += new System.EventHandler(this.CBLevel7SkippedMission_CheckedChanged);
            // 
            // NUDLevel7NumAttempts
            // 
            this.NUDLevel7NumAttempts.Location = new System.Drawing.Point(267, 105);
            this.NUDLevel7NumAttempts.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.NUDLevel7NumAttempts.Name = "NUDLevel7NumAttempts";
            this.NUDLevel7NumAttempts.Size = new System.Drawing.Size(275, 20);
            this.NUDLevel7NumAttempts.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDLevel7NumAttempts, "The number of times the mission was attempted prior to completion.");
            this.NUDLevel7NumAttempts.ValueChanged += new System.EventHandler(this.NUDLevel7NumAttempts_ValueChanged);
            // 
            // LblLevel7NumAttempts
            // 
            this.LblLevel7NumAttempts.AutoSize = true;
            this.LblLevel7NumAttempts.Location = new System.Drawing.Point(264, 89);
            this.LblLevel7NumAttempts.Name = "LblLevel7NumAttempts";
            this.LblLevel7NumAttempts.Size = new System.Drawing.Size(76, 13);
            this.LblLevel7NumAttempts.TabIndex = 7;
            this.LblLevel7NumAttempts.Text = "Num Attempts:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7NumAttempts, "The number of times the mission was attempted prior to completion.");
            // 
            // CBLevel7BonusObjective
            // 
            this.CBLevel7BonusObjective.AutoSize = true;
            this.CBLevel7BonusObjective.Location = new System.Drawing.Point(267, 69);
            this.CBLevel7BonusObjective.Name = "CBLevel7BonusObjective";
            this.CBLevel7BonusObjective.Size = new System.Drawing.Size(104, 17);
            this.CBLevel7BonusObjective.TabIndex = 6;
            this.CBLevel7BonusObjective.Text = "Bonus Objective";
            this.TTSettingInfo.SetToolTip(this.CBLevel7BonusObjective, "If the bonus objective of the mission has been completed.\r\nThis is unused in the " +
        "vanilla game, but can be added with the \"AddBonusObjective\" MFK function.");
            this.CBLevel7BonusObjective.UseVisualStyleBackColor = true;
            this.CBLevel7BonusObjective.CheckedChanged += new System.EventHandler(this.CBLevel7BonusObjective_CheckedChanged);
            // 
            // CBLevel7Completed
            // 
            this.CBLevel7Completed.AutoSize = true;
            this.CBLevel7Completed.Location = new System.Drawing.Point(267, 46);
            this.CBLevel7Completed.Name = "CBLevel7Completed";
            this.CBLevel7Completed.Size = new System.Drawing.Size(76, 17);
            this.CBLevel7Completed.TabIndex = 5;
            this.CBLevel7Completed.Text = "Completed";
            this.TTSettingInfo.SetToolTip(this.CBLevel7Completed, "If the mission has been completed.");
            this.CBLevel7Completed.UseVisualStyleBackColor = true;
            this.CBLevel7Completed.CheckedChanged += new System.EventHandler(this.CBLevel7Completed_CheckedChanged);
            // 
            // TxtLevel7MissionName
            // 
            this.TxtLevel7MissionName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel7MissionName.MaxLength = 16;
            this.TxtLevel7MissionName.Name = "TxtLevel7MissionName";
            this.TxtLevel7MissionName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel7MissionName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtLevel7MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            this.TxtLevel7MissionName.TextChanged += new System.EventHandler(this.TxtLevel7MissionName_TextChanged);
            // 
            // LblLevel7MissionName
            // 
            this.LblLevel7MissionName.AutoSize = true;
            this.LblLevel7MissionName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel7MissionName.Name = "LblLevel7MissionName";
            this.LblLevel7MissionName.Size = new System.Drawing.Size(76, 13);
            this.LblLevel7MissionName.TabIndex = 3;
            this.LblLevel7MissionName.Text = "Mission Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7MissionName, "The internal name of the mission.\r\nDetermined by the \"AddMission\" MFK function.");
            // 
            // LBLevel7Missions
            // 
            this.LBLevel7Missions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel7Missions.FormattingEnabled = true;
            this.LBLevel7Missions.Location = new System.Drawing.Point(8, 8);
            this.LBLevel7Missions.Name = "LBLevel7Missions";
            this.LBLevel7Missions.Size = new System.Drawing.Size(250, 316);
            this.LBLevel7Missions.TabIndex = 1;
            this.TTSettingInfo.SetToolTip(this.LBLevel7Missions, "The list of missions in the level.\r\nThe names in brackets are the vanilla game mi" +
        "ssions.");
            this.LBLevel7Missions.SelectedIndexChanged += new System.EventHandler(this.LBLevel7Missions_SelectedIndexChanged);
            // 
            // TPCharacterSheetLevel7Cards
            // 
            this.TPCharacterSheetLevel7Cards.Controls.Add(this.CBLevel7CardCollected);
            this.TPCharacterSheetLevel7Cards.Controls.Add(this.TxtLevel7CardName);
            this.TPCharacterSheetLevel7Cards.Controls.Add(this.LblLevel7CardName);
            this.TPCharacterSheetLevel7Cards.Controls.Add(this.LBLevel7Cards);
            this.TPCharacterSheetLevel7Cards.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetLevel7Cards.Name = "TPCharacterSheetLevel7Cards";
            this.TPCharacterSheetLevel7Cards.Size = new System.Drawing.Size(752, 333);
            this.TPCharacterSheetLevel7Cards.TabIndex = 2;
            this.TPCharacterSheetLevel7Cards.Text = "Cards";
            this.TPCharacterSheetLevel7Cards.UseVisualStyleBackColor = true;
            // 
            // CBLevel7CardCollected
            // 
            this.CBLevel7CardCollected.AutoSize = true;
            this.CBLevel7CardCollected.Location = new System.Drawing.Point(267, 46);
            this.CBLevel7CardCollected.Name = "CBLevel7CardCollected";
            this.CBLevel7CardCollected.Size = new System.Drawing.Size(70, 17);
            this.CBLevel7CardCollected.TabIndex = 9;
            this.CBLevel7CardCollected.Text = "Collected";
            this.TTSettingInfo.SetToolTip(this.CBLevel7CardCollected, "If the card has been collected.\r\nUpdating this will also update the Card Gallery." +
        "");
            this.CBLevel7CardCollected.UseVisualStyleBackColor = true;
            this.CBLevel7CardCollected.CheckedChanged += new System.EventHandler(this.CBLevel7CardCollected_CheckedChanged);
            // 
            // TxtLevel7CardName
            // 
            this.TxtLevel7CardName.Location = new System.Drawing.Point(267, 20);
            this.TxtLevel7CardName.MaxLength = 16;
            this.TxtLevel7CardName.Name = "TxtLevel7CardName";
            this.TxtLevel7CardName.Size = new System.Drawing.Size(275, 20);
            this.TxtLevel7CardName.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TxtLevel7CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            this.TxtLevel7CardName.TextChanged += new System.EventHandler(this.TxtLevel7CardName_TextChanged);
            // 
            // LblLevel7CardName
            // 
            this.LblLevel7CardName.AutoSize = true;
            this.LblLevel7CardName.Location = new System.Drawing.Point(264, 4);
            this.LblLevel7CardName.Name = "LblLevel7CardName";
            this.LblLevel7CardName.Size = new System.Drawing.Size(63, 13);
            this.LblLevel7CardName.TabIndex = 7;
            this.LblLevel7CardName.Text = "Card Name:";
            this.TTSettingInfo.SetToolTip(this.LblLevel7CardName, "Unused by the game. Hardcodedly set to \"Cardx\".");
            // 
            // LBLevel7Cards
            // 
            this.LBLevel7Cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLevel7Cards.FormattingEnabled = true;
            this.LBLevel7Cards.Location = new System.Drawing.Point(8, 8);
            this.LBLevel7Cards.Name = "LBLevel7Cards";
            this.LBLevel7Cards.Size = new System.Drawing.Size(250, 316);
            this.LBLevel7Cards.TabIndex = 6;
            this.TTSettingInfo.SetToolTip(this.LBLevel7Cards, "The list of cards in the level.\r\nThe names in brackets are the vanilla game cards" +
        ".");
            this.LBLevel7Cards.SelectedIndexChanged += new System.EventHandler(this.LBLevel7Cards_SelectedIndexChanged);
            // 
            // TPCharacterSheetCars
            // 
            this.TPCharacterSheetCars.Controls.Add(this.NUDCounter);
            this.TPCharacterSheetCars.Controls.Add(this.LblCounter);
            this.TPCharacterSheetCars.Controls.Add(this.GBCars);
            this.TPCharacterSheetCars.Location = new System.Drawing.Point(4, 22);
            this.TPCharacterSheetCars.Name = "TPCharacterSheetCars";
            this.TPCharacterSheetCars.Size = new System.Drawing.Size(768, 385);
            this.TPCharacterSheetCars.TabIndex = 2;
            this.TPCharacterSheetCars.Text = "Cars";
            this.TPCharacterSheetCars.UseVisualStyleBackColor = true;
            // 
            // NUDCounter
            // 
            this.NUDCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NUDCounter.Location = new System.Drawing.Point(12, 358);
            this.NUDCounter.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDCounter.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.NUDCounter.Name = "NUDCounter";
            this.NUDCounter.Size = new System.Drawing.Size(275, 20);
            this.NUDCounter.TabIndex = 12;
            this.NUDCounter.ThousandsSeparator = true;
            this.TTSettingInfo.SetToolTip(this.NUDCounter, "The number of cars in the inventory.\r\nThis should equal the number of cars with n" +
        "ames that aren\'t \"n/a\", but this isn\'t enforced.");
            this.NUDCounter.ValueChanged += new System.EventHandler(this.NUDCounter_ValueChanged);
            // 
            // LblCounter
            // 
            this.LblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCounter.AutoSize = true;
            this.LblCounter.Location = new System.Drawing.Point(9, 342);
            this.LblCounter.Name = "LblCounter";
            this.LblCounter.Size = new System.Drawing.Size(47, 13);
            this.LblCounter.TabIndex = 1;
            this.LblCounter.Text = "Counter:";
            this.TTSettingInfo.SetToolTip(this.LblCounter, "The number of cars in the inventory.\r\nThis should equal the number of cars with n" +
        "ames that aren\'t \"n/a\", but this isn\'t enforced.");
            // 
            // GBCars
            // 
            this.GBCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBCars.Controls.Add(this.NUDMaxHealth);
            this.GBCars.Controls.Add(this.LblMaxHealth);
            this.GBCars.Controls.Add(this.NUDCurrentHealth);
            this.GBCars.Controls.Add(this.LblCurrentHealth);
            this.GBCars.Controls.Add(this.TxtCarName);
            this.GBCars.Controls.Add(this.LblCarName);
            this.GBCars.Controls.Add(this.LBCars);
            this.GBCars.Location = new System.Drawing.Point(12, 4);
            this.GBCars.Name = "GBCars";
            this.GBCars.Size = new System.Drawing.Size(550, 335);
            this.GBCars.TabIndex = 0;
            this.GBCars.TabStop = false;
            this.GBCars.Text = "Cars";
            // 
            // NUDMaxHealth
            // 
            this.NUDMaxHealth.DecimalPlaces = 5;
            this.NUDMaxHealth.Location = new System.Drawing.Point(265, 113);
            this.NUDMaxHealth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDMaxHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NUDMaxHealth.Name = "NUDMaxHealth";
            this.NUDMaxHealth.Size = new System.Drawing.Size(275, 20);
            this.NUDMaxHealth.TabIndex = 10;
            this.TTSettingInfo.SetToolTip(this.NUDMaxHealth, "Unusued by the game. Should be the car\'s max hit points.");
            this.NUDMaxHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NUDMaxHealth.ValueChanged += new System.EventHandler(this.NUDMaxHealth_ValueChanged);
            // 
            // LblMaxHealth
            // 
            this.LblMaxHealth.AutoSize = true;
            this.LblMaxHealth.Location = new System.Drawing.Point(262, 97);
            this.LblMaxHealth.Name = "LblMaxHealth";
            this.LblMaxHealth.Size = new System.Drawing.Size(64, 13);
            this.LblMaxHealth.TabIndex = 9;
            this.LblMaxHealth.Text = "Max Health:";
            this.TTSettingInfo.SetToolTip(this.LblMaxHealth, "Unusued by the game. Should be the car\'s max hit points.");
            // 
            // NUDCurrentHealth
            // 
            this.NUDCurrentHealth.DecimalPlaces = 5;
            this.NUDCurrentHealth.Location = new System.Drawing.Point(265, 74);
            this.NUDCurrentHealth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDCurrentHealth.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NUDCurrentHealth.Name = "NUDCurrentHealth";
            this.NUDCurrentHealth.Size = new System.Drawing.Size(275, 20);
            this.NUDCurrentHealth.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.NUDCurrentHealth, "The current health the car has, as a percentage.");
            this.NUDCurrentHealth.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDCurrentHealth.ValueChanged += new System.EventHandler(this.NUDCurrentHealth_ValueChanged);
            // 
            // LblCurrentHealth
            // 
            this.LblCurrentHealth.AutoSize = true;
            this.LblCurrentHealth.Location = new System.Drawing.Point(262, 58);
            this.LblCurrentHealth.Name = "LblCurrentHealth";
            this.LblCurrentHealth.Size = new System.Drawing.Size(95, 13);
            this.LblCurrentHealth.TabIndex = 7;
            this.LblCurrentHealth.Text = "Current Health (%):";
            this.TTSettingInfo.SetToolTip(this.LblCurrentHealth, "The current health the car has, as a percentage.");
            // 
            // TxtCarName
            // 
            this.TxtCarName.Location = new System.Drawing.Point(265, 35);
            this.TxtCarName.MaxLength = 16;
            this.TxtCarName.Name = "TxtCarName";
            this.TxtCarName.Size = new System.Drawing.Size(275, 20);
            this.TxtCarName.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.TxtCarName, "The car name. Must match the Composite Drawable name of the Pure3D file.");
            this.TxtCarName.TextChanged += new System.EventHandler(this.TxtCarName_TextChanged);
            // 
            // LblCarName
            // 
            this.LblCarName.AutoSize = true;
            this.LblCarName.Location = new System.Drawing.Point(262, 19);
            this.LblCarName.Name = "LblCarName";
            this.LblCarName.Size = new System.Drawing.Size(38, 13);
            this.LblCarName.TabIndex = 3;
            this.LblCarName.Text = "Name:";
            this.TTSettingInfo.SetToolTip(this.LblCarName, "The car name. Must match the Composite Drawable name of the Pure3D file.");
            // 
            // LBCars
            // 
            this.LBCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBCars.FormattingEnabled = true;
            this.LBCars.Location = new System.Drawing.Point(6, 19);
            this.LBCars.Name = "LBCars";
            this.LBCars.Size = new System.Drawing.Size(250, 303);
            this.LBCars.TabIndex = 0;
            this.TTSettingInfo.SetToolTip(this.LBCars, "The list of card in the inventory.");
            this.LBCars.SelectedIndexChanged += new System.EventHandler(this.LBCars_SelectedIndexChanged);
            // 
            // TPSoundSettings
            // 
            this.TPSoundSettings.Controls.Add(this.CBIsSurround);
            this.TPSoundSettings.Controls.Add(this.TBDialogVolume);
            this.TPSoundSettings.Controls.Add(this.LblDialogVolumeValue);
            this.TPSoundSettings.Controls.Add(this.LblDialogVolume);
            this.TPSoundSettings.Controls.Add(this.TBCarVolume);
            this.TPSoundSettings.Controls.Add(this.LblCarVolumeValue);
            this.TPSoundSettings.Controls.Add(this.LblCarVolume);
            this.TPSoundSettings.Controls.Add(this.TBSFXVolume);
            this.TPSoundSettings.Controls.Add(this.LblSFXVolumeValue);
            this.TPSoundSettings.Controls.Add(this.LblSFXVolume);
            this.TPSoundSettings.Controls.Add(this.TBMusicVolume);
            this.TPSoundSettings.Controls.Add(this.LblMusicVolumeValue);
            this.TPSoundSettings.Controls.Add(this.LblMusicVolume);
            this.TPSoundSettings.Location = new System.Drawing.Point(4, 22);
            this.TPSoundSettings.Name = "TPSoundSettings";
            this.TPSoundSettings.Size = new System.Drawing.Size(776, 411);
            this.TPSoundSettings.TabIndex = 3;
            this.TPSoundSettings.Text = "Sound Settings";
            this.TPSoundSettings.UseVisualStyleBackColor = true;
            // 
            // CBIsSurround
            // 
            this.CBIsSurround.AutoSize = true;
            this.CBIsSurround.Location = new System.Drawing.Point(12, 263);
            this.CBIsSurround.Name = "CBIsSurround";
            this.CBIsSurround.Size = new System.Drawing.Size(80, 17);
            this.CBIsSurround.TabIndex = 12;
            this.CBIsSurround.Text = "Is Surround";
            this.TTSettingInfo.SetToolTip(this.CBIsSurround, "If the game should use surround sound.\r\nIf checked, the game audio will use surro" +
        "und sound. If unchecked, the game audio will be in stereo.");
            this.CBIsSurround.UseVisualStyleBackColor = true;
            // 
            // TBDialogVolume
            // 
            this.TBDialogVolume.BackColor = System.Drawing.Color.White;
            this.TBDialogVolume.Location = new System.Drawing.Point(12, 212);
            this.TBDialogVolume.Maximum = 100;
            this.TBDialogVolume.Name = "TBDialogVolume";
            this.TBDialogVolume.Size = new System.Drawing.Size(275, 45);
            this.TBDialogVolume.TabIndex = 11;
            this.TTSettingInfo.SetToolTip(this.TBDialogVolume, "The dialog volume level.");
            this.TBDialogVolume.ValueChanged += new System.EventHandler(this.TBDialogVolume_ValueChanged);
            // 
            // LblDialogVolumeValue
            // 
            this.LblDialogVolumeValue.AutoSize = true;
            this.LblDialogVolumeValue.Location = new System.Drawing.Point(83, 196);
            this.LblDialogVolumeValue.Name = "LblDialogVolumeValue";
            this.LblDialogVolumeValue.Size = new System.Drawing.Size(13, 13);
            this.LblDialogVolumeValue.TabIndex = 10;
            this.LblDialogVolumeValue.Text = "0";
            this.TTSettingInfo.SetToolTip(this.LblDialogVolumeValue, "The dialog volume level.");
            // 
            // LblDialogVolume
            // 
            this.LblDialogVolume.AutoSize = true;
            this.LblDialogVolume.Location = new System.Drawing.Point(9, 196);
            this.LblDialogVolume.Name = "LblDialogVolume";
            this.LblDialogVolume.Size = new System.Drawing.Size(78, 13);
            this.LblDialogVolume.TabIndex = 9;
            this.LblDialogVolume.Text = "Dialog Volume:";
            this.TTSettingInfo.SetToolTip(this.LblDialogVolume, "The dialog volume level.");
            // 
            // TBCarVolume
            // 
            this.TBCarVolume.BackColor = System.Drawing.Color.White;
            this.TBCarVolume.Location = new System.Drawing.Point(12, 148);
            this.TBCarVolume.Maximum = 100;
            this.TBCarVolume.Name = "TBCarVolume";
            this.TBCarVolume.Size = new System.Drawing.Size(275, 45);
            this.TBCarVolume.TabIndex = 8;
            this.TTSettingInfo.SetToolTip(this.TBCarVolume, "The car volume level.");
            this.TBCarVolume.ValueChanged += new System.EventHandler(this.TBCarVolume_ValueChanged);
            // 
            // LblCarVolumeValue
            // 
            this.LblCarVolumeValue.AutoSize = true;
            this.LblCarVolumeValue.Location = new System.Drawing.Point(83, 132);
            this.LblCarVolumeValue.Name = "LblCarVolumeValue";
            this.LblCarVolumeValue.Size = new System.Drawing.Size(13, 13);
            this.LblCarVolumeValue.TabIndex = 7;
            this.LblCarVolumeValue.Text = "0";
            this.TTSettingInfo.SetToolTip(this.LblCarVolumeValue, "The car volume level.");
            // 
            // LblCarVolume
            // 
            this.LblCarVolume.AutoSize = true;
            this.LblCarVolume.Location = new System.Drawing.Point(9, 132);
            this.LblCarVolume.Name = "LblCarVolume";
            this.LblCarVolume.Size = new System.Drawing.Size(64, 13);
            this.LblCarVolume.TabIndex = 6;
            this.LblCarVolume.Text = "Car Volume:";
            this.TTSettingInfo.SetToolTip(this.LblCarVolume, "The car volume level.");
            // 
            // TBSFXVolume
            // 
            this.TBSFXVolume.BackColor = System.Drawing.Color.White;
            this.TBSFXVolume.Location = new System.Drawing.Point(12, 84);
            this.TBSFXVolume.Maximum = 100;
            this.TBSFXVolume.Name = "TBSFXVolume";
            this.TBSFXVolume.Size = new System.Drawing.Size(275, 45);
            this.TBSFXVolume.TabIndex = 5;
            this.TTSettingInfo.SetToolTip(this.TBSFXVolume, "The SFX volume level.");
            this.TBSFXVolume.ValueChanged += new System.EventHandler(this.TBSFXVolume_ValueChanged);
            // 
            // LblSFXVolumeValue
            // 
            this.LblSFXVolumeValue.AutoSize = true;
            this.LblSFXVolumeValue.Location = new System.Drawing.Point(83, 68);
            this.LblSFXVolumeValue.Name = "LblSFXVolumeValue";
            this.LblSFXVolumeValue.Size = new System.Drawing.Size(13, 13);
            this.LblSFXVolumeValue.TabIndex = 4;
            this.LblSFXVolumeValue.Text = "0";
            this.TTSettingInfo.SetToolTip(this.LblSFXVolumeValue, "The SFX volume level.");
            // 
            // LblSFXVolume
            // 
            this.LblSFXVolume.AutoSize = true;
            this.LblSFXVolume.Location = new System.Drawing.Point(9, 68);
            this.LblSFXVolume.Name = "LblSFXVolume";
            this.LblSFXVolume.Size = new System.Drawing.Size(68, 13);
            this.LblSFXVolume.TabIndex = 3;
            this.LblSFXVolume.Text = "SFX Volume:";
            this.TTSettingInfo.SetToolTip(this.LblSFXVolume, "The SFX volume level.");
            // 
            // TBMusicVolume
            // 
            this.TBMusicVolume.BackColor = System.Drawing.Color.White;
            this.TBMusicVolume.Location = new System.Drawing.Point(12, 20);
            this.TBMusicVolume.Maximum = 100;
            this.TBMusicVolume.Name = "TBMusicVolume";
            this.TBMusicVolume.Size = new System.Drawing.Size(275, 45);
            this.TBMusicVolume.TabIndex = 2;
            this.TTSettingInfo.SetToolTip(this.TBMusicVolume, "The music volume level.");
            this.TBMusicVolume.ValueChanged += new System.EventHandler(this.TBMusicVolume_ValueChanged);
            // 
            // LblMusicVolumeValue
            // 
            this.LblMusicVolumeValue.AutoSize = true;
            this.LblMusicVolumeValue.Location = new System.Drawing.Point(83, 4);
            this.LblMusicVolumeValue.Name = "LblMusicVolumeValue";
            this.LblMusicVolumeValue.Size = new System.Drawing.Size(13, 13);
            this.LblMusicVolumeValue.TabIndex = 1;
            this.LblMusicVolumeValue.Text = "0";
            this.TTSettingInfo.SetToolTip(this.LblMusicVolumeValue, "The music volume level.");
            // 
            // LblMusicVolume
            // 
            this.LblMusicVolume.AutoSize = true;
            this.LblMusicVolume.Location = new System.Drawing.Point(9, 4);
            this.LblMusicVolume.Name = "LblMusicVolume";
            this.LblMusicVolume.Size = new System.Drawing.Size(76, 13);
            this.LblMusicVolume.TabIndex = 0;
            this.LblMusicVolume.Text = "Music Volume:";
            this.TTSettingInfo.SetToolTip(this.LblMusicVolume, "The music volume level.");
            // 
            // TPSuperCamCentral
            // 
            this.TPSuperCamCentral.Controls.Add(this.GBSuperCamCentral4);
            this.TPSuperCamCentral.Controls.Add(this.GBSuperCamCentral3);
            this.TPSuperCamCentral.Controls.Add(this.GBSuperCamCentral2);
            this.TPSuperCamCentral.Controls.Add(this.GBSuperCamCentral1);
            this.TPSuperCamCentral.Location = new System.Drawing.Point(4, 22);
            this.TPSuperCamCentral.Name = "TPSuperCamCentral";
            this.TPSuperCamCentral.Size = new System.Drawing.Size(776, 411);
            this.TPSuperCamCentral.TabIndex = 4;
            this.TPSuperCamCentral.Text = "Super Cam Central";
            this.TPSuperCamCentral.UseVisualStyleBackColor = true;
            // 
            // GBSuperCamCentral4
            // 
            this.GBSuperCamCentral4.Controls.Add(this.CBPreferredFollowCam4);
            this.GBSuperCamCentral4.Controls.Add(this.CBIsInvertedCameraEnabled4);
            this.GBSuperCamCentral4.Controls.Add(this.CBJumpCamsEnabled4);
            this.GBSuperCamCentral4.Controls.Add(this.LblPreferredFollowCam4);
            this.GBSuperCamCentral4.Location = new System.Drawing.Point(292, 117);
            this.GBSuperCamCentral4.Name = "GBSuperCamCentral4";
            this.GBSuperCamCentral4.Size = new System.Drawing.Size(275, 108);
            this.GBSuperCamCentral4.TabIndex = 6;
            this.GBSuperCamCentral4.TabStop = false;
            this.GBSuperCamCentral4.Text = "Super Cam Central 4";
            // 
            // CBPreferredFollowCam4
            // 
            this.CBPreferredFollowCam4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBPreferredFollowCam4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPreferredFollowCam4.FormattingEnabled = true;
            this.CBPreferredFollowCam4.Location = new System.Drawing.Point(9, 78);
            this.CBPreferredFollowCam4.Name = "CBPreferredFollowCam4";
            this.CBPreferredFollowCam4.Size = new System.Drawing.Size(260, 21);
            this.CBPreferredFollowCam4.TabIndex = 3;
            this.TTSettingInfo.SetToolTip(this.CBPreferredFollowCam4, "The preferred/default camera angle in the bonus game.");
            this.CBPreferredFollowCam4.SelectedIndexChanged += new System.EventHandler(this.CBPreferredFollowCam4_SelectedIndexChanged);
            // 
            // CBIsInvertedCameraEnabled4
            // 
            this.CBIsInvertedCameraEnabled4.AutoSize = true;
            this.CBIsInvertedCameraEnabled4.Location = new System.Drawing.Point(9, 42);
            this.CBIsInvertedCameraEnabled4.Name = "CBIsInvertedCameraEnabled4";
            this.CBIsInvertedCameraEnabled4.Size = new System.Drawing.Size(157, 17);
            this.CBIsInvertedCameraEnabled4.TabIndex = 2;
            this.CBIsInvertedCameraEnabled4.Text = "Is Inverted Camera Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsInvertedCameraEnabled4, "If the camera should be inverted when using first person camera in the bonus game" +
        ".");
            this.CBIsInvertedCameraEnabled4.UseVisualStyleBackColor = true;
            this.CBIsInvertedCameraEnabled4.CheckedChanged += new System.EventHandler(this.CBIsInvertedCameraEnabled4_CheckedChanged);
            // 
            // CBJumpCamsEnabled4
            // 
            this.CBJumpCamsEnabled4.AutoSize = true;
            this.CBJumpCamsEnabled4.Location = new System.Drawing.Point(9, 19);
            this.CBJumpCamsEnabled4.Name = "CBJumpCamsEnabled4";
            this.CBJumpCamsEnabled4.Size = new System.Drawing.Size(122, 17);
            this.CBJumpCamsEnabled4.TabIndex = 1;
            this.CBJumpCamsEnabled4.Text = "Jump Cams Enabled";
            this.TTSettingInfo.SetToolTip(this.CBJumpCamsEnabled4, "If the camera angle should change when going over a jump in the bonus game.");
            this.CBJumpCamsEnabled4.UseVisualStyleBackColor = true;
            this.CBJumpCamsEnabled4.CheckedChanged += new System.EventHandler(this.CBJumpCamsEnabled4_CheckedChanged);
            // 
            // LblPreferredFollowCam4
            // 
            this.LblPreferredFollowCam4.AutoSize = true;
            this.LblPreferredFollowCam4.Location = new System.Drawing.Point(6, 62);
            this.LblPreferredFollowCam4.Name = "LblPreferredFollowCam4";
            this.LblPreferredFollowCam4.Size = new System.Drawing.Size(110, 13);
            this.LblPreferredFollowCam4.TabIndex = 0;
            this.LblPreferredFollowCam4.Text = "Preferred Follow Cam:";
            this.TTSettingInfo.SetToolTip(this.LblPreferredFollowCam4, "The preferred/default camera angle in the bonus game.");
            // 
            // GBSuperCamCentral3
            // 
            this.GBSuperCamCentral3.Controls.Add(this.CBPreferredFollowCam3);
            this.GBSuperCamCentral3.Controls.Add(this.CBIsInvertedCameraEnabled3);
            this.GBSuperCamCentral3.Controls.Add(this.CBJumpCamsEnabled3);
            this.GBSuperCamCentral3.Controls.Add(this.LblPreferredFollowCam3);
            this.GBSuperCamCentral3.Location = new System.Drawing.Point(8, 117);
            this.GBSuperCamCentral3.Name = "GBSuperCamCentral3";
            this.GBSuperCamCentral3.Size = new System.Drawing.Size(275, 108);
            this.GBSuperCamCentral3.TabIndex = 5;
            this.GBSuperCamCentral3.TabStop = false;
            this.GBSuperCamCentral3.Text = "Super Cam Central 3";
            // 
            // CBPreferredFollowCam3
            // 
            this.CBPreferredFollowCam3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBPreferredFollowCam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPreferredFollowCam3.FormattingEnabled = true;
            this.CBPreferredFollowCam3.Location = new System.Drawing.Point(9, 78);
            this.CBPreferredFollowCam3.Name = "CBPreferredFollowCam3";
            this.CBPreferredFollowCam3.Size = new System.Drawing.Size(260, 21);
            this.CBPreferredFollowCam3.TabIndex = 3;
            this.TTSettingInfo.SetToolTip(this.CBPreferredFollowCam3, "The preferred/default camera angle in the bonus game.");
            this.CBPreferredFollowCam3.SelectedIndexChanged += new System.EventHandler(this.CBPreferredFollowCam3_SelectedIndexChanged);
            // 
            // CBIsInvertedCameraEnabled3
            // 
            this.CBIsInvertedCameraEnabled3.AutoSize = true;
            this.CBIsInvertedCameraEnabled3.Location = new System.Drawing.Point(9, 42);
            this.CBIsInvertedCameraEnabled3.Name = "CBIsInvertedCameraEnabled3";
            this.CBIsInvertedCameraEnabled3.Size = new System.Drawing.Size(157, 17);
            this.CBIsInvertedCameraEnabled3.TabIndex = 2;
            this.CBIsInvertedCameraEnabled3.Text = "Is Inverted Camera Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsInvertedCameraEnabled3, "If the camera should be inverted when using first person camera in the bonus game" +
        ".");
            this.CBIsInvertedCameraEnabled3.UseVisualStyleBackColor = true;
            this.CBIsInvertedCameraEnabled3.CheckedChanged += new System.EventHandler(this.CBIsInvertedCameraEnabled3_CheckedChanged);
            // 
            // CBJumpCamsEnabled3
            // 
            this.CBJumpCamsEnabled3.AutoSize = true;
            this.CBJumpCamsEnabled3.Location = new System.Drawing.Point(9, 19);
            this.CBJumpCamsEnabled3.Name = "CBJumpCamsEnabled3";
            this.CBJumpCamsEnabled3.Size = new System.Drawing.Size(122, 17);
            this.CBJumpCamsEnabled3.TabIndex = 1;
            this.CBJumpCamsEnabled3.Text = "Jump Cams Enabled";
            this.TTSettingInfo.SetToolTip(this.CBJumpCamsEnabled3, "If the camera angle should change when going over a jump in the bonus game.");
            this.CBJumpCamsEnabled3.UseVisualStyleBackColor = true;
            this.CBJumpCamsEnabled3.CheckedChanged += new System.EventHandler(this.CBJumpCamsEnabled3_CheckedChanged);
            // 
            // LblPreferredFollowCam3
            // 
            this.LblPreferredFollowCam3.AutoSize = true;
            this.LblPreferredFollowCam3.Location = new System.Drawing.Point(6, 62);
            this.LblPreferredFollowCam3.Name = "LblPreferredFollowCam3";
            this.LblPreferredFollowCam3.Size = new System.Drawing.Size(110, 13);
            this.LblPreferredFollowCam3.TabIndex = 0;
            this.LblPreferredFollowCam3.Text = "Preferred Follow Cam:";
            this.TTSettingInfo.SetToolTip(this.LblPreferredFollowCam3, "The preferred/default camera angle in the bonus game.");
            // 
            // GBSuperCamCentral2
            // 
            this.GBSuperCamCentral2.Controls.Add(this.CBPreferredFollowCam2);
            this.GBSuperCamCentral2.Controls.Add(this.CBIsInvertedCameraEnabled2);
            this.GBSuperCamCentral2.Controls.Add(this.CBJumpCamsEnabled2);
            this.GBSuperCamCentral2.Controls.Add(this.LblPreferredFollowCam2);
            this.GBSuperCamCentral2.Location = new System.Drawing.Point(292, 3);
            this.GBSuperCamCentral2.Name = "GBSuperCamCentral2";
            this.GBSuperCamCentral2.Size = new System.Drawing.Size(275, 108);
            this.GBSuperCamCentral2.TabIndex = 4;
            this.GBSuperCamCentral2.TabStop = false;
            this.GBSuperCamCentral2.Text = "Super Cam Central 2";
            // 
            // CBPreferredFollowCam2
            // 
            this.CBPreferredFollowCam2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBPreferredFollowCam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPreferredFollowCam2.FormattingEnabled = true;
            this.CBPreferredFollowCam2.Location = new System.Drawing.Point(9, 78);
            this.CBPreferredFollowCam2.Name = "CBPreferredFollowCam2";
            this.CBPreferredFollowCam2.Size = new System.Drawing.Size(260, 21);
            this.CBPreferredFollowCam2.TabIndex = 3;
            this.TTSettingInfo.SetToolTip(this.CBPreferredFollowCam2, "The preferred/default camera angle in the bonus game.");
            this.CBPreferredFollowCam2.SelectedIndexChanged += new System.EventHandler(this.CBPreferredFollowCam2_SelectedIndexChanged);
            // 
            // CBIsInvertedCameraEnabled2
            // 
            this.CBIsInvertedCameraEnabled2.AutoSize = true;
            this.CBIsInvertedCameraEnabled2.Location = new System.Drawing.Point(9, 42);
            this.CBIsInvertedCameraEnabled2.Name = "CBIsInvertedCameraEnabled2";
            this.CBIsInvertedCameraEnabled2.Size = new System.Drawing.Size(157, 17);
            this.CBIsInvertedCameraEnabled2.TabIndex = 2;
            this.CBIsInvertedCameraEnabled2.Text = "Is Inverted Camera Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsInvertedCameraEnabled2, "If the camera should be inverted when using first person camera in the bonus game" +
        ".");
            this.CBIsInvertedCameraEnabled2.UseVisualStyleBackColor = true;
            this.CBIsInvertedCameraEnabled2.CheckedChanged += new System.EventHandler(this.CBIsInvertedCameraEnabled2_CheckedChanged);
            // 
            // CBJumpCamsEnabled2
            // 
            this.CBJumpCamsEnabled2.AutoSize = true;
            this.CBJumpCamsEnabled2.Location = new System.Drawing.Point(9, 19);
            this.CBJumpCamsEnabled2.Name = "CBJumpCamsEnabled2";
            this.CBJumpCamsEnabled2.Size = new System.Drawing.Size(122, 17);
            this.CBJumpCamsEnabled2.TabIndex = 1;
            this.CBJumpCamsEnabled2.Text = "Jump Cams Enabled";
            this.TTSettingInfo.SetToolTip(this.CBJumpCamsEnabled2, "If the camera angle should change when going over a jump in the bonus game.");
            this.CBJumpCamsEnabled2.UseVisualStyleBackColor = true;
            this.CBJumpCamsEnabled2.CheckedChanged += new System.EventHandler(this.CBJumpCamsEnabled2_CheckedChanged);
            // 
            // LblPreferredFollowCam2
            // 
            this.LblPreferredFollowCam2.AutoSize = true;
            this.LblPreferredFollowCam2.Location = new System.Drawing.Point(6, 62);
            this.LblPreferredFollowCam2.Name = "LblPreferredFollowCam2";
            this.LblPreferredFollowCam2.Size = new System.Drawing.Size(110, 13);
            this.LblPreferredFollowCam2.TabIndex = 0;
            this.LblPreferredFollowCam2.Text = "Preferred Follow Cam:";
            this.TTSettingInfo.SetToolTip(this.LblPreferredFollowCam2, "The preferred/default camera angle in the bonus game.");
            // 
            // GBSuperCamCentral1
            // 
            this.GBSuperCamCentral1.Controls.Add(this.CBPreferredFollowCam1);
            this.GBSuperCamCentral1.Controls.Add(this.CBIsInvertedCameraEnabled1);
            this.GBSuperCamCentral1.Controls.Add(this.CBJumpCamsEnabled1);
            this.GBSuperCamCentral1.Controls.Add(this.LblPreferredFollowCam1);
            this.GBSuperCamCentral1.Location = new System.Drawing.Point(8, 3);
            this.GBSuperCamCentral1.Name = "GBSuperCamCentral1";
            this.GBSuperCamCentral1.Size = new System.Drawing.Size(275, 108);
            this.GBSuperCamCentral1.TabIndex = 0;
            this.GBSuperCamCentral1.TabStop = false;
            this.GBSuperCamCentral1.Text = "Super Cam Central 1";
            // 
            // CBPreferredFollowCam1
            // 
            this.CBPreferredFollowCam1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBPreferredFollowCam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPreferredFollowCam1.FormattingEnabled = true;
            this.CBPreferredFollowCam1.Location = new System.Drawing.Point(9, 78);
            this.CBPreferredFollowCam1.Name = "CBPreferredFollowCam1";
            this.CBPreferredFollowCam1.Size = new System.Drawing.Size(260, 21);
            this.CBPreferredFollowCam1.TabIndex = 3;
            this.TTSettingInfo.SetToolTip(this.CBPreferredFollowCam1, "The preferred/default camera angle in the bonus game.");
            this.CBPreferredFollowCam1.SelectedIndexChanged += new System.EventHandler(this.CBPreferredFollowCam1_SelectedIndexChanged);
            // 
            // CBIsInvertedCameraEnabled1
            // 
            this.CBIsInvertedCameraEnabled1.AutoSize = true;
            this.CBIsInvertedCameraEnabled1.Location = new System.Drawing.Point(9, 42);
            this.CBIsInvertedCameraEnabled1.Name = "CBIsInvertedCameraEnabled1";
            this.CBIsInvertedCameraEnabled1.Size = new System.Drawing.Size(157, 17);
            this.CBIsInvertedCameraEnabled1.TabIndex = 2;
            this.CBIsInvertedCameraEnabled1.Text = "Is Inverted Camera Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsInvertedCameraEnabled1, "If the camera should be inverted when using first person camera in the bonus game" +
        ".");
            this.CBIsInvertedCameraEnabled1.UseVisualStyleBackColor = true;
            this.CBIsInvertedCameraEnabled1.CheckedChanged += new System.EventHandler(this.CBIsInvertedCameraEnabled1_CheckedChanged);
            // 
            // CBJumpCamsEnabled1
            // 
            this.CBJumpCamsEnabled1.AutoSize = true;
            this.CBJumpCamsEnabled1.Location = new System.Drawing.Point(9, 19);
            this.CBJumpCamsEnabled1.Name = "CBJumpCamsEnabled1";
            this.CBJumpCamsEnabled1.Size = new System.Drawing.Size(122, 17);
            this.CBJumpCamsEnabled1.TabIndex = 1;
            this.CBJumpCamsEnabled1.Text = "Jump Cams Enabled";
            this.TTSettingInfo.SetToolTip(this.CBJumpCamsEnabled1, "If the camera angle should change when going over a jump in the bonus game.");
            this.CBJumpCamsEnabled1.UseVisualStyleBackColor = true;
            this.CBJumpCamsEnabled1.CheckedChanged += new System.EventHandler(this.CBJumpCamsEnabled1_CheckedChanged);
            // 
            // LblPreferredFollowCam1
            // 
            this.LblPreferredFollowCam1.AutoSize = true;
            this.LblPreferredFollowCam1.Location = new System.Drawing.Point(6, 62);
            this.LblPreferredFollowCam1.Name = "LblPreferredFollowCam1";
            this.LblPreferredFollowCam1.Size = new System.Drawing.Size(110, 13);
            this.LblPreferredFollowCam1.TabIndex = 0;
            this.LblPreferredFollowCam1.Text = "Preferred Follow Cam:";
            this.TTSettingInfo.SetToolTip(this.LblPreferredFollowCam1, "The preferred/default camera angle in the bonus game.");
            // 
            // TPTutorialManager
            // 
            this.TPTutorialManager.Controls.Add(this.CLBTutorialsSeen);
            this.TPTutorialManager.Controls.Add(this.LblTutorialsSeen);
            this.TPTutorialManager.Controls.Add(this.CBEnableTutorialEvents);
            this.TPTutorialManager.Location = new System.Drawing.Point(4, 22);
            this.TPTutorialManager.Name = "TPTutorialManager";
            this.TPTutorialManager.Size = new System.Drawing.Size(776, 411);
            this.TPTutorialManager.TabIndex = 5;
            this.TPTutorialManager.Text = "Tutorial Manager";
            this.TPTutorialManager.UseVisualStyleBackColor = true;
            // 
            // CLBTutorialsSeen
            // 
            this.CLBTutorialsSeen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBTutorialsSeen.FormattingEnabled = true;
            this.CLBTutorialsSeen.Location = new System.Drawing.Point(12, 39);
            this.CLBTutorialsSeen.Name = "CLBTutorialsSeen";
            this.CLBTutorialsSeen.Size = new System.Drawing.Size(275, 364);
            this.CLBTutorialsSeen.TabIndex = 3;
            this.TTSettingInfo.SetToolTip(this.CLBTutorialsSeen, "The different tutorials available.");
            this.CLBTutorialsSeen.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBTutorialsSeen_ItemCheck);
            // 
            // LblTutorialsSeen
            // 
            this.LblTutorialsSeen.AutoSize = true;
            this.LblTutorialsSeen.Location = new System.Drawing.Point(9, 23);
            this.LblTutorialsSeen.Name = "LblTutorialsSeen";
            this.LblTutorialsSeen.Size = new System.Drawing.Size(78, 13);
            this.LblTutorialsSeen.TabIndex = 2;
            this.LblTutorialsSeen.Text = "Tutorials Seen:";
            this.TTSettingInfo.SetToolTip(this.LblTutorialsSeen, "The different tutorials available.");
            // 
            // CBEnableTutorialEvents
            // 
            this.CBEnableTutorialEvents.AutoSize = true;
            this.CBEnableTutorialEvents.Location = new System.Drawing.Point(12, 3);
            this.CBEnableTutorialEvents.Name = "CBEnableTutorialEvents";
            this.CBEnableTutorialEvents.Size = new System.Drawing.Size(133, 17);
            this.CBEnableTutorialEvents.TabIndex = 1;
            this.CBEnableTutorialEvents.Text = "Enable Tutorial Events";
            this.TTSettingInfo.SetToolTip(this.CBEnableTutorialEvents, "Should the tutorial events be shown.");
            this.CBEnableTutorialEvents.UseVisualStyleBackColor = true;
            this.CBEnableTutorialEvents.CheckedChanged += new System.EventHandler(this.CBEnableTutorialEvents_CheckedChanged);
            // 
            // TPGUISystem
            // 
            this.TPGUISystem.Controls.Add(this.CBIsRadarEnabled);
            this.TPGUISystem.Location = new System.Drawing.Point(4, 22);
            this.TPGUISystem.Name = "TPGUISystem";
            this.TPGUISystem.Size = new System.Drawing.Size(776, 411);
            this.TPGUISystem.TabIndex = 6;
            this.TPGUISystem.Text = "GUI System";
            this.TPGUISystem.UseVisualStyleBackColor = true;
            // 
            // CBIsRadarEnabled
            // 
            this.CBIsRadarEnabled.AutoSize = true;
            this.CBIsRadarEnabled.Location = new System.Drawing.Point(12, 3);
            this.CBIsRadarEnabled.Name = "CBIsRadarEnabled";
            this.CBIsRadarEnabled.Size = new System.Drawing.Size(108, 17);
            this.CBIsRadarEnabled.TabIndex = 1;
            this.CBIsRadarEnabled.Text = "Is Radar Enabled";
            this.TTSettingInfo.SetToolTip(this.CBIsRadarEnabled, "If the radar should be shown in-game.");
            this.CBIsRadarEnabled.UseVisualStyleBackColor = true;
            this.CBIsRadarEnabled.CheckedChanged += new System.EventHandler(this.CBIsRadarEnabled_CheckedChanged);
            // 
            // TPCardGallery
            // 
            this.TPCardGallery.Controls.Add(this.CLBCollectedCardIDs);
            this.TPCardGallery.Controls.Add(this.LblCollectedCardIDs);
            this.TPCardGallery.Location = new System.Drawing.Point(4, 22);
            this.TPCardGallery.Name = "TPCardGallery";
            this.TPCardGallery.Size = new System.Drawing.Size(776, 411);
            this.TPCardGallery.TabIndex = 7;
            this.TPCardGallery.Text = "Card Gallery";
            this.TPCardGallery.UseVisualStyleBackColor = true;
            // 
            // CLBCollectedCardIDs
            // 
            this.CLBCollectedCardIDs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLBCollectedCardIDs.ContextMenuStrip = this.CMSCheckedListBox;
            this.CLBCollectedCardIDs.FormattingEnabled = true;
            this.CLBCollectedCardIDs.Location = new System.Drawing.Point(12, 20);
            this.CLBCollectedCardIDs.Name = "CLBCollectedCardIDs";
            this.CLBCollectedCardIDs.Size = new System.Drawing.Size(275, 379);
            this.CLBCollectedCardIDs.TabIndex = 4;
            this.TTSettingInfo.SetToolTip(this.CLBCollectedCardIDs, "A list of all cards available in the game.\r\nThe names in brackets are the vanilla" +
        " card names.");
            this.CLBCollectedCardIDs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBCollectedCardIDs_ItemCheck);
            // 
            // LblCollectedCardIDs
            // 
            this.LblCollectedCardIDs.AutoSize = true;
            this.LblCollectedCardIDs.Location = new System.Drawing.Point(9, 4);
            this.LblCollectedCardIDs.Name = "LblCollectedCardIDs";
            this.LblCollectedCardIDs.Size = new System.Drawing.Size(98, 13);
            this.LblCollectedCardIDs.TabIndex = 0;
            this.LblCollectedCardIDs.Text = "Collected Card IDs:";
            this.TTSettingInfo.SetToolTip(this.LblCollectedCardIDs, "A list of all cards available in the game.\r\nThe names in brackets are the vanilla" +
        " card names.");
            // 
            // TPCustomSaveData
            // 
            this.TPCustomSaveData.Controls.Add(this.LblCustomSaveDataLength);
            this.TPCustomSaveData.Controls.Add(this.LblCustomSaveData);
            this.TPCustomSaveData.Location = new System.Drawing.Point(4, 22);
            this.TPCustomSaveData.Name = "TPCustomSaveData";
            this.TPCustomSaveData.Size = new System.Drawing.Size(776, 411);
            this.TPCustomSaveData.TabIndex = 8;
            this.TPCustomSaveData.Text = "Custom Save Data";
            this.TPCustomSaveData.UseVisualStyleBackColor = true;
            // 
            // LblCustomSaveDataLength
            // 
            this.LblCustomSaveDataLength.AutoSize = true;
            this.LblCustomSaveDataLength.Location = new System.Drawing.Point(9, 19);
            this.LblCustomSaveDataLength.Name = "LblCustomSaveDataLength";
            this.LblCustomSaveDataLength.Size = new System.Drawing.Size(41, 13);
            this.LblCustomSaveDataLength.TabIndex = 1;
            this.LblCustomSaveDataLength.Text = "0 bytes";
            this.TTSettingInfo.SetToolTip(this.LblCustomSaveDataLength, "The custom save data added by Lucas\' Simpsons Hit & Run Mod Launcher.\r\nCurrently " +
        "just shows the size of the data, but a future update should add the functionalit" +
        "y to manipulate this data.");
            // 
            // LblCustomSaveData
            // 
            this.LblCustomSaveData.AutoSize = true;
            this.LblCustomSaveData.Location = new System.Drawing.Point(9, 4);
            this.LblCustomSaveData.Name = "LblCustomSaveData";
            this.LblCustomSaveData.Size = new System.Drawing.Size(99, 13);
            this.LblCustomSaveData.TabIndex = 0;
            this.LblCustomSaveData.Text = "Custom Save Data:";
            this.TTSettingInfo.SetToolTip(this.LblCustomSaveData, "The custom save data added by Lucas\' Simpsons Hit & Run Mod Launcher.\r\nCurrently " +
        "just shows the size of the data, but a future update should add the functionalit" +
        "y to manipulate this data.");
            // 
            // CHPersistentObjectStatesIndex
            // 
            this.CHPersistentObjectStatesIndex.Text = "Index";
            // 
            // CHPersistentObjectStatesValue
            // 
            this.CHPersistentObjectStatesValue.Text = "Value";
            // 
            // TTSettingInfo
            // 
            this.TTSettingInfo.AutoPopDelay = 25000;
            this.TTSettingInfo.InitialDelay = 500;
            this.TTSettingInfo.ReshowDelay = 100;
            this.TTSettingInfo.ShowAlways = true;
            this.TTSettingInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TTSettingInfo.ToolTipTitle = "Setting information";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TCMain);
            this.Controls.Add(this.MSMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MSMain;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmMain";
            this.Text = "SHAR Save Game Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.TCMain.ResumeLayout(false);
            this.TPSaveGameInfo.ResumeLayout(false);
            this.TPSaveGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSaveSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSaveMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSaveHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDisplayMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDisplayLevel)).EndInit();
            this.TPInputManager.ResumeLayout(false);
            this.TPInputManager.PerformLayout();
            this.TPCharacterSheet.ResumeLayout(false);
            this.TCCharacterSheet.ResumeLayout(false);
            this.TPCharacterSheetMiscellaneous.ResumeLayout(false);
            this.TPCharacterSheetMiscellaneous.PerformLayout();
            this.CMSCheckedListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCoins)).EndInit();
            this.TPCharacterSheetLevels.ResumeLayout(false);
            this.TCCharacterSheetLevels.ResumeLayout(false);
            this.TPCharacterSheetLevel1.ResumeLayout(false);
            this.TCCharacterSheetLevel1.ResumeLayout(false);
            this.TPCharacterSheetLevel1Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel1Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel1Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel1Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel1NumAttempts)).EndInit();
            this.TPCharacterSheetLevel1Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel1Cards.PerformLayout();
            this.TPCharacterSheetLevel2.ResumeLayout(false);
            this.TCCharacterSheetLevel2.ResumeLayout(false);
            this.TPCharacterSheetLevel2Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel2Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel2Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel2Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel2NumAttempts)).EndInit();
            this.TPCharacterSheetLevel2Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel2Cards.PerformLayout();
            this.TPCharacterSheetLevel3.ResumeLayout(false);
            this.TCCharacterSheetLevel3.ResumeLayout(false);
            this.TPCharacterSheetLevel3Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel3Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel3Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel3Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel3NumAttempts)).EndInit();
            this.TPCharacterSheetLevel3Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel3Cards.PerformLayout();
            this.TPCharacterSheetLevel4.ResumeLayout(false);
            this.TCCharacterSheetLevel4.ResumeLayout(false);
            this.TPCharacterSheetLevel4Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel4Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel4Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel4Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel4NumAttempts)).EndInit();
            this.TPCharacterSheetLevel4Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel4Cards.PerformLayout();
            this.TPCharacterSheetLevel5.ResumeLayout(false);
            this.TCCharacterSheetLevel5.ResumeLayout(false);
            this.TPCharacterSheetLevel5Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel5Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel5Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel5Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel5NumAttempts)).EndInit();
            this.TPCharacterSheetLevel5Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel5Cards.PerformLayout();
            this.TPCharacterSheetLevel6.ResumeLayout(false);
            this.TCCharacterSheetLevel6.ResumeLayout(false);
            this.TPCharacterSheetLevel6Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel6Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel6Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel6Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel6NumAttempts)).EndInit();
            this.TPCharacterSheetLevel6Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel6Cards.PerformLayout();
            this.TPCharacterSheetLevel7.ResumeLayout(false);
            this.TCCharacterSheetLevel7.ResumeLayout(false);
            this.TPCharacterSheetLevel7Miscellaneous.ResumeLayout(false);
            this.TPCharacterSheetLevel7Miscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7WaspsDestroyed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7NumSkinsPurchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7NumCarsPurchased)).EndInit();
            this.TPCharacterSheetLevel7Missions.ResumeLayout(false);
            this.TPCharacterSheetLevel7Missions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7BestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLevel7NumAttempts)).EndInit();
            this.TPCharacterSheetLevel7Cards.ResumeLayout(false);
            this.TPCharacterSheetLevel7Cards.PerformLayout();
            this.TPCharacterSheetCars.ResumeLayout(false);
            this.TPCharacterSheetCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCounter)).EndInit();
            this.GBCars.ResumeLayout(false);
            this.GBCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMaxHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCurrentHealth)).EndInit();
            this.TPSoundSettings.ResumeLayout(false);
            this.TPSoundSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBDialogVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSFXVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMusicVolume)).EndInit();
            this.TPSuperCamCentral.ResumeLayout(false);
            this.GBSuperCamCentral4.ResumeLayout(false);
            this.GBSuperCamCentral4.PerformLayout();
            this.GBSuperCamCentral3.ResumeLayout(false);
            this.GBSuperCamCentral3.PerformLayout();
            this.GBSuperCamCentral2.ResumeLayout(false);
            this.GBSuperCamCentral2.PerformLayout();
            this.GBSuperCamCentral1.ResumeLayout(false);
            this.GBSuperCamCentral1.PerformLayout();
            this.TPTutorialManager.ResumeLayout(false);
            this.TPTutorialManager.PerformLayout();
            this.TPGUISystem.ResumeLayout(false);
            this.TPGUISystem.PerformLayout();
            this.TPCardGallery.ResumeLayout(false);
            this.TPCardGallery.PerformLayout();
            this.TPCustomSaveData.ResumeLayout(false);
            this.TPCustomSaveData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem TSMIFile;
        private System.Windows.Forms.ToolStripMenuItem TSMINew;
        private System.Windows.Forms.ToolStripMenuItem TSMIOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMISave;
        private System.Windows.Forms.ToolStripMenuItem TSMISaveAs;
        private System.Windows.Forms.ToolStripSeparator TSS1;
        private System.Windows.Forms.ToolStripMenuItem TSMIExit;
        private System.Windows.Forms.TabControl TCMain;
        private System.Windows.Forms.TabPage TPSaveGameInfo;
        private System.Windows.Forms.TabPage TPInputManager;
        private System.Windows.Forms.TabPage TPCharacterSheet;
        private System.Windows.Forms.TabPage TPSoundSettings;
        private System.Windows.Forms.TabPage TPSuperCamCentral;
        private System.Windows.Forms.TabPage TPTutorialManager;
        private System.Windows.Forms.TabPage TPGUISystem;
        private System.Windows.Forms.TabPage TPCardGallery;
        private System.Windows.Forms.TabPage TPCustomSaveData;
        private System.Windows.Forms.Label LblSaveDate;
        private System.Windows.Forms.DateTimePicker DTPSaveDate;
        private System.Windows.Forms.CheckBox CBAutoSaveDate;
        private System.Windows.Forms.NumericUpDown NUDDisplayMission;
        private System.Windows.Forms.Label LblDisplayMission;
        private System.Windows.Forms.NumericUpDown NUDDisplayLevel;
        private System.Windows.Forms.Label LblDisplayLevel;
        private System.Windows.Forms.CheckBox CBIsRumbleEnabled;
        private System.Windows.Forms.Label LblMusicVolume;
        private System.Windows.Forms.TrackBar TBMusicVolume;
        private System.Windows.Forms.Label LblMusicVolumeValue;
        private System.Windows.Forms.TrackBar TBSFXVolume;
        private System.Windows.Forms.Label LblSFXVolumeValue;
        private System.Windows.Forms.Label LblSFXVolume;
        private System.Windows.Forms.TrackBar TBDialogVolume;
        private System.Windows.Forms.Label LblDialogVolumeValue;
        private System.Windows.Forms.Label LblDialogVolume;
        private System.Windows.Forms.TrackBar TBCarVolume;
        private System.Windows.Forms.Label LblCarVolumeValue;
        private System.Windows.Forms.Label LblCarVolume;
        private System.Windows.Forms.GroupBox GBSuperCamCentral1;
        private System.Windows.Forms.Label LblPreferredFollowCam1;
        private System.Windows.Forms.CheckBox CBIsInvertedCameraEnabled1;
        private System.Windows.Forms.CheckBox CBJumpCamsEnabled1;
        private System.Windows.Forms.ComboBox CBPreferredFollowCam1;
        private System.Windows.Forms.GroupBox GBSuperCamCentral4;
        private System.Windows.Forms.ComboBox CBPreferredFollowCam4;
        private System.Windows.Forms.CheckBox CBIsInvertedCameraEnabled4;
        private System.Windows.Forms.CheckBox CBJumpCamsEnabled4;
        private System.Windows.Forms.Label LblPreferredFollowCam4;
        private System.Windows.Forms.GroupBox GBSuperCamCentral3;
        private System.Windows.Forms.ComboBox CBPreferredFollowCam3;
        private System.Windows.Forms.CheckBox CBIsInvertedCameraEnabled3;
        private System.Windows.Forms.CheckBox CBJumpCamsEnabled3;
        private System.Windows.Forms.Label LblPreferredFollowCam3;
        private System.Windows.Forms.GroupBox GBSuperCamCentral2;
        private System.Windows.Forms.ComboBox CBPreferredFollowCam2;
        private System.Windows.Forms.CheckBox CBIsInvertedCameraEnabled2;
        private System.Windows.Forms.CheckBox CBJumpCamsEnabled2;
        private System.Windows.Forms.Label LblPreferredFollowCam2;
        private System.Windows.Forms.CheckBox CBEnableTutorialEvents;
        private System.Windows.Forms.CheckedListBox CLBTutorialsSeen;
        private System.Windows.Forms.Label LblTutorialsSeen;
        private System.Windows.Forms.CheckBox CBIsRadarEnabled;
        private System.Windows.Forms.CheckedListBox CLBCollectedCardIDs;
        private System.Windows.Forms.Label LblCollectedCardIDs;
        private System.Windows.Forms.Label LblCustomSaveDataLength;
        private System.Windows.Forms.Label LblCustomSaveData;
        private System.Windows.Forms.CheckBox CBIsSurround;
        private System.Windows.Forms.TabControl TCCharacterSheet;
        private System.Windows.Forms.TabPage TPCharacterSheetMiscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevels;
        private System.Windows.Forms.TabControl TCCharacterSheetLevels;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel1;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel2;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel3;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel4;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel5;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel6;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel7;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Label LblCurrentMissionInfo;
        private System.Windows.Forms.ComboBox CBCurrentMissionInfoMission;
        private System.Windows.Forms.ComboBox CBCurrentMissionInfoLevel;
        private System.Windows.Forms.ComboBox CBHighestMissionInfoMission;
        private System.Windows.Forms.ComboBox CBHighestMissionInfoLevel;
        private System.Windows.Forms.Label LblHighestMissionInfo;
        private System.Windows.Forms.CheckBox CBIsNavSystemEnabled;
        private System.Windows.Forms.NumericUpDown NUDCoins;
        private System.Windows.Forms.Label LblCoins;
        private System.Windows.Forms.CheckBox CBItchyScratchyTicket;
        private System.Windows.Forms.CheckBox CBItchyScratchyCBGFirst;
        private System.Windows.Forms.ColumnHeader CHPersistentObjectStatesIndex;
        private System.Windows.Forms.ColumnHeader CHPersistentObjectStatesValue;
        private System.Windows.Forms.TabPage TPCharacterSheetCars;
        private System.Windows.Forms.NumericUpDown NUDCounter;
        private System.Windows.Forms.Label LblCounter;
        private System.Windows.Forms.GroupBox GBCars;
        private System.Windows.Forms.ListBox LBCars;
        private System.Windows.Forms.NumericUpDown NUDMaxHealth;
        private System.Windows.Forms.Label LblMaxHealth;
        private System.Windows.Forms.NumericUpDown NUDCurrentHealth;
        private System.Windows.Forms.Label LblCurrentHealth;
        private System.Windows.Forms.TextBox TxtCarName;
        private System.Windows.Forms.Label LblCarName;
        private System.Windows.Forms.Label LblPersistentObjectStates;
        private System.Windows.Forms.CheckedListBox CLBPersistentObjectStates;
        private System.Windows.Forms.ContextMenuStrip CMSCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem TSMISelectAll;
        private System.Windows.Forms.ToolStripMenuItem TSMIDeselectAll;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel1;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel1Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel1Missions;
        private System.Windows.Forms.CheckBox CBLevel1FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel1NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel1NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel1NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel1NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel1WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel1WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel1CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel1CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel1Gags;
        private System.Windows.Forms.Label LblLevel1Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel1PurchasedRewards;
        private System.Windows.Forms.Label LblLevel1PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel1Missions;
        private System.Windows.Forms.TextBox TxtLevel1MissionName;
        private System.Windows.Forms.Label LblLevel1MissionName;
        private System.Windows.Forms.CheckBox CBLevel1BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel1Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel1NumAttempts;
        private System.Windows.Forms.Label LblLevel1NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel1BestTime;
        private System.Windows.Forms.Label LblLevel1BestTime;
        private System.Windows.Forms.CheckBox CBLevel1SkippedMission;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel2;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel2Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel2Missions;
        private System.Windows.Forms.CheckBox CBLevel2FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel2NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel2NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel2NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel2NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel2WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel2WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel2CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel2CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel2Gags;
        private System.Windows.Forms.Label LblLevel2Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel2PurchasedRewards;
        private System.Windows.Forms.Label LblLevel2PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel2Missions;
        private System.Windows.Forms.TextBox TxtLevel2MissionName;
        private System.Windows.Forms.Label LblLevel2MissionName;
        private System.Windows.Forms.CheckBox CBLevel2BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel2Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel2NumAttempts;
        private System.Windows.Forms.Label LblLevel2NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel2BestTime;
        private System.Windows.Forms.Label LblLevel2BestTime;
        private System.Windows.Forms.CheckBox CBLevel2SkippedMission;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel3;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel3Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel3Missions;
        private System.Windows.Forms.CheckBox CBLevel3FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel3NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel3NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel3NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel3NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel3WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel3WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel3CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel3CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel3Gags;
        private System.Windows.Forms.Label LblLevel3Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel3PurchasedRewards;
        private System.Windows.Forms.Label LblLevel3PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel3Missions;
        private System.Windows.Forms.TextBox TxtLevel3MissionName;
        private System.Windows.Forms.Label LblLevel3MissionName;
        private System.Windows.Forms.CheckBox CBLevel3BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel3Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel3NumAttempts;
        private System.Windows.Forms.Label LblLevel3NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel3BestTime;
        private System.Windows.Forms.Label LblLevel3BestTime;
        private System.Windows.Forms.CheckBox CBLevel3SkippedMission;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel4;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel4Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel4Missions;
        private System.Windows.Forms.CheckBox CBLevel4FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel4NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel4NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel4NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel4NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel4WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel4WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel4CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel4CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel4Gags;
        private System.Windows.Forms.Label LblLevel4Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel4PurchasedRewards;
        private System.Windows.Forms.Label LblLevel4PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel4Missions;
        private System.Windows.Forms.TextBox TxtLevel4MissionName;
        private System.Windows.Forms.Label LblLevel4MissionName;
        private System.Windows.Forms.CheckBox CBLevel4BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel4Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel4NumAttempts;
        private System.Windows.Forms.Label LblLevel4NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel4BestTime;
        private System.Windows.Forms.Label LblLevel4BestTime;
        private System.Windows.Forms.CheckBox CBLevel4SkippedMission;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel5;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel5Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel5Missions;
        private System.Windows.Forms.CheckBox CBLevel5FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel5NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel5NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel5NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel5NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel5WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel5WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel5CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel5CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel5Gags;
        private System.Windows.Forms.Label LblLevel5Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel5PurchasedRewards;
        private System.Windows.Forms.Label LblLevel5PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel5Missions;
        private System.Windows.Forms.TextBox TxtLevel5MissionName;
        private System.Windows.Forms.Label LblLevel5MissionName;
        private System.Windows.Forms.CheckBox CBLevel5BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel5Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel5NumAttempts;
        private System.Windows.Forms.Label LblLevel5NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel5BestTime;
        private System.Windows.Forms.Label LblLevel5BestTime;
        private System.Windows.Forms.CheckBox CBLevel5SkippedMission;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel6;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel6Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel6Missions;
        private System.Windows.Forms.CheckBox CBLevel6FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel6NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel6NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel6NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel6NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel6WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel6WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel6CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel6CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel6Gags;
        private System.Windows.Forms.Label LblLevel6Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel6PurchasedRewards;
        private System.Windows.Forms.Label LblLevel6PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel6Missions;
        private System.Windows.Forms.TextBox TxtLevel6MissionName;
        private System.Windows.Forms.Label LblLevel6MissionName;
        private System.Windows.Forms.CheckBox CBLevel6BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel6Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel6NumAttempts;
        private System.Windows.Forms.Label LblLevel6NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel6BestTime;
        private System.Windows.Forms.Label LblLevel6BestTime;
        private System.Windows.Forms.CheckBox CBLevel6SkippedMission;
        private System.Windows.Forms.TabControl TCCharacterSheetLevel7;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel7Miscellaneous;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel7Missions;
        private System.Windows.Forms.CheckBox CBLevel7FMVUnlocked;
        private System.Windows.Forms.NumericUpDown NUDLevel7NumCarsPurchased;
        private System.Windows.Forms.Label LblLevel7NumCarsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel7NumSkinsPurchased;
        private System.Windows.Forms.Label LblLevel7NumSkinsPurchased;
        private System.Windows.Forms.NumericUpDown NUDLevel7WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel7WaspsDestroyed;
        private System.Windows.Forms.Label LblLevel7CurrentSkin;
        private System.Windows.Forms.ComboBox CBLevel7CurrentSkin;
        private System.Windows.Forms.CheckedListBox CLBLevel7Gags;
        private System.Windows.Forms.Label LblLevel7Gags;
        private System.Windows.Forms.CheckedListBox CLBLevel7PurchasedRewards;
        private System.Windows.Forms.Label LblLevel7PurchasedRewards;
        private System.Windows.Forms.ListBox LBLevel7Missions;
        private System.Windows.Forms.TextBox TxtLevel7MissionName;
        private System.Windows.Forms.Label LblLevel7MissionName;
        private System.Windows.Forms.CheckBox CBLevel7BonusObjective;
        private System.Windows.Forms.CheckBox CBLevel7Completed;
        private System.Windows.Forms.NumericUpDown NUDLevel7NumAttempts;
        private System.Windows.Forms.Label LblLevel7NumAttempts;
        private System.Windows.Forms.NumericUpDown NUDLevel7BestTime;
        private System.Windows.Forms.Label LblLevel7BestTime;
        private System.Windows.Forms.CheckBox CBLevel7SkippedMission;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel1Cards;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel2Cards;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel3Cards;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel4Cards;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel5Cards;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel6Cards;
        private System.Windows.Forms.TabPage TPCharacterSheetLevel7Cards;
        private System.Windows.Forms.CheckBox CBLevel1CardCollected;
        private System.Windows.Forms.TextBox TxtLevel1CardName;
        private System.Windows.Forms.Label LblLevel1CardName;
        private System.Windows.Forms.ListBox LBLevel1Cards;
        private System.Windows.Forms.CheckBox CBLevel2CardCollected;
        private System.Windows.Forms.TextBox TxtLevel2CardName;
        private System.Windows.Forms.Label LblLevel2CardName;
        private System.Windows.Forms.ListBox LBLevel2Cards;
        private System.Windows.Forms.CheckBox CBLevel3CardCollected;
        private System.Windows.Forms.TextBox TxtLevel3CardName;
        private System.Windows.Forms.Label LblLevel3CardName;
        private System.Windows.Forms.ListBox LBLevel3Cards;
        private System.Windows.Forms.CheckBox CBLevel4CardCollected;
        private System.Windows.Forms.TextBox TxtLevel4CardName;
        private System.Windows.Forms.Label LblLevel4CardName;
        private System.Windows.Forms.ListBox LBLevel4Cards;
        private System.Windows.Forms.CheckBox CBLevel5CardCollected;
        private System.Windows.Forms.TextBox TxtLevel5CardName;
        private System.Windows.Forms.Label LblLevel5CardName;
        private System.Windows.Forms.ListBox LBLevel5Cards;
        private System.Windows.Forms.CheckBox CBLevel6CardCollected;
        private System.Windows.Forms.TextBox TxtLevel6CardName;
        private System.Windows.Forms.Label LblLevel6CardName;
        private System.Windows.Forms.ListBox LBLevel6Cards;
        private System.Windows.Forms.CheckBox CBLevel7CardCollected;
        private System.Windows.Forms.TextBox TxtLevel7CardName;
        private System.Windows.Forms.Label LblLevel7CardName;
        private System.Windows.Forms.ListBox LBLevel7Cards;
        private System.Windows.Forms.ToolTip TTSettingInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDSaveHour;
        private System.Windows.Forms.Label LblSaveTime;
        private System.Windows.Forms.NumericUpDown NUDSaveSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDSaveMinute;
    }
}

