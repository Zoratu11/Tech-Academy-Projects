using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math1 = new MyMath();
            MyMath math2 = new MyMath();
            MyMath math3 = new MyMath();

            int number1 = 12;
            decimal number2 = 4.32m;
            string number3 = "20";

            Console.WriteLine("After doing some math on " + number1 + " the result is: " + math1.DoMath(number1));
            Console.WriteLine("After doing some math on " + number2 + " the result is: " + math1.DoMath(number2));
            Console.WriteLine("After doing some math on " + number3 + " the result is: " + math1.DoMath(number3));

            Console.ReadLine();
        }
    }
}
