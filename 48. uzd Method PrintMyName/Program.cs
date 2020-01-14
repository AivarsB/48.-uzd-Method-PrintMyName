using System;

namespace _48._uzd_Method_PrintMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            Console.Write("Enter surname: ");
            var surname = Console.ReadLine();

            PrintMyName(name, surname);
        }

        static void PrintMyName(string name, string surname)
        {
            Console.WriteLine($"{name.Substring(0, 1)}. {surname}");
        }



    }
}
// Definēt metodi PrintMyName ar diviem string parametriem name un surname. Izsaucot metodi jāizdrukā teksts N. Surname; 
// Ievades parametrus metode var saņemt no lietotāja, vai tie var būt definēti iepriekš izmantojot mainīgos.