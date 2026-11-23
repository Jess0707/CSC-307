namespace CSharpMethodsAssignment;

public static class Program
{
    // Calculates the area of a circle using A = πr².
    public static double CalculateCircleArea(double radius) => Math.PI * radius * radius;
    // Calculates the area of a triangle using A = ½bh.
    public static double CalculateTriangleArea(double triangleBase, double height) => 0.5 * triangleBase * height;
    // Calculates the area of a square using A = l².
    public static double CalculateSquareArea(double length) => length * length;
    // Calculates the area of a rectangle using A = l × b.
    public static double CalculateRectangleArea(double length, double breadth) => length * breadth;

    // Solves ax² + bx + c = 0 and reports the real roots based on its discriminant.
    public static void SolveQuadraticEquation(double a, double b, double c)
    {
        if (a == 0) { Console.WriteLine("The equation is not quadratic because a equals zero."); return; }
        double discriminant = b * b - 4 * a * c;
        Console.WriteLine($"Discriminant: {discriminant:0.##}");
        if (discriminant > 0)
        {
            double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two real roots: x₁ = {firstRoot:0.##}, x₂ = {secondRoot:0.##}");
        }
        else if (discriminant == 0) Console.WriteLine($"One repeated real root: x = {-b / (2 * a):0.##}");
        else Console.WriteLine("There are no real roots.");
    }

    public static void Main()
    {
        Console.WriteLine("BUI-CSC 307 – C# Methods Assignment");
        Console.WriteLine("====================================");
        Console.WriteLine($"Circle area (radius 7): {CalculateCircleArea(7):0.00}");
        Console.WriteLine($"Triangle area (base 10, height 5): {CalculateTriangleArea(10, 5):0.00}");
        Console.WriteLine($"Square area (length 4): {CalculateSquareArea(4):0.00}");
        Console.WriteLine($"Rectangle area (length 8, breadth 5): {CalculateRectangleArea(8, 5):0.00}");
        Console.WriteLine();
        Console.WriteLine("Quadratic equation: x² - 3x + 2 = 0");
        SolveQuadraticEquation(1, -3, 2);
    }
}
