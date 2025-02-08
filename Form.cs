using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.WriteLine("Please enter the package weight:");
        decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

        // Check if the weight is greater than 50
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Prompt for package width
            Console.WriteLine("Please enter the package width:");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            // Prompt for package height
            Console.WriteLine("Please enter the package height:");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            // Prompt for package length
            Console.WriteLine("Please enter the package length:");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            // Check if the dimensions total greater than 50
            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                // Calculate the quote
                decimal packageVolume = packageWidth * packageHeight * packageLength;
                decimal quote = (packageVolume * packageWeight) / 100;

                // Display the quote as a dollar amount
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                Console.WriteLine("Thank you!");
            }
        }

        // Prevent the console window from closing immediately
        Console.ReadLine();
    }
}
