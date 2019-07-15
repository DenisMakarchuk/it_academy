using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_02_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb1 = 3;
            SByte sb2 = 3;
            Console.WriteLine(sb1.GetType());
            Console.WriteLine(sb2.GetType());

            byte b1 = 3;
            Byte b2 = 3;
            Console.WriteLine(b1.GetType());
            Console.WriteLine(b2.GetType());

            short s1 = 3;
            Int16 s2 = 3;
            Console.WriteLine(s1.GetType());
            Console.WriteLine(s2.GetType());

            ushort us1 = 3;
            UInt16 us2 = 3;
            Console.WriteLine(us1.GetType());
            Console.WriteLine(us2.GetType());

            int i1 = 3;
            Int32 i2 = 3;
            Console.WriteLine(i1.GetType());
            Console.WriteLine(i2.GetType());

            uint ui1 = 3;
            UInt32 ui2 = 3;
            Console.WriteLine(ui1.GetType());
            Console.WriteLine(ui2.GetType());

            long l1 = 3;
            Int64 l2 = 3;
            Console.WriteLine(l1.GetType());
            Console.WriteLine(l2.GetType());

            ulong ul1 = 3;
            UInt64 ul2 = 3;
            Console.WriteLine(ul1.GetType());
            Console.WriteLine(ul2.GetType());

            float f1 = 3.0f;
            Single f2 = 3.0f;
            Console.WriteLine(f1.GetType());
            Console.WriteLine(f2.GetType());

            double d1 = 3.0d;
            Double d2 = 3.0d;
            Console.WriteLine(d1.GetType());
            Console.WriteLine(d2.GetType());

            decimal dl1 = 3.0m;
            Decimal dl2 = 3.0m;
            Console.WriteLine(dl1.GetType());
            Console.WriteLine(dl2.GetType());

            char ch1 = 'A';
            Char ch2 = 'B';
            Console.WriteLine(ch1.GetType());
            Console.WriteLine(ch2.GetType());

            string st1 = "str";
            String st2 = "str";
            Console.WriteLine(st1.GetType());
            Console.WriteLine(st2.GetType());

            object o1 = 3;
            Object o2 = 3;
            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.Read();
        }
    }
}
