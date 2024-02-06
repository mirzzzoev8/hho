namespace Task2;
public class Circle : Shape
{
    private double radius;
    public double GetArea(){
        return radius * radius * 3.14;
    }

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }
}
