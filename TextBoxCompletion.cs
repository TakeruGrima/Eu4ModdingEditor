using Eu4ModEditor.ControlComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor
{
    class TextBoxCompletion : MyRichTextBox
    {
        #region Fields Region

        //declare  isCurslyBracesKeyPressed variable as Boolean and assign false value  
        //to check { key is pressed or not  
        public static Boolean isCurslyBracesKeyPressed = false;

        #endregion

        #region Constructor Region

        public TextBoxCompletion()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(28, 28, 28);
            ForeColor = Color.FromArgb(255, 255, 255);
            richTextBox1.KeyDown += new KeyEventHandler(richTextBox_KeyDown);
            richTextBox1.KeyPress += new KeyPressEventHandler(richTextBox_KeyPress);

            BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.AcceptsTab = true;
            richTextBox1.SelectionTabs = new int[] { 20};
            richTextBox1.TabIndex = 0;
            richTextBox1.Font = new Font("Consolas", 10);
            LineNumberTextBox.Font = richTextBox1.Font;
        }

        #endregion

        #region KeyEvents Region

        // if key (,{,<,",',[ is pressed then insert opposite key to GetRichTextBox() at Position SelectionStart+1  
        // add one line after inserting, e.Handled=true;  
        //finally set SelectionStart to specified position 
        private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            String s = e.KeyChar.ToString();
            int sel = richTextBox1.SelectionStart;
            switch (s)
            {
                case "(":
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, "()");
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + 1;
                    break;

                case "{":
                    String t = "{}";
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, t);
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + t.Length - 1;
                    isCurslyBracesKeyPressed = true;
                    break;

                case "[":
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, "[]");
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + 1;
                    break;

                case "<":
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, "<>");
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + 1;
                    break;

                case "\"":
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, "\"\"");
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + 1;
                    break;

                case "'":
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, "''");
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + 1;
                    break;
            }
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            int sel = richTextBox1.SelectionStart;
            if (e.KeyCode == Keys.Enter)
            {
                if (isCurslyBracesKeyPressed == true)
                {                                                           
                    richTextBox1.Text = richTextBox1.Text.Insert(sel, "\n    \n");
                    e.Handled = true;
                    richTextBox1.SelectionStart = sel + "    ".Length;
                    isCurslyBracesKeyPressed = false;
                }
            }
        }

        #endregion
    }
}
