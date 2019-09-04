using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter the number of minutes");
                int minutes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the initial number of the bacteria");
                int bacteria = Convert.ToInt32(Console.ReadLine());

                if (minutes > 0)
                {
                    for (int i = 1; i <= minutes; i++)
                    {
                        bacteria *= 2;
                    }
                    Console.WriteLine($"Number of the bacteria = {bacteria}. " +
                        $"\nPress 'enter' to try again or another button + 'enter' to stop.");
                }
                else
                    Console.WriteLine($"Number of the bacteria = {bacteria}. " +
                        $"\n{minutes} minutes have passed." +
                        $"\nPress 'enter' to try again or another button + 'enter' to stop.");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Enter);

            Console.Read();
        }
    }
}
