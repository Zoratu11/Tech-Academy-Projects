using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_117_Exercise
{
    class MyMath
    {
        public void DivideBy2(int num)
        {
            int quotient = num / 2;
            Console.WriteLine("Your number is: " + quotient);

        }

        public void DivideByNumber(out int num1, int num2, int divisor)
        {
            num1 = num2 / divisor;
        }

        public void DivideBy2(int num1, string message)
        {
            num1 = num1 / 2;
            Console.WriteLine(message + num1);
        }
    }
}
