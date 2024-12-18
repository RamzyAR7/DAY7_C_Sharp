using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_C_Sharp
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract double CalculateArea();
    }
    public class Rectangle2 : Shape
    {
        public double Width2 { get; set; }
        public double Height2 { get; set; }

        public Rectangle2(double _Width, double _Height)
        {
            Width2 = _Height;
            Height2 = _Width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double CalculateArea()
        {
            return Width2 * Height2;
        }

    }
}
