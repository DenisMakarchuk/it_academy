using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter where we are going? " +
                "\nUse W,S,A,D to go, " +
                "\nor Spase to stop, " +
                "\nor enything else to stay.");

            bool stopWord = false;

            while (stopWord == false)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Go up");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Do down");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Go left");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Go right");
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("We're not going anywhere else");
                        stopWord = true;
                        break;
                    default:
                        Console.WriteLine("We are not moving");
                        break;
                }
            }
            Console.Read();
        }
    }
}
