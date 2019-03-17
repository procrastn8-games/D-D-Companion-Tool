using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.Controls.Add(c);
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
    }
}
