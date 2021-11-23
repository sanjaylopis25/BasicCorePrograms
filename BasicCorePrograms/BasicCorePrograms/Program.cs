using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs \nCoin Flip -1 \nLeap Year -2 \nPower Of 2 -3 \nHarmonic Number -4 \nFactors -5");
            Console.WriteLine("Quotient & Remainder -6 \nSwap Numbers -7 \nEven or Odd -8 \nVowels -9 \nLargest -10");
            Console.Write("The number of Program to run : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    CoinFlip obj1 = new CoinFlip();
                    obj1.FlipCoin();
                    break;
                case 2:
                    LeapYear obj2 = new LeapYear();
                    obj2.Leapyear();
                    break;
                case 3:
                    PowerOf2 obj3 = new PowerOf2();
                    obj3.Power2();
                    break;
                case 4:
                    HarmonicNumber obj4 = new HarmonicNumber();
                    obj4.Harmonic();
                    break;
                case 5:
                    Factors obj5 = new Factors();
                    obj5.PrimeFactors();
                    break;
                case 6:
                    QuoandRem obj6 = new QuoandRem();
                    obj6.QuotientAndRemaider();
                    break;
                case 7:
                    Swap obj7 = new Swap();
                    obj7.Swapnumbers();
                    break;
                case 8:
                    EvenOdd obj8 = new EvenOdd();
                    obj8.EvenorOdd();
                    break;
                case 9:
                    Vowel obj9 = new Vowel();
                    obj9.VowelConsonant();
                    break;
                case 10:
                    Largestof3 obj10 = new Largestof3();
                    obj10.LargestNumber();
                    break;
            }
        }
    }
}
