using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace dnd.dnd_stuff.Classes
{
    class Logic
    {


        internal static DiceRollForm getMain()
        {
            var f = (dnd.DiceRollForm)Application.OpenForms["DiceRollForm"];
            return f;
        }
        public static bool HasSelectedHero()
        {
            var d = getMain();
            string currentHero = d.HeroSelectLbl.Text;
            string None = "Not Selected ▼";
            return currentHero.Equals(None);
        }

        internal static void SaveHero()
        {
            Hero h = new Hero();
            try
            {
                //save the sheet
                var sheet = (dnd.Controls.characterSheet)getMain().heroWatch1.HeroContentPanel.Controls[0];
                //save general panel stuff
                h.name = sheet.NameBx.Text;
                h.xp = Int32.Parse(sheet.ExpBx.Text);
                h.HeroClass = sheet.ClassBx.Text;
                h.level = Int32.Parse(sheet.LevelBx.Text);
                h.allignment = sheet.AllignBx.Text;
                h.race = sheet.RaceBx.Text;
                h.Sex = sheet.SexBx.Text;
                h.Desc = sheet.DescBx.Text;
                //get the big stats
                h.strength = Int32.Parse(sheet.STRStatLbl.Text);
                h.dexterity = Int32.Parse(sheet.DEXStatLbl.Text);
                h.constitution = Int32.Parse(sheet.CONStatLbl.Text);
                h.intelligence = Int32.Parse(sheet.INTStatLbl.Text);
                h.wisdom = Int32.Parse(sheet.WISStatLbl.Text);
                h.charisma = Int32.Parse(sheet.CHAStatLbl.Text);
                //saving throw proficency (stat is based on a mod)
                h.isProfStrSaves = sheet.StrProfChk.Checked;
                h.isProfDexSaves = sheet.DexProfChk.Checked;
                h.isProfConSaves = sheet.ConProfChk.Checked;
                h.isProfIntSaves = sheet.DexProfChk.Checked;
                h.isProfWisSaves = sheet.WisProfChk.Checked;
                h.isProfChaSaves = sheet.ChaProfChk.Checked;
                //pull gen stats
                h.armorClass = Int32.Parse(sheet.ACBx.Text);
                h.initiative = Int32.Parse(sheet.InitBx.Text);
                h.speed = Int32.Parse(sheet.SpdBx.Text);
                h.remainingHp = Int32.Parse(sheet.HPBx.Text);
                h.HitDice = sheet.HitDiceBx.Text;
                h.GoodSaves = new List<bool>{ sheet.Succ1Die.Checked, sheet.Succ2Die.Checked, sheet.Succ3Die.Checked };
                h.FailSaves = new List<bool> { sheet.Fail1Die.Checked, sheet.Fail2Die.Checked, sheet.Fail3Die.Checked };
                //get proffs and traits and langs and items
                h.ProfAbilField = sheet.ProfBx.Text;
                h.Langs = sheet.LangBx.Text;
                h.ItemsFld = sheet.ItemBx.Text;
                //get weapons
                Weapon wep1 = new Weapon
                {
                    name = sheet.Wep1WepBx.Text,
                    DmgDie = sheet.Wep1DmgBx.Text,
                    DmgType = sheet.Wep1TypeBx,
                    Note = sheet.Wep1NotesBx
                };
                Weapon wep2 = new Weapon
                {
                    name = sheet.Wep2WepBx.Text,
                    DmgDie = sheet.Wep2DmgBx.Text,
                    DmgType = sheet.Wep2TypeBx,
                    Note = sheet.Wep2NotesBx
                };
                Weapon wep3 = new Weapon
                {
                    name = sheet.Wep3WepBx.Text,
                    DmgDie = sheet.Wep3DmgBx.Text,
                    DmgType = sheet.Wep3TypeBx,
                    Note = sheet.Wep3NotesBx
                };
                h.weapons = new List<Weapon> { wep1, wep2, wep3 };
                //get Ammo
                Ammo Ammo1 = new Ammo
                {
                    name = sheet.Ammo1AmmoBx.Text,
                    Amt = sheet.Ammo1AmtBx.Text
                };
                Ammo Ammo2 = new Ammo
                {
                    name = sheet.Ammo2AmmoBx.Text,
                    Amt = sheet.Ammo2AmtBx.Text
                }; Ammo Ammo3 = new Ammo
                {
                    name = sheet.Ammo3AmmoBx.Text,
                    Amt = sheet.Ammo3AmtBx.Text
                };
                h.Ammo = new List<Ammo> {Ammo1,Ammo2,Ammo3};
                //get treasure and other equips
                h.treasure = sheet.TresBx.Text;
                h.Equipment = sheet.OtherEquipBx.Text;



            }
            catch
            {

            }


            
            saveXml(h);
        }
        private static void saveXml(Hero hero)
        {
            string path = AppdataRoaming + @"\ProcrastN8\Heros\" + hero.name.Replace('▼',' ') + ".xml";
            SerializeObject<Hero>(hero, path);
        }


        private static string AppdataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static void SerializeObject<T>(T serializableObject, string path)
        {
            if (serializableObject == null) { return; }
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);

                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(path));
                    xmlDocument.Save(path);

                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Hero GetHero()
        {
            Hero h = new Hero();
            h.name = getMain().HeroSelectLbl.Text;
            return h;
        }
    }
}
