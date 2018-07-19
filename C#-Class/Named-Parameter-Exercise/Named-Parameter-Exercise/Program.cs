using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameter_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            math.DoMath(12, 43);
            math.DoMath(num1: 5, num2: 10);

            Console.ReadLine();
        }
    }
}
