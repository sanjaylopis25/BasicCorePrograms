using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public void EvenorOdd()
        {
            Console.Write("Enter a value: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is Even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(n + " is Odd");
                Console.ReadLine();
            }
        }
    }
}
