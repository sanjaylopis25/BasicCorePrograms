using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public void Harmonic()
        {
            double harmonic = 0;
            Console.Write("Enter the value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (double i =1; i <= N; i++)
            {
                harmonic = harmonic + (1 / i);
            }
            Console.Write("The Harmonic Value is: " + harmonic);
            Console.ReadLine();
        }
    }
}
