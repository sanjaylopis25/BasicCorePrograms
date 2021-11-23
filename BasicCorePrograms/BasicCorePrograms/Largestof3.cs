using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Largestof3
    {
        public void LargestNumber()
        {
            Console.Write("Enter First number: ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (l > m && l > n)
            {
                Console.WriteLine(l + " is Largest");
                Console.ReadLine();
            }
            else if (m > l && m > n)
            {
                Console.WriteLine(m + " is Largest");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(n + " is Largest");
                Console.ReadLine();
            }
        }
    }
}
