using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public void Leapyear()
        {
            Console.Write("Enter the year in YYYY format : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year > 999) && (year < 10000))
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine(year + " is a Leap Year");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(year + " is not a Leap Year");
                    Console.ReadLine();
                }
            }
            else
                Console.Write("The year is not in YYYY format");
                Console.ReadLine();
        }

    }
}
