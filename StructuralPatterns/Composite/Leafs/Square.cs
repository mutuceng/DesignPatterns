using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leafs
{
    public class Square: ICanvasItem
    {
        public Square(string name) : base(name) { }

        public override void Draw(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}- Square: {Name}");
        }
    }
}
