using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance");

            
            Console.WriteLine("What is your age?"); //Writes question to console
            int age = Convert.ToInt32(Console.ReadLine()); // Get age from user

            Console.WriteLine("Have you ever had a DUI? (yes/no)"); //Writes question to console
            string response = Console.ReadLine().ToLower(); // Get DUI status from user and convert to lowercase
            bool dui = response == "yes";

            Console.WriteLine("How many speeding tickets do you have?"); //Writes question to console
            int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Get number of tickets from user

            // Checks qualification for insurance based on qualification rules
            bool qualification = (age > 15) && !dui && (speedingTickets <= 3);
            Console.WriteLine(qualification);
            Console.ReadLine();
        }
    }
}
