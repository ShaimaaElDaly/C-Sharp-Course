using System;

class Program
{
    static void Main()
    {
        // Let the user know we're starting the process
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for the weight of the box
        Console.Write("How much does your package weigh? ");
        decimal boxWeight = Convert.ToDecimal(Console.ReadLine());

        // If it's over the limit, exit early
        if (boxWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Ask for dimensions
        Console.Write("What is the width of your package? ");
        decimal boxWidth = Convert.ToDecimal(Console.ReadLine());

        Console.Write("What is the height of your package? ");
        decimal boxHeight = Convert.ToDecimal(Console.ReadLine());

        Console.Write("What is the length of your package? ");
        decimal boxLength = Convert.ToDecimal(Console.ReadLine());

        // Add all dimensions together
        decimal totalSize = boxWidth + boxHeight + boxLength;

        // If it’s too big, let the user know
        if (totalSize > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Perform cost calculation
        decimal shippingEstimate = (boxWidth * boxHeight * boxLength * boxWeight) / 100;

        // Provide the result with proper formatting
        Console.WriteLine($"Your estimated total for shipping this package is: ${shippingEstimate:F2}");
        Console.WriteLine("Thank you for using Package Express!");
    }
}
