using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Eu4ModEditor.JSON
{
    [DataContract]
    public class FileMod
    {
        [DataMember]
        public List<string> Paths { get; set; }
    }
}
