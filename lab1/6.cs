// Calculate area of rectangle using multiple inheritance of C#
using System;

interface IShape {
    double Area();
}

interface IRectangle {
    double Width { get; set; }
    double Height { get; set; }
}

class Rectangle : IShape, IRectangle {
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area() {
        return Width * Height;
    }
}

class Program {
    static void Main(string[] args) {
        Rectangle rect = new Rectangle();
        rect.Width = 100.0;
        rect.Height = 10.0;

        Console.WriteLine("The area of the rectangle is: " + rect.Area());
    }
}
