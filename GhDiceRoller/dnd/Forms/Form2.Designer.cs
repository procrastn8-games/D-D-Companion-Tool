namespace dnd.dnd.Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VerticalBtn = new System.Windows.Forms.Button();
            this.CharacterCreationBTN = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new System.Windows.Forms.PictureBox();
            this.VolumeBtn = new System.Windows.Forms.PictureBox();
            this.DiceRollForm = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterCreationBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = global::dnd.Properties.Resources.Border;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.VerticalBtn);
            this.panel1.Controls.Add(this.CharacterCreationBTN);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.VolumeBtn);
            this.panel1.Location = new System.Drawing.Point(2, -85);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 245);
            this.panel1.TabIndex = 3;
            // 
            // VerticalBtn
            // 
            this.VerticalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticalBtn.BackColor = System.Drawing.Color.Transparent;
            this.VerticalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VerticalBtn.FlatAppearance.BorderSize = 0;
            this.VerticalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerticalBtn.Image = global::dnd.Properties.Resources.icons8_down_arrow_50;
            this.VerticalBtn.Location = new System.Drawing.Point(6, 201);
            this.VerticalBtn.Name = "VerticalBtn";
            this.VerticalBtn.Size = new System.Drawing.Size(34, 37);
            this.VerticalBtn.TabIndex = 9;
            this.VerticalBtn.UseVisualStyleBackColor = false;
            this.VerticalBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterCreationBTN
            // 
            this.CharacterCreationBTN.BackColor = System.Drawing.Color.Transparent;
            this.CharacterCreationBTN.BackgroundImage = global::dnd.Properties.Resources.CharacterSheetButton;
            this.CharacterCreationBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterCreationBTN.ErrorImage = null;
            this.CharacterCreationBTN.Location = new System.Drawing.Point(10, 161);
            this.CharacterCreationBTN.Name = "CharacterCreationBTN";
            this.CharacterCreationBTN.Size = new System.Drawing.Size(30, 32);
            this.CharacterCreationBTN.TabIndex = 7;
            this.CharacterCreationBTN.TabStop = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BackgroundImage = global::dnd.Properties.Resources.Settings;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.Location = new System.Drawing.Point(10, 83);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(30, 32);
            this.SettingsBtn.TabIndex = 6;
            this.SettingsBtn.TabStop = false;
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume1;
            this.VolumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeBtn.ErrorImage = null;
            this.VolumeBtn.Location = new System.Drawing.Point(10, 122);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(30, 32);
            this.VolumeBtn.TabIndex = 5;
            this.VolumeBtn.TabStop = false;
            // 
            // DiceRollForm
            // 
            this.DiceRollForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiceRollForm.AutoScroll = true;
            this.DiceRollForm.BackColor = System.Drawing.Color.Black;
            this.DiceRollForm.BackgroundImage = global::dnd.Properties.Resources.InterfaceBG;
            this.DiceRollForm.Location = new System.Drawing.Point(46, -2);
            this.DiceRollForm.Margin = new System.Windows.Forms.Padding(1);
            this.DiceRollForm.Name = "DiceRollForm";
            this.DiceRollForm.Size = new System.Drawing.Size(748, 162);
            this.DiceRollForm.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 159);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiceRollForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "D&D Companion";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterCreationBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CharacterCreationBTN;
        private System.Windows.Forms.PictureBox SettingsBtn;
        private System.Windows.Forms.PictureBox VolumeBtn;
        private System.Windows.Forms.FlowLayoutPanel DiceRollForm;
        private System.Windows.Forms.Button VerticalBtn;
    }
}