namespace dnd.dnd.Controls
{
    partial class ChecksSaves
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
            this.flowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowPnl
            // 
            this.flowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPnl.AutoScroll = true;
            this.flowPnl.BackgroundImage = global::dnd.Properties.Resources.InterfaceBG;
            this.flowPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPnl.Location = new System.Drawing.Point(0, 0);
            this.flowPnl.Name = "flowPnl";
            this.flowPnl.Size = new System.Drawing.Size(231, 309);
            this.flowPnl.TabIndex = 0;
            // 
            // ChecksSaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPnl);
            this.Name = "ChecksSaves";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPnl;
    }
}
