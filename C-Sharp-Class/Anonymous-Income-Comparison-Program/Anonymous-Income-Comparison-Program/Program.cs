using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1: ");
            Console.WriteLine("Hourly Rate?");
            person1.SetHourlyRate(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            person1.SetHoursWorked(Console.ReadLine());

            Console.WriteLine("Person 2: ");
            Console.WriteLine("Hourly Rate?");
            person2.SetHourlyRate(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            person2.SetHoursWorked(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(person1.GetAnnualSalary());
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(person2.GetAnnualSalary());

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1.GetAnnualSalary() > person2.GetAnnualSalary());
        }
    }
}
