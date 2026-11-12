using System.Diagnostics;

public class FractionHolder
{
    private int _top;
    private int _bottom;

    public FractionHolder ()
    {
        _top = 1;
        _bottom = 1;
    }

    public FractionHolder (int top)
    {
        _top = top;
        _bottom = 1;
    }

    public FractionHolder (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
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

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}