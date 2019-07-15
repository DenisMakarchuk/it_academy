using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plus();
            Console.Read();
        }
        static void Plus()
        {
            double x, y, z;
            Console.WriteLine("Введите первое слагаемое");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            z = Convert.ToDouble(Console.ReadLine());
            if (z == x + y)
                Console.WriteLine("Правильно");
            else
            {
                Console.Write("Неправильно. ");
                if (z > x + y)
                    Console.WriteLine("Должно быть больше");
                else
                    Console.WriteLine("Должно быть меньше");
            }
        }
    }
}
