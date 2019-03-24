using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.dnd.Cards
{
    public partial class TopCard : UserControl
    {
        public TopCard()
        {
            InitializeComponent();
        }

        private void AddSpell_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new dnd.Cards.DescriptorsControl());
        }
    }
}
