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
    public partial class ColorProperty : Panel
    {
        #region

        Label labelColor;
        TextBox boxR;
        TextBox boxG;
        TextBox boxB;
        Button chooseButton;

        #endregion

        #region Constructor

        public ColorProperty()
        {
            InitializeComponent();

            labelColor = new Label();

            boxR = new TextBox();
            boxR.ReadOnly = true;
            boxG = new TextBox();
            boxG.ReadOnly = true;
            boxB = new TextBox();
            boxB.ReadOnly = true;

            chooseButton = new Button();
        }

        #endregion

        #region override methods

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #endregion

        #region initialize

        //return the y boundary of the component + 10 to separate over component
        public int Initialize(string name, ref Point location,int posXTextBox)//name is the name of component
            //location is the location of component, posXTextBox positionX of TextBox
        {
            this.Size = new Size(10, 10);
            this.AutoSize = true;

            this.Margin = new Padding(0);
            this.BackColor = Color.Transparent;
            Console.WriteLine(location);
            // location.Y -= 20;
            this.Location = new Point(location.X, location.Y - 5);

            Point currloc = new Point(0,5);

            Label l = new Label();

            l.Location = currloc;
            l.Name = name + "Label";
            l.TabIndex = 0;

            l.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(l);
            l.AutoSize = true;
            l.Text = name + " :";

            if (posXTextBox < l.Bounds.Right)
                posXTextBox = l.Bounds.Right;

            boxR.Location = new Point(posXTextBox, l.Bounds.Top - 3);
            boxR.Name = name + "R";
            boxR.Size = new Size(36, 20);

            Controls.Add(boxR);

            boxG.Location = new Point(boxR.Bounds.Right + 10, l.Bounds.Top - 3);
            boxG.Name = name + "G";
            boxG.Size = new Size(36, 20);

            Controls.Add(boxG);

            boxB.Location = new Point(boxG.Bounds.Right + 10, l.Bounds.Top - 3);
            boxB.Name = name + "B";
            boxB.Size = new Size(36, 20);

            Controls.Add(boxB);

            chooseButton.Location = new Point(boxB.Bounds.Right + 10, l.Bounds.Top - 5);
            chooseButton.Name = name + "Button";
            chooseButton.ForeColor = Color.Black;
            chooseButton.Size = new Size(10, 10);
            chooseButton.AutoSize = true;
            chooseButton.Text = "Browse";
            chooseButton.MouseClick += new MouseEventHandler(ChooseButton_Click);

            Controls.Add(chooseButton);

            Console.WriteLine(location);
            Console.WriteLine(boxB.Bounds.Bottom);
            location = new Point(location.X,location.Y + boxB.Bounds.Bottom + 5);

            return posXTextBox;
        }

        #endregion

        #region Event methods

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // Show the color dialog.
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                Color c = colorDialog.Color;

                Console.WriteLine(c.R.ToString());
                boxG.Text = c.G.ToString();
                boxB.Text = c.B.ToString();
                boxR.Text = c.R.ToString();
                Console.WriteLine(boxR.Text);
            }
        }

        #endregion
    }
}
