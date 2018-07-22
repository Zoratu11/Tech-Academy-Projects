using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("current time is: " + DateTime.Now);
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be {1}", num, DateTime.Now.AddHours(num));
        }
    }
}
