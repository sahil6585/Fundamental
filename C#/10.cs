using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to generate Fibonacci series: ");
        
        // Read the input number from the user
        int limit = Convert.ToInt32(Console.ReadLine());

        // Generate and print Fibonacci series up to the given limit
        Console.WriteLine("Fibonacci series up to " + limit + ":");
        PrintFibonacciSeries(limit);
    }

    // Function to generate and print Fibonacci series up to a given limit
    static void PrintFibonacciSeries(int limit)
    {
        int firstNum = 0, secondNum = 1, nextNum = 0;

        // Print the first two numbers of Fibonacci series
        Console.Write(firstNum + " " + secondNum + " ");

        // Generate and print Fibonacci series up to the limit
        while (nextNum <= limit)
        {
            nextNum = firstNum + secondNum;
            if (nextNum <= limit)
            {
                Console.Write(nextNum + " ");
            }
            firstNum = secondNum;
            secondNum = nextNum;
        }
    }
}
