using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double packageWeight;
            double packageWidth;
            double packageHeight;
            double packageLength;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Enter package weight: ");
            packageWeight = Convert.ToDouble(Console.ReadLine());
            if(packageWeight > 50.0)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            } else
            {
                Console.WriteLine("Enter package width: ");
                packageWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter package height: ");
                packageHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter package length: ");
                packageLength = Convert.ToDouble(Console.ReadLine());

                double total = packageWidth * packageHeight * packageLength;

                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                } else
                {
                    double quote = (total * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(quote, 2));
                    Console.WriteLine("Thank you.");
                }
            }

            Console.ReadLine();
        }
    }
}
