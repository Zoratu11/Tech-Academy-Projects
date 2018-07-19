using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Exercise
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("The name is: " + FirstName + " " + LastName);
        }
    }
}
