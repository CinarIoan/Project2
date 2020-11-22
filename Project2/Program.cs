using System;
using System.IO;
using System.Net;
using ScrapeLibrary;
namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nume: ");
            string nume = Console.ReadLine();
            nume = nume.ToUpper();
            Console.Write("prenume: ");
            string prenume = Console.ReadLine().ToUpperInvariant();
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first Console Project in Ubuntu");
            Console.WriteLine($"This is {nume} {prenume}");
            
            //some changes
            //some other changes

            string[] uniiRade = new string[]{
                "Ioan",
                "Adrian",
                "Raul",
                "Serban"
            };

            foreach(string name in uniiRade){
                Console.WriteLine(name);
            }

            string zig="You have mo make a decision!";
            char[] charZig = zig.ToCharArray();
            Array.Reverse(charZig);
            foreach(char cZig in charZig)
            {
                Console.Write(cZig);
            }

            string myString = String.Format("\n{0} = {1}", "First", "Second");
            Console.WriteLine(myString);
            string myString2 = string.Format("\n{0:C}", 123.45);
            Console.WriteLine(myString2);
            string myString3 = string.Format("Percentage: {0:P}", .123);
            Console.WriteLine(myString3);
            string myString4 = string.Format("Phone Number: {0:(0###) ### ###}", 0721234567);
            Console.WriteLine(myString4);

            //myString.Substring(2,10);
            //myString.ToUpper();
            //myString.Replace(" ", "--");
            //myString.Remove(6,14);


            DateTime myDateTime = DateTime.Now;
            Console.WriteLine(myDateTime.ToString());
            Console.WriteLine(myDateTime.ToShortDateString());
            Console.WriteLine(myDateTime.ToShortTimeString());
            Console.WriteLine(myDateTime.ToLongDateString());
            Console.WriteLine(myDateTime.ToLongTimeString());
            Console.WriteLine(myDateTime.AddDays(3).ToLongDateString());

            DateTime myBirthday = DateTime.Parse("1/31/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Car audi = new Car();
            //audi.Make = "Audi";
            audi.Model = "A3";
            audi.Year = 2006;
            audi.Color = "Dark-Grey";
            
            Console.WriteLine("Car:\n{0}\n{1}\n{2}\n{3}",
                audi.Make,
                audi.Model,
                audi.Year,
                audi.Color);

            // Car Value Methid Calling
            decimal valueOfCar = DetermieMarketValue(audi);
            Console.WriteLine("The value of {0} is {1:C}",audi.Make, valueOfCar);
            decimal audiValue = audi.DetermineCarValue();
            Console.WriteLine("{0:C}", audiValue);

            Car anotherAudi;
            anotherAudi = audi;

            Console.WriteLine("The {0} is sane as {1}", audi.Make, anotherAudi.Make);

            //anotherAudi = null; // We don't assign any space memory.
            // To prove, we try no print this again.
            // Console.WriteLine("The {0} is sane as {1}", audi.Make, anotherAudi.Make);
            // Apare aceasta eroare daca incercam sa accesam obiectul.
            /*
                Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
                at Project2.Program.Main(String[] args) in /home/cinar/Desktop/C#Projects/Project2/Program.cs:line 92
            */

            Car myThirdCar = new Car("BMW", "X5", 2008, "Blue");
            Console.WriteLine(myThirdCar.Make);
            Car.StaticMethod();
            audi.PrintHelloAuto();


            // From ScrapeLibrary by using ScrapeLibrary;

            Scrape scrape = new Scrape();
            string value = scrape.ScrapeWebpage("http://microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();

        }
        // Some classes
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            // Constructor
            public Car()
            {
                Console.WriteLine("This is a construcor and we will assing an automatic name for the car.");
                Make = "Nissan";
            }

            // Overloading constructor

            public Car(string make, string model, int year, string color)
            {
                Make = make;
                Model = model;
                Year = year;
                Color = color;
            }

            public void PrintHelloAuto()
            {
                Printing();
            }

            private void Printing()
            {
                Console.WriteLine("Hello {0} owner!", Make);
            }
            public decimal DetermineCarValue()
            {
                decimal carVal;
                if(Year>2000)
                    carVal = 10000;
                else carVal = 2000;
                return carVal;
            }

            // Static Method. (Allows us to call it without making an instance of the class.)
            public static void StaticMethod()
            {
                Console.WriteLine("This is just a static Method called.");
            }
        
        
        }
        private static decimal DetermieMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue;
        }



        

    }
}
