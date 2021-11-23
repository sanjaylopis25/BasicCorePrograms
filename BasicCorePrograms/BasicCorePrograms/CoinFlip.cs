using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class CoinFlip
    {
        public void FlipCoin()
        {
            double count = 0;
            double PercentHeads = 0;
            double PercentTails = 0;
            double Heads = 0;
            double Tails = 0;
            double HEADS = 0;
            Console.Write("The number of times to flip coin: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (count < N)
            {
                Random random = new Random();
                double toss = random.Next(0, 2);
                count++;
                if (toss == HEADS)
                {
                    Heads++;
                    Console.WriteLine("It's Heads");
                }
                else
                {
                    Tails++;
                    Console.WriteLine("It's Tails");
                }
            }
            PercentHeads = (Heads * 100) / count;
            PercentTails = (Tails * 100) / count;
            Console.WriteLine("Percentage of Heads : " + PercentHeads);
            Console.ReadLine();
            Console.WriteLine("Percentage of Tails : " + PercentTails);
            Console.ReadLine();
        }
    }
}
