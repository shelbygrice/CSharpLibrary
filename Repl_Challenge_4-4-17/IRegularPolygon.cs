using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repl_Challenge_4_4_17
{
    public interface IRegularPolygon
    {
        int NumOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();

        double GetArea();
    }
}
