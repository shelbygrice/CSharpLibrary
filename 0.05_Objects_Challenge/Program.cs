using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel resSmith = new Hotel();
            resSmith.RoomNumber = 228;
            resSmith.NumBeds = 2;
            resSmith.IsAvailable = true;

            Console.WriteLine("The Smith family is in room {0}", resSmith.RoomNumber);
            Console.ReadLine();

        }
    }
}
