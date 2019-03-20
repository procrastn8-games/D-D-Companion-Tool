using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd.dnd
{

    class Hero
    {
        string name = "";
        string strength;
        string dexterity;
        string constitution;
        string wisdom;
        string intelligence;
        string charisma;   

        List<string> weapons;
        List<string> armor;
        List<string> equipment;
        List<string> spells;
        List<string> proficiencies;
        List<string> features;
        List<Skill> SkillList;

        int level;
        string HeroClass;
        int Maxhp;
        int remainingHp;

        int initiative;
        int speed;
        int armorClass;
        


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
