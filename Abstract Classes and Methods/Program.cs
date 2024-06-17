public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(7.0);
        Rectangle rectangle = new Rectangle(7.0, 16.0);

        Console.WriteLine("Circle area: " + circle.GetArea());
        Console.WriteLine("Rectangle area: " + rectangle.GetArea());
    }
}