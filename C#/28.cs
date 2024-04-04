using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            try
            {
                // Attempting to divide by zero
                int x = 10;
                int y = 0;
                int result = x / y; // Division by zero will throw an exception
                Console.WriteLine("Result: " + result); // This line won't be executed
            }
            catch (DivideByZeroException ex1)
            {
                // Handling DivideByZeroException
                Console.WriteLine("Inner catch block: " + ex1.Message);
            }

            // This block won't be executed due to the exception in the inner try block
            Console.WriteLine("This line won't be executed after the inner try-catch block.");
        }
        catch (Exception ex2)
        {
            // Handling any other exception occurred in the outer try block
            Console.WriteLine("Outer catch block: " + ex2.Message);
        }
    }
}
