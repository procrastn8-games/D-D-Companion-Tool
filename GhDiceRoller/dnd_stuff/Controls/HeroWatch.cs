using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnd.dnd_stuff.Classes;

namespace dnd.dnd_stuff.Controls
{
    public partial class HeroWatch : UserControl
    {
        public HeroWatch()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.HeroContentPanel.Controls.Clear();
            this.HeroContentPanel.Controls.Add(new dnd.Controls.characterSheet(new Hero() { name = "deku" }));
        }

        private void HeroWatch_Load(object sender, EventArgs e)
        {
            this.HeroContentPanel.Controls.Add(new Label() { Name = "pls", Text = "Select hero!" });
        }

        private void CheckForHero()
        {
            if (Logic.HasSelectedHero())
            {
                this.HeroContentPanel.Controls.Add(new Label() { Name = "pls", Text = "Select hero!" });
            }
            else
            {
                this.HeroContentPanel.Controls.Clear();
                this.HeroContentPanel.Controls.Add(new dnd.Controls.characterSheet(Logic.GetHero()));
            }
        }

        private void HeroWatch_Paint(object sender, PaintEventArgs e)
        {

            if(!DesignMode)
            {
                if (HeroContentPanel.Controls[0].Name.Equals("pls"))
                {
                    CheckForHero();
                }
            }

        }
    }
}
