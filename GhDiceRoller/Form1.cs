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
    public partial class DiceRollForm : Form
    {
        public bool Volume = true;
        public string rollers = "plastic";
        public DiceRollForm()
        {
            InitializeComponent();
            List<int> usefullNums = new List<int> { 2, 4, 6, 10, 12, 20, 100 };
            foreach(int num in usefullNums)
            {
                FlowPnl.Controls.Add(new dnd.DieRoller(num));
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
                this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume1;
            }
            else
            {
                this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.NotVolume;
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

        private void CharacterCreationBTN_Click(object sender, EventArgs e)
        {
            dnd.Controls.Boner1 cform = new dnd.Controls.Boner1();
            cform.Show();

        }
    }
}
