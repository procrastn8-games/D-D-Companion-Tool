namespace dnd.dnd_stuff.Cards
{
    partial class TopCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddSpell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // AddSpell
            // 
            this.AddSpell.Location = new System.Drawing.Point(200, 3);
            this.AddSpell.Name = "AddSpell";
            this.AddSpell.Size = new System.Drawing.Size(22, 23);
            this.AddSpell.TabIndex = 1;
            this.AddSpell.Text = "+";
            this.AddSpell.UseVisualStyleBackColor = true;
            this.AddSpell.Click += new System.EventHandler(this.AddSpell_Click);
            // 
            // TopCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AddSpell);
            this.Controls.Add(this.label1);
            this.Name = "TopCard";
            this.Size = new System.Drawing.Size(225, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSpell;
    }
}
