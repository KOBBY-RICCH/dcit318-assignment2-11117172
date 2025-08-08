using System;

abstract class Shape
{
    // Abstract method - no implementation here
    public abstract double GetArea();
}

// Circle class inherits from Shape
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Override GetArea to calculate area of circle
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class inherits from Shape
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Override GetArea to calculate area of rectangle
    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Abstract Classes and Area Calculation ===");

        // Create a Circle with radius 5
        Shape myCircle = new Circle(5);
        Console.WriteLine($"Area of Circle: {myCircle.GetArea():F2}");

        // Create a Rectangle with width 4 and height 6
        Shape myRectangle = new Rectangle(4, 6);
        Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea():F2}");
    }
}
