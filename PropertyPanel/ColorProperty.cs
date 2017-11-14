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
        TextBox boxV;
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
            boxV = new TextBox();
            boxV.ReadOnly = true;
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
        public int Initialize(string name, Point location,int posXTextBox)//name is the name of component
            //location is the location of component, posXTextBox positionX of TextBox
        {
            location.Y -= 20;
            this.Location = location;

            Label l = new Label();

            l.Location = location;
            l.Name = name + "Label";
            l.TabIndex = 0;

            l.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(l);
            l.AutoSize = true;
            l.Text = name + " :";

            TextBox boxR = new TextBox();
            boxR.ReadOnly = true;

            if (posXTextBox < l.Bounds.Right)
                posXTextBox = l.Bounds.Right;

            boxR.Location = new Point(posXTextBox, l.Bounds.Top - 3);
            boxR.Name = name + "R";
            boxR.Size = new Size(36, 20);

            Controls.Add(boxR);

            boxV.Location = new Point(boxR.Bounds.Right + 10, l.Bounds.Top - 3);
            boxV.Name = name + "V";
            boxV.Size = new Size(36, 20);

            Controls.Add(boxV);

            boxB.Location = new Point(boxV.Bounds.Right + 10, l.Bounds.Top - 3);
            boxB.Name = name + "V";
            boxB.Size = new Size(36, 20);

            Controls.Add(boxB);

            chooseButton.Location = new Point(boxR.Bounds.Right + 10, l.Bounds.Top - 3);
            chooseButton.Name = name + "Button";
            chooseButton.Text = "Parcourir";

            Controls.Add(chooseButton);

            this.AutoSize = true;
            return boxB.Bounds.Bottom + 10;
        }

        #endregion
    }
}
