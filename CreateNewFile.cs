using Eu4ModEditor.ControlComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor
{
    public partial class CreateNewFile : Form
    {
        #region Fields Region

        //Variable use to move the form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        #endregion

        #region Constructor Region

        public CreateNewFile()
        {
            InitializeComponent();

            FilesList.ImageList = imageList1;
            FilesList.ItemHeight = 36;
            FilesList.Items.Add(new GListBoxItem("Pays",0));
            FilesList.Items.Add(new GListBoxItem("Event", 1));
            FilesList.Items.Add(new GListBoxItem("Decision", 2));
            FilesList.Items.Add(new GListBoxItem("Mission", 3));
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
    }
}
