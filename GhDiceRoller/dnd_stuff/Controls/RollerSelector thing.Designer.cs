namespace dnd.dnd_stuff.Controls
{
    partial class RollerSelector_thing
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
            this.MixedCheck = new System.Windows.Forms.RadioButton();
            this.PlasticChk = new System.Windows.Forms.RadioButton();
            this.MetalChk = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MixedCheck
            // 
            this.MixedCheck.AutoSize = true;
            this.MixedCheck.BackColor = System.Drawing.Color.Transparent;
            this.MixedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MixedCheck.ForeColor = System.Drawing.Color.White;
            this.MixedCheck.Location = new System.Drawing.Point(18, 70);
            this.MixedCheck.Name = "MixedCheck";
            this.MixedCheck.Size = new System.Drawing.Size(62, 21);
            this.MixedCheck.TabIndex = 12;
            this.MixedCheck.Text = "Mixed";
            this.MixedCheck.UseVisualStyleBackColor = false;
            // 
            // PlasticChk
            // 
            this.PlasticChk.AutoSize = true;
            this.PlasticChk.BackColor = System.Drawing.Color.Transparent;
            this.PlasticChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlasticChk.ForeColor = System.Drawing.Color.White;
            this.PlasticChk.Location = new System.Drawing.Point(18, 47);
            this.PlasticChk.Name = "PlasticChk";
            this.PlasticChk.Size = new System.Drawing.Size(67, 21);
            this.PlasticChk.TabIndex = 11;
            this.PlasticChk.Text = "Plastic";
            this.PlasticChk.UseVisualStyleBackColor = false;
            // 
            // MetalChk
            // 
            this.MetalChk.AutoSize = true;
            this.MetalChk.BackColor = System.Drawing.Color.Transparent;
            this.MetalChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetalChk.ForeColor = System.Drawing.Color.White;
            this.MetalChk.Location = new System.Drawing.Point(18, 24);
            this.MetalChk.Name = "MetalChk";
            this.MetalChk.Size = new System.Drawing.Size(60, 21);
            this.MetalChk.TabIndex = 10;
            this.MetalChk.Text = "Metal";
            this.MetalChk.UseVisualStyleBackColor = false;
            // 
            // RollerSelector_thing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MixedCheck);
            this.Controls.Add(this.PlasticChk);
            this.Controls.Add(this.MetalChk);
            this.Name = "RollerSelector_thing";
            this.Size = new System.Drawing.Size(116, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MixedCheck;
        private System.Windows.Forms.RadioButton PlasticChk;
        private System.Windows.Forms.RadioButton MetalChk;
    }
}
