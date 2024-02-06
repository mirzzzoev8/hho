namespace Task2;
public class Rectangle : Shape
{
    private double length;
    private double width;
    public double GetArea(){
        return length * width;
    }

    public Rectangle(string color, double length, double width) : base(color)
    {
        this.length = length;
        this.width = width;
    }
}
