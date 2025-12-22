using System;

namespace ClosureDemo
{
    class Program
    {
        static void Main()
        {
            Func<int, int> multiplier = CreateMultiplier(5);
            Console.WriteLine(multiplier(10)); // 50
        }

        static Func<int, int> CreateMultiplier(int factor)
        {
            return x => x * factor; // factor is captured
        }
    }
}