using System;

namespace fibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number of the Fibonocci Sequence would you like to calculate?");
            int userChoice = int.Parse(Console.ReadLine());
            int answer = FibNumGetter(userChoice);
            Console.WriteLine($"Fibonacci number at {userChoice}: {answer}.");
        }

        static int FibNumGetter(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
            {
                int twoBack = 0;
                int oneBack = 1;
                int current = 0;
                for (int i = num; i > 0; i--)
                {
                    current = twoBack + oneBack;
                    twoBack = oneBack;
                    oneBack = current;
                }
                return current;
            }
        }
    }
}
