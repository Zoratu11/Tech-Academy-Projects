using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Statement_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.
            Console.WriteLine("Guess a letter. If you get it right you win but if not you have to keep guessing!");
            char guess = Convert.ToChar(Console.ReadLine());
            bool keepGoing = true;

            while (keepGoing)
            {
                switch (guess)
                {
                    case 'a':
                        Console.WriteLine("Sorry 'a' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'g':
                        Console.WriteLine("Sorry 'g' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'z':
                        Console.WriteLine("Sorry 'z' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 't':
                        Console.WriteLine("Sorry 't' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'i':
                        Console.WriteLine("You got it correct! 'i' is the right letter!");
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;

                }
            }
            /*
            // 2.
            bool keepGoing = true;
            Console.WriteLine("Guess a letter. If you get it right you win but if not you have to keep guessing!");
            char guess = Convert.ToChar(Console.ReadLine());

            do
            {
                switch (guess)
                {
                    case 'a':
                        Console.WriteLine("Sorry 'a' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'g':
                        Console.WriteLine("Sorry 'g' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'z':
                        Console.WriteLine("Sorry 'z' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 't':
                        Console.WriteLine("Sorry 't' is the wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                    case 'i':
                        Console.WriteLine("You got it correct! 'i' is the right letter!");
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong guess");
                        Console.WriteLine("Guess another letter!");
                        guess = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
            while (keepGoing);
        }*/
            Console.ReadLine();
        }
    }
}
