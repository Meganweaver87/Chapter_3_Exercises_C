using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListExercises
{
    class Program
    {
        static void Main (string[] args)
        {
            List<string> wordList = new List<string> { "Green", "Eggs", "And", "Ham" };
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numTotal = evenNumbers(numList);
            wordsSelected(wordList);

        }
        static void wordsSelected(List<string> wordList)
        {
            
            Console.WriteLine("Please enter a word length: ");
            string responseOriginal = Console.ReadLine();
            int response = Convert.ToInt16(responseOriginal);

                foreach (string word in wordList)
                {
                    
                    if (word.Length == response)
                    {
                        Console.WriteLine(word);
                    }
                }
             
        }

        static int evenNumbers(List<int> numList)
        {
            int numSum = 0;

            foreach (int num in numList)
            {

                if (num % 2 == 0)
                {
                    numSum += num;
                }
            }
            Console.WriteLine(numSum);   
            return numSum;
        }

    }
}
