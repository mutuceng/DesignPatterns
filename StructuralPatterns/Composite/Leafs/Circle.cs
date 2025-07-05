using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.Leafs
{
    public class Circle: ICanvasItem
    {
        public Circle(string name) : base(name) { }

        public override void Draw(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}- Circle: {Name}");
        }
    }
}
