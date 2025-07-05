using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public class Canvas: ICanvasItem
    {
        private readonly List<ICanvasItem> _items = new();

        public Canvas(string name) : base(name) { }

        public void Add(ICanvasItem item) => _items.Add(item);

        public override void Draw(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}[Canvas] {Name}");
            foreach (var item in _items)
                item.Draw(indent + 2);
        }
    }
}
