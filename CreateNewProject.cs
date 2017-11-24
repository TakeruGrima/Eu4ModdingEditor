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

namespace Eu4ModEditor
{
    public partial class CreateNewProject : Form
    {
        #region Fields Region

        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        #endregion

        #region Constructor Region

        public CreateNewProject()
        {
            InitializeComponent();
        }

        #endregion

        #region MoveForm Region

        //these 3 methodes are event to move the form
        private void CreateNewProject_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CreateNewProject_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void CreateNewProject_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        #region ControlButton Region 

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

        #endregion

        #region ButtonsEvents Region

        private void ParcourirProjectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Emplacement du Projet";

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProjectEmplacementBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ParcourirModButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Emplacement du Mod";

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ModEmplacementBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" && ProjectEmplacementBox.Text != ""
                && ModEmplacementBox.Text != "")
            {
                string path;

                path = ProjectEmplacementBox.Text + "//" + NameBox.Text;
                Directory.CreateDirectory(path);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichier Projet Eu4 Mod (*.eu4Mod)|*.eu4Mod";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                saveFileDialog.FileName = path + "//" + NameBox.Text + ".eu4Mod";

                // Ecriture du fichier. On l'écrase s'il existe déjà
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName, false))
                {
                    sw.WriteLine(path);
                    sw.WriteLine(NameBox.Text);
                    sw.WriteLine(ModEmplacementBox.Text);
                }

                Properties.Settings.Default.ProjectName = NameBox.Text;
                Properties.Settings.Default.ProjectPath = path;
                Properties.Settings.Default.ModPath = ModEmplacementBox.Text;

                this.Close();
            }
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
