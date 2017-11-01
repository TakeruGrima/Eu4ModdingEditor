using Eu4ModEditor.JSON;
using Eu4ModEditor.JSON.Country;
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

namespace Eu4ModEditor.EditorFilesSetting
{
    public partial class CountrySettings : Form
    {
        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //variable concernant le pays
        private string name;//+extension du fichier

        public CountrySettings()
        {
            InitializeComponent();
        }

        //these 3 methodes are event to move the form
        private void CountrySettings_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CountrySettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void CountrySettings_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //Control Button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void ParcourirCountryButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string path = Properties.Settings.Default.ModPath;
            path = Path.Combine(path, "common", "countries");

            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Fichier Texte(*txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.Title = "Choisir le fichier du pays";

            if (openFileDialog.ShowDialog() == DialogResult.OK)//Un fichier a été sélectionner
            {
                try
                {
                    CountryFileBox.Text = openFileDialog.FileName;

                    name = openFileDialog.SafeFileName;
                }
                catch (Exception erreur)
                {
                    MessageBox.Show(erreur.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ParcourirTagButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string path = Properties.Settings.Default.ModPath;
            path = Path.Combine(path, "common", "country_tags");

            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Fichier Texte(*txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.Title = "Choisir le fichier des Country tags";

            if (openFileDialog.ShowDialog() == DialogResult.OK)//Un fichier a été sélectionner
            {
                try
                {
                    CountryTagsBox.Text = openFileDialog.FileName;
                }
                catch (Exception erreur)
                {
                    MessageBox.Show(erreur.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ParcourirLocalisationButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string path = Properties.Settings.Default.ModPath;
            path = Path.Combine(path, "localisation");

            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Fichier localisation(*yml)|*.yml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            Console.WriteLine(openFileDialog.InitialDirectory);

            openFileDialog.Title = "Choisir le fichier de localisation(langue)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)//Un fichier a été sélectionner
            {
                try
                {
                    LocalisationBox.Text = openFileDialog.FileName;
                }
                catch (Exception erreur)
                {
                    MessageBox.Show(erreur.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.ProjectPath;
            path = Path.Combine(path, "Countries");
            DirectoryInfo countriesDir = new DirectoryInfo(path);

            if (!countriesDir.Exists)
            {
                Directory.CreateDirectory(path);
            }

            string tag;

            //lecture du contenu du fichier country_tag pour récupérer le tag du pays
            using (System.IO.StreamReader sr = new System.IO.StreamReader(CountryTagsBox.Text))
            {
                tag = File.ReadAllText(CountryTagsBox.Text);
            }

            //Recuperation du tag selon le nom du pays
            string tmp = " = \"countries/" + name;
            int index = tag.IndexOf(tmp);

            tag = tag.Substring(index - 3, 3);

            //Construction du nom du fichier dans le projet
            tmp = name.Substring(0, name.Length - 4);//name sans le .txt

            string FilePath = Path.Combine(path,tag + " - " + tmp + ".json");//Chemin du fichier dans le projet

            //Create the CountryJsonFile
            CountryJson file = new CountryJson();

            file.CountryFile = new CountryFile();

            //countries folder
            file.CountryFile.CompletPath = CountryFileBox.Text;

            OpenFileDialog fileDialog = new OpenFileDialog();

            file.CountryFile.Name = tmp;//give the name of the country
            file.CountryFile.Path = "countries/" + tmp + ".txt";

            //country tag
            file.CountryTag = new CountryTag();
            file.CountryTag.Tag = tag;
            file.CountryTag.Path = CountryTagsBox.Text;

            //country localisation
            file.CountryLocalisation = new CountryLocalisation();
            file.CountryLocalisation.Path = LocalisationBox.Text;
            file.CountryLocalisation.Tag = tag;

            JSonManager<CountryJson> manager = new JSonManager<CountryJson>();
            manager.Save(FilePath, file);

            this.Close();
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
