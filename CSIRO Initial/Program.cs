using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIRO_Initial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Study s = new Study(args[0]);
            var output = Parser.Translate(s);
            output.Save(args[1]);

        }
    }
}
