using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            int result = x / y; // Division by zero will throw an exception
            Console.WriteLine("Result: " + result); // This line won't be executed
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
