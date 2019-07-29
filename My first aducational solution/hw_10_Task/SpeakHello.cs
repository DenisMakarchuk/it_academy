using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class SpeakHello
    {
        public static void Hello()
        {
            var time = DateTime.Now.Hour;
            bool isTrueTime = true;

            switch (isTrueTime)
            {
                case true when (time >= 6 && time < 12):
                    Console.WriteLine("Good morning");
                    break;
                case true when (time >= 12 && time < 18):
                    Console.WriteLine("Good day");
                    break;
                case true when (time >= 18 && time <= 23):
                    Console.WriteLine("Good evening");
                    break;
                case true when (time >= 0 && time < 6):
                    Console.WriteLine("Good night");
                    break;
            }
        }
    }
}
