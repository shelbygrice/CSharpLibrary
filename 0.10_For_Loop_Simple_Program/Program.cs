using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_For_Loop_Simple_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your starting number: ");
            int startingNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter your ending number: ");
            int endingNum = Int32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startingNum; i <= endingNum; i++)
            {
                sum += i;
                
            }
            Console.WriteLine("The sum of all numbers between {0} and {1} is {2}.", startingNum, endingNum, sum);
            Console.ReadLine();
        }
    }
}
