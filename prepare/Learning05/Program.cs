using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List <Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 10));
        shapes.Add(new Rectangle("Blue", 10, 20));
        shapes.Add(new Circle("Green", 10));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{color} - {area}");
        }
    }
}