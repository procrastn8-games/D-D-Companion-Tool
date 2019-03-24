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

        public int strength;
        public int dexterity;
        public int constitution;
        public int wisdom;
        public int intelligence;
        public int charisma;

        public List<Weapon> weapons;
        public List<Descriptor> armor;
        public List<Descriptor> items;
        public List<Descriptor> spells;
        public List<Descriptor> proficiencies;
        public List<Descriptor> features;
        public List<Skill> SkillList;
        public List<Descriptor> abilities;

        public int level;
        public int xp;
        public string HeroClass;
        public int Maxhp;
        public int remainingHp;

        public int initiative;
        public int speed;
        public int armorClass;

        private int getModifier(int level)
        {
            int mod = 0;
            if (level == 30)
            {
                mod = 10;
            }
            else if (level == 28 || level == 29)
            {
                mod = 9;
            }
            else if (level == 27 || level == 26)
            {
                mod = 8;
            }
            else if (level == 24 || level == 25)
            {
                mod = 7;
            }
            else if (level == 22 || level == 23)
            {
                mod = 6;
            }
            else if (level == 20 || level == 21)
            {
                mod = 5;
            }
            else if (level == 19 || level == 18)
            {
                mod = 4;
            }
            else if (level == 17 || level == 16)
            {
                mod = 3;
            }
            else if (level == 15 || level == 14)
            {
                mod = 2;
            }
            else if (level == 13 || level == 12)
            {
                mod = 1;
            }
            else if (level == 11 || level == 10)
            {
                mod = 0;
            }
            else if (level == 9 || level == 8)
            {
                mod = -1;
            }
            else if (level == 7 || level == 6)
            {
                mod = -2;
            }
            else if (level == 5 || level == 4)
            {
                mod = -3;
            }
            else if (level == 3 || level == 2)
            {
                mod = -4;
                    
            }
            else
            {
                mod =-5;
            }
            return mod;
        }



        private int profishBonus()
        {
            int bonus = 2;
            if (this.level>=5)
            {
                bonus = 3;
            }
            if (this.level >= 9)
            {
                bonus = 4;
            }
            if (this.level >= 12)
            {
                bonus = 5;
            }
            if (this.level >= 17)
            {
                bonus = 6;
            }
            return bonus;
        }



        // initiative -dex
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
