using System.Runtime.CompilerServices;

class Fraction
{
    //attributes
    private int _top;
    private int _bottom;

    //methods
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop( int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string top = _top.ToString();
        string bottom = _bottom.ToString();

        string fractionString = $"{top}/{bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double top = _top;
        double bottom = _bottom;
        double deci = top / bottom;
        return deci;
    }
}