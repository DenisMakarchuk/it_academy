using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_08_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string str = Console.ReadLine();

            string minWord = str, maxWord = string.Empty;
            int minWordIndex = 0, maxWordIndex = 0;
            int pinMarks = 0, letters = 0;

            FindWords(str, ref minWord, ref maxWord, ref letters, ref pinMarks, ref maxWordIndex, ref minWordIndex);
            RemoveWord(ref str, maxWordIndex, maxWord);
            Console.WriteLine($"The text after removal the greatest word: {str}");

            FindWords(str, ref minWord, ref maxWord, ref letters, ref pinMarks, ref maxWordIndex, ref minWordIndex);
            ReWrite(maxWordIndex, minWordIndex, maxWord, minWord, ref str);
            Console.WriteLine(str);

            Console.WriteLine($"The smallest word in the text: {minWord}");
            Console.WriteLine($"The greatest word in the text: {maxWord}");
            Console.WriteLine($"Number of letters and numbers: {letters}");
            Console.WriteLine($"Number of pinmarks: {pinMarks}");

            Console.Read();
        }
        static void RemoveWord(ref string str, int index, string word)
        {
            str = str.Remove(index, word.Length);
        }
        static void ReWrite(int firstIndex, int secondIndex, string word1, string word2, ref string str)
        {
            if (firstIndex>=secondIndex)
            {
                str = str.Remove(firstIndex, word1.Length);
                str = str.Insert(firstIndex, word2);
                str = str.Remove(secondIndex, word2.Length);
                str = str.Insert(secondIndex, word1);
            }
            else
            {
                str = str.Remove(secondIndex, word2.Length);
                str = str.Insert(secondIndex, word1);
                str = str.Remove(firstIndex, word1.Length);
                str = str.Insert(firstIndex, word2);
            }
        }
        static void FindWords(string str, ref string minWord, ref string maxWord, ref int letters, ref int pinMarks, ref int maxWordIndex, ref int minWordIndex)
        {
            maxWord = string.Empty;
            minWord = str;
            pinMarks = 0;
            letters = 0;
            int counterOfLetters = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsPunctuation(str[i]))
                    pinMarks++;
                if (str[i].Equals(' ') || char.IsPunctuation(str[i]))
                {
                    if (counterOfLetters != 0 && counterOfLetters < minWord.Length)
                    {
                        minWord = str.Substring(i + 1, counterOfLetters);
                        minWordIndex = i + 1;
                    }
                    if (counterOfLetters > maxWord.Length)
                    {
                        maxWord = str.Substring(i + 1, counterOfLetters);
                        maxWordIndex = i + 1;
                    }
                    counterOfLetters = 0;
                }
                else
                {
                    counterOfLetters++;
                    letters++;
                }

                if (i == 0 && counterOfLetters != 0)
                {
                    if (counterOfLetters < minWord.Length)
                    {
                        minWord = str.Substring(i, counterOfLetters);
                        minWordIndex = i;
                    }
                    if (counterOfLetters > maxWord.Length)
                    {
                        maxWord = str.Substring(i, counterOfLetters);
                        maxWordIndex = i;
                    }
                }
            }
        }
    }
}
