using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.dnd_stuff.Classes
{
   public class Weapon
    {
        public string name;
        public bool isProficient;
        public int modifier;
        public string icoPath;

        public MaskedTextBox DmgType { get; internal set; }
        public string DmgDie { get; internal set; }
        public TextBox Note { get; internal set; }
        //check strength vs dex and take higher

        //roll a d20 
        //icon //show +stat modifier
        //strength or dex label
        //maybe let user add own icon if wanted.
    }
}
