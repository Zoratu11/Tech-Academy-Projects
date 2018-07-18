using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Exercise
{
    class MyMath
    {
        public int DoMath(int number)
        {
            return number + 100;
        }

        public int DoMath(decimal number)
        {
            decimal number2 = 12.5m;
            number = number * number2;
            return (int)number;
        }

        public int DoMath(string number)
        {
            int number1 = 0;
            try
            {
                number1 = Convert.ToInt32(number);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("You were supposed to enter a number!");
            }

            return number1 - 10;

        }
    }
}
