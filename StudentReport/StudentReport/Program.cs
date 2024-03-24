using System;


namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing college name
            Console.WriteLine("Academy of Learning Career College");

            // Printing the header for the daily report
            Console.WriteLine("Student Daily Report");

            // Declaring variables to store student information
            string name;
            string course;
            int pageNumber;
            bool needHelp;
            string positiveExperiences;
            string feedback;
            int studyHours;

            // Asking and storeing student information
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();

            Console.WriteLine("What page number?");
            pageNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            needHelp = bool.Parse(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            studyHours = int.Parse(Console.ReadLine());

            // Printing closing message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
    }
}
