using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.PrototypePattern
{
    public class Test
    {
        public List<IShape> CloneShapes(List<IShape> shapes)
        {
            List<IShape> clonedShapes = new List<IShape>();
            foreach (IShape shape in shapes)
            {
                clonedShapes.Add(shape.Clone());
            }
            return clonedShapes;
        }
    }
}
