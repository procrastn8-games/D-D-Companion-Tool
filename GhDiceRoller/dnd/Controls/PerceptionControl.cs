using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class PerceptionControl : UserControl
    {
        private Hero hero;

        public PerceptionControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PerceptionControl
            // 
            this.Name = "PerceptionControl";
            this.Size = new System.Drawing.Size(231, 309);
            this.ResumeLayout(false);

        }
    }
}