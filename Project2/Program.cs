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
            Console.ReadLine();
        }
    }
}
