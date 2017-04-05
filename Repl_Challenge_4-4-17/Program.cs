using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repl_Challenge_4_4_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            DisplayPolygon("Square", square);
            Triangle triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);
            

            Console.Read();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine("{0} Number of Sides: {1}", polygonType, polygon.NumOfSides);
                Console.WriteLine("{0} Side Length: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown while trying to process {0}:\n {1}", polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}
