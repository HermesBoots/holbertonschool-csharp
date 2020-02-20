using System;

/// <summary>Represents any 2D shape.</summary>
class Shape
{
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
}


/// <summary>Represents a rectangle.</summary>
class Rectangle : Shape
{
    // first size dimension
    private int width;
    // second size dimension
    private int height;

    /// <summary>One of the rectangle's size dimensions.</summary>
    public int Width {
        get { return this.width; }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            this.width = value;
        }
    }
    
    /// <summary>One of the rectangle's size dimensions.</summary>
    public int Height {
        get { return this.height; }
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            this.height = value;
        }
    }
}
