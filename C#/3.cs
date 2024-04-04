using System;

class ArithmeticCalculator
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an arithmetic operator (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // Check for division by zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"Result: {result}");
        }

        Console.ReadKey();
    }
}
