using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to check if it's prime: ");
        
        // Read the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is prime
        bool isPrime = IsPrime(number);

        // Print whether the number is prime or not
        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }

    // Function to check if a number is prime
    static bool IsPrime(int n)
    {
        // If the number is less than 2, it's not prime
        if (n <= 1)
        {
            return false;
        }

        // Check divisibility by numbers from 2 to square root of n
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
