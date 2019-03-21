namespace FileRefrenceChecker
{
    partial class Form1
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
            this.RaveLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RaveLbl
            // 
            this.RaveLbl.AutoSize = true;
            this.RaveLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaveLbl.Location = new System.Drawing.Point(257, 146);
            this.RaveLbl.Name = "RaveLbl";
            this.RaveLbl.Size = new System.Drawing.Size(131, 15);
            this.RaveLbl.TabIndex = 0;
            this.RaveLbl.Text = "are you here for the rave?";
            this.RaveLbl.Click += new System.EventHandler(this.RaveLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 311);
            this.Controls.Add(this.RaveLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RaveLbl;
    }
}

