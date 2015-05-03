using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using VDS.RDF;
using VDS.RDF.Writing;

namespace CSIRO_Initial
{
    public static class Parser
    {
        public static XDocument Translate(Study source)
        {
            IGraph g = new Graph();
            
            RdfXmlWriter wr = new RdfXmlWriter();



            throw new NotImplementedException();
        }

    }
}
