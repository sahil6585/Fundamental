using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the radius
        Console.Write("Enter the radius of the circle: ");
        
        // Read the radius input from the user
        double radius = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the circle
        double area = Math.PI * radius * radius;

        // Print the area of the circle
        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }
}
