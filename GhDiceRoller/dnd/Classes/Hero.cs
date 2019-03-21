using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd.dnd
{

    public class Hero
    {
        public string name = "";
        public string strength;
        public string dexterity;
        public string constitution;
        public string wisdom;
        public string intelligence;
        public string charisma;

        public List<string> weapons;
        public List<string> armor;
        public List<string> equipment;
        public List<string> spells;
        public List<string> proficiencies;
        public List<string> features;
        public List<Skill> SkillList;

        public int level;
        public string HeroClass;
        public int Maxhp;
        public int remainingHp;

        public int initiative;
        public int speed;
        public int armorClass;
        


        // acrobatics -dex 
        // animalHandling -wisdom
        // arcana -int
        // athletics -str
        // deception -charisma
        // history -int
        // insight -wisdom
        // intimidation -charisma
        // investigation -int
        // medicene -wis
        // nature -int
        // perception -wis
        // performance -charisma
        // persuation -charisma
        // religion -int
        // slightOfHand -dex
        // stealth -dex
        // survival -wis

       

    }
}
