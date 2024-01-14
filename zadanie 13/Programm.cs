using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_13
{
    class Programm
    {
        static void Main(string[] args)
        {
            Building building = new Building("Улица заречная 24", 201.2, 180, 167);
            Console.WriteLine(building.Print());
            MultiBuilding multibuilding = new MultiBuilding("Улица мира 43", 178.2, 134.4,147, 14);
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }
    }
}
