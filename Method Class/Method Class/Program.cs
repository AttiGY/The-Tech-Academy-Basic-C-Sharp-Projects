using System;


namespace Method_Class
{
    // Define a class named MathOperations
    public class MathOperations
    {
        // Define a method named PerformOperation that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer and display the second integer
            Console.WriteLine($"Multiplying the first integer ({num1}) with itself is: {num1 * num1}");
            Console.WriteLine($"Second integer is: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // Call the PerformOperation method in the class, passing in two numbers (3 and 7)
            math.PerformOperation(3, 7);

            // Call the PerformOperation method in the class, specifying the parameters by name
            math.PerformOperation(num1: 5, num2: 10);

            // Add a line to prompt the user to press any key before closing the console
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
