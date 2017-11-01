using Eu4ModEditor.JSON;
using Eu4ModEditor.JSON.Country;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor.FilesEditor
{
    class Country : TextBoxCompletion
    {
        string Path;//Chemin du JSON contenant les chemin vers les fichiers du mod

        List<ZoneText> zonesText; //Contient des zones de texte pour chaque fichier du JSON

        //Localisation variables
        int debutLoc, lenghtloc;
        string localisations = "";

        public Country(string path)
        {
            InitializeComponent();

            Path = path;

            JSonManager<CountryJson> manager = new JSonManager<CountryJson>();

            CountryJson file = manager.Load(path);

            zonesText = new List<ZoneText>();

            zonesText.Add(new ZoneText(file.CountryFile.CompletPath, richTextBox1, 
                "<Country>"));
            zonesText[0].ReadAllFile();

            zonesText.Add(new ZoneText(file.CountryTag.Path, richTextBox1, 
                "<Country Tag>"));
            zonesText[1].ReadString(file.CountryTag.Tag + " = \"" + file.CountryFile.Path + "\"");

            zonesText.Add(new ZoneText(file.CountryLocalisation.Path, richTextBox1, 
                "<Country Localisation>"));

            using (System.IO.StreamReader sr = 
                new System.IO.StreamReader(file.CountryLocalisation.Path))
            {
                while(!sr.EndOfStream)
                {
                    string text = sr.ReadLine();

                    if (text.Contains(file.CountryLocalisation.Tag))
                    {
                        localisations += text + "\n";
                    }
                }
            }

            debutLoc = File.ReadAllText(file.CountryLocalisation.Path).IndexOf(file.CountryLocalisation.Tag);

            localisations = localisations.Remove(localisations.Length - 1);

            lenghtloc = localisations.Length;

            zonesText[2].ReadString(localisations);

           // Save();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.Size = new System.Drawing.Size(30, 394);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(713, 394);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Country";
            this.Size = new System.Drawing.Size(743, 394);
            this.ResumeLayout(false);
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            bool alreadyDone = false;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Back)
            {
                foreach (ZoneText zone in zonesText)
                {
                    if (alreadyDone==false)
                    {
                        alreadyDone = zone.KeyDown(e);
                    }
                }
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool alreadyDone = false;
          
            if (e.KeyChar == '\b')
            {
                e.Handled = true;
                return;
            }
            foreach (ZoneText zone in zonesText)
            {
                if (alreadyDone == false)
                {
                    alreadyDone = zone.KeyPress(e);
                }
            }
            if(alreadyDone==false)
            {
                e.Handled = true;
            }
        }



        //Méthode de sauvegarde
        public void Save()
        {
            using (System.IO.StreamWriter wr =
               new System.IO.StreamWriter(zonesText[0].Path))
            {
                wr.Write(zonesText[0].GetText().Replace("\n",Environment.NewLine));
            }

            string Filetext = File.ReadAllText(zonesText[2].Path);

            Filetext = Filetext.Replace(localisations, 
                zonesText[2].GetText().Remove(zonesText[2].GetText().Length-1));

            File.WriteAllText(zonesText[2].Path,Filetext);
        }
    }
}
