using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_07_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr01 = new int[8];
            int[] arr02 = new int[8];
            int[] arr03 = new int[8];

            Random ranNum = new Random();
            for (int i = 0; i < arr01.Length; i++)
            {
                arr01[i] = ranNum.Next(100);
            }
            for (int i = 0; i < arr02.Length; i++)
            {
                Console.WriteLine($"Enter the arr02[{i}] element");
                int HandNum = Convert.ToInt32(Console.ReadLine());
                arr02[i] = HandNum;
            }
            for (int i = 0; i < arr03.Length; i++)
            {
                arr03[i] = arr01[i] + arr02[i];
            }
            GetArr(arr01);
            GetArr(arr02);
            GetArr(arr03);
            Console.Read();
        }
        static void GetArr(int[] GetArr)
        {
            for (int i = 0; i < GetArr.Length; i++)
            {
                Console.Write($"{GetArr[i]}\t");
            }
            Console.WriteLine();
        }

    }
}
