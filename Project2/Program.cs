using System;

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

            Console.ReadLine();

        }
    }
}
