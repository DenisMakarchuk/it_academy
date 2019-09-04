using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_13_Task
{
    class MotorcycleRepository : IMotorcycleRepository
    {
        public static List<Motorcycle> motorcycles = new List<Motorcycle>();
        private static int _idCounter = 1;

        public void CreateMotorcycle(Motorcycle moto)
        {
            moto.Id = _idCounter;
            _idCounter++;
            motorcycles.Add(moto);
        }

        public void DeleteMotorcycle(int id)
        {
            var existMoto = motorcycles.SingleOrDefault(item => item.Id == id);
            if (existMoto == null)
            {
                throw new NullReferenceException();
            }
            motorcycles.Remove(existMoto);
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            var moto = motorcycles.SingleOrDefault(item => item.Id == id);
            return moto == null ? null : (Motorcycle)moto;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return motorcycles
                .Select(item => (Motorcycle)item)
                .ToList();
        }

        public Motorcycle UpdateMotorcycle(Motorcycle moto)
        {
            var existMoto = motorcycles.SingleOrDefault(item => item.Id == moto.Id);
            if (existMoto == null)
            {
                throw new NullReferenceException();
            }

            existMoto.Name = moto.Name;
            existMoto.Model = moto.Model;

            return (Motorcycle)existMoto;
        }
    }
}
