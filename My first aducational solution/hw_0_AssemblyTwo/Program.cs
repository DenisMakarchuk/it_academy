using System;
using hw_0_AssemblyOne;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_0_AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();

            Console.WriteLine("In other project:");

            //Console.WriteLine(Employee.ConstPrivet); can't be used because is privet
            Console.WriteLine(Employee.ConstPublic);
            //Console.WriteLine(Employee.ConstProtected); can't be used because is protected 
            //Console.WriteLine(Employee.ConstInternal); can't be used because is internal
            //Console.WriteLine(Employee.FileClass.ConstProtectedInternal); can't be used because is protected internal
            //Console.WriteLine(Employee.ConstPrivetProtected); can't be used because is privet protected

            //Console.WriteLine(employee._fieldPrivet); can't be used because is privet
            Console.WriteLine(employee.fieldPublic);
            //Console.WriteLine(employee.fieldProtected); can't be used because is protected
            //Console.WriteLine(employee.fieldInternal); can't be used because is internal
            //Console.WriteLine(employee.fieldProtectedInternal); can't be used because is protected internal
            //Console.WriteLine(employee.fieldPrivetProtected); can't be used because is privet protected

            //Employee.MethodPrivet(); can't be used because is privet
            Employee.MethodPublic();
            //Employee.MethodProtected(); can't be used because is protected
            //Employee.MethodInternal(); can't be used because is internal
            //Employee.MethodProtectedInternal(); can't be used because is protected internal
            //Employee.MethodPrivetProtected(); can't be used because is privet protected

            Console.Read();
        }
    }
}
