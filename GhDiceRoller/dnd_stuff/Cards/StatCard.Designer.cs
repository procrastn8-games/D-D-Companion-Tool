namespace dnd.dnd_stuff.Cards
{
    partial class StatCard
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
            this.ModLbl = new System.Windows.Forms.Label();
            this.StatLbl = new System.Windows.Forms.Label();
            this.IconPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ModLbl
            // 
            this.ModLbl.AutoSize = true;
            this.ModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ModLbl.Location = new System.Drawing.Point(30, 69);
            this.ModLbl.Name = "ModLbl";
            this.ModLbl.Size = new System.Drawing.Size(20, 24);
            this.ModLbl.TabIndex = 89;
            this.ModLbl.Text = "0";
            // 
            // StatLbl
            // 
            this.StatLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.StatLbl.Location = new System.Drawing.Point(0, 40);
            this.StatLbl.Name = "StatLbl";
            this.StatLbl.Size = new System.Drawing.Size(85, 29);
            this.StatLbl.TabIndex = 88;
            this.StatLbl.Text = "Stat";
            this.StatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconPB
            // 
            this.IconPB.Location = new System.Drawing.Point(23, 3);
            this.IconPB.Name = "IconPB";
            this.IconPB.Size = new System.Drawing.Size(40, 36);
            this.IconPB.TabIndex = 90;
            this.IconPB.TabStop = false;
            // 
            // StatCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.IconPB);
            this.Controls.Add(this.ModLbl);
            this.Controls.Add(this.StatLbl);
            this.Name = "StatCard";
            this.Size = new System.Drawing.Size(85, 101);
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ModLbl;
        public System.Windows.Forms.Label StatLbl;
        public System.Windows.Forms.PictureBox IconPB;
    }
}
