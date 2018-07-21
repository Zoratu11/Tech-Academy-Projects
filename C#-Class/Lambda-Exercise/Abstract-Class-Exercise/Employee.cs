using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exercise
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("The name is: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit! This job sucks!");
        }

        /*public static string operator==(Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return "The employee Ids are the same!";
            }
            else return "The employee Ids are not the same.";
            
        }

        public static string operator!=(Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
            {
                return "The employee Ids are not the same.";
            }
            else return "The employee Ids are the same!";
        }*/
    }
}
