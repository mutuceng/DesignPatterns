using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.Composite
{
    public class Directory:IFileSystemItem
    {
        private readonly List<IFileSystemItem> _children = new();
        public Directory(string name) : base(name) { }

        public void Add(IFileSystemItem item) => _children.Add(item);

        public void Delete(IFileSystemItem item) => _children.Remove(item);

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}+ {Name}");
            foreach (var child in _children)
                child.Display(indent + 2);
        }
    }
}
