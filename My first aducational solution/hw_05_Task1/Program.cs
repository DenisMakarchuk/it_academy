using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter the person's year of born");
                int yearOfBorn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of the month when the person was born");
                int monthOfBorn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the actual year");
                int yearNow = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of actual month");
                int monthNow = Convert.ToInt32(Console.ReadLine());

                int yearsOld = yearNow - yearOfBorn - 1;

                if (yearsOld >= 0)
                {
                    int extraYear = monthNow - monthOfBorn;
                    if (extraYear >= 0)
                    {
                        Console.WriteLine($"The person have {++yearsOld} years old. " +
                            $"\nPress 'enter' to try again or another button + 'enter' to stop.");
                    }
                    else
                    {
                        Console.WriteLine($"The person have {yearsOld} years old. " +
                            $"\nPress 'enter' to try again or another button + 'enter' to stop.");
                    }
                }
                else
                {
                    Console.WriteLine("The person was born in the future!!! " +
                        "\nPress 'enter' to try again or another button + 'enter' to stop.");
                }
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Enter);

            Console.Read();
        }
    }
}
