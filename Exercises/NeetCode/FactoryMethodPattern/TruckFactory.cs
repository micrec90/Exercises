using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.FactoryMethodPattern
{
    public class TruckFactory : VehicleFactory
    {
        public override IVehicle createVehicle()
        {
            return new Truck();
        }
    }
}
