using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using dnd;

namespace dnd.Controls
{
    public partial class CharacterInterface : UserControl
    {
        public dnd.Hero hero;
        public CharacterInterface()
        {
            InitializeComponent();
            this.hero = new dnd.Hero();
        }

        public CharacterInterface(dnd.Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }
        private void switchTo(UserControl c)
        {
            this.ControlsPanel.Controls.Clear();
            this.ControlsPanel.Controls.Add(c);
        }

        private void CharacterSheetBtn_Click(object sender, EventArgs e)
        {
            switchTo(new characterSheet(hero));
        }

        private void WeaponsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new WeaponsControl(hero));
        }

        private void SpellsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new DescriptorControl(hero, "spell"));
        }

        private void AbilitiesBtn_Click(object sender, EventArgs e)
        {
            switchTo(new DescriptorControl(hero, "abilities"));
        }
        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            switchTo(new DescriptorControl(hero, "items"));
        }
        private void statsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new StatsControl(hero));
        }

        private void CheckSaveBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.ChecksSaves(hero));
        }
        private void FeatsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new DescriptorControl(hero, "spell"));
        }

        private void ProficencyBtn_Click(object sender, EventArgs e)
        {
            switchTo(new DescriptorControl(hero, "profish"));
        }

        private void PerceptionBtn_Click(object sender, EventArgs e)
        {
            switchTo(new PerceptionControl(hero));
        }

        private void CharacterInterface_Load(object sender, EventArgs e)
        {

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               string fileToOpen = FD.FileName;

                ChracterTxtBx.Text = Path.GetFileNameWithoutExtension(fileToOpen);
                //Parent.Text = ChracterTxtBx.Text;
                //System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                // System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);             
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Parent.Text = ChracterTxtBx.Text;
        }

        private void ControlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
