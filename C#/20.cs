using System;

class Rectangle
{
    // Instance variables
    private double length;
    private double width;

    // Default constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return length * width;
    }

    // Method to display the values of length and width
    public void Display()
    {
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of Rectangle class using different constructors
        Rectangle rectangle1 = new Rectangle(); // Default constructor
        Rectangle rectangle2 = new Rectangle(5.0, 3.0); // Parameterized constructor

        // Displaying values of the objects
        Console.WriteLine("Values of rectangle1:");
        rectangle1.Display();
        Console.WriteLine("Area of rectangle1: " + rectangle1.CalculateArea());

        Console.WriteLine("\nValues of rectangle2:");
        rectangle2.Display();
        Console.WriteLine("Area of rectangle2: " + rectangle2.CalculateArea());
    }
}
