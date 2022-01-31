using System;
using System.Linq;
using System.Collections.Generic;
class Program
{

    static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Audi", "Skoda",
                       "Toyota", "Ford", "Mercedes","Seat", "Honda",
                       "Volkswagen","Opel", "Mazda","Suzuki" };


        void Lab1a()
        {
            var findCar = cars.FirstOrDefault(car => car.Equals("Opel", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(findCar);
        }

        void Lab1b()
        {
            var result = cars.Where(car => car.StartsWith("V", StringComparison.OrdinalIgnoreCase));

            foreach (var carsWithLetterV in result)
            {
                Console.WriteLine(carsWithLetterV);
            }
        }

        void Lab1c()
        {
            var result = cars.Where(car => car.ToLower().Contains("da", StringComparison.OrdinalIgnoreCase));

            foreach (var carsWithLetter_da in result)
            {
                Console.WriteLine(carsWithLetter_da);
            }
        }

        void Lab1d()
        {
            var result = cars.Where(car => car.StartsWith("M") || car.ToLower().EndsWith("i"));

            foreach (var carsWithLetter_M_i in result)
            {
                Console.WriteLine(carsWithLetter_M_i);
            }
        }

        void PrintCar()
        {
            Lab1a();
            Console.WriteLine("");
            Lab1b();
            Console.WriteLine("");
            Lab1c();
            Console.WriteLine("");
            Lab1d();
        }

        //PrintCar();

        string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", 
            "Megadeth", "Metallica", "Pearl Jam", 
            "Oasis", "Abba", "Blur", "Eurythmics", 
            "Genesis", "INXS", "Midnight Oil", "Kent", 
            "Madness", "Manic Street Preachers", "The Offspring", 
            "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple", "U2" };

        void Lab2a()
        {
            var result = bands.OrderByDescending(b => b.Length).FirstOrDefault();
            Console.WriteLine(result);
        }

        void Lab2b()
        {
            var result = bands.OrderBy(b => b.Length).FirstOrDefault();
            Console.WriteLine(result);
        }

        void Lab2c()
        {
            var result = bands.Where(b => b.StartsWith("M")).Count();

            Console.WriteLine(result);
        }

        void Lab2d()
        {
            var result = bands.Where(bands => bands.Length > 6).OrderBy(bands => bands);

            foreach (var totalBand in result)
            {
                Console.WriteLine(totalBand);
                
            }
        }

        void Lab2e()
        {
            var result = bands.OrderBy(bands => bands.Length);
            
            foreach (var band in result)
            {
                Console.WriteLine(band);
            }
                
        }

        void PrintBand()
        {
            //Lab2a();
            //Lab2b();
            //Lab2c();
            //Lab2d();
            Lab2e();

        }

        PrintBand();


    }
 
}


        







