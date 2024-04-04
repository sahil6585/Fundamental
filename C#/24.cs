using System;

// Abstract class Shape
abstract class Shape
{
    // Abstract method to calculate area
    public abstract double Area();
}

// Subclass Triangle inheriting from Shape
class Triangle : Shape
{
    // Constructor and properties for sides of the triangle
    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }

    // Constructor
    public Triangle(double side1, double side2, double side3) =>
        (Side1, Side2, Side3) = (side1, side2, side3);

    // Override the Area method to calculate area for a triangle
    public override double Area()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }
}

// Subclass Rectangle inheriting from Shape
class Rectangle : Shape
{
    // Constructor and properties for length and width of the rectangle
    public double Length { get; }
    public double Width { get; }

    // Constructor
    public Rectangle(double length, double width) => (Length, Width) = (length, width);

    // Override the Area method to calculate area for a rectangle
    public override double Area() => Length * Width;
}

// Subclass Circle inheriting from Shape
class Circle : Shape
{
    // Constructor and property for radius of the circle
    public double Radius { get; }

    // Constructor
    public Circle(double radius) => Radius = radius;

    // Override the Area method to calculate area for a circle
    public override double Area() => Math.PI * Radius * Radius;
}
