using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.AdapterPattern
{
    public class Square
    {
        private double sideLength;

        public Square() { }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public virtual double getSideLength()
        {
            return this.sideLength;
        }
    }
}
