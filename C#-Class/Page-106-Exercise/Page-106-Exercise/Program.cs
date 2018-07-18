using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_106_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList1 = new List<int>() { 5, 8, 9, 10, 12, 16, 20, 25 };
            int userNum;

            void divideByUserInput()
            {
                try
                {
                    Console.WriteLine("Please enter a number to divide each number in the list by.");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in intList1)
                    {
                        int quotient = number / userNum;
                        Console.WriteLine(number + " divided by " + userNum + " equals " + quotient);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a whole number.");
                    Console.WriteLine("Exception was caught. Restarting program...");
                    divideByUserInput();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't try to divide by zero.");
                    Console.WriteLine("Exception was caught. Restarting program...");
                    divideByUserInput();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Exception was caught. Restarting program...");
                    divideByUserInput();
                }
            }
            divideByUserInput();

            Console.ReadLine();
        }
    }
}
