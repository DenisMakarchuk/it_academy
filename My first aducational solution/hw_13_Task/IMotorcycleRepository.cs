using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_13_Task
{
    interface IMotorcycleRepository
    {
        void CreateMotorcycle(Motorcycle moto);

        Motorcycle GetMotorcycleByID(int id);

        List<Motorcycle> GetMotorcycles();

        Motorcycle UpdateMotorcycle(Motorcycle moto);

        void DeleteMotorcycle(int id);
    }
}
