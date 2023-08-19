using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class MedicalStudent : AbstractClass1, MedicalEquipments// InterfaceCivil
    {
      /*  public void EquipmentCivil(string name)
        {
            Console.WriteLine("ds");
        }
*/
        public void EquipmentMedical(string name)
        {
            Console.WriteLine("Medical Equipment Name : "+name);
        }

        public override void StudentDetailsAbstract(int id, string Name)
        {
            Console.WriteLine("printing Details of Medical student\n" + id + "\n" + Name);
        }
    }
}
