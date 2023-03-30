using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Square squareObject = new Square("blue", 5);
        // Console.WriteLine($"{squareObject.GetColour()} {squareObject.GetArea()}");
        Rectangle rectangleObject = new Rectangle("green", 5, 6);
        // Console.WriteLine($"{rectangleObject.GetColour()} {rectangleObject.GetArea()}");
        Circle circleObject = new Circle("red", 5);
        // Console.WriteLine($"{circleObject.GetColour()} {circleObject.GetArea()}");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(squareObject);
        shapeList.Add(rectangleObject);
        shapeList.Add(circleObject);

        foreach (Shape shapeObject in shapeList)
        {
            // Console.WriteLine($"{shapeObject.GetColour()} {shapeObject.GetArea()}");
            Console.WriteLine($"The {shapeObject.GetColour()} shape has an area of {shapeObject.GetArea()}.");
        }
    }
}
