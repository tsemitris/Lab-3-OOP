using System;
using System.Runtime.CompilerServices;

namespace OOP;

public class Circle
{
    double _radius;

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

}
