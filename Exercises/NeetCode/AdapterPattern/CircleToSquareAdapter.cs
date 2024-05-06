using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.AdapterPattern
{
    public class CircleToSquareAdapter : Square
    {
        private Circle circle;
        public CircleToSquareAdapter(Circle circle)
        {
            this.circle = circle;
        }

        public override double getSideLength()
        {
            return 2 * circle.getRadius();
        }
    }
}
