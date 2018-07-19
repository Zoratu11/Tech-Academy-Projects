using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_117_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();

            //regular method
            Console.WriteLine("Enter a number to be divided by 2: ");
            int number = Convert.ToInt32(Console.ReadLine());
            math.DivideBy2(number);

            //method with out parameter
            int quotient;
            int dividend = 1000;
            Console.WriteLine("enter a divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            math.DivideByNumber(out quotient, dividend, divisor);
            Console.WriteLine("Your quotient is: " + quotient);

            //Overloaded method
            Console.WriteLine("Enter a number to be divided by 2: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string message = "Here is your number: ";
            math.DivideBy2(num1, message);

            //Static class methods

            //static method 1
            MyMath2.DivideNumber(56, 6);

            //static method 2
            Console.WriteLine("Static method returned this: " + MyMath2.DivideNumber2(100, 25));

            Console.ReadLine();
        }
    }
}
