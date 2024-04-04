using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter two numbers
        Console.Write("Enter the starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        // Print prime numbers between the two input values
        Console.WriteLine($"Prime numbers between {start} and {end} are:");
        PrintPrimeNumbers(start, end);
    }

    // Function to check if a number is prime
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return f
