using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace FileRefrenceChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RaveLbl_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int delay = 10;
                this.BackColor = SystemColors.ControlDark;
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(delay);
                this.BackColor = Color.Red;
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(delay);
                this.BackColor = Color.Blue;
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(delay);
                this.BackColor = Color.HotPink;
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(delay);
                this.BackColor = Color.Yellow;
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(delay);
                this.BackColor = Color.Purple;
                this.Refresh();
                Application.DoEvents();
                Thread.Sleep(delay);
            }

        }
    }
}
