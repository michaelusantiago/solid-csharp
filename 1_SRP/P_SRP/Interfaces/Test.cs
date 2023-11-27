// SOLID Principles:
// 1. Single Responsibility Principle (SRP)
// 2. Open/Closed Principle (OCP)
// 3. Liskov Substitution Principle (LSP)
// 4. Interface Segregation Principle (ISP)
// 5. Dependency Inversion Principle (DIP)

// Interface for calculating area
public interface IAreaCalculator
{
    double CalculateArea();
}

// Base class representing a shape
public abstract class Shape : IAreaCalculator
{
    // Single Responsibility Principle (SRP)
    // Each class should have a single responsibility.
    // Here, the Shape class is responsible for defining a shape and its basic properties.

    // Open/Closed Principle (OCP)
    // The class should be open for extension but closed for modification.
    // Here, the Shape class can be extended to add new shapes without modifying the existing code.

    // Liskov Substitution Principle (LSP)
    // Subtypes must be substitutable for their base types.
    // Here, any derived class (e.g., Circle, Rectangle) should be able to replace the base class (Shape).

    // Common properties for all shapes
    public int Width { get; set; }
    public int Height { get; set; }

    // Constructor
    protected Shape(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Method to calculate area
    public abstract double CalculateArea();
}

// Circle class
public class Circle : Shape
{
    // Constructor
    public Circle(int radius) : base(radius, radius)
    {
    }

    // Calculate area for a circle
    public override double CalculateArea()
    {
        return Math.PI * Width * Width;
    }
}

// Rectangle class
public class Rectangle : Shape
{
    // Constructor
    public Rectangle(int width, int height) : base(width, height)
    {
    }

    // Calculate area for a rectangle
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
