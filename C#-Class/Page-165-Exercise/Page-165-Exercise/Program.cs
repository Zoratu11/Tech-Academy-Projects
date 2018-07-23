using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_165_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if(age <= 0)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("So you were born in {0}!", DateTime.Now.AddYears(-age).Year);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Sorry this program only takes positive numbers!");
                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry an error has occured. The programmer sucks :(");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
