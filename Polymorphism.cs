using System;

// Define an interface called IQuittable
public interface IQuittable
{
    // Define a void method called Quit()
    void Quit();
}

// Create an Employee class that inherits from the IQuittable interface
public class Employee : IQuittable
{
    // Implement the Quit() method in the Employee class
    public void Quit()
    {
        Console.WriteLine("Employee has quit the job.");
    }
}

class Program
{
    // Main method - the entry point of the console app
    static void Main(string[] args)
    {
        // Use polymorphism to create an object of type IQuittable
        IQuittable employee = new Employee();

        // Call the Quit() method on the IQuittable object
        employee.Quit();

        // Prevent the console window from closing immediately
        Console.ReadLine();
    }
}



