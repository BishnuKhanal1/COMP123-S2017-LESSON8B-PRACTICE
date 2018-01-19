using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is a drver class, a class that drives the rest of the program, codes
//it is static class, without it, application wouldn't function,
//it doesn't have to be intantiated, but creates the instance of my program
namespace COMP123_S2017_LESSON8B_PRACTICE
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bikalpa", 6);
            //now provide behavour (call method)
            Console.WriteLine("\n");
            person.Talks(); //. is a accessor to access method
            Console.WriteLine("\n");

            Student student = new Student("Erica", 5, "12354B");
            student.Studies();
            student.Talks();
            Console.WriteLine("\n");

            DomesticStudent domesticStudent = new DomesticStudent("Bobo", 15, "1234567C");
            domesticStudent.Talks();
            domesticStudent.Studies();
            domesticStudent.SetDomesticAddress("283 Pharmacy Ave");
           
            Console.WriteLine("\n");
        }
    }
}
