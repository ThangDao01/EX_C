using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace EX2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            string word = Console.ReadLine();
            char[] strToChar = str.ToCharArray();
            char[] wordToChar = word.ToCharArray();
            for (int i = 0; i < strToChar.Length; i++)
            {
                if (strToChar[i].Equals(wordToChar[0]))
                {
                    for (int j = 1; j < wordToChar.Length; j++)
                    {
                        if (strToChar[i + j].Equals(wordToChar[j]))
                        {
                            Console.WriteLine(strToChar[i + j] + "&" + wordToChar[j]);
                            if (j == wordToChar.Length-1)
                            {
                                ++count;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Word found {count} time in the string");
        }
    }
}