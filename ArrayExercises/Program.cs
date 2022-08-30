using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[6] { 1, 1, 2, 3, 5, 8 };
            foreach(int num in numberArray)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
                
            }
            
        }
    }
}
