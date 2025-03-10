using System;

// Define a namespace for the program
namespace PackageExpress
{
    // Create a class called "MathOperations"
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., add 10 to num1)
            int result = num1 + 10;

            // Display the second integer to the screen
            Console.WriteLine("The second integer is: " + num2);
        }
    }

    class Program
    {
        // Main method - the entry point of the console app
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOps.PerformOperation(5, 15);

            // Call the method in the class, specifying the parameters by name
            mathOps.PerformOperation(num1: 20, num2: 25);

            // Prevent the console window from closing immediately
            Console.ReadLine();
        }
    }
}

