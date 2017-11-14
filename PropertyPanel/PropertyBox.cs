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
    //This class is use to make a group box to set some properties of an object in the game
    //The ControlComponent are dynamic
    public partial class PropertyBox : GroupBox
    {
        #region fields

        Point locationCurr;//Current position of component
        int posXTextBox;

        #endregion

        #region Constructor

        public PropertyBox()
        {
            InitializeComponent();

            locationCurr = new Point(this.Bounds.Left + 6, this.Bounds.Top + 25);
        }

        #endregion

        #region override methods

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #endregion

        #region AddComponent methods

        //Add Label to a group
        public Rectangle AddLabel(string name)
        {
            Label l = new Label();

            l.Location = locationCurr;
            l.Name = name + "Label";
            l.TabIndex = 0;

            l.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(l);
            l.AutoSize = true;
            l.Text = name + " :";

            //return Boundary of the label 
            return l.Bounds;
        }

        //This methods add a label & a textBox
        public void AddField(string name)//name is the name of the label
        {
            Rectangle boundsLabel= AddLabel(name);

            TextBox box = new TextBox();

            if (posXTextBox < boundsLabel.Right)
                posXTextBox = boundsLabel.Right;

            box.Location = new Point(posXTextBox, boundsLabel.Top - 3);
            box.Name = name + "Box";

            this.Controls.Add(box);

            locationCurr.Y = box.Bounds.Bottom + 10;
        }

        //this methods add a label & 3 textbox for color RVB & show a colorDialog via a button
        public void AddColorField(string name)
        {
            ColorProperty colorProperty = new ColorProperty();

            posXTextBox = colorProperty.Initialize("Color", locationCurr, posXTextBox);

            Controls.Add(colorProperty);
        }

        #endregion
    }
}
