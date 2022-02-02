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


        void Lab1a() // a. Ta fram den bil som heter ”Opel” från arrayen. 
        {
            var findCar = cars.FirstOrDefault(car => car.Equals("Opel", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(findCar);
        }

        void Lab1b() // b. Ta fram alla bilar vars namn börjar på ”V”.
        {
            var result = cars.Where(car => car.StartsWith("V", StringComparison.OrdinalIgnoreCase));

            foreach (var carsWithLetterV in result)
            {
                Console.WriteLine(carsWithLetterV);
            }
        }

        void Lab1c() // c. Ta fram alla bilar vars namn innehåller bokstäverna ”da”.
        {
            var result = cars.Where(car => car.ToLower().Contains("da", StringComparison.OrdinalIgnoreCase));

            foreach (var carsWithLetter_da in result)
            {
                Console.WriteLine(carsWithLetter_da);
            }
        }

        void Lab1d() // d. Ta fram alla bilar som börjar på ”M” eller som slutar på ”i”.
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

        void Lab2a() // a. Ta fram det band som har längst bandnamn
        {
            var result = bands.OrderByDescending(b => b.Length).FirstOrDefault();
            Console.WriteLine(result);
        }

        void Lab2b() // b. Ta fram det band som har kortast bandnamn
        {
            var result = bands.OrderBy(b => b.Length).FirstOrDefault();
            Console.WriteLine(result);
        }

        void Lab2c() // c. Ta fram en siffra på hur många band som börjar på bokstaven ”M”
        {
            var result = bands.Where(b => b.StartsWith("M")).Count();

            Console.WriteLine(result);
        }

        void Lab2d()  /* d. Ta ut en lista på alla band sorterad i bokstavsordning.
                      Visa bara band som har ett bandnamn som är längre än 6 bokstäver.*/
        {
            var result = bands.Where(bands => bands.Length > 6).OrderBy(bands => bands);

            foreach (var totalBand in result)
            {
                Console.WriteLine(totalBand);

            }
        }

        void Lab2e() /* e. Skapa en lista som sorteras på längden på banden namn. 
                      Det band med kortast namn skall hamna först i listan och det med längst namn skall hamna sist */
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

        //PrintBand();

        List<int> numbers = new List<int>() { 54, 23, 76, 123, 93, 7, 3489, 88 };

        void Lab3a() // a. Ta fram medelvärdet av alla tal utan att loopa igenom listan.
        {
            var avgNum = numbers.Average();
            Console.WriteLine(avgNum);
        }

        void Lab3b() // b. Ta fram det största av alla tal utan att loopa igenom listan.
        {
            var maxNum = numbers.Max();
            Console.WriteLine(maxNum);
        }

        void Lab3c() // c. Ta fram det minsta av alla tal utan att loopa igenom listan.
        {
            var minNum = numbers.Min();
            Console.WriteLine(minNum);
        }

        void Lab3d() // d. Beräkna summan av alla tal.
        {
            var totalNum = numbers.Sum();
            Console.WriteLine(totalNum);
        }

        void Lab3e() // e. Ta fram alla jämna tal utan att loopa igenom listan
        {
            var result = numbers.Where(num => num % 2 == 0);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        void RunNum()
        {
            //La3a();
            //La3b();
            //Lab3c();
            //Lab3d();
            Lab3e();
        }

        //RunNum();

        void RunNameList() /*  4. Order by
                            Sortera på efternamn (sista split ‘ ‘) utan att använda någon loop
                            string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom" }; */
        {
            string[] nameList = { "Karl Folkesson", "Sven Karlsson", "Greta Blom" };
            var result = nameList.OrderBy(name => name.Substring(name.IndexOf(' ')));
            
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        //RunNameList(); 

        void NewListOfNum() /* NY LISTA
                            Skapa en ny lista från denna array där alla värden ökats med 2 dvs nya listan blir 3,5,7,9
                            int[] lista = { 1, 3, 5, 7 }; */

        {
            int[] lista = { 1, 3, 5, 7 };
            var lista2 = lista.Select(numLista => numLista + 2).ToList();

            foreach (var num in lista2)
            {
                Console.WriteLine(num);
            }
        }

        //NewListOfNum();

        void Vokaler() /* 6. VOKALER 
                            Skapa en lista med alla vokaler ur meningen
                            string fullText= "Flygande beckasiner söka whila på mjuka tufvor" */
        {
            char[] vowels = { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

            string fullText = "Flygande beckasiner söka whila på mjuka tufvor";
            var listOfVowels = fullText.ToLower().Where(text => vowels.Contains(text)).ToList();
            
            foreach (var vowel in listOfVowels)
            {
                Console.WriteLine(vowel);
            }
            
        
        }

        Vokaler();
        

    }

}










