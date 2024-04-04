using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Element at index 5: " + numbers[5]); // Index out of range will throw an exception
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}
