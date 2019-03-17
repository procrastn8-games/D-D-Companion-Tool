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
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPnl
            // 
            this.FlowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPnl.AutoScroll = true;
            this.FlowPnl.BackColor = System.Drawing.Color.Silver;
            this.FlowPnl.Location = new System.Drawing.Point(29, 0);
            this.FlowPnl.Margin = new System.Windows.Forms.Padding(1);
            this.FlowPnl.Name = "FlowPnl";
            this.FlowPnl.Size = new System.Drawing.Size(224, 465);
            this.FlowPnl.TabIndex = 0;
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume1;
            this.VolumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeBtn.ErrorImage = null;
            this.VolumeBtn.Location = new System.Drawing.Point(2, 44);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(25, 26);
            this.VolumeBtn.TabIndex = 1;
            this.VolumeBtn.TabStop = false;
            this.VolumeBtn.Click += new System.EventHandler(this.VolumeOnOff);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackgroundImage = global::dnd.Properties.Resources.Settings;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.Location = new System.Drawing.Point(2, 12);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(25, 26);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Click += new System.EventHandler(this.setting_Click);
            // 
            // DiceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(252, 465);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.VolumeBtn);
            this.Controls.Add(this.FlowPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(240, 120);
            this.Name = "DiceRollForm";
            this.Text = "Jay\'s Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPnl;
        private System.Windows.Forms.PictureBox VolumeBtn;
        private System.Windows.Forms.PictureBox SettingsBtn;
    }
}

