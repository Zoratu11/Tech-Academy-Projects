using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            int number;

            Console.WriteLine("This program will perform serveral math operations on a number of your choice!");
            Console.WriteLine("What number would you like to use?");
            number = Convert.ToInt32(Console.ReadLine());

            number = math.Add1000ToNumber(number);
            Console.WriteLine("After adding 1000 number is: " + number);
            number = math.Subtract200FromNumber(number);
            Console.WriteLine("After subtracting 200 the number is: " + number);
            number = math.MultiplyNumberBy50(number);
            Console.WriteLine("After doing the final operation on the number (multiplying by 50) the number is: " + number);

            Console.ReadLine();
        }
    }
}
