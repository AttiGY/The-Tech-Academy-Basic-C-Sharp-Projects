using System;


namespace ConsoleApp_MathOperator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a number:");
            double input1 = Convert.ToDouble(Console.ReadLine()); // Takes user input
            double result1 = input1 * 50; // Multiplies input by 50
            Console.WriteLine("Result after multiplying by 50: " + result1); // Prints result

            
            Console.WriteLine("Enter a number:");
            double input2 = Convert.ToDouble(Console.ReadLine()); // Takes user input
            double result2 = input2 + 25; // Adds 25 to input
            Console.WriteLine("Result after adding 25: " + result2); // Prints result

            
            Console.WriteLine("Enter a number:");
            double input3 = Convert.ToDouble(Console.ReadLine()); // Takes user input
            double result3 = input3 / 12.5; // Divides input by 12.5
            Console.WriteLine("Result after dividing by 12.5: " + result3); // Print result

            
            Console.WriteLine("Enter a number:");
            double input4 = Convert.ToDouble(Console.ReadLine()); // Takes user input
            bool result4 = input4 > 50; // Checks if input is greater than 50
            Console.WriteLine("Is the number greater than 50? " + result4); // Prints result

            
            Console.WriteLine("Enter a number:");
            double input5 = Convert.ToDouble(Console.ReadLine()); // Takes user input
            double remainder = input5 % 7; // Gets remainder after dividing input by 7
            Console.WriteLine("Remainder after dividing by 7: " + remainder); // Prints remainder
        }
    }
}
