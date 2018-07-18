using System;
using System.Collections.Generic;

namespace Page_103_Exercise
{
    class Program
    {
        static void Main()
        {
            //Question 1 start

            /*string[] nameArray = { "Bob", "Larry", "Chris", "Josh", "Ron", "Walt", "Robert" };
            string userInput;

            Console.WriteLine("Enter some text: ");
            userInput = Console.ReadLine();

            for(int i = 0; i < nameArray.Length; i++) 
            {
                nameArray[i] += " " + userInput;
            }

            foreach(string name in nameArray)
            {
                Console.WriteLine(name);
            }*/

            //Question 1 end

            //Question 2 start

            /*for(int j = 0; j > -5; j++)
            {
                Console.WriteLine("Hello, World!");
            }*/

            //Question 2 end

            //Question 3 start

            /*for(int j = 0; j < 5; j++)
            {
                Console.WriteLine("Hello, World!");
            }*/

            //Question 3 end

            //Question 4 start

            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Blarg");
            }*/

            //Question 4 end

            //Question 5 start

            /*for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("I like pie");
            }*/

            //Question 5 end

            //Question 6 start

            /*List<string> stringList1 = new List<string>() { "Blarg", "thing", "dog", "cat", "plane", "place" };
            Console.WriteLine("Enter a string to search the list for: ");
            string searchStr = Console.ReadLine();

            for(int i = 0; i < stringList1.Count; i++)
            {
                if(stringList1[i].Contains(searchStr))
                {
                    Console.WriteLine("The index you are looking for is : " + i);
                }
            }*/

            //Question 6 end

            //Question 7 start

            /*List<string> stringList1 = new List<string>() { "Blarg", "thing", "dog", "cat", "plane", "place" };
            Console.WriteLine("Enter a string to search the list for: ");
            string searchStr = Console.ReadLine();

            for(int i = 0; i < stringList1.Count; i++)
            {
                if(stringList1[i].Contains(searchStr))
                {
                    Console.WriteLine("The index you are looking for is : " + i);
                } else
                {
                    Console.WriteLine("The string you are looking for is not in the list!");
                }
            }*/

            //Question 7 end

            //Question 8 start

            /*string searchStr;
            void findStringInList1()
            {
                List<string> stringList1 = new List<string>() { "Blarg", "thing", "dog", "cat", "plane", "place" };
                Console.WriteLine("Enter a string to search the list for: ");
                searchStr = Console.ReadLine();

                for (int i = 0; i < stringList1.Count; i++)
                {
                    if (stringList1[i].Contains(searchStr))
                    {
                        Console.WriteLine("The index you are looking for is : " + i);
                        return;
                    }
                }

                Console.WriteLine("The string you are looking for is not in the list! Try again!");
                findStringInList1();
            }
            findStringInList1();*/

            //Question 8 end

            //Question 9 and 10 start

            /*string searchStr2;
            void findStringInList2()
            {
                List<string> stringList2 = new List<string>() { "thing", "thing", "dog", "dog", "cat", "cat", "mouse", "car" };
                Console.WriteLine("Enter a string to search the list for: ");
                searchStr2 = Console.ReadLine();
                bool matchFound = false;

                for (int i = 0; i < stringList2.Count; i++)
                {
                    if (stringList2[i].Contains(searchStr2))
                    {
                        Console.WriteLine("The index you are looking for is : " + i);
                        matchFound = true;
                    }

                    if(i == stringList2.Count - 1 && matchFound)
                    {
                        return;   
                    }
                }

                Console.WriteLine("The string you are looking for is not in the list! Try again!");
                findStringInList2();
            }
            findStringInList2();*/

            //Question 9 and 10 end

            //Question 11 start

            List<string> stringList3 = new List<string>() { "dog", "dog", "qwerty", "clock", "clock", "sun", "car", "car" };
            List<string> copyList = new List<string>();
            foreach(string str1 in stringList3)
            {
                foreach(string str2 in copyList)
                {
                    if(str1 == str2)
                    {
                        Console.Write("This string appears more than once. ");
                    }
                }

                Console.WriteLine("Your message is: " + str1);
                copyList.Add(str1);
            }

            //Question 11 end
        }
    }
}
