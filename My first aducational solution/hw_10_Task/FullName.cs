using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class FullName
    {
        readonly string _name;
        readonly string _surname;
        readonly string _patronymic;
        public FullName(string name, string surname) { _name = name.ToUpper(); _surname = surname.ToUpper(); }
        public FullName(string name, string surname, string patronymic) { _name = name.ToUpper(); _surname = surname.ToUpper(); _patronymic = patronymic.ToUpper(); }
        public void FullNameToString()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Surename: {_surname}");
            if (!string.IsNullOrEmpty(_patronymic))
            {
                Console.WriteLine($"Patronymic: {_patronymic}");
            }
        }
    }
}
