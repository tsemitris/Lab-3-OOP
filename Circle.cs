using System;
using System.Runtime.CompilerServices;

namespace OOP;

public class Circle
{
    double _radius;
    double pi = Math.PI;

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Radius can't be negative");
            }

            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = Math.Round(radius, 2);
    }

    public double GetArea()
    {
        return Math.Round(Radius * Radius * pi, 2);
    }

    public double GetCircumference()
    {
        return Math.Round(Radius * 2 * pi, 2);
    }

    public double GetVolume()
    {
        return Math.Round(4 * pi * Math.Pow(Radius, 3) / 3, 2);
    }
}
