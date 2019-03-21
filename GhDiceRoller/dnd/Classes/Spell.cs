using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd.dnd.Classes
{
    
    class Spell
    {

        public string name;
        public bool isProficient;
        public int modifier;
        public string icoPath;
        //check strength vs dex and take higher

        //roll a d20 
        //icon //show +stat modifier
        //strength or dex label
        //maybe let user add own icon if wanted.

        public Spell(string name, bool proficiency, int mod, string icoPath)
        {
            this.name = name;
            this.isProficient = proficiency;
            this.modifier = mod;
            this.icoPath = icoPath;
        }

        //add the things to do the things

    }
}
