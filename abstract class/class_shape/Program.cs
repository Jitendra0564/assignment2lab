using System;

namespace class_shape
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }
    }

}
