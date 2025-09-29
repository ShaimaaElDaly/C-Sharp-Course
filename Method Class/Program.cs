using System;

namespace NumberProcessorApp
{
    // This class handles processing of numbers
    class NumberProcessor
    {
        // Method that multiplies the first number by 3 and checks if second number is even
        public void AnalyzeNumbers(int input1, int input2)
        {
            int product = input1 * 3; // Multiply first input by 3
            Console.WriteLine("Triple of the first number: " + product); // Output the product

            // Check if the second number is even
            bool isEven = input2 % 2 == 0;
            Console.WriteLine("Second number (" + input2 + ") is even? " + isEven); // Display even check
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the NumberProcessor class
            NumberProcessor processor = new NumberProcessor();

            // Call the method using regular positional arguments
            processor.AnalyzeNumbers(4, 9);

            // Call the method using named arguments
            processor.AnalyzeNumbers(input2: 6, input1: 5);
        }
    }
}
