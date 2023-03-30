class Square : Shape
{
    // GetColour() instead of _colour.
    private double _side;

    public Square(string colour, double side) : base(colour)
    {
        _side = side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
