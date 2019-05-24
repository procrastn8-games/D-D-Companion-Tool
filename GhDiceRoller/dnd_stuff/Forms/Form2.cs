using dnd.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.dnd_stuff.Forms
{
    public partial class Form2 : Form
    {

    public bool Volume = true;
    public string rollers = "Plastic";
    DiceRollForm drf;

    public Form2(DiceRollForm drf)
    {
        this.drf = drf;
        InitializeComponent();
        List<int> usefullNums = new List<int> { 2, 4, 6, 10, 12, 20, 100 };
        foreach (int num in usefullNums)
        {
           DiceRollForm.Controls.Add(new DieRoller(num));
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
        if (sfrm == null)
        {
            settingsFrm s = new settingsFrm();
            s.Name = "settings";
            s.Show();
            s.Location = this.Location;

        }
        else
        {
            sfrm.TopMost = true;
            sfrm.TopMost = false;
        }

    }

    private void CharacterCreationBTN_Click(object sender, EventArgs e)
    {

        Boner1 sfrm = (Boner1)Application.OpenForms["Character"];
        if (sfrm == null)
        {
            Boner1 s = new Boner1();
            s.Name = "Character";
            s.Show();
            s.Location = this.Location;
        }
        else
        {
            sfrm.TopMost = true;
            sfrm.TopMost = false;
        }
    }

    private void DiceRollForm_Load(object sender, EventArgs e)
    {

    }

        private void button1_Click(object sender, EventArgs e)
        {
            drf.Show();
            this.Close();
        }
    }
}
