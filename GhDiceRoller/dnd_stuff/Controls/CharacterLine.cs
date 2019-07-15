using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.dnd_stuff.Controls
{
    public partial class CharacterLine : UserControl
    {
        public CharacterLine()
        {
            InitializeComponent();
        }

        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.White;
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(247, 153, 28);
        }
    }
}
