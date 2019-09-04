using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_0_AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("In other class:");

            //Console.WriteLine(Employee.ConstPrivet); can't be used because is privet
            Console.WriteLine(Employee.ConstPublic);
            //Console.WriteLine(Employee.ConstProtected); can't be used because is protected
            Console.WriteLine(Employee.ConstInternal);
            Console.WriteLine(Employee.ConstProtectedInternal);
            //Console.WriteLine(Employee.ConstPrivetProtected); can't be used because is privet protected

            //Console.WriteLine(employee._fieldPrivet); can't be used because is privet
            Console.WriteLine(employee.fieldPublic);
            //Console.WriteLine(employee.fieldProtected); can't be used because is protected
            Console.WriteLine(employee.fieldInternal);
            Console.WriteLine(employee.fieldProtectedInternal);
            //Console.WriteLine(employee.fieldPrivetProtected); can't be used because is privet protected

            //Employee.MethodPrivet(); can't be used because is privet
            Employee.MethodPublic();
            //Employee.MethodProtected(); can't be used because is protected
            Employee.MethodInternal();
            Employee.MethodProtectedInternal();
            //Employee.MethodPrivetProtected(); can't be used because is privet protected

            Console.WriteLine();

            Developer developer = new Developer();
            developer.MethodInheritance();

            Console.WriteLine();

            employee.TheSameMethod();

            Console.Read();
        }
    }
    class Developer : Employee
    {
        public void MethodInheritance()
        {
            Console.WriteLine("In inheritanced class:");

            //Console.WriteLine(ConstPrivet); can't be used because is privet
            Console.WriteLine(ConstPublic);
            Console.WriteLine(ConstProtected);
            Console.WriteLine(ConstInternal);
            Console.WriteLine(ConstProtectedInternal);
            Console.WriteLine(ConstPrivetProtected);

            //Console.WriteLine(_fieldPrivet); can't be used because is privet
            Console.WriteLine(fieldPublic);
            Console.WriteLine(fieldInternal);
            Console.WriteLine(fieldProtectedInternal);
            Console.WriteLine(fieldPrivetProtected);

            //MethodPrivet(); can't be used because is privet
            MethodPublic();
            MethodProtected();
            MethodInternal();
            MethodProtectedInternal();
            MethodPrivetProtected();
        }
    }

}
