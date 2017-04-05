using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repl_Challenge_4_4_17
{
    class Triangle : AbstractRegularPolygon
    {
        public Triangle(int sideLength) : base(3, sideLength)
        {
        }

        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
