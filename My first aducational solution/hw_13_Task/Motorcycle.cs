using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_13_Task
{
    class Motorcycle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public Motorcycle(string name, string model, int year, int odometer)
        {
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
