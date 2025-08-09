using System;

namespace AbstractExample
{
    // Abstract class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle class
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Area of Circle: {circle.GetArea()}");
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

            Console.ReadLine();
        }
    }
}
