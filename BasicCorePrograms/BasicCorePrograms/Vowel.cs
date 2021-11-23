using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Vowel
    {
        public void VowelConsonant()
        {
            Console.Write("Enter an Alphabet: ");
            char character = Convert.ToChar(Console.ReadLine().ToLower());
            switch (character)
            {
                case 'a':
                    Console.WriteLine(character + " is Vowel");
                    Console.ReadLine();
                    break;
                case 'e':
                    Console.WriteLine(character + " is Vowel");
                    Console.ReadLine();
                    break;
                case 'i':
                    Console.WriteLine(character + " is Vowel");
                    Console.ReadLine();
                    break;
                case 'o':
                    Console.WriteLine(character + " is Vowel");
                    Console.ReadLine();
                    break;
                case 'u':
                    Console.WriteLine(character + " is Vowel");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(character + " is Consonant");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
