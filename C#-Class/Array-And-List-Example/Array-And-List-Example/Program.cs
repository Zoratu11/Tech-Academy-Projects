using System;
using System.Collections.Generic;

namespace Array_And_List_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex;
            int secondIndex;
            int thirdIndex;

            string[] animalArray = new string[3];
            string[] nameArray = new string[4];

            animalArray[0] = "Dog";
            animalArray[1] = "Cat";
            animalArray[2] = "Llama";

            nameArray[0] = "Bob";
            nameArray[1] = "Walt";
            nameArray[2] = "Vic";
            nameArray[3] = "Riley";

            void getFirstIndex()
            {
                Console.WriteLine("Select an index from " +
                "0 to 2 to display a string from the " +
                "animal array!");
                firstIndex = Convert.ToInt32(Console.ReadLine());

                if (firstIndex > 2 || firstIndex < 0)
                {
                    Console.WriteLine("Please enter another number");
                    getFirstIndex();
                } else
                {
                    Console.WriteLine("At index " + firstIndex + " the value is: " + animalArray[firstIndex]);
                }
            }

            void getSecondIndex()
            {
                Console.WriteLine("Select an index from " +
                "0 to 3 to display a string from the " +
                "name array!");
                secondIndex = Convert.ToInt32(Console.ReadLine());

                if (secondIndex > 3 || secondIndex < 0)
                {
                    Console.WriteLine("Please enter another number");
                    getSecondIndex();
                }
                else
                {
                    Console.WriteLine("At index " + secondIndex + " the value is: " + nameArray[secondIndex]);
                }
            }

            getFirstIndex();
            getSecondIndex();

            List<string> list = new List<string>();
            list.Add("tree");
            list.Add("rock");
            list.Add("ground");
            list.Add("leaf");
            list.Add("horse");

            void getThirdIndex()
            {
                Console.WriteLine("Select an index from " +
                "0 to 4 to display a string from the " +
                "list!");
                thirdIndex = Convert.ToInt32(Console.ReadLine());

                if(thirdIndex > 4 || thirdIndex < 0)
                {
                    Console.WriteLine("Please enter anither number");
                    getThirdIndex();
                } else
                {
                    Console.WriteLine("At index " + thirdIndex + " the value is: " + list[thirdIndex]);
                }
            }

            getThirdIndex();
        }
    }
}
