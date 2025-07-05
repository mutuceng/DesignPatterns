using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Memento
    {
        private readonly List<Shape> _shapes;

        public Memento(List<Shape> shapes)
        {
            _shapes = new List<Shape>();
            foreach (var shape in shapes)
            {
                _shapes.Add(shape.Clone());
            }
        }

        public List<Shape> GetShapes()
        { 
            var copy = new List<Shape>();
            foreach (var shape in _shapes)
            {
                copy.Add(shape.Clone());
            }

            return copy;
        }
    }
}
