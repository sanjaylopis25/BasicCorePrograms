using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOf2
    {
        public void Power2()
        {
            double power = 0;
            Console.Write("The number of times : ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                power = Math.Pow(2, i);
                Console.WriteLine("2^"+ i + " = " + power);
                Console.ReadLine();
            }
        }
    }
}
