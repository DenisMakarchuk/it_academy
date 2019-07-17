using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_07_Task2
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
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.WriteLine($"Enter the {i + 1} element of the array");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"The last element of the array = {arr[arr.GetUpperBound(0)]}");

                Console.WriteLine("Enter the element of the array");
                int addElement = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the position of the added element from 1 to {numArr}");
                int addPosition = Convert.ToInt32(Console.ReadLine());

                if (addPosition > 0 && addPosition <= numArr)
                {
                    for (int i = arr.Length - 1; i >= addPosition; i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                    arr[addPosition-1] = addElement;

                    foreach (var item in arr)
                    {
                        Console.Write($"{item}\t");
                    }
                }
                else
                {
                    Console.WriteLine($"The position of the added element must be less than {numArr}");
                }
            }
            Console.Read();
        }
    }
}
