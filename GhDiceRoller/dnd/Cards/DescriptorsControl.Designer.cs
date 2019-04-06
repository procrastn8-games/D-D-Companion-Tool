namespace dnd.dnd.Cards
{
    partial class DescriptorsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLbl = new System.Windows.Forms.Label();
            this.IcoSelectorCmb = new System.Windows.Forms.ComboBox();
            this.IconBx = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.DescriptionBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconBx)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLbl.Location = new System.Drawing.Point(55, 1);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(161, 41);
            this.NameLbl.TabIndex = 64;
            this.NameLbl.Text = "Label";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // IcoSelectorCmb
            // 
            this.IcoSelectorCmb.BackColor = System.Drawing.Color.White;
            this.IcoSelectorCmb.ForeColor = System.Drawing.Color.White;
            this.IcoSelectorCmb.FormattingEnabled = true;
            this.IcoSelectorCmb.Location = new System.Drawing.Point(3, 48);
            this.IcoSelectorCmb.Name = "IcoSelectorCmb";
            this.IcoSelectorCmb.Size = new System.Drawing.Size(53, 21);
            this.IcoSelectorCmb.TabIndex = 63;
            this.IcoSelectorCmb.Text = "Icon?";
            // 
            // IconBx
            // 
            this.IconBx.BackColor = System.Drawing.Color.Transparent;
            this.IconBx.BackgroundImage = global::dnd.Properties.Resources.icons8_sword_24;
            this.IconBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconBx.Location = new System.Drawing.Point(3, 1);
            this.IconBx.Name = "IconBx";
            this.IconBx.Size = new System.Drawing.Size(46, 46);
            this.IconBx.TabIndex = 62;
            this.IconBx.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(3, 72);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(53, 23);
            this.browseBtn.TabIndex = 65;
            this.browseBtn.Text = "browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            // 
            // DescriptionBx
            // 
            this.DescriptionBx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBx.ForeColor = System.Drawing.SystemColors.Window;
            this.DescriptionBx.Location = new System.Drawing.Point(58, 45);
            this.DescriptionBx.Multiline = true;
            this.DescriptionBx.Name = "DescriptionBx";
            this.DescriptionBx.Size = new System.Drawing.Size(170, 50);
            this.DescriptionBx.TabIndex = 66;
            this.DescriptionBx.Text = "Description of this card........................................................." +
    "................................................................................" +
    ".............................";
            // 
            // DescriptorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.DescriptionBx);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IcoSelectorCmb);
            this.Controls.Add(this.IconBx);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DescriptorsControl";
            this.Size = new System.Drawing.Size(231, 98);
            ((System.ComponentModel.ISupportInitialize)(this.IconBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ComboBox IcoSelectorCmb;
        private System.Windows.Forms.PictureBox IconBx;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox DescriptionBx;
    }
}
