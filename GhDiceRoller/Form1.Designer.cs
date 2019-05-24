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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.TopWindowBar = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.VolumeBtn = new System.Windows.Forms.Button();
            this.SelectedRollerLbl = new System.Windows.Forms.Label();
            this.RollerLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.FlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.RollSelectPnl = new System.Windows.Forms.Panel();
            this.MixedCheck = new System.Windows.Forms.RadioButton();
            this.PlasticChk = new System.Windows.Forms.RadioButton();
            this.MetalChk = new System.Windows.Forms.RadioButton();
            this.LeftUpPnl = new System.Windows.Forms.Panel();
            this.LeftUpContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftDownContent = new System.Windows.Forms.Panel();
            this.DicePbx = new System.Windows.Forms.PictureBox();
            this.LeftDownPnl = new System.Windows.Forms.Panel();
            this.LeftBar = new System.Windows.Forms.Panel();
            this.SettingsPnl = new System.Windows.Forms.Panel();
            this.SettingsDiv = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.PictureBox();
            this.heroWatch1 = new dnd.dnd_stuff.Controls.HeroWatch();
            this.ContentPanel.SuspendLayout();
            this.TopWindowBar.SuspendLayout();
            this.RollSelectPnl.SuspendLayout();
            this.LeftUpPnl.SuspendLayout();
            this.LeftUpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LeftDownContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DicePbx)).BeginInit();
            this.LeftDownPnl.SuspendLayout();
            this.LeftBar.SuspendLayout();
            this.SettingsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Controls.Add(this.FlowPnl);
            this.ContentPanel.Controls.Add(this.TopWindowBar);
            this.ContentPanel.Controls.Add(this.RollSelectPnl);
            this.ContentPanel.Controls.Add(this.heroWatch1);
            this.ContentPanel.Location = new System.Drawing.Point(3, 2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(833, 305);
            this.ContentPanel.TabIndex = 5;
            // 
            // TopWindowBar
            // 
            this.TopWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.TopWindowBar.Controls.Add(this.CloseBtn);
            this.TopWindowBar.Controls.Add(this.MaxBtn);
            this.TopWindowBar.Controls.Add(this.MinBtn);
            this.TopWindowBar.Controls.Add(this.VolumeBtn);
            this.TopWindowBar.Controls.Add(this.SelectedRollerLbl);
            this.TopWindowBar.Controls.Add(this.RollerLbl);
            this.TopWindowBar.Controls.Add(this.TitleLbl);
            this.TopWindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopWindowBar.Location = new System.Drawing.Point(0, 0);
            this.TopWindowBar.Name = "TopWindowBar";
            this.TopWindowBar.Size = new System.Drawing.Size(833, 39);
            this.TopWindowBar.TabIndex = 7;
            this.TopWindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopWindowBar_MouseDown);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.Location = new System.Drawing.Point(783, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(50, 30);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "x";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaxBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaxBtn.Location = new System.Drawing.Point(733, 4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(50, 30);
            this.MaxBtn.TabIndex = 5;
            this.MaxBtn.Text = "□";
            this.MaxBtn.UseVisualStyleBackColor = false;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            this.MaxBtn.MouseEnter += new System.EventHandler(this.MaxBtn_MouseEnter);
            this.MaxBtn.MouseLeave += new System.EventHandler(this.MaxBtn_MouseLeave);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinBtn.Location = new System.Drawing.Point(683, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(50, 30);
            this.MinBtn.TabIndex = 4;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            this.MinBtn.MouseEnter += new System.EventHandler(this.MinBtn_MouseEnter);
            this.MinBtn.MouseLeave += new System.EventHandler(this.MinBtn_MouseLeave);
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume;
            this.VolumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeBtn.FlatAppearance.BorderSize = 0;
            this.VolumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolumeBtn.Location = new System.Drawing.Point(175, 4);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(30, 30);
            this.VolumeBtn.TabIndex = 14;
            this.VolumeBtn.UseVisualStyleBackColor = true;
            this.VolumeBtn.Click += new System.EventHandler(this.VolumeOnOff);
            // 
            // SelectedRollerLbl
            // 
            this.SelectedRollerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRollerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(153)))), ((int)(((byte)(28)))));
            this.SelectedRollerLbl.Location = new System.Drawing.Point(305, 12);
            this.SelectedRollerLbl.Name = "SelectedRollerLbl";
            this.SelectedRollerLbl.Size = new System.Drawing.Size(161, 24);
            this.SelectedRollerLbl.TabIndex = 13;
            this.SelectedRollerLbl.Text = "Not Selected ▼";
            this.SelectedRollerLbl.Click += new System.EventHandler(this.SelectedRollerLbl_Click);
            this.SelectedRollerLbl.MouseEnter += new System.EventHandler(this.SelectedRollerLbl_MouseEnter);
            this.SelectedRollerLbl.MouseLeave += new System.EventHandler(this.SelectedRollerLbl_MouseLeave);
            // 
            // RollerLbl
            // 
            this.RollerLbl.AutoSize = true;
            this.RollerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollerLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.RollerLbl.Location = new System.Drawing.Point(252, 12);
            this.RollerLbl.Name = "RollerLbl";
            this.RollerLbl.Size = new System.Drawing.Size(55, 18);
            this.RollerLbl.TabIndex = 12;
            this.RollerLbl.Text = "Roller: ";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLbl.Location = new System.Drawing.Point(8, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(73, 18);
            this.TitleLbl.TabIndex = 3;
            this.TitleLbl.Text = "Die Roller";
            this.TitleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopWindowBar_MouseDown);
            // 
            // FlowPnl
            // 
            this.FlowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPnl.AutoScroll = true;
            this.FlowPnl.BackColor = System.Drawing.Color.Transparent;
            this.FlowPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FlowPnl.Location = new System.Drawing.Point(82, 39);
            this.FlowPnl.Margin = new System.Windows.Forms.Padding(1);
            this.FlowPnl.Name = "FlowPnl";
            this.FlowPnl.Padding = new System.Windows.Forms.Padding(10);
            this.FlowPnl.Size = new System.Drawing.Size(753, 267);
            this.FlowPnl.TabIndex = 5;
            // 
            // RollSelectPnl
            // 
            this.RollSelectPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RollSelectPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RollSelectPnl.Controls.Add(this.MixedCheck);
            this.RollSelectPnl.Controls.Add(this.PlasticChk);
            this.RollSelectPnl.Controls.Add(this.MetalChk);
            this.RollSelectPnl.Location = new System.Drawing.Point(308, 45);
            this.RollSelectPnl.Name = "RollSelectPnl";
            this.RollSelectPnl.Size = new System.Drawing.Size(112, 100);
            this.RollSelectPnl.TabIndex = 0;
            this.RollSelectPnl.Visible = false;
            // 
            // MixedCheck
            // 
            this.MixedCheck.AutoSize = true;
            this.MixedCheck.BackColor = System.Drawing.Color.Transparent;
            this.MixedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MixedCheck.ForeColor = System.Drawing.Color.White;
            this.MixedCheck.Location = new System.Drawing.Point(12, 60);
            this.MixedCheck.Name = "MixedCheck";
            this.MixedCheck.Size = new System.Drawing.Size(62, 21);
            this.MixedCheck.TabIndex = 15;
            this.MixedCheck.Text = "Mixed";
            this.MixedCheck.UseVisualStyleBackColor = false;
            this.MixedCheck.CheckedChanged += new System.EventHandler(this.MixedCheck_CheckedChanged);
            // 
            // PlasticChk
            // 
            this.PlasticChk.AutoSize = true;
            this.PlasticChk.BackColor = System.Drawing.Color.Transparent;
            this.PlasticChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlasticChk.ForeColor = System.Drawing.Color.White;
            this.PlasticChk.Location = new System.Drawing.Point(12, 37);
            this.PlasticChk.Name = "PlasticChk";
            this.PlasticChk.Size = new System.Drawing.Size(67, 21);
            this.PlasticChk.TabIndex = 14;
            this.PlasticChk.Text = "Plastic";
            this.PlasticChk.UseVisualStyleBackColor = false;
            this.PlasticChk.CheckedChanged += new System.EventHandler(this.PlasticChk_CheckedChanged);
            // 
            // MetalChk
            // 
            this.MetalChk.AutoSize = true;
            this.MetalChk.BackColor = System.Drawing.Color.Transparent;
            this.MetalChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetalChk.ForeColor = System.Drawing.Color.White;
            this.MetalChk.Location = new System.Drawing.Point(12, 14);
            this.MetalChk.Name = "MetalChk";
            this.MetalChk.Size = new System.Drawing.Size(60, 21);
            this.MetalChk.TabIndex = 13;
            this.MetalChk.Text = "Metal";
            this.MetalChk.UseVisualStyleBackColor = false;
            this.MetalChk.CheckedChanged += new System.EventHandler(this.MetalChk_CheckedChanged);
            // 
            // LeftUpPnl
            // 
            this.LeftUpPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(153)))), ((int)(((byte)(28)))));
            this.LeftUpPnl.Controls.Add(this.LeftUpContent);
            this.LeftUpPnl.Location = new System.Drawing.Point(1, 85);
            this.LeftUpPnl.Name = "LeftUpPnl";
            this.LeftUpPnl.Size = new System.Drawing.Size(80, 85);
            this.LeftUpPnl.TabIndex = 8;
            this.LeftUpPnl.Click += new System.EventHandler(this.LeftUpContent_Click);
            // 
            // LeftUpContent
            // 
            this.LeftUpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftUpContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.LeftUpContent.Controls.Add(this.pictureBox1);
            this.LeftUpContent.Location = new System.Drawing.Point(0, 0);
            this.LeftUpContent.Name = "LeftUpContent";
            this.LeftUpContent.Size = new System.Drawing.Size(68, 86);
            this.LeftUpContent.TabIndex = 0;
            this.LeftUpContent.Click += new System.EventHandler(this.LeftUpContent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::dnd.Properties.Resources.Worn_equipment;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.LeftUpContent_Click);
            // 
            // LeftDownContent
            // 
            this.LeftDownContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftDownContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.LeftDownContent.Controls.Add(this.DicePbx);
            this.LeftDownContent.Location = new System.Drawing.Point(0, -1);
            this.LeftDownContent.Name = "LeftDownContent";
            this.LeftDownContent.Size = new System.Drawing.Size(68, 86);
            this.LeftDownContent.TabIndex = 1;
            this.LeftDownContent.Click += new System.EventHandler(this.LeftDownContent_Click);
            // 
            // DicePbx
            // 
            this.DicePbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DicePbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DicePbx.BackgroundImage")));
            this.DicePbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DicePbx.Location = new System.Drawing.Point(15, 25);
            this.DicePbx.Name = "DicePbx";
            this.DicePbx.Size = new System.Drawing.Size(40, 40);
            this.DicePbx.TabIndex = 0;
            this.DicePbx.TabStop = false;
            this.DicePbx.Click += new System.EventHandler(this.LeftDownContent_Click);
            // 
            // LeftDownPnl
            // 
            this.LeftDownPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(153)))), ((int)(((byte)(28)))));
            this.LeftDownPnl.Controls.Add(this.LeftDownContent);
            this.LeftDownPnl.Location = new System.Drawing.Point(0, 0);
            this.LeftDownPnl.Name = "LeftDownPnl";
            this.LeftDownPnl.Size = new System.Drawing.Size(80, 85);
            this.LeftDownPnl.TabIndex = 10;
            this.LeftDownPnl.Click += new System.EventHandler(this.LeftDownContent_Click);
            // 
            // LeftBar
            // 
            this.LeftBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.LeftBar.Controls.Add(this.SettingsPnl);
            this.LeftBar.Controls.Add(this.LeftDownPnl);
            this.LeftBar.Controls.Add(this.LeftUpPnl);
            this.LeftBar.Location = new System.Drawing.Point(3, 41);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(81, 266);
            this.LeftBar.TabIndex = 1;
            // 
            // SettingsPnl
            // 
            this.SettingsPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.SettingsPnl.Controls.Add(this.SettingsDiv);
            this.SettingsPnl.Controls.Add(this.SettingsBtn);
            this.SettingsPnl.Location = new System.Drawing.Point(5, 218);
            this.SettingsPnl.Name = "SettingsPnl";
            this.SettingsPnl.Size = new System.Drawing.Size(71, 43);
            this.SettingsPnl.TabIndex = 9;
            // 
            // SettingsDiv
            // 
            this.SettingsDiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.SettingsDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsDiv.Location = new System.Drawing.Point(21, 1);
            this.SettingsDiv.Name = "SettingsDiv";
            this.SettingsDiv.Size = new System.Drawing.Size(30, 2);
            this.SettingsDiv.TabIndex = 12;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.BackgroundImage")));
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.Location = new System.Drawing.Point(20, 6);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(32, 32);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.TabStop = false;
            // 
            // heroWatch1
            // 
            this.heroWatch1.AutoSize = true;
            this.heroWatch1.Location = new System.Drawing.Point(82, 39);
            this.heroWatch1.Name = "heroWatch1";
            this.heroWatch1.Size = new System.Drawing.Size(753, 267);
            this.heroWatch1.TabIndex = 8;
            this.heroWatch1.Visible = false;
            // 
            // DiceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(838, 310);
            this.Controls.Add(this.LeftBar);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 304);
            this.Name = "DiceRollForm";
            this.Text = "D&D Companion";
            this.Load += new System.EventHandler(this.DiceRollForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopWindowBar_MouseDown);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.TopWindowBar.ResumeLayout(false);
            this.TopWindowBar.PerformLayout();
            this.RollSelectPnl.ResumeLayout(false);
            this.RollSelectPnl.PerformLayout();
            this.LeftUpPnl.ResumeLayout(false);
            this.LeftUpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LeftDownContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DicePbx)).EndInit();
            this.LeftDownPnl.ResumeLayout(false);
            this.LeftBar.ResumeLayout(false);
            this.SettingsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel TopWindowBar;
        private System.Windows.Forms.Label SelectedRollerLbl;
        private System.Windows.Forms.Label RollerLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.FlowLayoutPanel FlowPnl;
        private System.Windows.Forms.Button VolumeBtn;
        private System.Windows.Forms.Panel RollSelectPnl;
        private System.Windows.Forms.RadioButton MixedCheck;
        private System.Windows.Forms.RadioButton PlasticChk;
        private System.Windows.Forms.RadioButton MetalChk;
        private System.Windows.Forms.Panel LeftDownContent;
        private System.Windows.Forms.Panel LeftUpContent;
        private System.Windows.Forms.Panel LeftDownPnl;
        private System.Windows.Forms.Panel LeftUpPnl;
        private System.Windows.Forms.Panel LeftBar;
        private System.Windows.Forms.PictureBox DicePbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SettingsPnl;
        private System.Windows.Forms.PictureBox SettingsBtn;
        private System.Windows.Forms.Panel SettingsDiv;
        private dnd_stuff.Controls.HeroWatch heroWatch1;
    }
}

