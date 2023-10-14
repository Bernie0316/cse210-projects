// Create a class to hold fraction.
using System;

// The class should be in its own file.
public class Fraction
{
    // The class should have two attributes for the top and bottom numbers.
    // Make sure the attributes are private.
    private int _top;
    private int _bottom;

    // Create the following constructors:
    public Fraction()
    {
        // Constructor that has no parameters that initializes the number to 1/1.
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        // Constructor that has one parameter for the top and that initializes the denominator to 1. 
        // So that if you pass in the number 5, 
        // the fraction would be initialized to 5/1.
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        // Constructor that has two parameters, 
        // one for the top and one for the bottom.
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionstring()
    {
        string fraction = $"{_top} / {_bottom}";
        return fraction;   
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}