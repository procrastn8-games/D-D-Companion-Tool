using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class StatsControl : UserControl
    {
        private Hero hero;

        public StatsControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StatsControl
            // 
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}