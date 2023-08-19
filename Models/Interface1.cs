using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal interface Interface1
    {
       
   
        string Name { get; set; }
        string lName { get; set; }

       void NamePassing(string name, string lName);


   
    }
}
