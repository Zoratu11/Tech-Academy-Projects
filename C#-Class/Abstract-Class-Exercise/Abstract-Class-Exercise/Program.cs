using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 41 };
            Employee emp2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 41 };
            string message = emp1 == emp2;
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
