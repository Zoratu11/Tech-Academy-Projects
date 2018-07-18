using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        long number1 = Convert.ToInt64(Console.ReadLine());
        number1 = number1 * 50;
        Console.WriteLine("First number times 50 equals: " + number1);

        Console.WriteLine("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        number2 = number2 + 25;
        Console.WriteLine("Second number plus 25 equals: " + number2);

        Console.WriteLine("Enter third number: ");
        double number3 = Convert.ToDouble(Console.ReadLine());
        number3 = number3 / 12.5;
        Console.WriteLine("Third number divided by 12.5 equals: " + number3);

        Console.WriteLine("Enter fourth number: ");
        int number4 = Convert.ToInt32(Console.ReadLine());
        bool greaterThan = number4 > 50;
        Console.WriteLine("Fourth number is greater than 50 is: " + greaterThan);

        Console.WriteLine("Enter fifth number: ");
        int number5 = Convert.ToInt32(Console.ReadLine());
        int remainder = number5 % 7;
        Console.WriteLine("The remainder of the fifth number divided by 7 is: " + remainder);

        Console.ReadLine();
    }
}
