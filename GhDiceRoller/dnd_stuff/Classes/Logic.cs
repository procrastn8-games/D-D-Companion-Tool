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
