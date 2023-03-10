class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetNumerator()
    {
        return _top;
    }
    public int GetDenominator()
    {
        return _bottom;
    }
    public void SetNumerator(int top)
    {
        _top = top;
    }
    public void SetDenominator(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        if (_bottom == 1)
        {
            return $"{_top}";
        }
        else
        {
            return $"{_top}/{_bottom}";
        }
    }

    public double GetDecimalValue()
    {
        double top = _top;
        double bottom = _bottom;
        return top / bottom;
    }
}
