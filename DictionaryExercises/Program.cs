using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> roster = new Dictionary<string, int>();
            roster.Add("Megan", 08070);
            roster.Add("Rocky", 08180);
            roster.Add("Mandy", 08071);

            foreach(KeyValuePair <string, int> i in roster)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            };
        }
    }
}
