
internal class Rectangle
{

    public double Length { get; set; }

    public double Width { get; set; }


    /// <summary>
    /// Default/Empty Constructor
    /// </summary>
    public Rectangle()
    {
        Length = 0;
        Width = 0;
    }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Width * Length;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }

    public override string ToString()
    {
        return $"Length: {Length}\nWidth:{Width}\nArea:{CalculateArea()}\nPerimeter:{CalculatePerimeter()}";
    }

}

