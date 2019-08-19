using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_13_UnoqueItem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start ID:");
            int startId = Convert.ToInt32(Console.ReadLine());

            UniqueItem[] arrId = NewTipes(startId);
            Console.WriteLine();
            GetArr(arrId);

            Console.Read();
        }

        static UniqueItem[] NewTipes(int startId)
        {
            UniqueItem[] arrId = new UniqueItem[10];

            arrId[0] = new UniqueItem(startId);

            int counterId = startId + 1;
            for (int i = 1; i < arrId.Length; i++)
            {
                arrId[i] = new UniqueItem(counterId);
                counterId += 1;
            }

            return arrId;
        }

        static void GetArr(UniqueItem[] arrId)
        {
            Console.WriteLine("The ID's of tipes are:");
            foreach (var item in arrId)
            {
                UniqueItem uniqueItem = item;
                int getId = uniqueItem.ItemId;
                Console.WriteLine(getId);
            }
        }
    }
}
