# CSharpMethodsAssignment

**Course:** BUI-CSC 307 – Programming with C#

This console application demonstrates reusable C# methods for geometric areas and quadratic equations.

## Implemented methods
- `CalculateCircleArea(double radius)` — `A = πr²`
- `CalculateTriangleArea(double triangleBase, double height)` — `A = ½bh`
- `CalculateSquareArea(double length)` — `A = l²`
- `CalculateRectangleArea(double length, double breadth)` — `A = l × b`
- `SolveQuadraticEquation(double a, double b, double c)` — `x = (-b ± √(b² - 4ac)) / 2a`

The quadratic method handles two roots, a repeated root, no real roots, and `a = 0`.

## Technologies
C#, .NET 10 SDK, and a .NET console application.

## Running
```bash
dotnet run
dotnet build
```

## Sample output
```text
BUI-CSC 307 – C# Methods Assignment
====================================
Circle area (radius 7): 153.94
Triangle area (base 10, height 5): 25.00
Square area (length 4): 16.00
Rectangle area (length 8, breadth 5): 40.00
Quadratic equation: x² - 3x + 2 = 0
Discriminant: 1
Two real roots: x₁ = 2, x₂ = 1
```
