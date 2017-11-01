using Eu4ModEditor.ControlComponent;
using Eu4ModEditor.FilesEditor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor.EditorComponent
{
    class SolutionTreeView : TreeView
    {
        CreateNewFile createNew;
        AddExistFile addExistFile;

        //ContextStrip to add,edit, view something in solutionTreeView
        MyContextMenuStrip RightClickMenuStrip;

        //Constructor
        public SolutionTreeView()
        {

        }

        //Add new file
        private void AjouterNew_Click(object sender, EventArgs e)
        {
            createNew = new CreateNewFile();
            createNew.Show();
            createNew.Focus();
        }

        //Add existing file
        private void AjouterExist_Click(object sender, EventArgs e)
        {
            addExistFile = new AddExistFile();
            addExistFile.Show();
            addExistFile.Focus();
        }

        //Right Click on treeView
        public void OnClickRight(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node == this.Nodes[0])
            {
                RightClickMenuStrip = new MyContextMenuStrip();

                ToolStripMenuItem AddStripItem = new ToolStripMenuItem("Ajouter");
                AddStripItem.BackColor = Color.FromArgb(27,27,28);
                AddStripItem.ForeColor = Color.White;
                AddStripItem.Name = "Ajouter";

                ToolStripMenuItem AddNewStripItem = new ToolStripMenuItem("Nouveau Element...");
                AddNewStripItem.BackColor = Color.FromArgb(27, 27, 28);
                AddNewStripItem.ForeColor = Color.White;
                AddNewStripItem.Name = "Nouveau Element";

                AddNewStripItem.Click += new System.EventHandler(this.AjouterNew_Click);

                ToolStripMenuItem AddExistStripItem = new ToolStripMenuItem("Element Existant...");
                AddExistStripItem.BackColor = Color.FromArgb(27, 27, 28);
                AddExistStripItem.ForeColor = Color.White;
                AddExistStripItem.Name = "Nouveau Element";

                AddExistStripItem.Click += new System.EventHandler(this.AjouterExist_Click);

                AddStripItem.DropDownItems.Add(AddNewStripItem);
                AddStripItem.DropDownItems.Add(AddExistStripItem);

                RightClickMenuStrip.Items.Add(AddStripItem);

                RightClickMenuStrip.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
            }
        }

        //Left Click, renvoit une TextBoxCompletion pour afficher du texte
        public TextBoxCompletion OnDoubleClickLeft(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.ImageKey=="Pays")
            {
                Country country = new Country(e.Node.Name);

                return country;
            }
            return null;
        }

        //Method to display directory project
        public void PopulateTreeView()
        {
            TreeNode rootNode;
            if (Properties.Settings.Default.ProjectName != "")
            {
                DirectoryInfo info = new DirectoryInfo(Properties.Settings.Default.ProjectPath);
                if (info.Exists)
                {
                    Console.WriteLine("POPULATE");
                    rootNode = new TreeNode(info.Name);
                    rootNode.Tag = info;
                    GetDirectories(info.GetDirectories(), rootNode);
                    GetFiles(info, rootNode);
                    Nodes.Add(rootNode);
                }
                Nodes[0].Expand();
            }
        }

        //Method to get the directories
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                aNode.SelectedImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                GetFiles(subDir, aNode);
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        //GetFiles of a directory
        private void GetFiles(DirectoryInfo dir, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            foreach (FileInfo file in dir.GetFiles())
            {
                if(file.Name != Properties.Settings.Default.ProjectName + ".eu4Mod")
                {
                    Console.WriteLine(Properties.Settings.Default.ProjectName + ".eu4Mod");
                    Console.WriteLine(file.Name);
                    aNode = new TreeNode(file.Name, 0, 0);
                    DefineFileDisplay(aNode,file.FullName);
                    aNode.Tag = file;
                    nodeToAddTo.Nodes.Add(aNode);
                }
            }
        }

        private void DefineFileDisplay(TreeNode node,string path)
        {
            Regex countryRegex = new Regex("-");

            node.Name = path;
            if (countryRegex.Match(node.Text).Success)
            {
                node.SelectedImageKey = "Pays";
                node.ImageKey = "Pays";

                //on affiche le nom du fichier sans extension
                node.Text = node.Text.Substring(0, node.Text.Length - 5); 
            }
        }
    }
}
