﻿using System;


namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints program name
            Console.WriteLine("Anonymous Income Comparison Program");

            //gets details of Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate:");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine()); // User input hourly rate
            Console.WriteLine("Enter hours worked per week:");
            double hoursWorkedPerWeek1 = Convert.ToDouble(Console.ReadLine()); // User input hours worked per week

            // Calculating annual salary of Person 1
            double annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52; // multiplying working hours by weeks in a year

            // gets details of Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate:");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine()); // User input hourly rate
            Console.WriteLine("Enter hours worked per week:");
            double hoursWorkedPerWeek2 = Convert.ToDouble(Console.ReadLine()); // User input hours worked per week

            // Calculate annual salary of Person 2
            double annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52; // multiplying working hours by weeks in a year

            // Printing annual salaries
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

            // Check if Person 1 makes more money than Person 2 and print the result
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Person 1 makes more money than Person 2: " + person1MakesMore);
            Console.ReadLine(); //keeps program running


        }
    }
}
