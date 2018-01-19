using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn_04_AbstractPlanets_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Planet planet = new Planet("Earth", 2315478.23, 2145456863.12);
           // planet.ToString();
            Console.WriteLine(planet.ToString());
            Console.WriteLine();
        }
    }
}
