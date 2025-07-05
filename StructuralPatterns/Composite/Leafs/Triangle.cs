using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leafs
{
    public class Triangle: ICanvasItem
    {
        public Triangle(string name) : base(name) { }

        public override void Draw(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}- Triangle: {Name}");
        }

    }
}
