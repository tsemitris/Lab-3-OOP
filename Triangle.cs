using System;

namespace OOP;

public class Triangle
{
    double _base;
    double _height;

    public double Base
    {
        get { return _base; }
        set
        {
            /*
                Checks if the values is less than 0.
                    If it is, then throw a error message.
                    Otherwise it will save the value in the _base variable.
            */
            if (value <= 0)
            {
                throw new ArgumentException("Base can't be negative");
            }

            _base = value;
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            /*
                Checks if the values is less than 0.
                    If it is, then throw a error message.
                    Otherwise it will save the value in the _height variable.
            */
            if (value <= 0)
            {
                throw new ArgumentException("Height can't be negative");
            }

            _height = value;
        }
    }

    // Constructor
    public Triangle(double triangleBase, double triangleHeight)
    {
        // Saves parameter in Base and Height variable.
        Base = Math.Round(triangleBase, 2);
        Height = Math.Round(triangleHeight, 2);
    }

    // Method to get area
    public double GetArea()
    {
        return Math.Round((Base * Height) / 2);
    }
}
