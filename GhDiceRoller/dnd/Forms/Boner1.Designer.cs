namespace dnd.Controls
{
    partial class Boner1
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
            this.CharactersTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.CharactersTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharactersTabControl
            // 
            this.CharactersTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.CharactersTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharactersTabControl.Controls.Add(this.tabPage1);
            this.CharactersTabControl.Location = new System.Drawing.Point(-3, -1);
            this.CharactersTabControl.Multiline = true;
            this.CharactersTabControl.Name = "CharactersTabControl";
            this.CharactersTabControl.SelectedIndex = 0;
            this.CharactersTabControl.Size = new System.Drawing.Size(327, 435);
            this.CharactersTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Leave += new System.EventHandler(this.tabPage_Leave);
            // 
            // PlusBtn
            // 
            this.PlusBtn.FlatAppearance.BorderSize = 0;
            this.PlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBtn.Location = new System.Drawing.Point(-4, 408);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(23, 23);
            this.PlusBtn.TabIndex = 1;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // Boner1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::dnd.Properties.Resources.Border;
            this.ClientSize = new System.Drawing.Size(325, 434);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.CharactersTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Boner1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Character Manager";
            this.Load += new System.EventHandler(this.Boner1_Load);
            this.CharactersTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CharactersTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button PlusBtn;
    }
}