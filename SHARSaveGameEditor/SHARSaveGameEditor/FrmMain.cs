using System;
using System.IO;
using System.Windows.Forms;

namespace SHARSaveGameEditor
{
    public partial class FrmMain : Form
    {
        private SaveGame SaveGame = new SaveGame();
        private string LastPath = string.Empty;
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
                Text = value ? "SHAR Save Game Editor*" : "SHAR Save Game Editor";
            }
        }

        private static readonly string[] CardNames =
        {
            // Level 1
            "card11 (Home Made Football)",
            "card12 (Crab Juice)",
            "card13 (Insanity Pepper)",
            "card14 (Spinemelter 2000)",
            "card15 (Parchment)",
            "card16 (Carbon Rod)",
            "card17 (Mr. Sparkle Box)",
            "UNUSED",
            // Level 2
            "card21 (Head of Jebediah)",
            "card22 (AM Radio Toy)",
            "card23 (Bonestorm Game)",
            "card24 (\"Big Butt Skinner\")",
            "card25 (Mr. Honeybunny)",
            "card26 (Drivers License)",
            "card27 (Pregnancy Test)",
            "UNUSED",
            // Level 3
            "card31 (Angel Skeleton)",
            "card32 (Bart's Soul)",
            "card33 (Lisa Lionheart)",
            "card34 (Lisa's Valentine)",
            "card35 (Lisa's Machine)",
            "card36 (Evil Braces)",
            "card37 (Soy Pop)",
            "UNUSED",
            // Level 4
            "card41 (Mr. Plow Jacket)",
            "card42 (Burns Portrait)",
            "card43 (Love Letter)",
            "card44 (\"Homer\" Bowling Ball)",
            "card45 (Red Blazer)",
            "card46 (Boudoir Album)",
            "card47 (Pepper Spray)",
            "UNUSED",
            // Level 5
            "card51 (Apu's T-Shirt)",
            "card52 (Pin Pals Shirt)",
            "card53 (Prop 24 Sign)",
            "card54 (Baby Feeder)",
            "card55 (Ganesh Costume)",
            "card56 (Chutney Squishee)",
            "card57 (Hot Dog)",
            "UNUSED",
            // Level 6
            "card61 (Radioactive Man#1)",
            "card62 (\"BORT\" License Plate)",
            "card63 (Bart T-Shirt)",
            "card64 (Australia Boot)",
            "card65 (Itchy and Scratchy Cel)",
            "card66 (Garbo Doll)",
            "card67 (Bart's Flying Hamster Science Project)",
            "UNUSED",
            // Level 7
            "card71 (Soul Donut)",
            "card72 (Krusty Doll)",
            "card73 (Human Cookbook)",
            "card74 (Time Travel Toaster)",
            "card75 (Hell Toupee)",
            "card76 (Monkey's Paw)",
            "card77 (\"Smarch\" Calendar)",
            "UNUSED",
        };

        private static readonly string[] Level1PurchasedRewards =
        {
            "Reward 0 (Plow King)",
            "Reward 1 (Duff Truck)",
            "Reward 2 (Surveillance Van)",
            "Reward 3 (Homer - Casual)",
            "Reward 4 (Homer - Muumuu)",
            "Reward 5 (Homer - Chosen One)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level1Gags = {
            "Gag 0 (gag_bbq.p3d)",
            "Gag 1 (gag_gas.p3d)",
            "Gag 2 (gag_shel.p3d)",
            "Gag 3 (gag_swng.p3d)",
            "Gag 4 (gag_swg2.p3d)",
            "Gag 5 (gag_sqsh.p3d)",
            "Gag 6 (gag_jasp.p3d)",
            "Gag 7 (gag_atm.p3d)",
            "Gag 8 (gag_tv.p3d)",
            "Gag 9 (gag_azte.p3d)",
            "Gag 10 (gag_melt.p3d)",
            "Gag 11 (gag_fire.p3d)",
            "Gag 12 (gag_sknr.p3d)",
            "Gag 13 (gag_tele.p3d)",
            "Gag 14 (gag_alm2.p3d)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level1Missions =
        {
            "Mission 0 (The Cola Caper)",
            "Mission 1 (S-M-R-T)",
            "Mission 2 (Petty Theft Homer)",
            "Mission 3 (Office Spaced)",
            "Mission 4 (Blind Big Brother)",
            "Mission 5 (Flowers By Irene)",
            "Mission 6 (Bonestorm Storm)",
            "Mission 7 (The Fat and Furious)",
            "Bonus Mission (This Old Shanty)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

        private static readonly string[] Level2PurchasedRewards =
        {
            "Reward 0 (Mr. Plow)",
            "Reward 1 (Limo)",
            "Reward 2 (Fire Truck)",
            "Reward 3 (Bart - Tall)",
            "Reward 4 (Bart - Football)",
            "Reward 5 (Bart - Ninja)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level2Gags = {
            "Gag 0 (gag_jar.p3d)",
            "Gag 1 (gag_flm.p3d)",
            "Gag 2 (gag_love.p3d)",
            "Gag 3 (gag_slot.p3d)",
            "Gag 4 (gag_cata.p3d)",
            "Gag 5 (gag_tony.p3d)",
            "Gag 6 (gag_bomb.p3d)",
            "Gag 7 (gag_milk.p3d)",
            "Gag 8 (gag_car.p3d)",
            "Gag 9 (gag_mol2.p3d)",
            "Gag 10 (l2_dump.p3d)",
            "Gag 11 (unused)",
            "Gag 12 (unused)",
            "Gag 13 (unused)",
            "Gag 14 (unused)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level2Missions =
        {
            "Mission 1 (Detention Deficit Disorder)",
            "Mission 2 (Weapons of Mass Delinquency)",
            "Mission 3 (Vox Nerduli)",
            "Mission 4 (Bart 'n' Frink)",
            "Mission 5 (Better Than Beef)",
            "Mission 6 (Monkey See Monkey D'oh)",
            "Mission 7 (Cell-Outs)",
            "Mission 8 (Unnamed)",
            "Bonus Mission (Dial B for Blood)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

        private static readonly string[] Level3PurchasedRewards =
        {
            "Reward 0 (School Bus)",
            "Reward 1 (Donut Truck)",
            "Reward 2 (Nerd Car)",
            "Reward 3 (Lisa - Cool)",
            "Reward 4 (Lisa - Floreda)",
            "Reward 5 (Lisa - Hockey)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level3Gags = {
            "Gag 0 (gag_racm.p3d)",
            "Gag 1 (gag_clnk.p3d)",
            "Gag 2 (gag_flag.p3d)",
            "Gag 3 (gag_pig.p3d)",
            "Gag 4 (gag_alrm.p3d)",
            "Gag 5 (gag_matt.p3d)",
            "Gag 6 (gag_perp.p3d)",
            "Gag 7 (gag_pant.p3d)",
            "Gag 8 (gag_kids.p3d)",
            "Gag 9 (gag_tele.p3d)",
            "Gag 10 (l3_dump.p3d)",
            "Gag 11 (unused)",
            "Gag 12 (unused)",
            "Gag 13 (unused)",
            "Gag 14 (unused)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level3Missions =
        {
            "Mission 1 (Nerd Race Queen)",
            "Mission 2 (Clueless)",
            "Mission 3 (Bonfire of the Manatees)",
            "Mission 4 (Operation Hellfish)",
            "Mission 5 (Slithery Sleuthing)",
            "Mission 6 (Fishy Deals)",
            "Mission 7 (The Old Pirate and the Sea)",
            "Mission 8 (Unnamed)",
            "Bonus Mission (Princi-pal)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

        private static readonly string[] Level4PurchasedRewards =
        {
            "Reward 0 (Tractor)",
            "Reward 1 (Krusty's Limo)",
            "Reward 2 (Curator)",
            "Reward 3 (Marge - Inmate)",
            "Reward 4 (Marge - Classy)",
            "Reward 5 (Marge - Police)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level4Gags = {
            "Gag 0 (l04_bbq.p3d)",
            "Gag 1 (l04_gas.p3d)",
            "Gag 2 (gag_shel.p3d)",
            "Gag 3 (l04_swng.p3d)",
            "Gag 4 (gag_sqsh.p3d)",
            "Gag 5 (gag_jasp.p3d)",
            "Gag 6 (gag_atm.p3d)",
            "Gag 7 (gag_tv.p3d)",
            "Gag 8 (l04_azte.p3d)",
            "Gag 9 (gag_melt.p3d)",
            "Gag 10 (gag_fire.p3d)",
            "Gag 11 (gag_sknr.p3d)",
            "Gag 12 (gag_lamp.p3d)",
            "Gag 13 (gag_tele.p3d)",
            "Gag 14 (gag_alm2.p3d)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level4Missions =
        {
            "Mission 1 (For A Few Donuts More)",
            "Mission 2 (Redneck Roundup)",
            "Mission 3 (Ketchup Logic)",
            "Mission 4 (Return of the Nearly-Dead)",
            "Mission 5 (Wolves Stole My Pills)",
            "Mission 6 (The Cola Wars)",
            "Mission 7 (From Outer Space)",
            "Mission 8 (Unnamed)",
            "Bonus Mission (Beached Love)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

        private static readonly string[] Level5PurchasedRewards =
        {
            "Reward 0 (Car Built For Homer)",
            "Reward 1 (Police Car)",
            "Reward 2 (Cola Truck)",
            "Reward 3 (Apu - Army)",
            "Reward 4 (Apu - American)",
            "Reward 5 (Apu - B-sharps)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level5Gags = {
            "Gag 0 (gag_jar.p3d)",
            "Gag 1 (gag_flm.p3d)",
            "Gag 2 (gag_love.p3d)",
            "Gag 3 (gag_slot.p3d)",
            "Gag 4 (gag_mol2.p3d)",
            "Gag 5 (l5_dump.p3d)",
            "Gag 6 (unused)",
            "Gag 7 (unused)",
            "Gag 8 (unused)",
            "Gag 9 (unused)",
            "Gag 10 (unused)",
            "Gag 11 (unused)",
            "Gag 12 (unused)",
            "Gag 13 (unused)",
            "Gag 14 (unused)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level5Missions =
        {
            "Mission 1 (Incriminating Caffeine)",
            "Mission 2 (. . . and Baby Makes 8)",
            "Mission 3 (Eight is Too Much)",
            "Mission 4 (This Little Piggy)",
            "Mission 5 (Never Trust a Snake)",
            "Mission 6 (Kiwk Cash)",
            "Mission 7 (Curious Curator)",
            "Mission 8 (Unnamed)",
            "Bonus Mission (Kinky Frinky)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

        private static readonly string[] Level6PurchasedRewards =
        {
            "Reward 0 (Globex Super Villain Car)",
            "Reward 1 (Armored Truck)",
            "Reward 2 (Chase Sedan)",
            "Reward 3 (Bart - Hugo)",
            "Reward 4 (Bart - Cadet)",
            "Reward 5 (Bart - Bartman)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level6Gags = {
            "Gag 0 (gag_racm.p3d)",
            "Gag 1 (gag_clnk.p3d)",
            "Gag 2 (l06_flag.p3d)",
            "Gag 3 (l06_pig.p3d)",
            "Gag 4 (gag_alrm.p3d)",
            "Gag 5 (gag_matt.p3d)",
            "Gag 6 (gag_perp.p3d)",
            "Gag 7 (l06_pant.p3d)",
            "Gag 8 (gag_kids.p3d)",
            "Gag 9 (gag_tele.p3d)",
            "Gag 10 (l6_dump.p3d)",
            "Gag 11 (unused)",
            "Gag 12 (unused)",
            "Gag 13 (unused)",
            "Gag 14 (unused)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level6Missions =
        {
            "Mission 1 (Going to the Lu')",
            "Mission 2 (Getting Down with the Clown)",
            "Mission 3 (Lab Coat Caper)",
            "Mission 4 (Duff for Me, Duff for You)",
            "Mission 5 (Full Metal Jackass)",
            "Mission 6 (Set to Kill)",
            "Mission 7 (Kang and Kodos Strike Back)",
            "Mission 8 (Unnamed)",
            "Bonus Mission (Milking the Pigs)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

        private static readonly string[] Level7PurchasedRewards =
        {
            "Reward 0 (Zombie Car)",
            "Reward 1 (Hover Bike)",
            "Reward 2 (Hearse)",
            "Reward 3 (Homer - Dirty)",
            "Reward 4 (Homer - Evil)",
            "Reward 5 (Homer - Donut)",
            "Reward 6 (Unused)",
            "Reward 7 (Unused)",
            "Reward 8 (Unused)",
            "Reward 9 (Unused)",
            "Reward 10 (Unused)",
            "Reward 11 (Unused)",
        };

        private static readonly string[] Level7Gags = {
            "Gag 0 (l07_gas.p3d)",
            "Gag 1 (l07_swng.p3d)",
            "Gag 2 (l07_swg2.p3d)",
            "Gag 3 (gag_sqsh.p3d)",
            "Gag 4 (gag_jasp.p3d)",
            "Gag 5 (gag_atm.p3d)",
            "Gag 6 (gag_tv.p3d)",
            "Gag 7 (l07_azte.p3d)",
            "Gag 8 (gag_fire.p3d)",
            "Gag 9 (gag_sknr.p3d)",
            "Gag 10 (gag_tele.p3d)",
            "Gag 11 (gag_alm2.p3d)",
            "Gag 12 (gag_lamp.p3d)",
            "Gag 13 (gag_bed.p3d)",
            "Gag 14 (l07_shel.p3d)",
            "Gag 15 (unused)",
            "Gag 16 (unused)",
            "Gag 17 (unused)",
            "Gag 18 (unused)",
            "Gag 19 (unused)",
            "Gag 20 (unused)",
            "Gag 21 (unused)",
            "Gag 22 (unused)",
            "Gag 23 (unused)",
            "Gag 24 (unused)",
            "Gag 25 (unused)",
            "Gag 26 (unused)",
            "Gag 27 (unused)",
            "Gag 28 (unused)",
            "Gag 29 (unused)",
            "Gag 30 (unused)",
            "Gag 31 (unused)",
        };

        private static readonly string[] Level7Missions =
        {
            "Mission 1 (Rigor Motors)",
            "Mission 2 (Long Black Probes)",
            "Mission 3 (Pocket Protector)",
            "Mission 4 (There's Something About Monty)",
            "Mission 5 (Alien \"Auto\"topsy Part I)",
            "Mission 6 (Alien \"Auto\"topsy Part II)",
            "Mission 7 (Alien \"Auto\"topsy Part III)",
            "Mission 8 (Unnamed)",
            "Bonus Mission (Flaming Tires)",
            "Race 1 (Time Trial)",
            "Race 2 (Circuit Race)",
            "Race 3 (Checkpoint Race)",
            "Race 4 (Wager Race)",
        };

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

        private CharacterSheet.Level.MissionRecord GetMissionRecordFromIndex(CharacterSheet.Level level, int index)
        {
            switch (index)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    return level.Missions[index];
                case 8:
                    return level.BonusMission;
                case 9:
                case 10:
                case 11:
                    return level.StreetRaces[index - 9];
                case 12:
                    return level.GambleRace;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBAutoSaveDate.Checked = true;

            CBCurrentMissionInfoLevel.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Levels));
            CBCurrentMissionInfoMission.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Missions));
            CBHighestMissionInfoLevel.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Levels));
            CBHighestMissionInfoMission.DataSource = Enum.GetValues(typeof(CharacterSheet.CurrentMission.Missions));

            for (int i = 0; i < SaveGame.CharacterSheet.PersistentObjectStates.Length; i++)
                CLBPersistentObjectStates.Items.Add($"Persistent Object {i}");
            /*for (int i = 0; i < SaveGame.CharacterSheet.PersistentObjectStates.Length; i++)
                LVPersistentObjectStates.Items.Add(new ListViewItem(new string[] { i.ToString(), "0" }));*/

            foreach (var value in Level1PurchasedRewards)
                CLBLevel1PurchasedRewards.Items.Add(value);
            foreach (var value in Level1Gags)
                CLBLevel1Gags.Items.Add(value);
            foreach (var value in Level1Missions)
                LBLevel1Missions.Items.Add(value);
            LBLevel1Missions.SelectedIndex = 0;

            foreach (var value in Level2PurchasedRewards)
                CLBLevel2PurchasedRewards.Items.Add(value);
            foreach (var value in Level2Gags)
                CLBLevel2Gags.Items.Add(value);
            foreach (var value in Level2Missions)
                LBLevel2Missions.Items.Add(value);
            LBLevel2Missions.SelectedIndex = 0;

            foreach (var value in Level3PurchasedRewards)
                CLBLevel3PurchasedRewards.Items.Add(value);
            foreach (var value in Level3Gags)
                CLBLevel3Gags.Items.Add(value);
            foreach (var value in Level3Missions)
                LBLevel3Missions.Items.Add(value);
            LBLevel3Missions.SelectedIndex = 0;

            foreach (var value in Level4PurchasedRewards)
                CLBLevel4PurchasedRewards.Items.Add(value);
            foreach (var value in Level4Gags)
                CLBLevel4Gags.Items.Add(value);
            foreach (var value in Level4Missions)
                LBLevel4Missions.Items.Add(value);
            LBLevel4Missions.SelectedIndex = 0;

            foreach (var value in Level5PurchasedRewards)
                CLBLevel5PurchasedRewards.Items.Add(value);
            foreach (var value in Level5Gags)
                CLBLevel5Gags.Items.Add(value);
            foreach (var value in Level5Missions)
                LBLevel5Missions.Items.Add(value);
            LBLevel5Missions.SelectedIndex = 0;

            foreach (var value in Level6PurchasedRewards)
                CLBLevel6PurchasedRewards.Items.Add(value);
            foreach (var value in Level6Gags)
                CLBLevel6Gags.Items.Add(value);
            foreach (var value in Level6Missions)
                LBLevel6Missions.Items.Add(value);
            LBLevel6Missions.SelectedIndex = 0;

            foreach (var value in Level7PurchasedRewards)
                CLBLevel7PurchasedRewards.Items.Add(value);
            foreach (var value in Level7Gags)
                CLBLevel7Gags.Items.Add(value);
            foreach (var value in Level7Missions)
                LBLevel7Missions.Items.Add(value);
            LBLevel7Missions.SelectedIndex = 0;

            CBPreferredFollowCam1.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));
            CBPreferredFollowCam2.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));
            CBPreferredFollowCam3.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));
            CBPreferredFollowCam4.DataSource = Enum.GetValues(typeof(SuperCamCentral.PreferredFollowCams));

            foreach (var value in Enum.GetValues(typeof(TutorialManager.TutorialMode)))
                CLBTutorialsSeen.Items.Add(value);

            foreach (var card in CardNames)
                CLBCollectedCardIDs.Items.Add(card);

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
            try
            {
                using (var fileStream = File.OpenRead(filePath))
                using (var binaryReader = new BinaryReader(fileStream))
                {
                    SaveGame saveGame = new SaveGame(binaryReader);
                    SaveGame = saveGame;
                    LastPath = filePath;
                    PopulateData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading save file: {ex}", "Error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateData()
        {
            TCMain.Enabled = false;

            SaveGameInfo saveGameInfo = SaveGame.SaveGameInfo;
            DTPSaveDate.Value = saveGameInfo.SaveDate;
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
                CLBPersistentObjectStates.SetItemChecked(i, characterSheet.PersistentObjectStates[i]);
            CLBPersistentObjectStates.EndUpdate();
            /*LVPersistentObjectStates.BeginUpdate();
            for (int i = 0; i < characterSheet.PersistentObjectStates.Length; i++)
                LVPersistentObjectStates.Items[i].SubItems[1].Text = characterSheet.PersistentObjectStates[i].ToString();
            LVPersistentObjectStates.EndUpdate();*/
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
            for (int i = 0; i < CLBLevel1PurchasedRewards.Items.Count; i++)
                CLBLevel1PurchasedRewards.SetItemChecked(i, characterSheet.Levels[0].PurchasedRewards[i]);
            CLBLevel1PurchasedRewards.EndUpdate();
            CLBLevel1Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel1Gags.Items.Count; i++)
                CLBLevel1Gags.SetItemChecked(i, characterSheet.Levels[0].GagsCompleted[i] || (characterSheet.Levels[0].GagMask & (1 << i)) > 0);
            CLBLevel1Gags.EndUpdate();
            LBLevel1Missions_SelectedIndexChanged(LBLevel1Missions, EventArgs.Empty);
            CBLevel2FMVUnlocked.Checked = characterSheet.Levels[1].FMVUnlocked;
            NUDLevel2NumCarsPurchased.Value = characterSheet.Levels[1].NumCarsPurchased;
            NUDLevel2NumSkinsPurchased.Value = characterSheet.Levels[1].NumSkinsPurchased;
            NUDLevel2WaspsDestroyed.Value = characterSheet.Levels[1].WaspsDestroyed;
            CBLevel2CurrentSkin.Text = characterSheet.Levels[1].CurrentSkin;
            CLBLevel2PurchasedRewards.BeginUpdate();
            for (int i = 0; i < CLBLevel2PurchasedRewards.Items.Count; i++)
                CLBLevel2PurchasedRewards.SetItemChecked(i, characterSheet.Levels[1].PurchasedRewards[i]);
            CLBLevel2PurchasedRewards.EndUpdate();
            CLBLevel2Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel2Gags.Items.Count; i++)
                CLBLevel2Gags.SetItemChecked(i, characterSheet.Levels[1].GagsCompleted[i] || (characterSheet.Levels[1].GagMask & (1 << i)) > 0);
            CLBLevel2Gags.EndUpdate();
            LBLevel2Missions_SelectedIndexChanged(LBLevel2Missions, EventArgs.Empty);
            CBLevel3FMVUnlocked.Checked = characterSheet.Levels[2].FMVUnlocked;
            NUDLevel3NumCarsPurchased.Value = characterSheet.Levels[2].NumCarsPurchased;
            NUDLevel3NumSkinsPurchased.Value = characterSheet.Levels[2].NumSkinsPurchased;
            NUDLevel3WaspsDestroyed.Value = characterSheet.Levels[2].WaspsDestroyed;
            CBLevel3CurrentSkin.Text = characterSheet.Levels[2].CurrentSkin;
            CLBLevel3PurchasedRewards.BeginUpdate();
            for (int i = 0; i < CLBLevel3PurchasedRewards.Items.Count; i++)
                CLBLevel3PurchasedRewards.SetItemChecked(i, characterSheet.Levels[2].PurchasedRewards[i]);
            CLBLevel3PurchasedRewards.EndUpdate();
            CLBLevel3Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel3Gags.Items.Count; i++)
                CLBLevel3Gags.SetItemChecked(i, characterSheet.Levels[2].GagsCompleted[i] || (characterSheet.Levels[2].GagMask & (1 << i)) > 0);
            CLBLevel3Gags.EndUpdate();
            LBLevel3Missions_SelectedIndexChanged(LBLevel3Missions, EventArgs.Empty);
            CBLevel4FMVUnlocked.Checked = characterSheet.Levels[3].FMVUnlocked;
            NUDLevel4NumCarsPurchased.Value = characterSheet.Levels[3].NumCarsPurchased;
            NUDLevel4NumSkinsPurchased.Value = characterSheet.Levels[3].NumSkinsPurchased;
            NUDLevel4WaspsDestroyed.Value = characterSheet.Levels[3].WaspsDestroyed;
            CBLevel4CurrentSkin.Text = characterSheet.Levels[3].CurrentSkin;
            CLBLevel4PurchasedRewards.BeginUpdate();
            for (int i = 0; i < CLBLevel4PurchasedRewards.Items.Count; i++)
                CLBLevel4PurchasedRewards.SetItemChecked(i, characterSheet.Levels[3].PurchasedRewards[i]);
            CLBLevel4PurchasedRewards.EndUpdate();
            CLBLevel4Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel4Gags.Items.Count; i++)
                CLBLevel4Gags.SetItemChecked(i, characterSheet.Levels[3].GagsCompleted[i] || (characterSheet.Levels[3].GagMask & (1 << i)) > 0);
            CLBLevel4Gags.EndUpdate();
            LBLevel4Missions_SelectedIndexChanged(LBLevel4Missions, EventArgs.Empty);
            CBLevel5FMVUnlocked.Checked = characterSheet.Levels[4].FMVUnlocked;
            NUDLevel5NumCarsPurchased.Value = characterSheet.Levels[4].NumCarsPurchased;
            NUDLevel5NumSkinsPurchased.Value = characterSheet.Levels[4].NumSkinsPurchased;
            NUDLevel5WaspsDestroyed.Value = characterSheet.Levels[4].WaspsDestroyed;
            CBLevel5CurrentSkin.Text = characterSheet.Levels[4].CurrentSkin;
            CLBLevel5PurchasedRewards.BeginUpdate();
            for (int i = 0; i < CLBLevel5PurchasedRewards.Items.Count; i++)
                CLBLevel5PurchasedRewards.SetItemChecked(i, characterSheet.Levels[4].PurchasedRewards[i]);
            CLBLevel5PurchasedRewards.EndUpdate();
            CLBLevel5Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel5Gags.Items.Count; i++)
                CLBLevel5Gags.SetItemChecked(i, characterSheet.Levels[4].GagsCompleted[i] || (characterSheet.Levels[4].GagMask & (1 << i)) > 0);
            CLBLevel5Gags.EndUpdate();
            LBLevel5Missions_SelectedIndexChanged(LBLevel5Missions, EventArgs.Empty);
            CBLevel6FMVUnlocked.Checked = characterSheet.Levels[5].FMVUnlocked;
            NUDLevel6NumCarsPurchased.Value = characterSheet.Levels[5].NumCarsPurchased;
            NUDLevel6NumSkinsPurchased.Value = characterSheet.Levels[5].NumSkinsPurchased;
            NUDLevel6WaspsDestroyed.Value = characterSheet.Levels[5].WaspsDestroyed;
            CBLevel6CurrentSkin.Text = characterSheet.Levels[5].CurrentSkin;
            CLBLevel6PurchasedRewards.BeginUpdate();
            for (int i = 0; i < CLBLevel6PurchasedRewards.Items.Count; i++)
                CLBLevel6PurchasedRewards.SetItemChecked(i, characterSheet.Levels[5].PurchasedRewards[i]);
            CLBLevel6PurchasedRewards.EndUpdate();
            CLBLevel6Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel6Gags.Items.Count; i++)
                CLBLevel6Gags.SetItemChecked(i, characterSheet.Levels[5].GagsCompleted[i] || (characterSheet.Levels[5].GagMask & (1 << i)) > 0);
            CLBLevel6Gags.EndUpdate();
            LBLevel6Missions_SelectedIndexChanged(LBLevel6Missions, EventArgs.Empty);
            CBLevel7FMVUnlocked.Checked = characterSheet.Levels[6].FMVUnlocked;
            NUDLevel7NumCarsPurchased.Value = characterSheet.Levels[6].NumCarsPurchased;
            NUDLevel7NumSkinsPurchased.Value = characterSheet.Levels[6].NumSkinsPurchased;
            NUDLevel7WaspsDestroyed.Value = characterSheet.Levels[6].WaspsDestroyed;
            CBLevel7CurrentSkin.Text = characterSheet.Levels[6].CurrentSkin;
            CLBLevel7PurchasedRewards.BeginUpdate();
            for (int i = 0; i < CLBLevel7PurchasedRewards.Items.Count; i++)
                CLBLevel7PurchasedRewards.SetItemChecked(i, characterSheet.Levels[6].PurchasedRewards[i]);
            CLBLevel7PurchasedRewards.EndUpdate();
            CLBLevel7Gags.BeginUpdate();
            for (int i = 0; i < CLBLevel7Gags.Items.Count; i++)
                CLBLevel7Gags.SetItemChecked(i, characterSheet.Levels[6].GagsCompleted[i] || (characterSheet.Levels[6].GagMask & (1 << i)) > 0);
            CLBLevel7Gags.EndUpdate();
            LBLevel7Missions_SelectedIndexChanged(LBLevel7Missions, EventArgs.Empty);

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

            CustomSaveData customSaveData = SaveGame.CustomSaveData;
            LblCustomSaveDataLength.Text = $"{customSaveData.Data.Length} bytes";

            TCMain.Enabled = true;
            UnsavedChanges = false;
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.Control)
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
                    TSMISave.PerformClick();
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

            using (var ofd = new OpenFileDialog() { Title = "Open Save File" })
            {
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                LoadSave(ofd.FileName);
            }
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
                        DTPSaveDate.Value = SaveGame.SaveGameInfo.SaveDate;
                    using (var fileStream = File.OpenWrite(LastPath))
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

            using (var sfd = new SaveFileDialog() { Title = "Save File", FileName = "Save1" })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    if (CBAutoSaveDate.Checked)
                        DTPSaveDate.Value = SaveGame.SaveGameInfo.SaveDate;
                    using (var fileStream = File.OpenWrite(sfd.FileName))
                    using (var binaryWriter = new BinaryWriter(fileStream))
                        SaveGame.Write(binaryWriter);
                    UnsavedChanges = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing save file: {ex}", "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSMISaveAs_Click(object sender, EventArgs e)
        {
            if (!ConfirmPurchaseTotals())
                return;

            using (var sfd = new SaveFileDialog() { Title = "Save File" })
            {
                if (string.IsNullOrEmpty(LastPath))
                {
                    sfd.FileName = "Save1";
                }
                else
                {
                    sfd.InitialDirectory = Path.GetDirectoryName(LastPath);
                    sfd.FileName = Path.GetFileName(LastPath);
                }
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    if (CBAutoSaveDate.Checked)
                        DTPSaveDate.Value = SaveGame.SaveGameInfo.SaveDate;
                    using (var fileStream = File.OpenWrite(sfd.FileName))
                    using (var binaryWriter = new BinaryWriter(fileStream))
                        SaveGame.Write(binaryWriter);
                    UnsavedChanges = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing save file: {ex}", "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSMIExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBAutoSaveDate_CheckedChanged(object sender, EventArgs e)
        {
            DTPSaveDate.Enabled = !CBAutoSaveDate.Checked;
        }

        private void DTPSaveDate_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SaveGameInfo.SaveDate = DTPSaveDate.Value;
        }

        private void NUDDisplayLevel_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SaveGameInfo.DisplayLevel = (byte)NUDDisplayLevel.Value;
        }

        private void NUDDisplayMission_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SaveGameInfo.DisplayMission = (byte)NUDDisplayMission.Value;
        }

        private void CBIsRumbleEnabled_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.InputManager.IsRumbleEnabled = CBIsRumbleEnabled.Checked;
        }

        private void TxtPlayerName_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.PlayerName = TxtPlayerName.Text;
        }

        private void CBCurrentMissionInfoLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.CurrentMissionInfo.Level = (CharacterSheet.CurrentMission.Levels)CBCurrentMissionInfoLevel.SelectedItem;
        }

        private void CBCurrentMissionInfoMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.CurrentMissionInfo.Mission = (CharacterSheet.CurrentMission.Missions)CBCurrentMissionInfoMission.SelectedItem;
        }

        private void CBHighestMissionInfoLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.HighestMissionInfo.Level = (CharacterSheet.CurrentMission.Levels)CBHighestMissionInfoLevel.SelectedItem;
        }

        private void CBHighestMissionInfoMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.HighestMissionInfo.Mission = (CharacterSheet.CurrentMission.Missions)CBHighestMissionInfoMission.SelectedItem;
        }

        private void CBIsNavSystemEnabled_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.IsNavSystemEnabled = CBIsNavSystemEnabled.Checked;
        }

        private void NUDCoins_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Coins = (int)NUDCoins.Value;
        }

        private void CBItchyScratchyCBGFirst_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.ItchyScratchyCBGFirst = CBItchyScratchyCBGFirst.Checked;
        }

        private void CBItchyScratchyTicket_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.ItchyScratchyTicket = CBItchyScratchyTicket.Checked;
        }

        private void CLBPersistentObjectStates_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.PersistentObjectStates[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void TSMIPersistentObjectStatesSelectAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to select all?\nThis action cannot be reversed.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            CLBPersistentObjectStates.BeginUpdate();
            for (int i = 0; i < CLBPersistentObjectStates.Items.Count; i++)
                CLBPersistentObjectStates.SetItemChecked(i, true);
            CLBPersistentObjectStates.EndUpdate();
        }

        private void TSMIPersistentObjectStatesDeselectAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to deselect all?\nThis action cannot be reversed.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            CLBPersistentObjectStates.BeginUpdate();
            for (int i = 0; i < CLBPersistentObjectStates.Items.Count; i++)
                CLBPersistentObjectStates.SetItemChecked(i, false);
            CLBPersistentObjectStates.EndUpdate();
        }

        /*private void LVPersistentObjectStates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lvi = LVPersistentObjectStates.GetItemAt(e.X, e.Y);
            if (lvi == null)
                return;

            var bounds = lvi.SubItems[1].Bounds;
            bounds.X += LVPersistentObjectStates.Location.X;
            bounds.Y += LVPersistentObjectStates.Location.Y;
            NUDEditPersistentObjectState.Bounds = bounds;
            NUDEditPersistentObjectState.Value = byte.Parse(lvi.SubItems[1].Text);
            NUDEditPersistentObjectState.Visible = true;
            NUDEditPersistentObjectState.Focus();
            NUDEditPersistentObjectState.Tag = lvi;
        }

        private void NUDEditPersistentObjectState_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (NUDEditPersistentObjectState.Tag is ListViewItem lvi)
                    {
                        int index = int.Parse(lvi.SubItems[0].Text);
                        byte value = (byte)NUDEditPersistentObjectState.Value;
                        if (value != SaveGame.CharacterSheet.PersistentObjectStates[index])
                        {
                            UnsavedChanges = true;
                            SaveGame.CharacterSheet.PersistentObjectStates[index] = value;
                            lvi.SubItems[1].Text = value.ToString();
                        }
                        NUDEditPersistentObjectState.Visible = false;
                        LVPersistentObjectStates.Focus();
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Escape:
                    NUDEditPersistentObjectState.Visible = false;
                    LVPersistentObjectStates.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void NUDEditPersistentObjectState_Leave(object sender, EventArgs e)
        {
            if (NUDEditPersistentObjectState.Tag is ListViewItem lvi)
            {
                int index = int.Parse(lvi.SubItems[0].Text);
                byte value = (byte)NUDEditPersistentObjectState.Value;
                if (value != SaveGame.CharacterSheet.PersistentObjectStates[index])
                {
                    UnsavedChanges = true;
                    SaveGame.CharacterSheet.PersistentObjectStates[index] = value;
                    lvi.SubItems[1].Text = value.ToString();
                }
                NUDEditPersistentObjectState.Visible = false;
                LVPersistentObjectStates.Focus();
            }
        }*/

        private void CBLevel1FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].FMVUnlocked = CBLevel1FMVUnlocked.Checked;
        }

        private void NUDLevel1NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].NumCarsPurchased = (int)NUDLevel1NumCarsPurchased.Value;
        }

        private void NUDLevel1NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].NumSkinsPurchased = (int)NUDLevel1NumSkinsPurchased.Value;
        }

        private void NUDLevel1WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].WaspsDestroyed = (int)NUDLevel1WaspsDestroyed.Value;
        }

        private void CBLevel1CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].CurrentSkin = CBLevel1CurrentSkin.Text;
        }

        private void CLBLevel1PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[0].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel1Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[0].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[0].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[0].GagsViewed = CLBLevel1Gags.SelectedItems.Count;
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
            if (UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).Name = TxtLevel1MissionName.Text;
        }

        private void CBLevel1Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).Completed = CBLevel1Completed.Checked;
        }

        private void CBLevel1BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).BonusObjective = CBLevel1BonusObjective.Checked;
        }

        private void NUDLevel1NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).NumAttempts = (uint)NUDLevel1NumAttempts.Value;
        }

        private void CBLevel1SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).SkippedMission = CBLevel1SkippedMission.Checked;
        }

        private void NUDLevel1BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel1Missions || LBLevel1Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[0], LBLevel1Missions.SelectedIndex).BestTime = (int)NUDLevel1BestTime.Value;
        }

        private void CBLevel2FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].FMVUnlocked = CBLevel2FMVUnlocked.Checked;
        }

        private void NUDLevel2NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].NumCarsPurchased = (int)NUDLevel2NumCarsPurchased.Value;
        }

        private void NUDLevel2NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].NumSkinsPurchased = (int)NUDLevel2NumSkinsPurchased.Value;
        }

        private void NUDLevel2WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].WaspsDestroyed = (int)NUDLevel2WaspsDestroyed.Value;
        }

        private void CBLevel2CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].CurrentSkin = CBLevel2CurrentSkin.Text;
        }

        private void CLBLevel2PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[1].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel2Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[1].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[1].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[1].GagsViewed = CLBLevel2Gags.SelectedItems.Count;
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
            if (UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).Name = TxtLevel2MissionName.Text;
        }

        private void CBLevel2Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).Completed = CBLevel2Completed.Checked;
        }

        private void CBLevel2BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).BonusObjective = CBLevel2BonusObjective.Checked;
        }

        private void NUDLevel2NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).NumAttempts = (uint)NUDLevel2NumAttempts.Value;
        }

        private void CBLevel2SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).SkippedMission = CBLevel2SkippedMission.Checked;
        }

        private void NUDLevel2BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel2Missions || LBLevel2Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[1], LBLevel2Missions.SelectedIndex).BestTime = (int)NUDLevel2BestTime.Value;
        }

        private void CBLevel3FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].FMVUnlocked = CBLevel3FMVUnlocked.Checked;
        }

        private void NUDLevel3NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].NumCarsPurchased = (int)NUDLevel3NumCarsPurchased.Value;
        }

        private void NUDLevel3NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].NumSkinsPurchased = (int)NUDLevel3NumSkinsPurchased.Value;
        }

        private void NUDLevel3WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].WaspsDestroyed = (int)NUDLevel3WaspsDestroyed.Value;
        }

        private void CBLevel3CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].CurrentSkin = CBLevel3CurrentSkin.Text;
        }

        private void CLBLevel3PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[2].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel3Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[2].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[2].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[2].GagsViewed = CLBLevel3Gags.SelectedItems.Count;
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
            if (UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).Name = TxtLevel3MissionName.Text;
        }

        private void CBLevel3Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).Completed = CBLevel3Completed.Checked;
        }

        private void CBLevel3BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).BonusObjective = CBLevel3BonusObjective.Checked;
        }

        private void NUDLevel3NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).NumAttempts = (uint)NUDLevel3NumAttempts.Value;
        }

        private void CBLevel3SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).SkippedMission = CBLevel3SkippedMission.Checked;
        }

        private void NUDLevel3BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel3Missions || LBLevel3Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[2], LBLevel3Missions.SelectedIndex).BestTime = (int)NUDLevel3BestTime.Value;
        }

        private void CBLevel4FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].FMVUnlocked = CBLevel4FMVUnlocked.Checked;
        }

        private void NUDLevel4NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].NumCarsPurchased = (int)NUDLevel4NumCarsPurchased.Value;
        }

        private void NUDLevel4NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].NumSkinsPurchased = (int)NUDLevel4NumSkinsPurchased.Value;
        }

        private void NUDLevel4WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].WaspsDestroyed = (int)NUDLevel4WaspsDestroyed.Value;
        }

        private void CBLevel4CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].CurrentSkin = CBLevel4CurrentSkin.Text;
        }

        private void CLBLevel4PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[3].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel4Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[3].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[3].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[3].GagsViewed = CLBLevel4Gags.SelectedItems.Count;
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
            if (UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).Name = TxtLevel4MissionName.Text;
        }

        private void CBLevel4Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).Completed = CBLevel4Completed.Checked;
        }

        private void CBLevel4BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).BonusObjective = CBLevel4BonusObjective.Checked;
        }

        private void NUDLevel4NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).NumAttempts = (uint)NUDLevel4NumAttempts.Value;
        }

        private void CBLevel4SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).SkippedMission = CBLevel4SkippedMission.Checked;
        }

        private void NUDLevel4BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel4Missions || LBLevel4Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[3], LBLevel4Missions.SelectedIndex).BestTime = (int)NUDLevel4BestTime.Value;
        }

        private void CBLevel5FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].FMVUnlocked = CBLevel5FMVUnlocked.Checked;
        }

        private void NUDLevel5NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].NumCarsPurchased = (int)NUDLevel5NumCarsPurchased.Value;
        }

        private void NUDLevel5NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].NumSkinsPurchased = (int)NUDLevel5NumSkinsPurchased.Value;
        }

        private void NUDLevel5WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].WaspsDestroyed = (int)NUDLevel5WaspsDestroyed.Value;
        }

        private void CBLevel5CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].CurrentSkin = CBLevel5CurrentSkin.Text;
        }

        private void CLBLevel5PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[4].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel5Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[4].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[4].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[4].GagsViewed = CLBLevel5Gags.SelectedItems.Count;
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
            if (UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).Name = TxtLevel5MissionName.Text;
        }

        private void CBLevel5Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).Completed = CBLevel5Completed.Checked;
        }

        private void CBLevel5BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).BonusObjective = CBLevel5BonusObjective.Checked;
        }

        private void NUDLevel5NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).NumAttempts = (uint)NUDLevel5NumAttempts.Value;
        }

        private void CBLevel5SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).SkippedMission = CBLevel5SkippedMission.Checked;
        }

        private void NUDLevel5BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel5Missions || LBLevel5Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[4], LBLevel5Missions.SelectedIndex).BestTime = (int)NUDLevel5BestTime.Value;
        }

        private void CBLevel6FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].FMVUnlocked = CBLevel6FMVUnlocked.Checked;
        }

        private void NUDLevel6NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].NumCarsPurchased = (int)NUDLevel6NumCarsPurchased.Value;
        }

        private void NUDLevel6NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].NumSkinsPurchased = (int)NUDLevel6NumSkinsPurchased.Value;
        }

        private void NUDLevel6WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].WaspsDestroyed = (int)NUDLevel6WaspsDestroyed.Value;
        }

        private void CBLevel6CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].CurrentSkin = CBLevel6CurrentSkin.Text;
        }

        private void CLBLevel6PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[5].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel6Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[5].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[5].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[5].GagsViewed = CLBLevel6Gags.SelectedItems.Count;
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
            if (UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).Name = TxtLevel6MissionName.Text;
        }

        private void CBLevel6Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).Completed = CBLevel6Completed.Checked;
        }

        private void CBLevel6BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).BonusObjective = CBLevel6BonusObjective.Checked;
        }

        private void NUDLevel6NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).NumAttempts = (uint)NUDLevel6NumAttempts.Value;
        }

        private void CBLevel6SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).SkippedMission = CBLevel6SkippedMission.Checked;
        }

        private void NUDLevel6BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel6Missions || LBLevel6Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[5], LBLevel6Missions.SelectedIndex).BestTime = (int)NUDLevel6BestTime.Value;
        }

        private void CBLevel7FMVUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].FMVUnlocked = CBLevel7FMVUnlocked.Checked;
        }

        private void NUDLevel7NumCarsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].NumCarsPurchased = (int)NUDLevel7NumCarsPurchased.Value;
        }

        private void NUDLevel7NumSkinsPurchased_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].NumSkinsPurchased = (int)NUDLevel7NumSkinsPurchased.Value;
        }

        private void NUDLevel7WaspsDestroyed_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].WaspsDestroyed = (int)NUDLevel7WaspsDestroyed.Value;
        }

        private void CBLevel7CurrentSkin_TextChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].CurrentSkin = CBLevel7CurrentSkin.Text;
        }

        private void CLBLevel7PurchasedRewards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Levels[6].PurchasedRewards[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void CLBLevel7Gags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            bool value = e.NewValue == CheckState.Checked;
            SaveGame.CharacterSheet.Levels[6].GagMask |= (uint)(1 << e.Index);
            SaveGame.CharacterSheet.Levels[6].GagsCompleted[e.Index] = value;
            SaveGame.CharacterSheet.Levels[6].GagsViewed = CLBLevel7Gags.SelectedItems.Count;
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
            if (UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).Name = TxtLevel7MissionName.Text;
        }

        private void CBLevel7Completed_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).Completed = CBLevel7Completed.Checked;
        }

        private void CBLevel7BonusObjective_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).BonusObjective = CBLevel7BonusObjective.Checked;
        }

        private void NUDLevel7NumAttempts_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).NumAttempts = (uint)NUDLevel7NumAttempts.Value;
        }

        private void CBLevel7SkippedMission_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).SkippedMission = CBLevel7SkippedMission.Checked;
        }

        private void NUDLevel7BestTime_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingLevel7Missions || LBLevel7Missions.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            GetMissionRecordFromIndex(SaveGame.CharacterSheet.Levels[6], LBLevel7Missions.SelectedIndex).BestTime = (int)NUDLevel7BestTime.Value;
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
                NUDMaxHealth.Value = (decimal)(car.MaxHealth * 100d);
                NUDMaxHealth.Enabled = true;
            }
            UpdatingCars = false;
        }

        private void TxtCarName_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingCars || LBCars.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Cars[LBCars.SelectedIndex].Name = TxtCarName.Text;
        }

        private void NUDCurrentHealth_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingCars || LBCars.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Cars[LBCars.SelectedIndex].CurrentHealth = (float)(NUDCurrentHealth.Value / 100);
        }

        private void NUDMaxHealth_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingCars || LBCars.SelectedIndex == -1)
                return;

            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Cars[LBCars.SelectedIndex].MaxHealth = (float)(NUDMaxHealth.Value / 100);
        }

        private void NUDCounter_ValueChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CharacterSheet.Cars.Counter = (int)NUDCounter.Value;
        }

        // TODO: Character Sheet

        private void TBMusicVolume_ValueChanged(object sender, EventArgs e)
        {
            LblMusicVolumeValue.Text = $"{TBMusicVolume.Value}%";
            UnsavedChanges = true;
            SaveGame.SoundSettings.MusicVolume = TBMusicVolume.Value / 100f;
        }

        private void TBSFXVolume_ValueChanged(object sender, EventArgs e)
        {
            LblSFXVolumeValue.Text = $"{TBSFXVolume.Value}%";
            UnsavedChanges = true;
            SaveGame.SoundSettings.SFXVolume = TBSFXVolume.Value / 100f;
        }

        private void TBCarVolume_ValueChanged(object sender, EventArgs e)
        {
            LblCarVolumeValue.Text = $"{TBCarVolume.Value}%";
            UnsavedChanges = true;
            SaveGame.SoundSettings.CarVolume = TBCarVolume.Value / 100f;
        }

        private void TBDialogVolume_ValueChanged(object sender, EventArgs e)
        {
            LblDialogVolumeValue.Text = $"{TBDialogVolume.Value}%";
            UnsavedChanges = true;
            SaveGame.SoundSettings.DialogVolume = TBDialogVolume.Value / 100f;
        }

        private void CBJumpCamsEnabled1_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[0].JumpCamsEnabled = CBJumpCamsEnabled1.Checked;
        }

        private void CBIsInvertedCameraEnabled1_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[0].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled1.Checked;
        }

        private void CBPreferredFollowCam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[0].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam1.SelectedItem;
        }

        private void CBJumpCamsEnabled2_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[1].JumpCamsEnabled = CBJumpCamsEnabled2.Checked;
        }

        private void CBIsInvertedCameraEnabled2_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[1].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled2.Checked;
        }

        private void CBPreferredFollowCam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[1].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam2.SelectedItem;
        }

        private void CBJumpCamsEnabled3_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[2].JumpCamsEnabled = CBJumpCamsEnabled3.Checked;
        }

        private void CBIsInvertedCameraEnabled3_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[2].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled3.Checked;
        }

        private void CBPreferredFollowCam3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[2].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam3.SelectedItem;
        }

        private void CBJumpCamsEnabled4_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[3].JumpCamsEnabled = CBJumpCamsEnabled4.Checked;
        }

        private void CBIsInvertedCameraEnabled4_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[3].IsInvertedCameraEnabled = CBIsInvertedCameraEnabled4.Checked;
        }

        private void CBPreferredFollowCam4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.SuperCamCentrals[3].PreferredFollowCam = (SuperCamCentral.PreferredFollowCams)CBPreferredFollowCam4.SelectedItem;
        }

        private void CBEnableTutorialEvents_CheckedChanged(object sender, EventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.TutorialManager.EnableTutorialEvents = CBEnableTutorialEvents.Checked;
        }

        private void CLBTutorialsSeen_ItemCheck(object sender, ItemCheckEventArgs e)
        {
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
            UnsavedChanges = true;
            SaveGame.GUISystem.IsRadarEnabled = CBIsRadarEnabled.Checked;
        }

        private void CLBCollectedCardIDs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UnsavedChanges = true;
            SaveGame.CardGallery.CollectedCardIDs[e.Index] = e.NewValue == CheckState.Checked;
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
    }
}
