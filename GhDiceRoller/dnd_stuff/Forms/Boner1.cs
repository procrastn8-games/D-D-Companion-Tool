using dnd.dnd_stuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace dnd.Controls
{
    public partial class Boner1 : Form
    {
        Hero currentHero;
        public Boner1()
        {
            InitializeComponent();
        }

        private void Boner1_Load(object sender, EventArgs e)
        {
            
        }

        private void saveXml(Hero hero)
        {
            List <dnd_stuff.Hero> MasterControlList = new List<dnd_stuff.Hero>();
            MasterControlList.Add(hero);
            string path = "";
            SerializeObject<List<dnd_stuff.Hero>>(MasterControlList, path);

        }

        private static string AppdataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string path = AppdataRoaming + @"\ProcrastN8\BokuNoHero.xml";

        public void SerializeObject<T>(T serializableObject, string fileName)
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

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            var tp = new TabPage();
            tp.Tag = new dnd_stuff.Hero();

            tp.Text = "character";

            CharacterInterface CI = new Controls.CharacterInterface();

            tp.Controls.Add(CI);           
            this.CharactersTabControl.Controls.Add(tp);
            CI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;

            tp.Leave += tabPage_Leave;
            
        }

    

        private void tabPage_Leave(object sender, EventArgs e)
        {
            TabPage tp = (TabPage)sender;

            dnd_stuff.Hero hero = (dnd_stuff.Hero)tp.Tag;
            saveXml(hero);
            MessageBox.Show("saving");
           
        }
    }
}
