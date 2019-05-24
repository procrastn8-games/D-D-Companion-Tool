using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnd.Controls;

namespace dnd
{
    public partial class DiceRollForm : Form
    {
        public bool Volume = true;
        public string rollers = "Plastic";
        public DiceRollForm()
        {
            InitializeComponent();
            SelectRollers();
        }

        private void VolumeOnOff(object sender, EventArgs e)
        {
            Volume = !Volume;
            setIcon();
        }

        private void setIcon()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (this.Volume)
            {
                this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.Volume1;
            }
            else
            {
                this.VolumeBtn.BackgroundImage = global::dnd.Properties.Resources.NotVolume;
            }
        }

        private void CharacterCreationBTN_Click(object sender, EventArgs e)
        {            
            Boner1 sfrm = (Boner1)Application.OpenForms["Character"];
            if (sfrm == null)
            {
                Boner1 s = new Boner1();
                s.Name = "Character";
                s.Show();
                s.Location = this.Location;
            }
            else
            {
                sfrm.TopMost = true;
                sfrm.TopMost = false;
            }
        }


		private void MaxBtn_Click(object sender, EventArgs e)
		{

			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}

			
		}

		private void MinBtn_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}


/// <summary>
/// 
/// dont get rid of this it makes the size grippers on the form
/// </summary>
/// <param name="m"></param>
		protected override void WndProc(ref Message m)
		{
			const UInt32 WM_NCHITTEST = 0x0084;
			const UInt32 WM_MOUSEMOVE = 0x0200;

			const UInt32 HTLEFT = 10;
			const UInt32 HTRIGHT = 11;
			const UInt32 HTBOTTOMRIGHT = 17;
			const UInt32 HTBOTTOM = 15;
			const UInt32 HTBOTTOMLEFT = 16;
			const UInt32 HTTOP = 12;
			const UInt32 HTTOPLEFT = 13;
			const UInt32 HTTOPRIGHT = 14;

			const int RESIZE_HANDLE_SIZE = 10;
			bool handled = false;
			if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
			{
				Size formSize = this.Size;
				Point screenPoint = new Point(m.LParam.ToInt32());
				Point clientPoint = this.PointToClient(screenPoint);

				Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
			{HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
			{HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
			{HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
			{HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
			{HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
			{HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
			{HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
			{HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
		};

				foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
				{
					if (hitBox.Value.Contains(clientPoint))
					{
						m.Result = (IntPtr)hitBox.Key;
						handled = true;
						break;
					}
				}
			}

			if (!handled)
				base.WndProc(ref m);
		}


		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void TopWindowBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			settingsFrm sfrm = (settingsFrm)Application.OpenForms["settings"];
			if (sfrm == null)
			{
				settingsFrm s = new settingsFrm();
				s.Name = "settings";
				s.Show();
				s.Location = this.Location;

			}
			else
			{
				sfrm.TopMost = true;
				sfrm.TopMost = false;
			}
		}

        private void SelectedRollerLbl_Click(object sender, EventArgs e)
        {
           
            this.RollSelectPnl.Visible = !this.RollSelectPnl.Visible;
            this.RollSelectPnl.BringToFront();
            //dnd.Controls.RollerSelector_thing rst = new dnd.Controls.RollerSelector_thing();
            //this.Controls.Add(rst);
            //rst.Show();
            //rst.BringToFront();
            //rst.Location = new Point(SelectedRollerLbl.Location.X, SelectedRollerLbl.Location.Y - 12);
           
        }

        private void SelectedRollerLbl_MouseEnter(object sender, EventArgs e)
        {
            SelectedRollerLbl.ForeColor = Color.White;
        }

        private void SelectedRollerLbl_MouseLeave(object sender, EventArgs e)
        {
            SelectedRollerLbl.ForeColor = Color.FromArgb(247, 153, 28);
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            this.CloseBtn.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBtn.BackColor = Color.Transparent;
           
        }

        private void MaxBtn_MouseEnter(object sender, EventArgs e)
        {
            this.MaxBtn.BackColor = Color.FromArgb(45,45,45);
        }

        private void MaxBtn_MouseLeave(object sender, EventArgs e)
        {
            this.MaxBtn.BackColor = Color.Transparent;
        }

        private void MinBtn_MouseEnter(object sender, EventArgs e)
        {
            this.MinBtn.BackColor = Color.FromArgb(45, 45, 45);
           
        }

        private void MinBtn_MouseLeave(object sender, EventArgs e)
        {
            this.MinBtn.BackColor = Color.Transparent;
        }

        private void MetalChk_CheckedChanged(object sender, EventArgs e)
        {
            rollerSwap(sender);
        }

        private void rollerSwap(object sender)
        {
            this.SelectedRollerLbl.Text = ((RadioButton)sender).Text + "  ▼";
            this.rollers = ((RadioButton)sender).Text;
            this.RollSelectPnl.Visible = false;
        }

        private void PlasticChk_CheckedChanged(object sender, EventArgs e)
        {
            rollerSwap(sender);
        }

        private void MixedCheck_CheckedChanged(object sender, EventArgs e)
        {
            rollerSwap(sender);
        }
        private Color Orange  = Color.FromArgb(247, 153, 28);
        private Color GrayBar = Color.FromArgb(034, 035, 37);
        private void LeftDownContent_Click(object sender, EventArgs e)
        {

            LeftUpPnl.BackColor = GrayBar;
            LeftDownPnl.BackColor = Orange;
            LeftUpPnl.BorderStyle = BorderStyle.None;
            LeftDownPnl.BorderStyle = BorderStyle.Fixed3D;
            SelectRollers();
        }

        private void LeftUpContent_Click(object sender, EventArgs e)
        {
            LeftUpPnl.BackColor = Orange;
            LeftDownPnl.BackColor = GrayBar;
            this.LeftDownPnl.BorderStyle = BorderStyle.None;
            FlowPnl.BackColor = GrayBar;
            LeftUpPnl.BorderStyle = BorderStyle.Fixed3D;
            SelectHero();
        }

        private void SelectRollers()
        {
            this.FlowPnl.Visible = true;
            this.heroWatch1.Visible = false;
            //List<int> usefullNums = new List<int> { 2, 4, 6, 10, 12, 20, 100 };
            //foreach (int num in usefullNums)
            //{
            //    FlowPnl.Controls.Add(new DieRoller(num));
            //}
        }

        private void SelectHero()
        {
            this.FlowPnl.Visible = false; 
            this.heroWatch1.Visible = true;          
        }

        private void DiceRollForm_Load(object sender, EventArgs e)
        {
            ///Select top boi
            LeftUpPnl.BackColor = GrayBar;
            LeftDownPnl.BackColor = Orange;
            LeftUpPnl.BorderStyle = BorderStyle.None;
            LeftDownPnl.BorderStyle = BorderStyle.Fixed3D;
            ////



        }

        /// <summary>
        /// close the whole app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}
