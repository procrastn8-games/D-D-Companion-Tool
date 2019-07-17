using System;
using System.Windows.Forms;

namespace dnd.Controls
{
    public partial class characterSheet : UserControl
    {
        private dnd_stuff.Hero hero;
        public characterSheet(dnd_stuff.Hero hero)
        {
            InitializeComponent();
            this.hero = hero;          
        }


        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            NameBx.Text = hero.name.ToString();
            ExpBx.Text = hero.xp.ToString();
            ClassBx.Text = hero.HeroClass.ToString();
            LevelBx.Text =  hero.level.ToString(); ;
            AllignBx.Text = hero.allignment;
            RaceBx.Text = hero.race;
            SexBx.Text = hero.Sex;
            DescBx.Text = hero.Desc;
            //get the big stats
            STRStatLbl.Text = hero.strength.ToString(); 
            DEXStatLbl.Text = hero.dexterity.ToString();
            CONStatLbl.Text = hero.constitution.ToString();
            INTStatLbl.Text = hero.intelligence.ToString();
            WISStatLbl.Text = hero.wisdom.ToString();
            CHAStatLbl.Text = hero.charisma.ToString();
            //saving throw proficency (stat is based on a mod)
            StrProfChk.Checked = hero.isProfStrSaves;
            DexProfChk.Checked = hero.isProfDexSaves;
            ConProfChk.Checked = hero.isProfConSaves;
            DexProfChk.Checked = hero.isProfIntSaves;
            WisProfChk.Checked = hero.isProfWisSaves;
            ChaProfChk.Checked = hero.isProfChaSaves;
            //pull gen stats
            ACBx.Text = hero.armorClass.ToString();
            InitBx.Text = hero.initiative.ToString();
            SpdBx.Text = hero.speed.ToString();
            HPBx.Text = hero.remainingHp.ToString();
            HitDiceBx.Text = hero.HitDice;
            try
            {
                Succ1Die.Checked = hero.GoodSaves[0];
                Succ2Die.Checked = hero.GoodSaves[1];
                Succ3Die.Checked = hero.GoodSaves[2];
            }
            catch
            {
                Succ1Die.Checked = false;
                Succ2Die.Checked = false;
                Succ3Die.Checked = false;
            }
            ///
            try
            {
                Fail1Die.Checked = hero.FailSaves[0];
                Fail2Die.Checked = hero.FailSaves[1];
                Fail3Die.Checked = hero.FailSaves[2];
            }
            catch
            {
                Fail1Die.Checked = false;
                Fail2Die.Checked = false;
                Fail3Die.Checked = false;
            }


            //get proffs and traits and langs and items
            ProfBx.Text = hero.ProfAbilField;
            LangBx.Text = hero.Langs;
            ItemBx.Text = hero.ItemsFld;
            //get weapons
            try
            {
                Wep1WepBx.Text = hero.weapons[0].name;
                Wep1DmgBx.Text = hero.weapons[0].DmgDie;
                Wep1TypeBx.Text = hero.weapons[0].DmgType;
                Wep1NotesBx.Text = hero.weapons[0].Note;
            }
            catch
            {
                Wep1WepBx.Text = "";
                Wep1DmgBx.Text ="";
                Wep1TypeBx.Text = "";
                Wep1NotesBx.Text = "";
            }


            //2
            try
            {
                Wep2WepBx.Text = hero.weapons[1].name;
                Wep2DmgBx.Text = hero.weapons[1].DmgDie;
                Wep2TypeBx.Text = hero.weapons[1].DmgType;
                Wep2NotesBx.Text = hero.weapons[1].Note;
            }
            catch
            {
                Wep2WepBx.Text = "";
                Wep2DmgBx.Text = "";
                Wep2TypeBx.Text = "";
                Wep2NotesBx.Text = "";
            }
            //3
            try
            {
                Wep3WepBx.Text = hero.weapons[2].name;
                Wep3DmgBx.Text = hero.weapons[2].DmgDie;
                Wep3TypeBx.Text = hero.weapons[2].DmgType;
                Wep3NotesBx.Text = hero.weapons[2].Note;
            }
            catch
            {
                Wep3WepBx.Text = "";
                Wep3DmgBx.Text = "";
                Wep3TypeBx.Text = "";
                Wep3NotesBx.Text = "";
            }
            //get ammo
            try
            {
                Ammo1AmmoBx.Text = hero.Ammo[0].name;
                Ammo1AmtBx.Text = hero.Ammo[0].Amt;
            }
            catch
            {
                Ammo1AmmoBx.Text = "";
                Ammo1AmtBx.Text = "";
            }

            //1
            try
            {
                Ammo2AmmoBx.Text = hero.Ammo[1].name;
                Ammo2AmtBx.Text = hero.Ammo[1].Amt;
            }
            catch
            {
                Ammo2AmmoBx.Text = "";
                Ammo2AmtBx.Text = "";
            }
            //2
            try
            {
                Ammo3AmmoBx.Text = hero.Ammo[2].name;
                Ammo3AmtBx.Text = hero.Ammo[2].Amt;
            }
            catch
            {
                Ammo3AmmoBx.Text = "";
                Ammo3AmtBx.Text = "";
            }
            //get treasure and other equips
            TresBx.Text = hero.treasure;
            OtherEquipBx.Text = hero.Equipment;

        }

        private void CharacterInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
