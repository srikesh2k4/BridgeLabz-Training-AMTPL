using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var evenSquares = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * n);

            foreach (var n in evenSquares)
                Console.WriteLine(n);
        }
    }
}