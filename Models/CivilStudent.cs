using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class CivilStudent : AbstractClass1, InterfaceCivil
    {
        public void EquipmentCivil(string name)
        {
            Console.WriteLine("Cicil equipmets : "+name);
        }

        /*  public override void CivilEquipments(string equipmentName)
 {
     Console.WriteLine("Civil equipments"+equipmentName);
 }*/

        public override void StudentDetailsAbstract(int id, string Name)
        {
            Console.WriteLine("printing students Details for Civil Students\n" + id + "\n" + Name);
        }
    }
}
