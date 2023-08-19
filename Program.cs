using InterfaceExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Here go to definition click directly show interface class========================================");
            Interface1 myInterface = new DefinitionGoing();
            myInterface.NamePassing("hii", "haloo\n");
            Console.WriteLine("=========================Abstract interface difference===================================");
            Console.WriteLine("====================Civil========================================");
            CivilStudent studentCivil = new CivilStudent();
            studentCivil.StudentDetailsAbstract(1, "civil");
            //studentCivil.CivilEquipments("scale");
            Console.WriteLine("====================Medical========================================");
            MedicalStudent studentMedical = new MedicalStudent();
            studentMedical.StudentDetailsAbstract(1, "medical");
            Console.WriteLine("============================================================");
            Console.WriteLine("=========================Multiple inheritance used interface ===================================");
            MedicalEquipments studentMedical2 = new MedicalStudent();
            //InterfaceCivil student3 = new MedicalStudent();
            studentMedical2.EquipmentMedical("Surgical knife");
           // student3.EquipmentCivil("dd");
            Console.WriteLine("============================================================");
            
            InterfaceCivil studentCivil2 = new CivilStudent();
            studentCivil2.EquipmentCivil("Camera");
            Console.WriteLine("============================================================");

        }
    }
 

  
}
