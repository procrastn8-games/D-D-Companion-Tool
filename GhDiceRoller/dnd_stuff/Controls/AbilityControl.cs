using System.Windows.Forms;
using dnd.dnd_stuff;

namespace dnd.Controls
{
    internal class AbilityControl : UserControl
    {
        private Hero hero;

        public AbilityControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AbilityControl
            // 
            this.Name = "AbilityControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}