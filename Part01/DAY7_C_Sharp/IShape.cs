using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_C_Sharp
{
    internal interface IShape
    {
        double Area { get; }

        void Draw();

        void PrintDetails()
        {
            Console.WriteLine("default from interface");
        }
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double _Width, double _Height)
        {
            Width = _Width;
            Height = _Height;
        }

        public double Area
        {
            get { return Width * Height; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle ==> Area: {Width * Height}");
        }
    }
    class Circle: IShape
    {
        public double Radius { get; set; }

        public Circle(double _Radius)
        {
            Radius = _Radius;
        }
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing a Circle ==> Area : {Math.PI * Radius * Radius}");
        }
    }
}
