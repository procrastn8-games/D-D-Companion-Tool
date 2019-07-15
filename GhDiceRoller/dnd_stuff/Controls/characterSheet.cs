using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.Controls
{
    public partial class characterSheet : UserControl
    {
        private dnd_stuff.Hero hero;
        public characterSheet(dnd_stuff.Hero hero)
        {
            InitializeComponent();
            this.hero = hero;


        }


        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            NameBx.Text = hero.name;
        }

        private void CharacterInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
