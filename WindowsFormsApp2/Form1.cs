using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DiceRollForm : Form
    {
        public bool Volume;
        public string rollers = "plastic";
        public DiceRollForm()
        {
            InitializeComponent();
            List<int> usefullNums = new List<int> { 4, 6, 10, 12, 20 };
            foreach(int num in usefullNums)
            {
                FlowPnl.Controls.Add(new WindowsFormsApp2.DieRoller(num));
            }

        }

        private void VolumeOnOff(object sender, EventArgs e)
        {
            Volume = !Volume;
            setIcon();
        }

        private void setIcon()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (this.Volume)
            {
                this.VolumeBtn.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Volume1;
            }
            else
            {
                this.VolumeBtn.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.NotVolume;
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {           
            settingsFrm sfrm = (settingsFrm)Application.OpenForms["settings"];
            if ( sfrm== null)
            {
            settingsFrm s = new settingsFrm();
            s.Name = "settings";
            s.StartPosition = FormStartPosition.CenterParent;
            s.Show();
            }
            else
            {
                sfrm.TopMost = true;
                sfrm.TopMost = false;
            }

        }
    }
}
