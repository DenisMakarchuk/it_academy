using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathChecked();
            Console.Read();
        }
        static void MathChecked()
        {
            double x, y, z, op;
            string str;
            Console.WriteLine("Введите первое число");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите + или -");
            str = Convert.ToString(Console.ReadLine());
            if (str == "+" || str == "-") //Checks what was enter: + or -. Returns from the method if there was anything else
            {
                if (str == "+")
                    op = x + y;
                else
                    op = x - y;
            }
            else
            {
                Console.WriteLine("Введён неправильный оператор");
                return;
            }
            Console.WriteLine("Введите ответ");
            z = Convert.ToDouble(Console.ReadLine());
            if (z == op) //Checks the answer
                Console.WriteLine("Правильно");
            else
            {
                Console.Write("Неправильно. ");
                if (z > op)
                    Console.WriteLine("Должно быть больше");
                else
                    Console.WriteLine("Должно быть меньше");
            }
        }
    }
}
