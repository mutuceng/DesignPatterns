using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Component
{
    public abstract class ICanvasItem
    {
        public string Name { get; }
        protected ICanvasItem(string name) => Name = name;
        public abstract void Draw(int indent = 0);
    }
}
