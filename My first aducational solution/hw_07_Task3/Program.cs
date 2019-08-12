using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_07_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements greater than 1");
            int numArr = Convert.ToInt32(Console.ReadLine());

            if (numArr <= 1)
            {
                Console.WriteLine("The number of array elements must be greater than 1");
            }
            else
            {
                int[] arr = new int[numArr];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Enter the {i + 1} element of the array");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (var item in arr)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
                Console.WriteLine("The array in the opposite direction:");

                int j = arr.Length, tempNum = 0;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    tempNum = arr[i];
                    arr[i] = arr[--j];
                    arr[j] = tempNum;
                }
                foreach (var item in arr)
                {
                    Console.Write($"{item}\t");
                }
            }
            Console.Read();
        }
    }
}
