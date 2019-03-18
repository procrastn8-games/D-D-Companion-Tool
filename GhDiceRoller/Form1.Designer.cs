namespace dnd
{
    partial class DiceRollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            this.FlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.VolumeBtn = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new System.Windows.Forms.PictureBox();
            this.CharacterCreationBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterCreationBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPnl
            // 
            this.FlowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPnl.AutoScroll = true;
            this.FlowPnl.BackColor = System.Drawing.Color.Black;
            this.FlowPnl.BackgroundImage = global::dnd.Properties.Resources.InterfaceBG;
            this.FlowPnl.Location = new System.Drawing.Point(39, 0);
            this.FlowPnl.Margin = new System.Windows.Forms.Padding(1);
            this.FlowPnl.Name = "FlowPnl";
            this.FlowPnl.Size = new System.Drawing.Size(299, 572);
            this.FlowPnl.TabIndex = 0;
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume1;
            this.VolumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeBtn.ErrorImage = null;
            this.VolumeBtn.Location = new System.Drawing.Point(3, 54);
            this.VolumeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(33, 32);
            this.VolumeBtn.TabIndex = 1;
            this.VolumeBtn.TabStop = false;
            this.VolumeBtn.Click += new System.EventHandler(this.VolumeOnOff);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackgroundImage = global::dnd.Properties.Resources.Settings;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.Location = new System.Drawing.Point(3, 15);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(33, 32);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Click += new System.EventHandler(this.setting_Click);
            // 
            // CharacterCreationBTN
            // 
            this.CharacterCreationBTN.BackgroundImage = global::dnd.Properties.Resources.CharacterSheetButton;
            this.CharacterCreationBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterCreationBTN.ErrorImage = null;
            this.CharacterCreationBTN.Location = new System.Drawing.Point(3, 94);
            this.CharacterCreationBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CharacterCreationBTN.Name = "CharacterCreationBTN";
            this.CharacterCreationBTN.Size = new System.Drawing.Size(33, 32);
            this.CharacterCreationBTN.TabIndex = 4;
            this.CharacterCreationBTN.TabStop = false;
            this.CharacterCreationBTN.Click += new System.EventHandler(this.CharacterCreationBTN_Click);
            // 
            // DiceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(336, 572);
            this.Controls.Add(this.CharacterCreationBTN);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.VolumeBtn);
            this.Controls.Add(this.FlowPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(314, 137);
            this.Name = "DiceRollForm";
            this.Text = "Jay\'s Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterCreationBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPnl;
        private System.Windows.Forms.PictureBox VolumeBtn;
        private System.Windows.Forms.PictureBox SettingsBtn;
        private System.Windows.Forms.PictureBox CharacterCreationBTN;
    }
}

