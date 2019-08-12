using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class Passport
    {
        readonly string _series;
        readonly int _numPassport;

        public Passport(string series, int numpass) { _series = series.ToUpper(); _numPassport = numpass; }

        public void PassportToString()
        {
            Console.WriteLine("Passport information:");
            Console.WriteLine($"series: {_series} \t number of the passport: {_numPassport}");
        }
    }
}
