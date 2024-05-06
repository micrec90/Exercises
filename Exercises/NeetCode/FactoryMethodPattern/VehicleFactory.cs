using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.FactoryMethodPattern
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle createVehicle();
    }
}
