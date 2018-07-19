using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter_Exersice
{
    class MyMath
    {
        public int doMath(int num1, int num2 = 9)
        {
            return num1 * num2;
        }
    }
}
