using DevComponents.DotNetBar.Metro;
using Eu4ModEditor.FilesEditor;
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
    public partial class MainForm : Form
    {
        bool isWindowMaximized = false;

        Size _normalWindowSize = new Size(new Point(0, 0));
        Point _normalWindowLocation = Point.Empty;

        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                //si le chemin du fichier est passé en argument
                if (Environment.GetCommandLineArgs().Length == 2)
                {
                    string path;
                    string name;
                    string modPath;
                    //lecture du contenu du fichier
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(Environment.GetCommandLineArgs()[1]))
                    {
                        path = sr.ReadLine();
                        name = sr.ReadLine();
                        modPath = sr.ReadLine();
                    }

                    Properties.Settings.Default.ProjectPath = path;
                    Properties.Settings.Default.ProjectName = name;
                    Properties.Settings.Default.ModPath = modPath;

                    SolutionView.PopulateTreeView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement: " + ex.Message);
            }
        }

        //these 3 methodes are event to move the form
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //Controls Button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(MaxButton, "Maximize");
                MaxButton.CFormState = ControlComponent.MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(MaxButton, "Restore Down");
                MaxButton.CFormState = ControlComponent.MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //SolutionViewEvent
        private void SolutionView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SolutionView.OnClickRight(sender, e);
            }
        }

        //Double clic sur un fichier dans l'explorateur de solution
        private void SolutionView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SolutionView.SelectedNode != null)
                {
                    TabPage tp = new TabPage(SolutionView.SelectedNode.Text);

                    //Verifie si la page ajouter n'existe pas
                    if(TextTab.Controls.Find(SolutionView.SelectedNode.Text, true).Length == 0)
                    {
                        TextBoxCompletion textBox = SolutionView.OnDoubleClickLeft(sender, e);
                        if (textBox != null)
                        {
                            tp.Controls.Add(textBox);
                            tp.Name = SolutionView.SelectedNode.Text;
                            TextTab.TabPages.Add(tp);

                            tp.Show();
                        }
                    }
                }
            }
        }

        //Create a new project
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewProject createNewProject = new CreateNewProject();
            createNewProject.Show();
            createNewProject.Focus();
        }

        //Open a project
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Fichier Projet Eu4 Mod (*.eu4Mod)|*.eu4Mod";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)//Un fichier a été sélectionner
            {
                try
                {
                    string path;
                    string name;
                    string modPath;

                    //lecture du contenu du fichier
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName))
                    {
                        path = sr.ReadLine();
                        name = sr.ReadLine();
                        modPath = sr.ReadLine();
                    }

                    Properties.Settings.Default.ProjectPath = path;
                    Properties.Settings.Default.ProjectName = name;
                    Properties.Settings.Default.ModPath = modPath;

                    Console.WriteLine(Properties.Settings.Default.ProjectPath);
                    Console.WriteLine(Properties.Settings.Default.ProjectName);
                    Console.WriteLine(Properties.Settings.Default.ModPath);

                    SolutionView.PopulateTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement: " + ex.Message);
                }
            }
        }

        //Actualise the treeView
        private void MainForm_Activated(object sender, EventArgs e)
        {
            SolutionView.Nodes.Clear();
            SolutionView.PopulateTreeView();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in TextTab.TabPages)
            {
                Country c = (Country)page.Controls[0];

                c.Save();
            }
        }

        /*private void SolutionView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Bounds.Height == 0)
                return;

            e.Graphics.FillRectangle(new SolidBrush((e.Node.Parent?.Index ?? e.Node.Index) % 2 == 0 ? Color.Blue : Color.Aqua), e.Bounds);

            if (e.Node.Nodes.Count > 0)
            {
                if (!e.Node.IsExpanded)
                    e.Graphics.FillPolygon(Brushes.Red,
                        new[]
                        {
                        new PointF(e.Bounds.X + e.Bounds.Height / 10, e.Bounds.Y + e.Bounds.Height / 10),
                        new PointF(e.Bounds.X + e.Bounds.Height / 10, e.Bounds.Y + e.Bounds.Height * 0.9f),
                        new PointF(e.Bounds.X + e.Bounds.Height, e.Bounds.Y + e.Bounds.Height / 2)
                        });
                else
                    e.Graphics.FillPolygon(Brushes.Red,
                        new[]
                        {
                        new PointF(e.Bounds.X + e.Bounds.Height / 10, e.Bounds.Y + e.Bounds.Height / 10),
                        new PointF(e.Bounds.X + e.Bounds.Height, e.Bounds.Y + e.Bounds.Height / 10),
                        new PointF(e.Bounds.X + e.Bounds.Height / 2, e.Bounds.Y + e.Bounds.Height)
                        });
            }
            e.Graphics.DrawString(e.Node.Text, new Font(FontFamily.GenericMonospace, e.Bounds.Height * 0.7f),
                new SolidBrush(Color.Black),
                new Rectangle(e.Bounds.X + e.Bounds.Height, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
        }*/
    }
}
