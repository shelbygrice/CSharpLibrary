using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student devan = new Student();
            devan.FirstName = "Devan";
            devan.LastName = "Peetz";
            devan.Age = 25;

            Student shelby = new Student("Shelby");

            Student charlesMichael = new Student("Charles", "Michael", 30, "Assassin");


            
        }
    }
}
