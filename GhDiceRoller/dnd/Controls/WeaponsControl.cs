using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class WeaponsControl : UserControl
    {
        private Hero hero;

        public WeaponsControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WeaponsControl
            // 
            this.Name = "WeaponsControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}