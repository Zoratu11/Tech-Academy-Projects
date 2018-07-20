using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Exercise
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("The name is: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit! This job sucks!");
        }

    }
}
