using System;

namespace EmployeeComparison
{
    // Create an Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // Check if one of the objects is null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id properties of the two Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to complement the "==" operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override the Equals method
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee emp = (Employee)obj;
            return Id == emp.Id;
        }

        // Override the GetHashCode method
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two objects of the Employee class and assign values to their properties
            Employee employee1 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded "==" operator
            bool areEqual = employee1 == employee2;

            // Display the results
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Prevent the console window from closing immediately
            Console.ReadLine();
        }
    }
}

