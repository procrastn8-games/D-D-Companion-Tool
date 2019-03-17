using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.Controls
{
    public partial class Boner1 : Form
    {
        public Boner1()
        {
            InitializeComponent();
        }

        private void Boner1_Load(object sender, EventArgs e)
        {
            foreach(TabPage tab in CharactersTabControl.TabPages)
            {
                tab.Controls.Add(new dnd.Controls.CharacterInterface());
            }
        }

    }
}
