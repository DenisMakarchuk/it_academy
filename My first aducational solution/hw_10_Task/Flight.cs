using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class Flight
    {
        readonly string _country;
        readonly DateTime _date;
        readonly int _weightBaggage;
        int time = new Random().Next(0, 24);

        public Flight(string country, DateTime date, int weightBaggage) { _country = country.ToUpper(); _date = date; _weightBaggage = weightBaggage; }

        public void FlightInformationToString()
        {
            int baggage = _weightBaggage / 35;
            int extraWeight = _weightBaggage % 35 / 10;
            int handBaggage = _weightBaggage % 35 % 10;

            if (extraWeight != 0 && extraWeight + handBaggage <= 35)
            {
                extraWeight += handBaggage;
                handBaggage = 0;
            }

            if (extraWeight != 0)
            {
                baggage++;
            }

            if (DateTime.Now.Hour >= time)
            {
                time = (DateTime.Now.Hour + 1) % 24;
            }

            Console.WriteLine($"Departure: {_date.ToShortDateString()} at {time} o'clock");
            Console.WriteLine($"Your baggage: {baggage}. \nYour hand baggage: {handBaggage} kilo");
            Console.WriteLine($"The destination country: {_country}");
            Console.WriteLine($"Your extrapay fo the baggage: {baggage * 35}$");
        }
    }
}
