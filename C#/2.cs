using System;

class Program
{
    static void Main()
    {
        // Input first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Input second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        
        // Display results
        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
        
        // Check for division by zero
        if (num2 != 0)
        {
            double quotient = num1 / num2;
            Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
    }
}
