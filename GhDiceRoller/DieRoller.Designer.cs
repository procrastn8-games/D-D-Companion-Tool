namespace dnd
{
    partial class DieRoller
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumDown = new System.Windows.Forms.Label();
            this.NumUp = new System.Windows.Forms.Label();
            this.DieNumTxt = new System.Windows.Forms.Label();
            this.DieCountTxt = new System.Windows.Forms.Label();
            this.ModDown = new System.Windows.Forms.Label();
            this.ModUp = new System.Windows.Forms.Label();
            this.ModNumTxt = new System.Windows.Forms.Label();
            this.ModTxt = new System.Windows.Forms.Label();
            this.RollText = new System.Windows.Forms.TextBox();
            this.RollBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.NumDown);
            this.panel1.Controls.Add(this.NumUp);
            this.panel1.Controls.Add(this.DieNumTxt);
            this.panel1.Controls.Add(this.DieCountTxt);
            this.panel1.Controls.Add(this.ModDown);
            this.panel1.Controls.Add(this.ModUp);
            this.panel1.Controls.Add(this.ModNumTxt);
            this.panel1.Controls.Add(this.ModTxt);
            this.panel1.Controls.Add(this.RollText);
            this.panel1.Controls.Add(this.RollBtn);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 81);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // NumDown
            // 
            this.NumDown.BackColor = System.Drawing.Color.White;
            this.NumDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumDown.Location = new System.Drawing.Point(175, 17);
            this.NumDown.Name = "NumDown";
            this.NumDown.Size = new System.Drawing.Size(16, 16);
            this.NumDown.TabIndex = 41;
            this.NumDown.Text = "-";
            this.NumDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumDown.Click += new System.EventHandler(this.NumDown_Click);
            this.NumDown.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.NumDown.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // NumUp
            // 
            this.NumUp.BackColor = System.Drawing.Color.White;
            this.NumUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumUp.Location = new System.Drawing.Point(197, 17);
            this.NumUp.Name = "NumUp";
            this.NumUp.Size = new System.Drawing.Size(16, 16);
            this.NumUp.TabIndex = 40;
            this.NumUp.Text = "+";
            this.NumUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumUp.Click += new System.EventHandler(this.NumUp_Click);
            this.NumUp.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.NumUp.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // DieNumTxt
            // 
            this.DieNumTxt.BackColor = System.Drawing.Color.Transparent;
            this.DieNumTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DieNumTxt.Location = new System.Drawing.Point(153, 20);
            this.DieNumTxt.Name = "DieNumTxt";
            this.DieNumTxt.Size = new System.Drawing.Size(28, 19);
            this.DieNumTxt.TabIndex = 39;
            this.DieNumTxt.Text = "1";
            this.DieNumTxt.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.DieNumTxt.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // DieCountTxt
            // 
            this.DieCountTxt.AutoSize = true;
            this.DieCountTxt.BackColor = System.Drawing.Color.Transparent;
            this.DieCountTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DieCountTxt.Location = new System.Drawing.Point(104, 20);
            this.DieCountTxt.Name = "DieCountTxt";
            this.DieCountTxt.Size = new System.Drawing.Size(52, 13);
            this.DieCountTxt.TabIndex = 38;
            this.DieCountTxt.Text = "# of dice:";
            this.DieCountTxt.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.DieCountTxt.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // ModDown
            // 
            this.ModDown.BackColor = System.Drawing.Color.White;
            this.ModDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModDown.Location = new System.Drawing.Point(175, 47);
            this.ModDown.Name = "ModDown";
            this.ModDown.Size = new System.Drawing.Size(16, 16);
            this.ModDown.TabIndex = 37;
            this.ModDown.Text = "-";
            this.ModDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModDown.Click += new System.EventHandler(this.ModDown_Click);
            this.ModDown.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.ModDown.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // ModUp
            // 
            this.ModUp.BackColor = System.Drawing.Color.White;
            this.ModUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModUp.Location = new System.Drawing.Point(197, 47);
            this.ModUp.Name = "ModUp";
            this.ModUp.Size = new System.Drawing.Size(16, 16);
            this.ModUp.TabIndex = 36;
            this.ModUp.Text = "+";
            this.ModUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModUp.Click += new System.EventHandler(this.ModUp_Click);
            this.ModUp.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.ModUp.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // ModNumTxt
            // 
            this.ModNumTxt.BackColor = System.Drawing.Color.Transparent;
            this.ModNumTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModNumTxt.Location = new System.Drawing.Point(153, 45);
            this.ModNumTxt.Name = "ModNumTxt";
            this.ModNumTxt.Size = new System.Drawing.Size(28, 19);
            this.ModNumTxt.TabIndex = 35;
            this.ModNumTxt.Text = "0";
            this.ModNumTxt.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.ModNumTxt.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // ModTxt
            // 
            this.ModTxt.AutoSize = true;
            this.ModTxt.BackColor = System.Drawing.Color.Transparent;
            this.ModTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModTxt.Location = new System.Drawing.Point(104, 45);
            this.ModTxt.Name = "ModTxt";
            this.ModTxt.Size = new System.Drawing.Size(47, 13);
            this.ModTxt.TabIndex = 34;
            this.ModTxt.Text = "Modifier:";
            this.ModTxt.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.ModTxt.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // RollText
            // 
            this.RollText.BackColor = System.Drawing.Color.White;
            this.RollText.Location = new System.Drawing.Point(12, 44);
            this.RollText.Name = "RollText";
            this.RollText.Size = new System.Drawing.Size(75, 20);
            this.RollText.TabIndex = 33;
            this.RollText.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.RollText.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // RollBtn
            // 
            this.RollBtn.BackColor = System.Drawing.Color.White;
            this.RollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.RollBtn.Location = new System.Drawing.Point(12, 15);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(75, 23);
            this.RollBtn.TabIndex = 32;
            this.RollBtn.Text = "d";
            this.RollBtn.UseVisualStyleBackColor = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            this.RollBtn.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.RollBtn.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "DieRoller";
            this.Size = new System.Drawing.Size(226, 82);
            this.MouseEnter += new System.EventHandler(this.DieRoller_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DieRoller_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NumDown;
        private System.Windows.Forms.Label NumUp;
        private System.Windows.Forms.Label DieNumTxt;
        private System.Windows.Forms.Label DieCountTxt;
        private System.Windows.Forms.Label ModDown;
        private System.Windows.Forms.Label ModUp;
        private System.Windows.Forms.Label ModNumTxt;
        private System.Windows.Forms.Label ModTxt;
        private System.Windows.Forms.TextBox RollText;
        private System.Windows.Forms.Button RollBtn;
    }
}
