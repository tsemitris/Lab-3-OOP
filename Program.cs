using Microsoft.VisualBasic;

namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        PrintCircleInfo(5);
        PrintCircleInfo(6);

        PrintTriangleInfo(6, 4);
    }

    static void PrintCircleInfo(double radius)
    {
        Circle circle = new Circle(radius);

        Console.WriteLine($"Circle info: \nRadius: {radius} \nArea: {circle.GetArea()}.");
        Console.WriteLine($"Diameter: {circle.GetCircumference()}.");
        Console.WriteLine($"Volume: {circle.GetVolume()}.\n");
    }

    static void PrintTriangleInfo(double triangleBase, double triangleHeight)
    {
        Triangle triangle = new Triangle(triangleBase, triangleHeight);

        Console.WriteLine($"Triangle info: \nArea: {triangle.GetArea()}cm²");
    }
}
