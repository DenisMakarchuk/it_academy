using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class SecurityCheck
    {
        public static void Check()
        {
            SpeakHello.Hello();

            Console.WriteLine("Have you any liquid volume of more than 100 ml? (yes/no)");
            bool unswer1 = Console.ReadLine().ToUpper().Equals("YES") ? false : true;
            if (!unswer1)
            {
                Console.WriteLine("It can not be taken on board. Turn in the baggage?");
                bool unswer11 = Console.ReadLine().ToUpper().Equals("YES") ? true : false;
                if (!unswer11)
                {
                    Console.WriteLine("You can not fly");
                    return;
                }
            }

            Console.WriteLine("Have you something forbidden?");
            bool unswer2 = Console.ReadLine().ToUpper().Equals("YES") ? true : false;
            if (unswer2)
            {
                Console.WriteLine("You are detained!");
                return;
            }
            else
            {
                Console.WriteLine("Good flight!");
            }
        }
    }
}
