﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Output_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string text = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\Zoratu\Desktop\Logs\log1.txt", true))
            {
                file.WriteLine(text);
            }
            string[] fileText = File.ReadAllLines(@"C:\Users\Zoratu\Desktop\Logs\log1.txt");
            Console.WriteLine("Here is the text inside the file: \n");
            foreach (string str in fileText)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
