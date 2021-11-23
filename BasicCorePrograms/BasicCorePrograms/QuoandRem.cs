using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuoandRem
    {
        public void QuotientAndRemaider()
        {
            Console.Write("Enter a dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient is: " + quotient);
            Console.WriteLine("Remainder is: " + remainder);
            Console.ReadLine();
        }
    }
}
