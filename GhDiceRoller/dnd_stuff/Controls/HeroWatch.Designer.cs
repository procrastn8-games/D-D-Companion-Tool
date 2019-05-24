namespace dnd.dnd_stuff.Controls
{
    partial class HeroWatch
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
            this.HeroContentPnl = new System.Windows.Forms.Panel();
            this.HeroSelectPnl = new System.Windows.Forms.Panel();
            this.HeroFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.HeroContentPnl.SuspendLayout();
            this.HeroSelectPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeroContentPnl
            // 
            this.HeroContentPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeroContentPnl.BackColor = System.Drawing.Color.DimGray;
            this.HeroContentPnl.Controls.Add(this.HeroSelectPnl);
            this.HeroContentPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.HeroContentPnl.Location = new System.Drawing.Point(0, 0);
            this.HeroContentPnl.Margin = new System.Windows.Forms.Padding(1);
            this.HeroContentPnl.Name = "HeroContentPnl";
            this.HeroContentPnl.Size = new System.Drawing.Size(756, 267);
            this.HeroContentPnl.TabIndex = 7;
            // 
            // HeroSelectPnl
            // 
            this.HeroSelectPnl.BackColor = System.Drawing.Color.Gainsboro;
            this.HeroSelectPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeroSelectPnl.Controls.Add(this.HeroFlowPnl);
            this.HeroSelectPnl.Location = new System.Drawing.Point(0, 0);
            this.HeroSelectPnl.Name = "HeroSelectPnl";
            this.HeroSelectPnl.Size = new System.Drawing.Size(753, 46);
            this.HeroSelectPnl.TabIndex = 0;
            // 
            // HeroFlowPnl
            // 
            this.HeroFlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.HeroFlowPnl.Location = new System.Drawing.Point(0, 0);
            this.HeroFlowPnl.Name = "HeroFlowPnl";
            this.HeroFlowPnl.Size = new System.Drawing.Size(753, 68);
            this.HeroFlowPnl.TabIndex = 0;
            // 
            // HeroWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.HeroContentPnl);
            this.Name = "HeroWatch";
            this.Size = new System.Drawing.Size(753, 267);
            this.HeroContentPnl.ResumeLayout(false);
            this.HeroSelectPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeroContentPnl;
        private System.Windows.Forms.Panel HeroSelectPnl;
        private System.Windows.Forms.FlowLayoutPanel HeroFlowPnl;
    }
}
