using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class ReverseWord
    {
        public void Reverse()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string reversedWord = "";

            int i = word.Length - 1;
            while (i >= 0)
            {
                reversedWord += word[i];
                i--;
            }

            Console.WriteLine("Reversed word: " + reversedWord);
        }
    }
}
