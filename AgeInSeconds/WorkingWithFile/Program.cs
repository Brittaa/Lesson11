using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/Britta/Demo/Demo.rtf"; // faili adressi saad kui lohistad kausta terminali, siis kuvab asukoha.
            //Read file content
            List<string> lines = File.ReadAllLines(path).ToList();


            foreach(string line in lines)
            {
                Console.WriteLine($"{line} is on the list");
            }

            Console.WriteLine("Lets add an item.");
            string userItem = Console.ReadLine();

            lines.Add(userItem);

            File.WriteAllLines(path, lines);
            List<string> lines1 = File.ReadAllLines(path).ToList();

            foreach (string line in lines1)
            {
                Console.WriteLine($"{line} is on the list");
            }
            //ei saanud hetkel veel tööle macil.
        }
    }
}
