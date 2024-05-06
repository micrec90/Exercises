using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.FactoryMethodPattern
{
    public class Car : IVehicle
    {
        public string getType()
        {
            return "Car";
        }
    }
}
