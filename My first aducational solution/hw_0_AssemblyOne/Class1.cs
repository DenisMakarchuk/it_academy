using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_0_AssemblyOne
{
    public class Employee
    {
        const string ConstPrivet = "ConstPrivet";
        public const string ConstPublic = "ConstPublic";
        protected const string ConstProtected = "ConstProtected";
        internal const string ConstInternal = "ConstInternal";
        protected internal const string ConstProtectedInternal = "ConstProtectedInternal";
        private protected const string ConstPrivetProtected = "ConstPrivetProtected";

        string _fieldPrivet = "_fieldPrivet";
        public string fieldPublic = "fieldPublic";
        protected string fieldProtected = "fieldProtected";
        internal string fieldInternal = "fieldInternal";
        protected internal string fieldProtectedInternal = "fieldProtectedInternal";
        private protected string fieldPrivetProtected = "fieldPrivetProtected";

        static void MethodPrivet()
        {
            Console.WriteLine("MethodPrivet");
        }
        public static void MethodPublic()
        {
            Console.WriteLine("MethodPublic");
        }
        protected static void MethodProtected()
        {
            Console.WriteLine("MethodProtected");
        }
        internal static void MethodInternal()
        {
            Console.WriteLine("MethodInternal");
        }
        protected internal static void MethodProtectedInternal()
        {
            Console.WriteLine("MethodProtectedInternal");
        }
        private protected static void MethodPrivetProtected()
        {
            Console.WriteLine("MethodPrivetProtected");
        }
        public void TheSameMethod()
        {
            Console.WriteLine("In the same method:");

            Console.WriteLine(ConstPrivet);
            Console.WriteLine(ConstPublic);
            Console.WriteLine(ConstProtected);
            Console.WriteLine(ConstInternal);
            Console.WriteLine(ConstProtectedInternal);
            Console.WriteLine(ConstPrivetProtected);

            Console.WriteLine(_fieldPrivet);
            Console.WriteLine(fieldPublic);
            Console.WriteLine(fieldProtected);
            Console.WriteLine(fieldInternal);
            Console.WriteLine(fieldProtectedInternal);
            Console.WriteLine(fieldPrivetProtected);

            MethodPrivet();
            MethodPublic();
            MethodProtected();
            MethodInternal();
            MethodProtectedInternal();
            MethodPrivetProtected();
        }
    }
}
