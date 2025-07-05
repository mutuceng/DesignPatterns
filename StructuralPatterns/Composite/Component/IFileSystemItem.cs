using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Component
{
    public abstract class IFileSystemItem
    {
        public string Name { get; }
        protected IFileSystemItem(string name) => Name = name;
        public abstract void Display(int indent = 0);
    }
}
