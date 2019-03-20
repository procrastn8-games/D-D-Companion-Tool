using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class SpellsControl : UserControl
    {
        private Hero hero;

        public SpellsControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SpellsControl
            // 
            this.Name = "SpellsControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}