using System;

namespace SealedClass
{
    public sealed class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;

        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Console.WriteLine("The area of circle is " + circle.CalculateArea());
            Console.ReadLine();
        }
    }
}
