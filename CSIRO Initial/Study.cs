using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSIRO_Initial
{
    public class Study
    {
        public XDocument BackingDoc { get; protected set; }

        public Study(string path)
        {
            BackingDoc = XDocument.Load(path);
        }
    }
}
