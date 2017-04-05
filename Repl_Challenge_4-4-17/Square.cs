using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repl_Challenge_4_4_17
{
    class Square : Polygon
    {
        public Square(int sideLength) : base(4, sideLength)
        {
            this.SideLength = sideLength;
        }
        public double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
