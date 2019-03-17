using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd
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

        internal static dnd.DiceRollForm getForm()
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
            bool CanCrit = false; 
            try
            {
                int numDice = int.Parse(DieNumTxt.Text);
                if(crit == 100 || crit == 20)
                {
                    CanCrit = true;
                }
                int mod = int.Parse(ModNumTxt.Text);
                if (getForm().Volume)
                {
                    playSound(numDice);
                }
                int total = 0;
                for (int i = 0; i < numDice; i++)
                {
                    int roll = getRandom(crit);
                    if (roll == crit && CanCrit) playCritSound();
                    else if (roll == 1 && CanCrit) playFailSound();
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

        private void playFailSound()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));

            var a = global::dnd.Properties.Resources._100_Percent;
            if (getRandom(3) > 1)
            {
                a = global::dnd.Properties.Resources._100_Percent;
            }
            else
            {
                a = global::dnd.Properties.Resources.Crit;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private void playCritSound()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));

            var a = global::dnd.Properties.Resources.Botched;
            if (getRandom(3) > 1)
            {
                a = global::dnd.Properties.Resources.Failure;
            }
            else
            {
                a = global::dnd.Properties.Resources.Botched;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
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
        }

        private void playPlastic(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;
           
            var a = global::dnd.Properties.Resources._3_Plastic;
            switch (numDice)
            {
                case 3:
                    if (getRandom(3) > 1)
                    {
                        a = global::dnd.Properties.Resources.Many_Plastic;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._3_Plastic;
                    }
                    break;
                case 2:
                    if (getRandom(3) > 1)
                    {
                    a= global::dnd.Properties.Resources._2_Plastic;
                    }
                    else
                    {
                    a = global::dnd.Properties.Resources._2_Plastic;
                    }
                    break;
                default:
                    a = global::dnd.Properties.Resources._1_Plastic;
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();

        }

        private void playMetal(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;

            var a = global::dnd.Properties.Resources._3_Plastic;
            switch (numDice)
            {
                case 3:
                    if (getRandom(3) > 1)
                    {
                        a = global::dnd.Properties.Resources.Many_Metal;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._3_Metal;
                    }
                    break;
                case 2:
                        a = global::dnd.Properties.Resources._2_Metal;                 
                    break;
                default:
                    a = global::dnd.Properties.Resources._1_Metal;
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private void playMixed(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;

            var a = global::dnd.Properties.Resources.Mixed_4;
            switch (numDice)
            {
                case 3:
                    if (getRandom(3) > 1)
                    {
                        a = global::dnd.Properties.Resources.Mixed_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources.Mixed_4;
                    }
                    break;
                case 2:
                    a = global::dnd.Properties.Resources.Mixed_2;
                    break;
                default:
                    a = global::dnd.Properties.Resources._1_Metal;
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
