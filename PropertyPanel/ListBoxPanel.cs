using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor.PropertyPanel
{
    public partial class ListBoxPanel : GroupBox
    {
        #region Field Region

        ListBox listBox;
        Button upButton;
        Button downButton;
        Button deleteButton;

        ComboBox comboBox;
        Button addButton;

        #endregion

        #region Constructor

        public ListBoxPanel()
        {
            InitializeComponent();
            listBox = new ListBox();
            upButton = new Button();
            downButton = new Button();
            deleteButton = new Button();

            comboBox = new ComboBox();
            addButton = new Button();
        }

        #endregion

        #region overide methods

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #endregion

        #region methods

        public void Initialize(string name,ref Point location, int posXTextBox)
        {
            this.Size = new Size(10, 10);
            this.AutoSize = true;

            this.Name = name + "ListBoxPanel";
            this.Text = name;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;

            Console.WriteLine(location);
            this.Location = location;

            Point currloc = new Point(6,20);

            listBox.Location = currloc;
            listBox.Items.Add("Coucou");
            listBox.Items.Add("Salut");
            listBox.Items.Add("Bonjour");
            listBox.Items.Add("Bloup");

            this.Controls.Add(listBox);
    
            upButton.Location = new Point(listBox.Bounds.Right + 10, currloc.Y);
            upButton.Size = new Size(10, 10);
            upButton.ForeColor = Color.Black;
            upButton.AutoSize = true;
            upButton.Text = "/\\";

            upButton.MouseClick += new MouseEventHandler(UpButton_Click);

            this.Controls.Add(upButton);

            downButton.Location = new Point(upButton.Location.X, upButton.Bounds.Bottom + 15);
            downButton.Size = new Size(10, 10);
            downButton.ForeColor = Color.Black;
            downButton.AutoSize = true;
            downButton.Text = "\\/";

            downButton.MouseClick += new MouseEventHandler(DownButton_Click);

            this.Controls.Add(downButton);

            deleteButton.Location = new Point(upButton.Location.X, downButton.Bounds.Bottom+15);
            deleteButton.Size = new Size(10, 10);
            deleteButton.ForeColor = Color.Black;
            deleteButton.AutoSize = true;
            deleteButton.Text = "Delete";

            deleteButton.MouseClick += new MouseEventHandler(DeleteButton_Click);

            this.Controls.Add(deleteButton);

            comboBox.Location = new Point(listBox.Location.X, listBox.Bounds.Bottom + 10);
            comboBox.ForeColor = Color.Black;
            comboBox.Items.Add("Test1");
            comboBox.Items.Add("Test2");
            comboBox.Items.Add("Test3");

            this.Controls.Add(comboBox);

            addButton.Location = new Point(comboBox.Bounds.Right,comboBox.Location.Y);
            addButton.Size = new Size(10, 10);
            addButton.ForeColor = Color.Black;
            addButton.AutoSize = true;
            addButton.Text = "Add";

            addButton.MouseClick += new MouseEventHandler(AddButton_Click);

            this.Controls.Add(addButton);
        }

        #endregion

        #region Event methods

        //When clicked the selected item go up in listBox
        private void UpButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox.SelectedIndex;
            if (selectedIndex > 0 & selectedIndex != -1)
            {
                listBox.Items.Insert(selectedIndex - 1,listBox.Items[selectedIndex]);
                listBox.Items.RemoveAt(selectedIndex + 1);
                listBox.SelectedIndex = selectedIndex - 1;
            }
        }

        //When clicked the selected item go down in listBox
        private void DownButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox.SelectedIndex;
            if (selectedIndex < listBox.Items.Count - 1 & selectedIndex != -1)
            {
                listBox.Items.Insert(selectedIndex + 2, listBox.Items[selectedIndex]);
                listBox.Items.RemoveAt(selectedIndex);
                listBox.SelectedIndex = selectedIndex + 1;

            }
        }

        //When clicked the selected item is deleted in the list
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            listBox.SelectedIndex = listBox.SelectedIndex + 1;
        }

        //When clicked the selected item in comboBox is add to listBox
        private void AddButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(comboBox.SelectedItem);
        }

        #endregion
    }
}
