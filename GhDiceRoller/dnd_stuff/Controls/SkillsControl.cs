using System.Windows.Forms;
using dnd.dnd_stuff;

namespace dnd.Controls
{
    internal class SkillsControl : UserControl
    {
        private Hero hero;

        public SkillsControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SkillsControl
            // 
            this.Name = "SkillsControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}