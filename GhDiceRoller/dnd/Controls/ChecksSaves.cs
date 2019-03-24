using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.dnd.Controls
{
    public partial class ChecksSaves : UserControl
    {
        private Hero hero;
        public ChecksSaves(dnd.Hero hero)
        {
            this.hero = hero;
            InitializeComponent();
            List<Check> checks = new List<Check>();
            checks.Add(new Check("initiative", hero.dexterity));
            checks.Add(new Check("perception", hero.wisdom));
            checks.Add(new Check("acrobatics", hero.dexterity));
            checks.Add(new Check("animal Handling", hero.wisdom));
            checks.Add(new Check("arcana", hero.intelligence));
            checks.Add(new Check("athletics", hero.strength));
            checks.Add(new Check("decpetion", hero.charisma));
            checks.Add(new Check("history", hero.intelligence));
            checks.Add(new Check("insight", hero.wisdom));
            checks.Add(new Check("intimidation", hero.charisma));
            checks.Add(new Check("investigation", hero.intelligence));
            checks.Add(new Check("medicine", hero.wisdom));        
            checks.Add(new Check("performance", hero.charisma));
            checks.Add(new Check("persuation", hero.charisma));
            checks.Add(new Check("religion", hero.intelligence));
            checks.Add(new Check("slightOfHand", hero.dexterity));
            checks.Add(new Check("stealth", hero.dexterity));
            checks.Add(new Check("Constitution", hero.constitution));
            checks.Add(new Check("strength", hero.wisdom));
            checks.Add(new Check("Int", hero.wisdom));
            checks.Add(new Check("Wisdom", hero.wisdom));
            checks.Add(new Check("dexterity", hero.wisdom));
            checks.Add(new Check("charisma", hero.wisdom));

            foreach(Check c in checks)
            {
                this.flowPnl.Controls.Add(new dnd.Cards.CheckCard(c.text,c.dependency));
            }
          




        }
    }
}
class Check
{
    public Check(string text, int dep)
    {
        this.text = text;
        this.dependency = dep;
    }


    public string text;
    public int dependency;
}
