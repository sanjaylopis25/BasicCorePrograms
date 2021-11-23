using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Swap
    {
        public void Swapnumbers()
        {
            Console.Write("Enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping....");
            Console.WriteLine("a value is: " + a);
            Console.WriteLine("b value is: " + b);
            Console.ReadLine();
        }
    }
}
