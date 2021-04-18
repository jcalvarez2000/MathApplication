using System;
using System.Collections.Generic;
using System.Text;

namespace MathApplication
{
    public class ShapeFactory
    {
        //static Dictionary<string, int> ShapeCount = new Dictionary<string, int>();
        static Dictionary<Type, int> ShapeCount = new Dictionary<Type, int>();

        public Circle createCircle(float radius)
        {
            Circle newCircle = new Circle(radius);

            int count;
            ShapeCount.TryGetValue(typeof(Circle), out count);
            ShapeCount[typeof(Circle)] = count + 1;

            return newCircle;
        }

        public Shape createRectangle(float width, float length)
        {
            Rectangle newRectangle = new Rectangle(width, length);

            int count;
            ShapeCount.TryGetValue(typeof(Rectangle), out count);
            ShapeCount[typeof(Rectangle)] = count + 1;

            return newRectangle;
        }

        public Shape createSquare(float side)
        {
            Square newSquare = new Square(side);

            int count;
            ShapeCount.TryGetValue(typeof(Square), out count);
            ShapeCount[typeof(Square)] = count + 1;

            return newSquare;
        }

        public Triangle createTriangle(float sideA, float sideB, float sideC, float height, float triangleBase)
        {
            Triangle newTriangle = new Triangle(sideA, sideB, sideC, height, triangleBase);
  
            int count;

            ShapeCount.TryGetValue(typeof(Triangle), out count);
            ShapeCount[typeof(Triangle)] = count + 1;

            return newTriangle;
        }

        static public void printInstances()
        {
            foreach (KeyValuePair<Type, int> count in ShapeCount)
            {
                Console.WriteLine("Shape: {0} Instances: {1}", count.Key, count.Value);
            }
        }

    }
}
