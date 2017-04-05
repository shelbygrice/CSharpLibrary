using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repl_Challenge_4_4_17
{
    abstract class AbstractRegularPolygon
    {
        public AbstractRegularPolygon(int numOfSides, int sideLength)
        {
            this.NumOfSides = numOfSides;
            this.SideLength = sideLength;
        }

        public int NumOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetPerimeter()
        {
            return NumOfSides * SideLength;
        }

        public abstract double GetArea();
    }
}
