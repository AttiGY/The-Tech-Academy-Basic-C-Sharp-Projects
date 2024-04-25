using System;


namespace Method_Class
{
    // Defining a class named MathOperations
    public class MathOperations
    {
        // Defining a method named PerformOperation that takes two integers as parameters
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
            // Instantiating the MathOperations class
            MathOperations math = new MathOperations();

            // Calling the PerformOperation method in the class, passing in two numbers (3 and 7)
            math.PerformOperation(3, 7);

            // Calling the PerformOperation method in the class, specifying the parameters by name
            math.PerformOperation(num1: 5, num2: 10);

            // Keeping console open until a key is pressed
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
