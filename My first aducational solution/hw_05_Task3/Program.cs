using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter how much money are on the account");
                double startMoney = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number of months during which the money will be on the account");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the interest rate of the account in %");
                double interestRate = Convert.ToDouble(Console.ReadLine());

                double interestRateIncome = 0, totalSum = startMoney;

                if (startMoney < 0 || month < 0 || interestRate < 0)
                {
                    Console.WriteLine("Invalid data entered! " +
                        "\nPress 'enter' to try again or another button +'enter' to stop.");
                }
                else
                {
                    Console.WriteLine("Interest rate income by the month: ");
                    for (int i = 1; i <= month; i++)
                    {
                        interestRateIncome = totalSum * (interestRate / 100 / 12);
                        totalSum = totalSum + interestRateIncome;
                        Console.Write("{0: #.##}, ", interestRateIncome);
                    }
                    Console.WriteLine("\nThe total sum of the initial deposit, which was {2}, " +
                        "on the account whis the interest rate {3: #.##}% after {0} months = {1: #.##} " +
                        "\nPress 'enter' to try again or another button +'enter' to stop.", month, totalSum, startMoney, interestRate);
                }
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Enter);

            Console.Read();
        }
    }
}
