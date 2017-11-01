﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eu4ModEditor.ControlComponent
{
    public partial class MyRichTextBox : UserControl
    {
        public int TextLength
        {
            get
            {
                return richTextBox1.TextLength;
            }
        }

        public override string Text
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }

        public Color SelectionBackColor
        {
            get
            {
                return richTextBox1.SelectionBackColor;
            }
            set
            {
                richTextBox1.SelectionBackColor = value;
            }
        }

        public int SelectionStart
        {
            get
            {
                return richTextBox1.SelectionStart;
            }
            set
            {
                richTextBox1.SelectionStart = value;
            }
        }

        public MyRichTextBox()
        {
            InitializeComponent();
            LineNumberTextBox.Width = 100;
        }

        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1
            int line = richTextBox1.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBox1.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBox1.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBox1.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            richTextBox1.Select();
            // create & set Point pt to (0,0)
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1
            int First_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int First_Line = richTextBox1.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1
            int Last_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBox1.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line
            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        

        private void MyRichTextBox_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            AddLineNumbers();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            Point pt = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void MyRichTextBox_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        public void Cut()
        {
            richTextBox1.Cut();
        }

        public void Copy()
        {
            richTextBox1.Copy();
        }

        public void Paste()
        {
            richTextBox1.Paste();
        }

        public void Find(string str,int start,int end, RichTextBoxFinds options)
        {
            richTextBox1.Find(str,start,end,options);
        }
    }
}
