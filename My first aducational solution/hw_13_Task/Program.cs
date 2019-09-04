using System;
using log4net;
using log4net.Config;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_13_Task
{
    class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Logger.InitLogger();

            MotorcycleRepository motorcycleRepository = new MotorcycleRepository();

            Motorcycle motorcycle = new Motorcycle("Honda", "CB", 2014, 23);

            Logger.Log.Info("CRUD operations started!");
            motorcycleRepository.CreateMotorcycle(motorcycle);

            Motorcycle moto = motorcycleRepository.GetMotorcycleByID(1);

            Logger.Log.Info("Start of console output");
            Console.WriteLine($"The name of the motorcycle: {moto.Name}\n" +
                $"The model of motorcycle: {moto.Model}\n" +
                $"The year of issure: {moto.Year}\n" +
                $"The odometer of the motorcycle: {moto.Odometer}");

            Console.Read();
            Logger.Log.Info("Program completed successfully");
        }
    }
}
