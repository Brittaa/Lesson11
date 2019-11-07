using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAge();
            Console.ReadLine();

        }
        public static void GetAge()
        {
            
            int yearOfBirth;
            Console.WriteLine("Please enter you year of birth: ");
            try
            {
                yearOfBirth = int.Parse(Console.ReadLine());
                int userAge = 2019 - yearOfBirth;
                Console.WriteLine($"You are {userAge} years old.");
            }
            catch
            {
                Console.WriteLine("Invalid date format.");
                GetAge();  //Recurssion - funktsioon on funktsiooni sees.
            }

        }
    }
}
