using System;
using System.Security.Cryptography.X509Certificates;

public class Fractions
{
    private int _topnumber;
    private int _bottomnumer;

    public Fractions()
    {
        _topnumber = 1;
        _bottomnumer = 1;
    }

    public Fractions(int wholeNumber)
    {
        _topnumber = wholeNumber;
        _bottomnumer = 1;
    }
    public Fractions(int top, int bottom)
    {
        _topnumber = top;
        _bottomnumer = bottom;
    }

    public void GetTop()
    {
        
    }
    public void SetTop(int top)
    {
        
    }

    public void GetBottom()
    {
        
    }
    public void SetBottom(int bottom)
    {
        
    }

    public string GetFractioningString()
    {
        string fraction = $"{_topnumber}/{_bottomnumer}";

        return fraction;
    }

    public double GetDecimalValue()
    {
        
        return (double)_topnumber / (double)_bottomnumer;
    }
}

