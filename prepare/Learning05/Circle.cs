class Circle : Shape
{
    private double _radius;
    private double _pi = 3.1415926535;

    public Circle(string colour, double radius) : base(colour)
    {
        _radius = radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * _pi;
    }
}
