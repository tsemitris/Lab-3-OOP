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
            /*
                Checks if the values is less than 0.
                    If it is, then throw a error message.
                    Otherwise it will save the value in the _radius variable.
            */
            if (value <= 0)
            {
                throw new ArgumentException("Radius can't be negative");
            }

            _radius = value;
        }
    }

    // Constructor.
    public Circle(double radius)
    {
        // Saves the parameter on the variable Radius
        Radius = Math.Round(radius, 2);
    }

    // Method to get circle area.
    public double GetArea()
    {
        return Math.Round(Radius * Radius * pi, 2);
    }

    // Method to get circum ference.
    public double GetCircumference()
    {
        return Math.Round(Radius * 2 * pi, 2);
    }

    // Method to get volume.
    public double GetVolume()
    {
        return Math.Round(4 * pi * Math.Pow(Radius, 3) / 3, 2);
    }
}
