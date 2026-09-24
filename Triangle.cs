using System;

namespace OOP;

public class Triangle
{
    double _base;
    double _height;
    double pi = Math.PI;

    public double Base
    {
        get { return _base; }
        set
        {
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
            if (value <= 0)
            {
                throw new ArgumentException("Height can't be negative");
            }

            _height = value;
        }
    }

    public Triangle(double triangleBase, double triangleHeight)
    {
        Base = Math.Round(triangleBase, 2);
        Height = Math.Round(triangleHeight, 2);
    }
}
