using System;
using System.Collections.Generic;
using System.Linq;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Age in seconds
            var start = new DateTime(1991, 5, 22);
            var end = DateTime.Now;
            var age = end - start;
            Console.WriteLine(age.TotalSeconds);*/

            Console.WriteLine("Name three colors: ");
            string userInput = Console.ReadLine();

            string[] colors = userInput.Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> colorList = colors.ToList();
            foreach (string color in colorList)
            {
                    Console.WriteLine(color);
            }

            colorList.Add("pink");
            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("Do you want add or remove color?");
            string userChoice = Console.ReadLine();
            if(userChoice.ToLower() == "add")
            {
                Console.WriteLine("Enter a color to add:");
                string userAnswer = Console.ReadLine();
                colorList.Add(userAnswer);
            }
            else if (userChoice.ToLower() == "remove")
            {
                Console.WriteLine("Enter a color to remove:");
                string userAnswer = Console.ReadLine();
                colorList.Remove(userAnswer);
            }
            else
            {
                Console.WriteLine("Unknow Command.");
            }

            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }

        }
    }
}
