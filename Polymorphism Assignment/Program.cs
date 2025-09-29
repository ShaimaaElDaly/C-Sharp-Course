using System;

namespace QuittableApp2
{
    // Interface definition with a Quit method
    public interface IQuittable
    {
        void Quit(); // Contract for quitting
    }

    // Employee class that implements the IQuittable interface
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        // Quit method logs quit time
        public void Quit()
        {
            Console.WriteLine($"Employee #{Id} - {FirstName} quit at {DateTime.Now}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate employee with data
            var emp = new Employee { Id = 42, FirstName = "Shaimaa" };

            // Interface reference assigned to Employee object
            IQuittable quitter = emp;

            // Quit using interface method (polymorphism)
            quitter.Quit(); // Outputs time and ID
        }
    }
}
