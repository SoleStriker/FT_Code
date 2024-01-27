using static System.Console;
class ShapesDemo
{
    static void Main()
    {
        // Your code here
        Square square = new Square { Height = 10, Width = 10 };
        WriteLine(square.ComputeArea());

        Rectangle rectangle = new Rectangle { Height = 15, Width = 10 };
        WriteLine(rectangle.ComputeArea());

        Triangle triangle = new Triangle { Height = 10, Width = 20 };
        WriteLine(triangle.ComputeArea());
    }
}
abstract class GeometricFigure
{
    private double height;
    private double width;
    private double area;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Width 
    {
        get { return width; }
        set { width = value; }
    }

    public double Area 
    {
        get { return area; }
    }
}
class Square : GeometricFigure
{
    public double Area => Height * Width;
    public double ComputeArea()
    {
        return Area;
    }
}
class Rectangle : GeometricFigure
{
    public double Area => Height * Width;

    public double ComputeArea()
    {
        return Area;
    }
}

class Triangle : GeometricFigure
{
    public double Area => 0.5f * Height * Width;

    public double ComputeArea()
    {
        return Area;
    }
}

