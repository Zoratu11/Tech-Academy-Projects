using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee() { FirstName = "Bob", LastName = "Larry", Id = 21 };
            Employee emp2 = new Employee() { FirstName = "Larry", LastName = "Guy", Id = 70 };
            Employee emp3 = new Employee() { FirstName = "Alien", LastName = "Blarg", Id = 43 };
            Employee emp4 = new Employee() { FirstName = "Laurie", LastName = "blah", Id = 2 };
            Employee emp5 = new Employee() { FirstName = "Student", LastName = "Test", Id = 90 };
            Employee emp6 = new Employee() { FirstName = "Joe", LastName = "Dog", Id = 100 };
            Employee emp7 = new Employee() { FirstName = "Person", LastName = "Couch", Id = 14 };
            Employee emp8 = new Employee() { FirstName = "Joe", LastName = "Hmm", Id = 10 };
            Employee emp9 = new Employee() { FirstName = "Cait", LastName = "Random", Id = 58 };
            Employee emp10 = new Employee() { FirstName = "Walt", LastName = "Fedora", Id = 19 };
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);
            empList.Add(emp10);

            List<Employee> copyList = new List<Employee>();
            foreach(Employee emp in empList)
            {
                if (emp.FirstName == "Joe")
                {
                    copyList.Add(emp);
                }
            }

            List<Employee> otherList = empList.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> anotherList = empList.Where(x => x.Id > 5).ToList();

            Console.WriteLine("empList is: ");
            foreach (Employee emp in empList)
            {
                Console.WriteLine("FirstName: " + emp.FirstName + " " + "LastName: " + emp.LastName + " " + "Id: " + emp.Id);
            }
            Console.WriteLine();
            Console.WriteLine("copyList is: ");
            foreach (Employee emp in copyList)
            {
                Console.WriteLine("FirstName: " + emp.FirstName + " " + "LastName: " + emp.LastName + " " + "Id: " + emp.Id);
            }
            Console.WriteLine();
            Console.WriteLine("otherList is: ");
            foreach (Employee emp in otherList)
            {
                Console.WriteLine("FirstName: " + emp.FirstName + " " + "LastName: " + emp.LastName + " " + "Id: " + emp.Id);
            }
            Console.WriteLine();
            Console.WriteLine("anotherList is: ");
            foreach (Employee emp in anotherList)
            {
                Console.WriteLine("FirstName: " + emp.FirstName + " " + "LastName: " + emp.LastName + " " + "Id: " + emp.Id);
            }

            Console.ReadLine();
        }
    }
}
