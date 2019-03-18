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
            this.panel1.BackgroundImage = global::dnd.Properties.Resources.InterfaceBG;
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NumDown
            // 
            this.NumDown.BackColor = System.Drawing.Color.White;
            this.NumDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumDown.Location = new System.Drawing.Point(256, 10);
            this.NumDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumDown.Name = "NumDown";
            this.NumDown.Size = new System.Drawing.Size(22, 20);
            this.NumDown.TabIndex = 41;
            this.NumDown.Text = " -   ";
            this.NumDown.Click += new System.EventHandler(this.NumDown_Click);
            // 
            // NumUp
            // 
            this.NumUp.BackColor = System.Drawing.Color.White;
            this.NumUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumUp.Location = new System.Drawing.Point(228, 10);
            this.NumUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumUp.Name = "NumUp";
            this.NumUp.Size = new System.Drawing.Size(22, 20);
            this.NumUp.TabIndex = 40;
            this.NumUp.Text = " +";
            this.NumUp.Click += new System.EventHandler(this.NumUp_Click);
            // 
            // DieNumTxt
            // 
            this.DieNumTxt.BackColor = System.Drawing.Color.Transparent;
            this.DieNumTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DieNumTxt.Location = new System.Drawing.Point(204, 13);
            this.DieNumTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DieNumTxt.Name = "DieNumTxt";
            this.DieNumTxt.Size = new System.Drawing.Size(37, 23);
            this.DieNumTxt.TabIndex = 39;
            this.DieNumTxt.Text = "1";
            // 
            // DieCountTxt
            // 
            this.DieCountTxt.AutoSize = true;
            this.DieCountTxt.BackColor = System.Drawing.Color.Transparent;
            this.DieCountTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DieCountTxt.Location = new System.Drawing.Point(139, 13);
            this.DieCountTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DieCountTxt.Name = "DieCountTxt";
            this.DieCountTxt.Size = new System.Drawing.Size(66, 17);
            this.DieCountTxt.TabIndex = 38;
            this.DieCountTxt.Text = "# of dice:";
            // 
            // ModDown
            // 
            this.ModDown.BackColor = System.Drawing.Color.White;
            this.ModDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModDown.Location = new System.Drawing.Point(256, 69);
            this.ModDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModDown.Name = "ModDown";
            this.ModDown.Size = new System.Drawing.Size(22, 20);
            this.ModDown.TabIndex = 37;
            this.ModDown.Text = " - ";
            this.ModDown.Click += new System.EventHandler(this.ModDown_Click);
            // 
            // ModUp
            // 
            this.ModUp.BackColor = System.Drawing.Color.White;
            this.ModUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModUp.Location = new System.Drawing.Point(228, 69);
            this.ModUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModUp.Name = "ModUp";
            this.ModUp.Size = new System.Drawing.Size(22, 20);
            this.ModUp.TabIndex = 36;
            this.ModUp.Text = " +";
            this.ModUp.Click += new System.EventHandler(this.ModUp_Click);
            // 
            // ModNumTxt
            // 
            this.ModNumTxt.BackColor = System.Drawing.Color.Transparent;
            this.ModNumTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModNumTxt.Location = new System.Drawing.Point(204, 66);
            this.ModNumTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModNumTxt.Name = "ModNumTxt";
            this.ModNumTxt.Size = new System.Drawing.Size(37, 23);
            this.ModNumTxt.TabIndex = 35;
            this.ModNumTxt.Text = "0";
            // 
            // ModTxt
            // 
            this.ModTxt.AutoSize = true;
            this.ModTxt.BackColor = System.Drawing.Color.Transparent;
            this.ModTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModTxt.Location = new System.Drawing.Point(139, 66);
            this.ModTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModTxt.Name = "ModTxt";
            this.ModTxt.Size = new System.Drawing.Size(62, 17);
            this.ModTxt.TabIndex = 34;
            this.ModTxt.Text = "Modifier:";
            // 
            // RollText
            // 
            this.RollText.Location = new System.Drawing.Point(16, 65);
            this.RollText.Margin = new System.Windows.Forms.Padding(4);
            this.RollText.Name = "RollText";
            this.RollText.Size = new System.Drawing.Size(99, 22);
            this.RollText.TabIndex = 33;
            // 
            // RollBtn
            // 
            this.RollBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollBtn.Location = new System.Drawing.Point(16, 7);
            this.RollBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(100, 28);
            this.RollBtn.TabIndex = 32;
            this.RollBtn.Text = "d";
            this.RollBtn.UseVisualStyleBackColor = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DieRoller";
            this.Size = new System.Drawing.Size(301, 101);
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
