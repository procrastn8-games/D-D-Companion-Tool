namespace dnd
{
    partial class settingsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.spacePnl2 = new System.Windows.Forms.Panel();
            this.SettingsLbl = new System.Windows.Forms.Label();
            this.MixedCheck = new System.Windows.Forms.RadioButton();
            this.PlasticChk = new System.Windows.Forms.RadioButton();
            this.MetalChk = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.spacePnl2);
            this.panel1.Controls.Add(this.SettingsLbl);
            this.panel1.Controls.Add(this.MixedCheck);
            this.panel1.Controls.Add(this.PlasticChk);
            this.panel1.Controls.Add(this.MetalChk);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 56);
            this.panel1.TabIndex = 0;
            // 
            // spacePnl2
            // 
            this.spacePnl2.BackColor = System.Drawing.Color.Transparent;
            this.spacePnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spacePnl2.ForeColor = System.Drawing.SystemColors.Control;
            this.spacePnl2.Location = new System.Drawing.Point(9, 21);
            this.spacePnl2.Name = "spacePnl2";
            this.spacePnl2.Size = new System.Drawing.Size(255, 1);
            this.spacePnl2.TabIndex = 4;
            // 
            // SettingsLbl
            // 
            this.SettingsLbl.AutoSize = true;
            this.SettingsLbl.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsLbl.Location = new System.Drawing.Point(113, 5);
            this.SettingsLbl.Name = "SettingsLbl";
            this.SettingsLbl.Size = new System.Drawing.Size(45, 13);
            this.SettingsLbl.TabIndex = 3;
            this.SettingsLbl.Text = "Settings";
            this.SettingsLbl.UseMnemonic = false;
            // 
            // MixedCheck
            // 
            this.MixedCheck.AutoSize = true;
            this.MixedCheck.BackColor = System.Drawing.Color.Transparent;
            this.MixedCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.MixedCheck.Location = new System.Drawing.Point(183, 32);
            this.MixedCheck.Name = "MixedCheck";
            this.MixedCheck.Size = new System.Drawing.Size(88, 17);
            this.MixedCheck.TabIndex = 2;
            this.MixedCheck.Text = "Mixed Rollers";
            this.MixedCheck.UseVisualStyleBackColor = false;
            this.MixedCheck.CheckedChanged += new System.EventHandler(this.MixedCheck_CheckedChanged);
            // 
            // PlasticChk
            // 
            this.PlasticChk.AutoSize = true;
            this.PlasticChk.BackColor = System.Drawing.Color.Transparent;
            this.PlasticChk.ForeColor = System.Drawing.SystemColors.Control;
            this.PlasticChk.Location = new System.Drawing.Point(95, 32);
            this.PlasticChk.Name = "PlasticChk";
            this.PlasticChk.Size = new System.Drawing.Size(91, 17);
            this.PlasticChk.TabIndex = 1;
            this.PlasticChk.Text = "Plastic Rollers";
            this.PlasticChk.UseVisualStyleBackColor = false;
            this.PlasticChk.CheckedChanged += new System.EventHandler(this.PlasticChk_CheckedChanged);
            // 
            // MetalChk
            // 
            this.MetalChk.AutoSize = true;
            this.MetalChk.BackColor = System.Drawing.Color.Transparent;
            this.MetalChk.ForeColor = System.Drawing.SystemColors.Control;
            this.MetalChk.Location = new System.Drawing.Point(9, 32);
            this.MetalChk.Name = "MetalChk";
            this.MetalChk.Size = new System.Drawing.Size(86, 17);
            this.MetalChk.TabIndex = 0;
            this.MetalChk.Text = "Metal Rollers";
            this.MetalChk.UseVisualStyleBackColor = false;
            this.MetalChk.CheckedChanged += new System.EventHandler(this.MetalChk_CheckedChanged);
            // 
            // settingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(290, 69);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsFrm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel spacePnl2;
        private System.Windows.Forms.Label SettingsLbl;
        private System.Windows.Forms.RadioButton MixedCheck;
        private System.Windows.Forms.RadioButton PlasticChk;
        private System.Windows.Forms.RadioButton MetalChk;
    }
}