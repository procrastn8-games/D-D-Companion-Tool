﻿namespace WindowsFormsApp2
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
            this.SuspendLayout();
            // 
            // NumDown
            // 
            this.NumDown.BackColor = System.Drawing.Color.White;
            this.NumDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumDown.Location = new System.Drawing.Point(187, 20);
            this.NumDown.Name = "NumDown";
            this.NumDown.Size = new System.Drawing.Size(13, 13);
            this.NumDown.TabIndex = 31;
            this.NumDown.Text = " - ";
            this.NumDown.Click += new System.EventHandler(this.NumDown_Click);
            // 
            // NumUp
            // 
            this.NumUp.AutoSize = true;
            this.NumUp.BackColor = System.Drawing.Color.White;
            this.NumUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumUp.Location = new System.Drawing.Point(187, 5);
            this.NumUp.Name = "NumUp";
            this.NumUp.Size = new System.Drawing.Size(13, 13);
            this.NumUp.TabIndex = 30;
            this.NumUp.Text = "+";
            this.NumUp.Click += new System.EventHandler(this.NumUp_Click);
            // 
            // DieNumTxt
            // 
            this.DieNumTxt.BackColor = System.Drawing.Color.Black;
            this.DieNumTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DieNumTxt.Location = new System.Drawing.Point(166, 8);
            this.DieNumTxt.Name = "DieNumTxt";
            this.DieNumTxt.Size = new System.Drawing.Size(15, 13);
            this.DieNumTxt.TabIndex = 29;
            this.DieNumTxt.Text = "1";
            // 
            // DieCountTxt
            // 
            this.DieCountTxt.AutoSize = true;
            this.DieCountTxt.BackColor = System.Drawing.Color.Black;
            this.DieCountTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DieCountTxt.Location = new System.Drawing.Point(113, 8);
            this.DieCountTxt.Name = "DieCountTxt";
            this.DieCountTxt.Size = new System.Drawing.Size(52, 13);
            this.DieCountTxt.TabIndex = 28;
            this.DieCountTxt.Text = "# of dice:";
            // 
            // ModDown
            // 
            this.ModDown.BackColor = System.Drawing.Color.White;
            this.ModDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModDown.Location = new System.Drawing.Point(187, 59);
            this.ModDown.Name = "ModDown";
            this.ModDown.Size = new System.Drawing.Size(13, 13);
            this.ModDown.TabIndex = 27;
            this.ModDown.Text = " - ";
            this.ModDown.Click += new System.EventHandler(this.ModDown_Click);
            // 
            // ModUp
            // 
            this.ModUp.AutoSize = true;
            this.ModUp.BackColor = System.Drawing.Color.White;
            this.ModUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModUp.Location = new System.Drawing.Point(187, 44);
            this.ModUp.Name = "ModUp";
            this.ModUp.Size = new System.Drawing.Size(13, 13);
            this.ModUp.TabIndex = 26;
            this.ModUp.Text = "+";
            this.ModUp.Click += new System.EventHandler(this.ModUp_Click);
            // 
            // ModNumTxt
            // 
            this.ModNumTxt.BackColor = System.Drawing.Color.Black;
            this.ModNumTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModNumTxt.Location = new System.Drawing.Point(166, 51);
            this.ModNumTxt.Name = "ModNumTxt";
            this.ModNumTxt.Size = new System.Drawing.Size(15, 13);
            this.ModNumTxt.TabIndex = 25;
            this.ModNumTxt.Text = "0";
            // 
            // ModTxt
            // 
            this.ModTxt.AutoSize = true;
            this.ModTxt.BackColor = System.Drawing.Color.Black;
            this.ModTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModTxt.Location = new System.Drawing.Point(113, 51);
            this.ModTxt.Name = "ModTxt";
            this.ModTxt.Size = new System.Drawing.Size(47, 13);
            this.ModTxt.TabIndex = 24;
            this.ModTxt.Text = "Modifier:";
            // 
            // RollText
            // 
            this.RollText.Location = new System.Drawing.Point(12, 50);
            this.RollText.Name = "RollText";
            this.RollText.Size = new System.Drawing.Size(75, 20);
            this.RollText.TabIndex = 23;
            // 
            // RollBtn
            // 
            this.RollBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollBtn.Location = new System.Drawing.Point(12, 3);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(75, 23);
            this.RollBtn.TabIndex = 22;
            this.RollBtn.Text = "d";
            this.RollBtn.UseVisualStyleBackColor = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NumDown);
            this.Controls.Add(this.NumUp);
            this.Controls.Add(this.DieNumTxt);
            this.Controls.Add(this.DieCountTxt);
            this.Controls.Add(this.ModDown);
            this.Controls.Add(this.ModUp);
            this.Controls.Add(this.ModNumTxt);
            this.Controls.Add(this.ModTxt);
            this.Controls.Add(this.RollText);
            this.Controls.Add(this.RollBtn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DieRoller";
            this.Size = new System.Drawing.Size(220, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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