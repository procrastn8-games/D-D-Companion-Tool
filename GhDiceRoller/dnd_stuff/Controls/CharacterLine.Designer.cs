namespace dnd.dnd_stuff.Controls
{
    partial class CharacterLine
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
            this.CharLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CharLbl
            // 
            this.CharLbl.AutoSize = true;
            this.CharLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(153)))), ((int)(((byte)(28)))));
            this.CharLbl.Location = new System.Drawing.Point(14, 1);
            this.CharLbl.Name = "CharLbl";
            this.CharLbl.Size = new System.Drawing.Size(53, 13);
            this.CharLbl.TabIndex = 0;
            this.CharLbl.Text = "Character";
            this.CharLbl.MouseEnter += new System.EventHandler(this.Lbl_MouseEnter);
            this.CharLbl.MouseLeave += new System.EventHandler(this.Lbl_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 1);
            this.panel1.TabIndex = 1;
            // 
            // CharacterLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CharLbl);
            this.Name = "CharacterLine";
            this.Size = new System.Drawing.Size(101, 20);
            this.MouseEnter += new System.EventHandler(this.Lbl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Lbl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CharLbl;
        private System.Windows.Forms.Panel panel1;
    }
}
