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

namespace dnd.Controls
{
    public partial class CharacterInterface : UserControl
    {
        public CharacterInterface()
        {
            InitializeComponent();
        }

        private void switchTo(UserControl c)
        {
            this.ControlsPanel.Controls.Clear();
            this.ControlsPanel.Controls.Add(c);
        }

        private void CharacterSheetBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.characterSheet());
        }

        private void WeaponsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.WeaponsControl());
        }

        private void SpellsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.SpellsControl());
        }

        private void AbilitiesBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.AbilityControl());
        }

        private void SkillsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.SkillsControl());
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.StatsControl());
        }

        private void ArmorBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.ArmorControl());
        }

        private void ProficencyBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.ProficienyControl());
        }

        private void PerceptionBtn_Click(object sender, EventArgs e)
        {
            switchTo(new dnd.Controls.PerceptionControl());
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
    }
}
