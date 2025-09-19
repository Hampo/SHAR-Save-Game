using System.Windows.Forms;

namespace SHARSaveGameEditor
{
    public partial class FrmConfirmCards : Form
    {
        public enum SyncSources
        {
            None,
            CharacterSheet,
            CardGallery,
        }

        public SyncSources SyncSource { get; private set; } = SyncSources.None;

        public FrmConfirmCards()
        {
            InitializeComponent();
        }

        private void BtnSyncFromCharacterSheet_Click(object sender, System.EventArgs e)
        {
            SyncSource = SyncSources.CharacterSheet;
        }

        private void BtnSyncFromCardGallery_Click(object sender, System.EventArgs e)
        {
            SyncSource = SyncSources.CardGallery;
        }

        private void BtnDoNotSync_Click(object sender, System.EventArgs e)
        {
            SyncSource = SyncSources.None;
        }
    }
}
