using NeetCode.AdapterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.AdapterPattern
{
    public class SquareHole
    {
        private double sideLength;

        public SquareHole(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public bool canFit(Square square)
        {
            return this.sideLength >= square.getSideLength();
        }
    }
}
