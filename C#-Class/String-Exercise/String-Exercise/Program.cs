using System;
using System.Text;

namespace String_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "I like cats";
            string string2 = "I like dogs";
            string string3 = "I like birds";

            string string4 = string1 + string2 + string3;

            string upperString = string4.ToLower();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sunset it the time of day when " +
                "our sky meets the outer space solar winds.");
            sb.AppendLine("There are blue, pink, and purple " +
                "swirls, spinning and twisting, like clouds " +
                "of balloons caught in a blender.");
            sb.AppendLine("The sun moves slowly to hide " +
                "behind the line of horizon, while the moon " +
                "races to take its place in prominence atop " +
                "the night sky. ");
            sb.AppendLine("People slow to a crawl, entranced, " +
                "fully forgetting the deeds that still must be done.");
            sb.AppendLine("There is a coolness, a calmness, " +
                "when the sun does set");

            Console.WriteLine(sb);
        }
    }
}
