using System;

namespace Car_Insurance_Approval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int applicantAge;
            bool hasDUI;
            int numOfTickets;

            Console.WriteLine("What is your age?");
            applicantAge = Convert.ToInt32(Console.ReadLine());

            void getDUIAnswer()
            {
                Console.WriteLine("Have you ever had a DUI? Answer yes or no!");
                string answer = Console.ReadLine();

                if(answer.ToLower() == "yes")
                {
                    hasDUI = true;
                } else if(answer.ToLower() == "no")
                {
                    hasDUI = false;
                }
                else
                {
                    Console.WriteLine("Bzzzt wrong, enter yes or no");
                    getDUIAnswer();
                }
            }

            getDUIAnswer();

            Console.WriteLine("How many speeding tickets do you have?");
            numOfTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            if(applicantAge > 15 && !hasDUI && numOfTickets < 4)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

        }
    }
}
