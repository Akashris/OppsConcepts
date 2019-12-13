using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shapes
    {
        public virtual void draw()
        {
            Console.WriteLine("Formula And Example");
        }
    }
    public class Square : Shapes
    {
        public override void draw()
        {
            Console.WriteLine("\nSquare = Side * Side");
            int side = 5, area;
            Console.WriteLine("For a square of side {0} mts", side);
            area = side * side;
            Console.WriteLine("Area is {0} sqr mts", area);
        }
    }
    public class Rectangle : Shapes
    {
        public override void draw()
        {
            Console.WriteLine("\nRectangle = Length * Breadth");
            int length = 4, breadth = 6, area;
            Console.WriteLine("For a rectangle of length {0}mts and {1}mts", length, breadth);
            area = length * breadth;
            Console.WriteLine("Area is {0} sqr mts", area);
        }
    }
    public class Circle : Shapes
    {
        public override void draw()
        {
            Console.WriteLine("\nCircle = 3.14 * Radius * Radius");
            double radius = 7;
            double area;
            Console.WriteLine("For a circle of radius {0}mts", radius);
            area = 3.14 * radius * radius;
            Console.WriteLine("Area is {0} sqr mts", area);
        }
    }

    public class TestPolymorphism
    {
        public static void Main(string[] args)
        {
            Shapes obj;
            obj = new Shapes();
            obj.draw();
            obj = new Square();
            obj.draw();
            obj = new Rectangle();
            obj.draw();
            obj = new Circle();
            obj.draw();
            Console.ReadKey();
        }
    }
}