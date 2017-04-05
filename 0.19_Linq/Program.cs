using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() { VIN = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009 },
                new UsedCar() { VIN = "B1", Make = "Hyundai", Model = "Accent", Price = 3000, Year = 2004 },
                new UsedCar() { VIN = "C3", Make = "Ford", Model = "Taurus", Price = 7000, Year = 2010 },
                new UsedCar() { VIN = "D4", Make = "Ford", Model = "Escape", Price = 15000, Year = 2014 },
                new UsedCar() { VIN = "E5", Make = "BMW", Model = "55i", Price = 15000, Year = 2015 },
                new UsedCar() { VIN = "E3", Make = "BMW", Model = "55i", Price = 9000, Year = 2002 },
                new UsedCar() { VIN = "C2", Make = "Toyota", Model = "4Runner", Price = 6500, Year = 2002 },
                new UsedCar() { VIN = "B4", Make = "Toyota", Model = "Camry", Price = 8700, Year = 2011 }
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                //Console.WriteLine("The {0} {1} {2} is a nice used car that costs {3:C}.", bmw.Year, bmw.Make, bmw.Model, bmw.Price); 
            }

            var prices = from car in usedCars
                         where car.Price < 10000
                         select car;
            foreach (var price in prices)
            {
                //Console.WriteLine("The {0} {1} is more affordable at {2:C}", price.Make, price.Model, price.Price);
            }
            //Console.WriteLine("");
            //Console.WriteLine("LINQ with Lambda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach (var toyota in toyotas)
            {
                //Console.WriteLine(toyota.Model);
            }

            var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Make == "BMW" || car.Make == "Ford");
            foreach (var niceUsedCar in niceUsedCars)
            {
                //    Console.WriteLine(niceUsedCar.Model);
                //}
                //Console.ReadLine();

                Console.WriteLine("What are you looking for in a car today?");
                var input = Console.ReadLine();
                Console.WriteLine("Please enter the amount you would like to spend:");
                int budget = Int32.Parse(Console.ReadLine());
                var shopCars = from car in usedCars
                               where
          car.VIN == input ||
          car.Make == input ||
          car.Model == input &&
          car.Price <= budget
                               select car;
                foreach (var shopCar in shopCars)
                {
                    Console.WriteLine("The {0} {1} {2} is affordable and within your parameters.", shopCar.Year, shopCar.Make, shopCar.Model);
                    Console.ReadLine();
                }

            }
        }

        class UsedCar
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
        }
    }
}
 