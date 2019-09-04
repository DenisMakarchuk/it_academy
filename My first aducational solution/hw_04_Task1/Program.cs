using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLetter = 65;
            int counter = 0;

            for (int lustLetter = 90; lustLetter >= firstLetter; lustLetter--)
            {
                char letter = (char)lustLetter;
                Console.Write($"{letter} \t");

                ++counter;
                if (counter % 10 == 0)
                    Console.WriteLine();
            }
            Console.Read();
        }
    }
}
