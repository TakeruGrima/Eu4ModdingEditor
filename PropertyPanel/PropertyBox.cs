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
            this.AutoSize = true;
        }

        #endregion

        #region override methods

        protected override void OnPaint(PaintEventArgs pe)
        {
            foreach (Control c in this.Controls)
            {
                if(c is TextBox || c is ComboBox)
                {
                    c.Location = new Point(posXTextBox, c.Location.Y);
                }
            }

            base.OnPaint(pe);
        }

        #endregion

        #region AddComponent methods

        //Add Label to a group, return a label to store it outside the controls
        public Label AddLabel(string name)
        {
            Label l = new Label();

            l.Location = locationCurr;
            l.Name = name + "Label";
            l.TabIndex = 0;

            l.Size = new System.Drawing.Size(10, 10);
            this.Controls.Add(l);
            l.AutoSize = true;
            l.Text = name + " :";

            this.Invalidate();
            //return Boundary of the label 
            return l;
        }

        //This methods add a label & a textBox
        public TextBox AddField(string name)//name is the name of the label
        {
            Rectangle boundsLabel= AddLabel(name).Bounds;

            TextBox box = new TextBox();

            if (posXTextBox < boundsLabel.Right)
                posXTextBox = boundsLabel.Right;

            box.Location = new Point(posXTextBox, boundsLabel.Top - 3);
            box.Name = name + "Box";

            this.Controls.Add(box);

            locationCurr.Y = box.Bounds.Bottom + 10;

            this.Invalidate();

            return box;
        }

        //this methods add a label & 3 textbox for color RVB & show a colorDialog via a button
        public ColorProperty AddColorField(string name)
        {
            ColorProperty colorProperty = new ColorProperty();

            posXTextBox = colorProperty.Initialize(name, ref locationCurr, posXTextBox);

            Console.WriteLine(locationCurr);
            Controls.Add(colorProperty);

            this.Invalidate();

            return colorProperty;
        }

        //this methods add a comboBox
        public ComboBox AddComboBox(string name)
        {
            ComboBox cb = new ComboBox();

            cb.Location = locationCurr;
            cb.Name = name + "ComboBox";

            this.Controls.Add(cb);

            locationCurr = new Point(locationCurr.X, cb.Bounds.Bottom + 10);

            return cb;
        }

        //this methods add a listBox with button and ComboBox to add thing to listBox
        public ListBoxPanel addListBoxPanel(string name)
        {
            ListBoxPanel lbp = new ListBoxPanel();

            lbp.Initialize(name, ref locationCurr, posXTextBox);

            this.Controls.Add(lbp);

            return lbp;
        }

        #endregion
    }
}
