using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd
{
    public partial class settingsFrm : Form
    {
        public settingsFrm()
        {
            InitializeComponent();
        }

        private void MetalChk_CheckedChanged(object sender, EventArgs e)
        {
            DieRoller.getForm().rollers = "Metal";
        }

        private void PlasticChk_CheckedChanged(object sender, EventArgs e)
        {
            DieRoller.getForm().rollers = "Plastic";
        }

        private void MixedCheck_CheckedChanged(object sender, EventArgs e)
        {
            DieRoller.getForm().rollers = "Mixed";
        }
    }
}
