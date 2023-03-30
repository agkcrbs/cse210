abstract class Shape
{
    private string _colour;

    public Shape(string colour)
    {
        _colour = colour;
    }

    public string GetColour()
    {
        return _colour;
    }

    public void SetColor(string colour)
    {
        _colour = colour;
    }

    public abstract double GetArea();
}
