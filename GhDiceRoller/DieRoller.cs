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

        internal static DiceRollForm getForm()
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
                    if (Environment.UserName.ToLower().Equals("lukas")){
                        roll = 1;
                    }
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
            var a = global::dnd.Properties.Resources.Awful;
            int choices = getRandom(4);
            if (choices == 4)
            {
                a = global::dnd.Properties.Resources.Awful;
            }
            else if (choices == 3)
            {
                a = global::dnd.Properties.Resources.Fucked_Up;
            }
            else if (choices == 2)
            {
                a = global::dnd.Properties.Resources.Lost_Another_One;
            }
            else
            {
                a = global::dnd.Properties.Resources.You_re_Fucked_mixdown;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private void playCritSound()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));

            var a = global::dnd.Properties.Resources.Fancy;
            int choices = getRandom(2);
            if (choices == 2) 
            {
                a = global::dnd.Properties.Resources.Fancy;
            }
            else
            {
                a = global::dnd.Properties.Resources.Illogical;
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
           
            var a = global::dnd.Properties.Resources._3_Plastic_1;
                    int choices = getRandom(8);
            switch (numDice)
            {
                case 3:
                    if (choices == 8)
                    {
                        a = global::dnd.Properties.Resources._3_Plastic_1;
                    }
                    else if (choices == 7)
                    {
                        a = global::dnd.Properties.Resources._3_Plastic_2;
                    }
                    else if (choices == 6)
                    {
                        a = global::dnd.Properties.Resources._3_Plastic_3;
                    }
                    else if (choices == 5)
                    {
                        a = global::dnd.Properties.Resources._3_Plastic_4;
                    }
                    else if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources.Many_Plastic_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources.Many_Plastic_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources.Many_Plastic_3;
                    }
                    else 
                    {
                        a = global::dnd.Properties.Resources.Many_Plastic_4;
                    }
                    break;
                case 2:
                    choices = getRandom(4);
                    if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources._2_Plastic_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources._2_Plastic_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources._2_Plastic_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._2_Plastic_4;
                    }
                    break;
                default:
                    choices = getRandom(4);
                    if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources._1_Plastic_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources._1_Plastic_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources._1_Plastic_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._1_Plastic_4;
                    }
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();

        }

        private void playMetal(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;

            var a = global::dnd.Properties.Resources._3_Metal_1;
            int choices = getRandom(8);
            switch (numDice)
            {
                case 3:
                    
                    if (choices == 8)
                    {
                        a = global::dnd.Properties.Resources._3_Metal_1;
                    }
                    else if (choices == 7)
                    {
                        a = global::dnd.Properties.Resources._3_Metal_2;
                    }
                    else if (choices == 6)
                    {
                        a = global::dnd.Properties.Resources._3_Metal_3;
                    }
                    else if (choices == 5)
                    {
                        a = global::dnd.Properties.Resources._3_Metal_4;
                    }
                    else if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources.Many_Plastic_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources.Many_Metal_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources.Many_Metal_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources.Many_Metal_4;
                    }
                    break;
                case 2:
                    choices = getRandom(4);
                    if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources._2_Metal_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources._2_Metal_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources._2_Metal_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._2_Metal_4;
                    }
                    break;
                default:
                    choices = getRandom(4);
                    if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources._1_Metal_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources._1_metal_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources._1_Metal_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._1_Metal_4;
                    }
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private void playMixed(int numDice)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRollForm));
            if (numDice > 2) numDice = 3;
            var a = global::dnd.Properties.Resources.Mixed_4_1;
            int choices = getRandom(8);
            switch (numDice)
            {
                case 3:
                    if (choices == 8)
                    {
                        a = global::dnd.Properties.Resources.Mixed_4_1;
                    }
                    else if (choices == 7)
                    {
                        a = global::dnd.Properties.Resources.Mixed_4_2;
                    }
                    else if (choices == 6)
                    {
                        a = global::dnd.Properties.Resources.Mixed_4_3;
                    }
                    else if (choices == 5)
                    {
                        a = global::dnd.Properties.Resources.Mixed_4_4;
                    }
                    else if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources.Mixed_3_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources.Mixed_3_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources.Mixed_3_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources.Mixed_3_4;
                    }
                    break;
                case 2:
                    choices = getRandom(4);
                    if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources.Mixed_2_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources.Mixed_2_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources.Mixed_2_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources.Mixed_2_4;
                    }
                    break;
                default:
                    choices = getRandom(4);
                    if (choices == 4)
                    {
                        a = global::dnd.Properties.Resources._1_Metal_1;
                    }
                    else if (choices == 3)
                    {
                        a = global::dnd.Properties.Resources._1_metal_2;
                    }
                    else if (choices == 2)
                    {
                        a = global::dnd.Properties.Resources._1_Plastic_3;
                    }
                    else
                    {
                        a = global::dnd.Properties.Resources._1_Plastic_4;
                    }
                    break;
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(a);
            player.Play();
        }

        private int getRandom(int v)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
