using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceExample.Models
{
    internal class DefinitionGoing : Interface1
    {

        public string Name { get; set; }
        public string lName { get; set; }
        

        void Interface1.NamePassing(string name, string lName)
        {
            Console.WriteLine("hii DefinitionGoing "+name+""+lName);
        }

    }
}
