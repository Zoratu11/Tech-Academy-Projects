using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current day of the week?");
            DaysOfTheWeek day;
            try
            {
                string str = Console.ReadLine();
                str = str.First().ToString().ToUpper() + str.Substring(1);
                if(Enum.IsDefined(typeof(DaysOfTheWeek), str))
                {
                    day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), str);
                    Console.WriteLine("day equals: " + day);
                } else
                {
                    Console.WriteLine("Please enter an actual day of the week!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week!");
            }
        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
