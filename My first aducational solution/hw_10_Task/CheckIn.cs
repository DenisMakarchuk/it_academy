using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class CheckIn : Initialisers
    {
        public static void Check()
        {
            SpeakHello.Hello();

            Initialisers.FullNameInitialiser();
            FullName fullName = new FullName(name, surname, patronymic);

            Initialisers.PassportInitialiser();
            Passport passport = new Passport(series, numPassport);

            Initialisers.FlightInitialiser();
            Flight flight = new Flight(country, date, weightBaggage);

            Console.WriteLine();

            Console.WriteLine("The information about your flight:");
            Console.WriteLine();

            fullName.FullNameToString();
            Console.WriteLine();

            passport.PassportToString();
            Console.WriteLine();

            flight.FlightInformationToString();
        }
    }
}
