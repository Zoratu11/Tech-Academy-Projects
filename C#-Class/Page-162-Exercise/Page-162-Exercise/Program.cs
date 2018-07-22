using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_162_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string text = "This doesnt change";
            Console.WriteLine(text);
            Console.WriteLine(text);
            var balance = new Decimal(67.9);
            Person person = new Person("Blarg");

            Console.WriteLine("Person name is {0} and Person id is {1}", person.Name, person.Id);

            Console.ReadLine();
        }
    }
    public class Person
    {
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public Person(string name) : this(name, 100) { }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
