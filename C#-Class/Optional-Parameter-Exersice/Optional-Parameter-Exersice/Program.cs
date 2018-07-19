using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();

            Console.WriteLine("Enter 1 or 2 numbers, if you " +
                "enter 2 numbers enter them one by one.\n" +
                "Leave the second line blank if you don't " +
                "want to enter another number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int num2;

            if(str == "")
            {
                int num3 = math.doMath(num1);
                Console.WriteLine("Here is your number after doing some math: " + num3);
            } else
            {
                num2 = Convert.ToInt32(str);
                int num3 = math.doMath(num1, num2);
                Console.WriteLine("Here is your number after doing some math: " + num3);
            }

            Console.ReadLine();
        }
    }
}
