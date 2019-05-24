using System.Collections.Generic;
using System.Windows.Forms;
using dnd.dnd_stuff;

namespace dnd.Controls
{
    internal class DescriptorControl : UserControl
    {
        private FlowLayoutPanel FlowPnl;
        private dnd_stuff.Cards.TopCard topCard1;
        private Hero hero;
        private List<dnd_stuff.Classes.Descriptor> dList;

        public DescriptorControl(Hero hero, string type)
        {
            InitializeComponent();
            this.hero = hero;
            var a = hero.spells;
            List<dnd_stuff.Classes.Descriptor> list = new List<dnd_stuff.Classes.Descriptor>();
            switch (type)
            {
                case "spell":
                    dList = hero.spells;
                    break;
                case "abilitys":
                    dList = hero.abilities;
                    break;
                case "items":
                    dList = hero.items;
                    break;
                case "feats":
                    dList = hero.features;
                    break;
                case "profish":
                    dList = hero.proficiencies;
                    break;
                default:
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.FlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.topCard1 = new dnd_stuff.Cards.TopCard();
            this.FlowPnl.SuspendLayout();
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
            this.FlowPnl.Controls.Add(this.topCard1);
            this.FlowPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPnl.Location = new System.Drawing.Point(0, 0);
            this.FlowPnl.Name = "FlowPnl";
            this.FlowPnl.Size = new System.Drawing.Size(250, 327);
            this.FlowPnl.TabIndex = 1;
            this.FlowPnl.WrapContents = false;
            // 
            // topCard1
            // 
            this.topCard1.Location = new System.Drawing.Point(3, 3);
            this.topCard1.Name = "topCard1";
            this.topCard1.Size = new System.Drawing.Size(225, 28);
            this.topCard1.TabIndex = 0;
            // 
            // DescriptorControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FlowPnl);
            this.Name = "DescriptorControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.Load += new System.EventHandler(this.SpellsControl_Load);
            this.FlowPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SpellsControl_Load(object sender, System.EventArgs e)
        {
            this.FlowPnl.Controls.Add(new dnd_stuff.Cards.DescriptorsControl());
           

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.FlowPnl.Controls.Add(new dnd_stuff.Cards.DescriptorsControl());
        }
    }
}