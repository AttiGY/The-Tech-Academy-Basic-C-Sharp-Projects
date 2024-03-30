using System;


namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message:
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

                // Check if weight exceeds maximum limit
                if (weight > 50)
                {
                // Display error message
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                 }

            Console.WriteLine("Please enter the package width:"); //displays instruction for user
            int width = Convert.ToInt32(Console.ReadLine()); //converts user input to integer and assigns it to width

            
            Console.WriteLine("Please enter the package height:"); //displays instruction for user
            int height = Convert.ToInt32(Console.ReadLine()); //converts user input to integer and assigns it to height


            Console.WriteLine("Please enter the package length:"); //displays instruction for user
            int length = Convert.ToInt32(Console.ReadLine()); //converts user input to integer and assigns it to lenght


            int dimensionsTotal = width + height + length; // calculates total dimensions

                    // checking dimension limit
                    if (dimensionsTotal > 50)
                    {
                        // Display error message
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        Console.ReadLine();
                    }

            float quote = (float)(width * height * length * weight) / 100; //calculates quote

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}
