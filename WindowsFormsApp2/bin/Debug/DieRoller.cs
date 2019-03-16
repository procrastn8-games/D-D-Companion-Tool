using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DieRoller : UserControl
    {
        private int crit;
        public DieRoller(int v)
        {
            InitializeComponent();
            this.crit = v;
            this.RollBtn.Text = RollBtn.Text + v;
        }

        private void NumUp_Click(object sender, EventArgs e)
        {
            DieNumTxt.Text = "" + (int.Parse(DieNumTxt.Text) + 1);
        }

        internal static WindowsFormsApp2.DiceRollForm getForm()
        {
            DiceRollForm dr = (DiceRollForm)Application.OpenForms["DiceRollForm"];
            return dr;
        }

        private void NumDown_Click(object sender, EventArgs e)
        {
            if (int.Parse(DieNumTxt.Text) > 1)
            {
                DieNumTxt.Text = "" + (int.Parse(DieNumTxt.Text) - 1);
            }
        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int numDice = int.Parse(DieNumTxt.Text);
                int mod = int.Parse(ModNumTxt.Text);
                if (getForm().Volume)
                {
                    playSound(numDice);
                }
                int total = 0;
                for (int i = 0; i < numDice; i++)
                {
                    int roll = getRandom(crit);
                    roll = roll + mod;
                    total = total + roll;
                }
                RollText.Text = "" + total;
            }
            catch
            {
                MessageBox.Show("woops, drank too much grog, can't math that");
            }

        }

        private void playSound(int numDice)
        {
            string rollers = getForm().rollers;
            if (rollers.ToLower().Equals("plastic"))
            {
                playPlastic(numDice);
            }
            else if (rollers.ToLower().Equals("metal")){
                playMetal(numDice);
            }
            else
            {
                playMixed(numDice);
            }


            String path;
            switch (numDice)
            {
                case 1:
                    path = "";
                    break;
                default:
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
            player.Play();
        }

        private void playPlastic(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;
           
            var a = global::WindowsFormsApp2.Properties.Resources._3_Plastic;
            switch (numDice)
            {
                case 3:
                    if (getRandom(3) > 1)
                    {
                        a = global::WindowsFormsApp2.Properties.Resources.Many_Plastic;
                    }
                    else
                    {
                        a = global::WindowsFormsApp2.Properties.Resources._3_Plastic;
                    }
                    break;
                case 2:
                    if (getRandom(3) > 1)
                    {
                    a= global::WindowsFormsApp2.Properties.Resources._2_Plastic;
                    }
                    else
                    {
                    a = global::WindowsFormsApp2.Properties.Resources._2_Plastic;
                    }
                    break;
                default:
                    a = global::WindowsFormsApp2.Properties.Resources._1_Plastic;
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();

        }

        private void playMetal(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;

            var a = global::WindowsFormsApp2.Properties.Resources._3_Plastic;
            switch (numDice)
            {
                case 3:
                    if (getRandom(3) > 1)
                    {
                        a = global::WindowsFormsApp2.Properties.Resources.Many_Metal;
                    }
                    else
                    {
                        a = global::WindowsFormsApp2.Properties.Resources._3_Metal;
                    }
                    break;
                case 2:
                        a = global::WindowsFormsApp2.Properties.Resources._2_Metal;                 
                    break;
                default:
                    a = global::WindowsFormsApp2.Properties.Resources._1_Metal;
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private void playMixed(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;

            var a = global::WindowsFormsApp2.Properties.Resources.Mixed_4;
            switch (numDice)
            {
                case 3:
                    if (getRandom(3) > 1)
                    {
                        a = global::WindowsFormsApp2.Properties.Resources.Mixed_3;
                    }
                    else
                    {
                        a = global::WindowsFormsApp2.Properties.Resources.Mixed_4;
                    }
                    break;
                case 2:
                    a = global::WindowsFormsApp2.Properties.Resources.Mixed_2;
                    break;
                default:
                    a = global::WindowsFormsApp2.Properties.Resources._1_Metal;
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private int getRandom(int v)
        {
            Random random = new Random();
            return random.Next(1, v + 1);
        }

        private void ModUp_Click(object sender, EventArgs e)
        {
            ModNumTxt.Text = "" + (int.Parse(ModNumTxt.Text) + 1);
        }

        private void ModDown_Click(object sender, EventArgs e)
        {
            ModNumTxt.Text = "" + (int.Parse(ModNumTxt.Text) - 1);
        }
    }
}
