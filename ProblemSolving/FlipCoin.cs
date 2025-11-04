using System;

namespace BridgeLabzApp.BasicCSharp{
    class FlipCoin {
        public FlipCoin()
        {
            Random random = new Random();
            Console.Write("Tell number of times coin to flip");
            string? totalFlips = Console.ReadLine();
            double countHead = 0;
            double countTail = 0;
            if (int.TryParse(totalFlips,out int totalFlipsNum)){
                for (int i = 0; i < totalFlipsNum; i++)
                {
                    double rand = random.NextDouble();
                    if (rand< 0.5)
                    {
                        countTail++;
                    }
                    else
                    {
                        countHead++;
                    }

                }
                double percentageHead = (countHead * 100) / totalFlipsNum;
                double percentageTail = (countTail * 100) / totalFlipsNum;
                Console.WriteLine($"Head Percentage is {percentageHead:F2} % and Tail Percentage is {percentageTail:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }


        }
    }
}