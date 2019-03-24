using dnd.dnd.Classes;
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

        public List<Weapon> weapons;
        public List<Descriptor> armor;
        public List<Descriptor> items;
        public List<Descriptor> spells;
        public List<Descriptor> proficiencies;
        public List<Descriptor> features;
        public List<Skill> SkillList;
        public List<Descriptor> abilities;

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
