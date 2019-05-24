using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.dnd_stuff.Cards
{
    public partial class CheckCard : UserControl
    {
        private int mod;
        public CheckCard(string text, int mod)
        {
            InitializeComponent();
            this.button1.Text = text;
            this.mod = mod;
        }
    }
}
