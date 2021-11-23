using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void PrimeFactors()
        {
            int i, j;
            int count = 0;
            int flag = 0;
            Console.Write("Enter the value : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime factor of {0}:\n", num);
            for (i = 2; i < num; i++)
            {
                // check for divisibility
                if (num % i == 0)
                {
                    count = 0;
                    // check for prime number
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadLine();
            if (flag == 0)
            {
                Console.Write("There is no Prime factor for {0} ", num);
                Console.ReadLine();
            }
        }
    }
}
