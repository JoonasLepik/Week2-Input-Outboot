using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            //progamm küsib kajutaja nime
            //progamm tervitab kasutajat nimepidi
            Console.WriteLine("Mis su nimi on?");

            string UserName = Console.ReadLine();

            //Console.WriteLine("Hello, = +Username);

            //string interpolation

            // {}- altGr + 7 / altGr + 0
            Console.WriteLine($"Hello, {UserName}");


            Console.Read();
        }
    }
}
