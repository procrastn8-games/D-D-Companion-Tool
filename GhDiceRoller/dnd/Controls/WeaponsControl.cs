using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class WeaponsControl : UserControl
    {
        private FlowLayoutPanel FlowPnl;
        private Hero hero;

        public WeaponsControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.FlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlowPnl
            // 
            this.FlowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPnl.AutoScroll = true;
            this.FlowPnl.AutoScrollMargin = new System.Drawing.Size(400, 400);
            this.FlowPnl.BackColor = System.Drawing.Color.Transparent;
            this.FlowPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPnl.Location = new System.Drawing.Point(0, 0);
            this.FlowPnl.Name = "FlowPnl";
            this.FlowPnl.Size = new System.Drawing.Size(250, 327);
            this.FlowPnl.TabIndex = 0;
            this.FlowPnl.WrapContents = false;
            // 
            // WeaponsControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FlowPnl);
            this.Name = "WeaponsControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.Load += new System.EventHandler(this.WeaponsControl_Load);
            this.ResumeLayout(false);

        }

        private void WeaponsControl_Load(object sender, System.EventArgs e)
        {
            if (hero.weapons == null)
            {
                hero.weapons = new System.Collections.Generic.List<string>();

            }
            
            foreach(var wep in hero.weapons)
            {
                //add that shit
            }
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
                this.FlowPnl.Controls.Add(new dnd.Cards.weaponCard());
        }
    }
}