using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_02_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //implicit conversion examples
                byte i = 3;
                short x = i;
                int y = x;
                long z = y;
            }
            {
                //explicit conversion examples
                sbyte i = 3;
                ushort x = (ushort)i;
                double y = (double)x;
                decimal z = (decimal)y;
            }
            {
                //packing example
                int i = 3;
                object x = i;
                //unpacking example
                int y = (int)x;
            }
            Console.Read();
        }
    }
}
