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

        public string DmgType { get; set; }
        public string DmgDie { get; set; }
        public string Note { get; set; }
        //check strength vs dex and take higher

        //roll a d20 
        //icon //show +stat modifier
        //strength or dex label
        //maybe let user add own icon if wanted.
    }
}
