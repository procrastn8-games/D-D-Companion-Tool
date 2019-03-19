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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CharacterCreationBTN = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new System.Windows.Forms.PictureBox();
            this.VolumeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterCreationBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).BeginInit();
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
            this.FlowPnl.Location = new System.Drawing.Point(59, 0);
            this.FlowPnl.Margin = new System.Windows.Forms.Padding(1);
            this.FlowPnl.Name = "FlowPnl";
            this.FlowPnl.Size = new System.Drawing.Size(305, 706);
            this.FlowPnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::dnd.Properties.Resources.Border;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.CharacterCreationBTN);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.VolumeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 716);
            this.panel1.TabIndex = 1;
            // 
            // CharacterCreationBTN
            // 
            this.CharacterCreationBTN.BackColor = System.Drawing.Color.Transparent;
            this.CharacterCreationBTN.BackgroundImage = global::dnd.Properties.Resources.CharacterSheetButton;
            this.CharacterCreationBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterCreationBTN.ErrorImage = null;
            this.CharacterCreationBTN.Location = new System.Drawing.Point(13, 109);
            this.CharacterCreationBTN.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterCreationBTN.Name = "CharacterCreationBTN";
            this.CharacterCreationBTN.Size = new System.Drawing.Size(40, 40);
            this.CharacterCreationBTN.TabIndex = 7;
            this.CharacterCreationBTN.TabStop = false;
            this.CharacterCreationBTN.Click += new System.EventHandler(this.CharacterCreationBTN_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BackgroundImage = global::dnd.Properties.Resources.Settings;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.Location = new System.Drawing.Point(13, 13);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(40, 40);
            this.SettingsBtn.TabIndex = 6;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Click += new System.EventHandler(this.setting_Click);
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume1;
            this.VolumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeBtn.ErrorImage = null;
            this.VolumeBtn.Location = new System.Drawing.Point(13, 61);
            this.VolumeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(40, 40);
            this.VolumeBtn.TabIndex = 5;
            this.VolumeBtn.TabStop = false;
            this.VolumeBtn.Click += new System.EventHandler(this.VolumeOnOff);
            // 
            // DiceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImage = global::dnd.Properties.Resources.Good_Border;
            this.ClientSize = new System.Drawing.Size(359, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlowPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(314, 137);
            this.Name = "DiceRollForm";
            this.Text = "D&D Companion";
            this.Load += new System.EventHandler(this.DiceRollForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterCreationBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CharacterCreationBTN;
        private System.Windows.Forms.PictureBox SettingsBtn;
        private System.Windows.Forms.PictureBox VolumeBtn;
    }
}

