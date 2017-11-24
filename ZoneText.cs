using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eu4ModEditor
{
    class ZoneText
    {
        #region Field Region

        private string text;

        string Separator, EndSeparator;
        public string Path;// Chemin du fichier

        RichTextBox markBox;//cette textBox contient le texte mais les \t de la mise en page sont
        //remplacé par des <

        RichTextBox box;

        int SelectionStart;//Position du texte

        #endregion

        #region Property Region

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                box.Text += Separator + "\n\t" + Text.Replace("\n", "\n\t");
                box.Text += "\n" + EndSeparator + "\n\n";
            }
        }

        #endregion

        #region Constructor Region

        public ZoneText(string path, RichTextBox box, string separator)
        {
            Separator = separator;
            EndSeparator = separator.Replace("<", "<\\");

            markBox = new RichTextBox();
            this.box = box;

            Path = path;
        }

        #endregion

        #region Read Methods

        public void ReadAllFile()
        {
            Text = File.ReadAllText(Path);

            ActualizeMarkBox();

            getSelectionStart();
        }

        public void ReadString(string text)
        {
            Text = text;

            ActualizeMarkBox();

            getSelectionStart();
        }

        #endregion

        #region Methods

        public void getSelectionStart()
        {
            SelectionStart = box.Text.IndexOf(Separator) + Separator.Length + 2;
        }

        public void ActualizeMarkBox()
        {
            markBox.Text = box.Text.Replace("\n\t", "\n<");
        }

        public string GetText()
        {
            getSelectionStart();
            int end = box.Text.IndexOf(EndSeparator);

            string tmp;

            tmp = box.Text.Substring(SelectionStart, end - SelectionStart);
            tmp = tmp.Replace("\n\t", "\n");
            return tmp;
        }

        #endregion

        #region KeyEvents

        public bool KeyDown(KeyEventArgs e)
        {
            int boxSelectionStart = box.SelectionStart;

            int indexFindEnd = box.Text.IndexOf(EndSeparator);
            int indexFindDebut = box.Text.IndexOf(Separator) + Separator.Length;

            if (indexFindEnd > box.SelectionStart)
            {
                if (indexFindEnd > box.SelectionStart && indexFindDebut < box.SelectionStart)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (markBox.Text[box.SelectionStart - 1] == '<')
                        {
                            //e.Handled = true;
                            box.Text = box.Text.Remove(box.SelectionStart - 2, 2);
                            markBox.Text = markBox.Text.Remove(box.SelectionStart - 2, 2);
                            return false;
                        }
                    }
                    else if(e.KeyCode == Keys.Enter)
                    {
                        box.Select(box.SelectionStart, 0);

                        Clipboard.SetText("\n\t");

                        box.Paste();
                        //box.Text = box.Text.Insert(box.SelectionStart, "\n\t");
                        e.Handled = true;
                        //box.SelectionStart = box.SelectionStart + 2;
                        return true;
                    }
                }
            }
            ActualizeMarkBox();
            return false;
        }

        public bool KeyPress(KeyPressEventArgs e)
        {
            int indexFindEnd = box.Text.IndexOf(EndSeparator);
            int indexFindDebut = box.Text.IndexOf(Separator) + Separator.Length;

            if (indexFindEnd <= box.SelectionStart
                && indexFindEnd + EndSeparator.Length >= box.SelectionStart)
            {
                e.Handled = true;
                return false;
            }

            if (indexFindEnd > box.SelectionStart)
            {
                ActualizeMarkBox();
                return true;
            }
            return false;
        }

        #endregion
    }
}
