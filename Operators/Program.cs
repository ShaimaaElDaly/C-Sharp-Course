using System;

namespace EmployeeEqualityApp2
{
    // Class representing an employee with identity and name details
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Override ToString() for better debug output
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id})";
        }

        // Overload '==', comparing employee Ids safely
        public static bool operator ==(Employee e1, Employee e2)
        {
            // Handle null comparisons
            if (ReferenceEquals(e1, e2)) return true;
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null)) return false;

            return e1.Id == e2.Id;
        }

        // Overload '!=' as required
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            return this == other;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate employees
            var emp1 = new Employee { Id = 200, FirstName = "Shaimaa", LastName = "ElDaly" };
            var emp2 = new Employee { Id = 200, FirstName = "Salma", LastName = "Ahmed" };

            // Output both employee data
            Console.WriteLine("Employee 1: " + emp1);
            Console.WriteLine("Employee 2: " + emp2);

            // Compare using ==
            Console.WriteLine("Are they equal? " + (emp1 == emp2));
        }
    }
}
