using System;
namespace BridgeLabzApp.ProblemSolving
{
    public class LeapYear
    {
        public LeapYear()
        {
            bool wrongInput = true;
            while (wrongInput)
            {
                Console.WriteLine("Enter the year to check leap year: ");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine($"{year} is leap year");
                    }
                    else if (year % 100 == 0)
                    {
                        Console.WriteLine($"{year} is not leap year");
                    }
                    else if (year % 4 == 0)
                    {
                        Console.WriteLine($"{year} is leap year");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is not leap year");
                    }
                    
                    wrongInput = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }

    }
}


