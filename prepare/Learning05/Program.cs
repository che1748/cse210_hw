using System;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("blue", 3);
        Rectangle shape2 = new Rectangle("Yellow", 2, 4);
        Circle shape3 = new Circle("green", 4);

        List<Shape> shapeList = new List<Shape>()
        {
            shape1, shape2, shape3
        };

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}