using System;

namespace Lab_6_Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 6 Parallel Arrays");
            string[] Names = { "Rich Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone ={"555-1334","555-3882","555-8211","555-1617","555-2803"};

           string strSearch;
            Console.WriteLine("Type a name to search for in the phone book:");
            strSearch = Console.ReadLine();

            for (int n = 0; n < Names.Length; n++)
            {
                if (Names[n].IndexOf(strSearch) > -1)
                {
                    Console.WriteLine(Names[n] + " ->" + Phone[n]);
                }
            }
            Console.ReadLine();

        }
    }
}
