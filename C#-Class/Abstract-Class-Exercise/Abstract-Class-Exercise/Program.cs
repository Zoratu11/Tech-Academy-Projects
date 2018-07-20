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
            Employee<string> emp1 = new Employee<string>();
            Employee<int> emp2 = new Employee<int>();
            emp1.things = new List<string>() { "Panda", "Snake", "Monkey", "Praying Mantis", "Tiger", "Turtle", "Red Panda" };
            emp2.things = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            Console.WriteLine("What movie are all these animals from?");
            foreach(string animal in emp1.things)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("\n");
            foreach(int number in emp2.things)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
