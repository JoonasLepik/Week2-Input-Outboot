using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kajutaja eesnime
            //Programm Küsib kajutaja perekonna nime
            //Programm tervitab kasutajat, kasutades nid andmeid
            Console.WriteLine("Mis on sinu ees nimi?");
            string UserName = Console.ReadLine();
            Console.WriteLine("Mis su perekonna nimi on?");
            string LasName = Console.ReadLine();
            Console.WriteLine($"Hello, {UserName} {LasName}");
            Console.ReadLine();
        }
    }
}
