using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    abstract class AbstractClass1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void StudentDetailsAbstract(int id, string Name);

       // public abstract void CivilEquipments( string equipmentName);
       //this function cannot use, it should be derived both medical and civil class.medical doesnt need this function
       //to avoid we use inetrface
    }
}
