using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace MathApplication
{
    class Program
    {
        static void PrintArray(ref Shape[] shapes)
        {
            foreach (Shape aShape in shapes)
            {
                Console.WriteLine("{0} with Area: {1} and Perimeter: {2}", aShape.Name, aShape.Area, aShape.Perimeter);
            }
        }

        static void PrintJson(ref Shape[] shapes)
        {
            foreach (Shape aShape in shapes)
            {
                Console.WriteLine(aShape.serialize());                
            }
        }

        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            Shape[] shapes =
            {
                factory.createSquare(10),
                factory.createRectangle(2, 3),
                factory.createCircle(3),
                factory.createCircle(6),
                factory.createTriangle(3,3,3, 3.5f, 3),
                factory.createTriangle(3,3,4, 4.5f, 3),
                factory.createTriangle(1,3,4, 1.5f, 4)
            };

            Console.WriteLine("My initial array of shape contains:");
            PrintArray(ref shapes);

            Array.Sort(shapes, new PerimeterComparer());
            Console.WriteLine("\nAfter sorting with the perimeter, the order is:");
            PrintArray(ref shapes);

            Array.Sort(shapes, new AreaComparer());
            Console.WriteLine("\nAfter sorting with the area, the order is:");
            PrintArray(ref shapes);

            Console.WriteLine("\nJson of the objects:");
            PrintJson(ref shapes);

            Console.WriteLine("\nInstances created:");
            ShapeFactory.printInstances();
        }
    }
}
