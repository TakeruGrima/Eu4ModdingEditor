using Eu4ModEditor.ControlComponent;
using Eu4ModEditor.EditorComponent;
using Eu4ModEditor.EditorFilesSetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace Eu4ModEditor
{
    public partial class AddExistFile : Form
    {
        #region Fields Region

        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //FilesListsType
        GListBox ListFilesAllType;
        GListBox ListFilesContent;
        GListBox ListFilesTrigger;

        #endregion

        #region Constructor Region

        public AddExistFile()
        {
            InitializeComponent();

            InitializeFileTypeTree();
            FileTypeTree.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.FileTypeTree_NodeMouseClick);

            //FilesList Initialisation

            FilesList.ImageList = imageList1;
            FilesList.ItemHeight = 36;

            //FilesList Game Content
            FilesList.Items.Add(new FileListBoxItem("Pays", 0,
                        "Definition d'un pays dans Europa Universalis IV",
                        "Game Content"));
            FilesList.Items.Add(new FileListBoxItem("Religion", 0,
                "Definition d'une religion dans Europa Universalis IV",
                "Game Content"));
            FilesList.Items.Add(new FileListBoxItem("Culture", 0,
                 "Definition d'une culture dans Europa Universalis IV",
                 "Game Content"));
            FilesList.Items.Add(new FileListBoxItem("Ideas", 0,
                 "Definition des idées nationales d'un pays dans Europa Universalis IV", 
                 "Game Content"));

            //FilesList Game Trigger
            FilesList.Items.Add(new FileListBoxItem("Event", 1,
                        "Definition d'un évenement dans Europa Universalis IV",
                        "Game Trigger"));
            FilesList.Items.Add(new FileListBoxItem("Mission", 3,
                "Definition d'une mission dans Europa Universalis IV",
                "Game Trigger"));
            FilesList.Items.Add(new FileListBoxItem("Decision", 2,
                 "Definition d'une décision dans Europa Universalis IV",
                 "Game Trigger"));

            ListFilesAllType = new GListBox();
            ListFilesContent = new GListBox();
            ListFilesTrigger = new GListBox();

            foreach (FileListBoxItem item in FilesList.Items)
            {
                ListFilesAllType.Items.Add(item);
            }

            foreach (FileListBoxItem item in FilesList.Items)
            {
                if(item.Type == "Game Content")
                {
                    ListFilesContent.Items.Add(item);
                    Console.WriteLine(item);
                }
            }

            foreach (FileListBoxItem item in FilesList.Items)
            {
                if (item.Type == "Game Trigger")
                    ListFilesTrigger.Items.Add(item);
            }
        }

        #endregion

        #region MoveForm Region

        //these 3 methodes are event to move the form
        private void CreateNewFile_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CreateNewFile_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void CreateNewFile_MouseUp(object sender, MouseEventArgs e)
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

        #region ButtonEvents Region

        //Add file
        private void Ajouter_Click(object sender, EventArgs e)
        {
            switch(FilesList.SelectedIndex)
            {
                case 0:
                    CountrySettings settings = new CountrySettings();
                    settings.Show();
                    settings.Focus();
                    this.Close();
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }

        //Annuler l'opération
        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ListFiles Region

        private void FilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileListBoxItem item = (FileListBoxItem)FilesList.SelectedItem;

            DescriptionBox.Text = item.Description;
            TypeLabelText.Text = item.Type;
            
        }

        //Initialize FileTypeTree
        private void InitializeFileTypeTree()
        {
            TreeNode racineNode = new TreeNode("EuIV Mod FileType");
            racineNode.Expand();

            TreeNode root = new TreeNode("Game Content");

            racineNode.Nodes.Add(root);

            root = new TreeNode("Game Trigger");

            racineNode.Nodes.Add(root);

            FileTypeTree.Nodes.Add(racineNode);

            FileTypeTree.Nodes[0].Expand();
        }

        private void FileTypeTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(e.Node == FileTypeTree.Nodes[0].Nodes[0])
                {
                    FilesList.Items.Clear();

                    FilesList.Items.AddRange(ListFilesContent.Items);
                }
                else if (e.Node == FileTypeTree.Nodes[0].Nodes[1])
                {
                    FilesList.Items.Clear();

                    FilesList.Items.AddRange(ListFilesTrigger.Items);
                }
                else
                {
                    FilesList.Items.Clear();

                    FilesList.Items.AddRange(ListFilesAllType.Items);
                }
            }
        }

        #endregion
    }
}
