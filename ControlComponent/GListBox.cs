using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor.ControlComponent
{
    // GListBox class 
    public class GListBox : ListBox
    {
        private ImageList _myImageList = new ImageList();
        public ImageList ImageList
        {
            get { return _myImageList; }
            set
            {
                _myImageList = value;

                if (null != _myImageList)
                {
                    this.ItemHeight = _myImageList.ImageSize.Height;
                }
            }
        }
        public GListBox()
        {
            // Set owner draw mode
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            GListBoxItem item;
            Rectangle bounds = e.Bounds;
            Size imageSize = new Size(0, 0);

            if (_myImageList != null)
                imageSize = _myImageList.ImageSize;

            try
            {
                item = (GListBoxItem)Items[e.Index];
                if (item.ImageIndex != -1)
                {
                    ImageList.Draw(e.Graphics, bounds.Left, e.Bounds.Top+ (bounds.Height/2 - imageSize.Height/2), item.ImageIndex);

                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left + imageSize.Width +8, bounds.Top + (imageSize.Height / 2 - 4));
                }
                else
                {
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left, bounds.Top + 2);
                }
            }
            catch
            {
            }
            base.OnDrawItem(e);
        }
    }//End of GListBox class

    // GListBoxItem class 
    public class GListBoxItem
    {
        private string _myText;
        private int _myImageIndex;
        // properties 
        public string Text
        {
            get { return _myText; }
            set { _myText = value; }
        }
        public int ImageIndex
        {
            get { return _myImageIndex; }
            set { _myImageIndex = value; }
        }
        //constructor
        public GListBoxItem(string text, int index)
        {
            _myText = text;
            _myImageIndex = index;
        }
        public GListBoxItem(string text) : this(text, -1) { }
        public GListBoxItem() : this("") { }
        public override string ToString()
        {
            return _myText;
        }
    }//End of GListBoxItem class
}
