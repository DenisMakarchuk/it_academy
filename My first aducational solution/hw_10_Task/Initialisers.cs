using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class Initialisers
    {
        internal static string name, surname, patronymic;
        public static void FullNameInitialiser()
        {
            do
            {
                Console.WriteLine("Enter the name without numbers and spaces");
                name = Console.ReadLine();
            }
            while (IsLellers.LettersTrue(name) != true);

            do
            {
                Console.WriteLine("Enter the surname without numbers and spaces");
                surname = Console.ReadLine();
            }
            while (IsLellers.LettersTrue(surname) != true);

            do
            {
                Console.WriteLine("Enter the patronymic without numbers and spaces or press 'enter' if you have no patronymic");
                patronymic = Console.ReadLine();
            }
            while (IsLellers.LerrerPatronymic(patronymic) != true);
        }

        internal static string series;
        internal static int numPassport = 0;
        public static void PassportInitialiser()
        {
            do
            {
                Console.WriteLine("Enter the series of the passport");
                series = Console.ReadLine();
            }
            while (IsLellers.LettersTrue(series) != true && series.Length != 2);

            do
            {
                try
                {
                    Console.WriteLine("Enter the number of the passport");
                    numPassport = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException) { }
                if (Convert.ToString(numPassport).Length == 8)
                    break;
            }
            while (true);
        }

        internal static int weightBaggage = -1;
        internal static string country;
        internal static DateTime date = new DateTime();
        public static void FlightInitialiser()
        {
            do
            {
                Console.WriteLine("Enter destination country");
                country = Console.ReadLine();
            }
            while (IsLellers.LettersTrue(country) != true);
            do
            {
                try
                {
                    Console.WriteLine("Enter departure time dd.mm.yyyy");
                    date = Convert.ToDateTime(Console.ReadLine());
                }
                catch (System.FormatException) { }
                if (date != new DateTime() && date >= DateTime.Now)
                    break;
            }
            while (true);
            do
            {
                try
                {
                    Console.WriteLine("Enter baggage weight");
                    weightBaggage = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException) { }
                if (weightBaggage >= 0)
                    break;
            }
            while (true);
        }
    }
}
