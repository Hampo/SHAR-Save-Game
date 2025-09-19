namespace SHARSaveGameEditor
{
    partial class FrmConfirmCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmCards));
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnSyncFromCharacterSheet = new System.Windows.Forms.Button();
            this.BtnSyncFromCardGallery = new System.Windows.Forms.Button();
            this.BtnDoNotSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(12, 9);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(563, 26);
            this.LblInfo.TabIndex = 0;
            this.LblInfo.Text = "The collected card information in the CharacterSheet does not match the collected" +
    " card information in the CardGallery.\r\nWould you like to sync the collected card" +
    " information?";
            // 
            // BtnSyncFromCharacterSheet
            // 
            this.BtnSyncFromCharacterSheet.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSyncFromCharacterSheet.Location = new System.Drawing.Point(18, 49);
            this.BtnSyncFromCharacterSheet.Name = "BtnSyncFromCharacterSheet";
            this.BtnSyncFromCharacterSheet.Size = new System.Drawing.Size(179, 23);
            this.BtnSyncFromCharacterSheet.TabIndex = 1;
            this.BtnSyncFromCharacterSheet.Text = "Sync From Character Sheet";
            this.BtnSyncFromCharacterSheet.UseVisualStyleBackColor = true;
            this.BtnSyncFromCharacterSheet.Click += new System.EventHandler(this.BtnSyncFromCharacterSheet_Click);
            // 
            // BtnSyncFromCardGallery
            // 
            this.BtnSyncFromCardGallery.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSyncFromCardGallery.Location = new System.Drawing.Point(203, 49);
            this.BtnSyncFromCardGallery.Name = "BtnSyncFromCardGallery";
            this.BtnSyncFromCardGallery.Size = new System.Drawing.Size(179, 23);
            this.BtnSyncFromCardGallery.TabIndex = 2;
            this.BtnSyncFromCardGallery.Text = "Sync From Card Gallery";
            this.BtnSyncFromCardGallery.UseVisualStyleBackColor = true;
            this.BtnSyncFromCardGallery.Click += new System.EventHandler(this.BtnSyncFromCardGallery_Click);
            // 
            // BtnDoNotSync
            // 
            this.BtnDoNotSync.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnDoNotSync.Location = new System.Drawing.Point(388, 49);
            this.BtnDoNotSync.Name = "BtnDoNotSync";
            this.BtnDoNotSync.Size = new System.Drawing.Size(179, 23);
            this.BtnDoNotSync.TabIndex = 3;
            this.BtnDoNotSync.Text = "Do Not Sync";
            this.BtnDoNotSync.UseVisualStyleBackColor = true;
            this.BtnDoNotSync.Click += new System.EventHandler(this.BtnDoNotSync_Click);
            // 
            // FrmConfirmCards
            // 
            this.AcceptButton = this.BtnSyncFromCharacterSheet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnDoNotSync;
            this.ClientSize = new System.Drawing.Size(585, 89);
            this.Controls.Add(this.BtnDoNotSync);
            this.Controls.Add(this.BtnSyncFromCardGallery);
            this.Controls.Add(this.BtnSyncFromCharacterSheet);
            this.Controls.Add(this.LblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfirmCards";
            this.Text = "Confirm Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnSyncFromCharacterSheet;
        private System.Windows.Forms.Button BtnSyncFromCardGallery;
        private System.Windows.Forms.Button BtnDoNotSync;
    }
}