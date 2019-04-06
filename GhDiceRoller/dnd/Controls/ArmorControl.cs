using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class ArmorControl : UserControl
    {
        private Hero hero;

        public ArmorControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ArmorControl
            // 
            this.Name = "ArmorControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}