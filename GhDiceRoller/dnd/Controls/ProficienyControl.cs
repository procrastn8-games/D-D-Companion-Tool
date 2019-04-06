using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class ProficienyControl : UserControl
    {
        private Hero hero;

        public ProficienyControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProficienyControl
            // 
            this.Name = "ProficienyControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}