// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Circle
{
    private double radius;
    private double x;
    private double y;

    public double Radius { get { return radius; } set {radius=value;} }
    public double X { get { return x; } set {x=value; } }
    public double Y { get { return y; } set { y = value; } }



    public Circle(double radius, double x, double y)
    {
        this.radius = radius;
        this.x = x;
        this.y = y;
    }

    public double Calc_Area()
    {
        return (Math.PI * Math.Pow(radius,2));
    }

    public double Calc_Per()
    {
        return (2 * Math.PI * radius);
    }


}


partial class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(10,10,10);

        double area = circle.Calc_Area();
        Console.WriteLine("Area: "+ area);

        double perimeter = circle.Calc_Per();
        Console.WriteLine("Perimeter: "+perimeter);




    }

}

