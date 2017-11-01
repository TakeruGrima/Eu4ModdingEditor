using Eu4ModEditor.ControlComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eu4ModEditor.EditorComponent
{
    class FileListBoxItem : GListBoxItem
    {
        public string Description { get; set; }
        public string Type { get; set; }

        public FileListBoxItem(string text, int indexImage,string description,string fileType)
            :base(text,indexImage)
        {
            Description = description;
            Type = fileType;
        }
    }
}
