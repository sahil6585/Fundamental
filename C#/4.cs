using System;

class Program
{
    static void Main()
    {
        // Input principal amount
        Console.Write("Enter the Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Input rate of interest
        Console.Write("Enter the Rate of Interest (in percentage): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Input number of years
        Console.Write("Enter the Number of Years: ");
        double years = Convert.ToDouble(Console.ReadLine());

        // Calculate simple interest
        double simpleInterest = (principal * rate * years) / 100;

        // Display the result
        Console.WriteLine($"Principal Amount: {principal}");
        Console.WriteLine($"Rate of Interest: {rate}%");
        Console.WriteLine($"Number of Years: {years}");
        Console.WriteLine($"Simple Interest: {simpleInterest}");
    }
}
