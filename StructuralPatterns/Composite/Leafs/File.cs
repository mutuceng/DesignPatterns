using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leafs
{
    public class File: IFileSystemItem
    {
        public File(string name) : base(name) { }
        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}- {Name}");
        }
    }
}
