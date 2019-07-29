using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check-in\n");
            CheckIn.Check();

            Console.WriteLine();

            Console.WriteLine("Security check\n");
            SecurityCheck.Check();

            Console.Read();
        }
    }
}
