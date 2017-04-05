using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repl_Challenge_4_4_17
{
    class Octogon : IRegularPolygon
    {
        public int NumOfSides { get; set; }
        public int SideLength { get; set; }

        public Octogon(int sideLength)
        {
            this.NumOfSides = 8;
            this.SideLength = sideLength;
        }

        public double GetArea()
        {
           return SideLength * SideLength *(2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumOfSides * SideLength;
        }
    }
}
