using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.PrototypePattern
{
    public class Square : IShape
    {
        private int length;

        public Square(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public IShape Clone()
        {
            return new Square(length);
        }
    }
}
