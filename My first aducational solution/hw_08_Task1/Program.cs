using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_08_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text, separate the lines with \";\"");
            string poem = Console.ReadLine();
            string[] poemArr = poem.Split(';');

            for (int i = 0; i < poemArr.Length; i++)
            {
                poemArr[i] = poemArr[i].Replace('o', 'a').Replace('O','A');
            }

            for (int i = 0; i < poemArr.Length; i++)
            {
                Console.WriteLine(poemArr[i]);
            }

            Console.Read();
        }
    }
}
