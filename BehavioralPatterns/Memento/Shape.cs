using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Shape(double x, double y, string color, string type)
        {
            X = x;
            Y = y;
            Color = color;
            Type = type;
        }

        public Shape Clone()
        {
            return new Shape(X, Y, Color, Type);
        }
    }
}
