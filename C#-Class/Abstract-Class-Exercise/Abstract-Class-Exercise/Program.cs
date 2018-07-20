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
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student" };
            emp.SayName();
            IQuittable emp2 = new Employee();
            emp2.Quit();

            Console.ReadLine();
        }
    }
}
