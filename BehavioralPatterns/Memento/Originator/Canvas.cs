using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Memento;

namespace Memento.Originator
{
    public class Canvas
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            Console.WriteLine($"Şekil eklendi: {shape.Type} at ({shape.X}, {shape.Y}), Renk: {shape.Color}");
        }

        public void PrintShapes()
        {
            Console.WriteLine("Canvas'taki Şekiller:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Şekil: {shape.Type}, Konum: ({shape.X}, {shape.Y}), Renk: {shape.Color}");
            }
        }

        public Memento.Memento Save() // Fully qualify the Memento type to avoid ambiguity  
        {
            return new Memento.Memento(shapes);
        }

        public void Restore(Memento.Memento memento) // Fully qualify the Memento type to avoid ambiguity  
        {
            shapes = memento.GetShapes();
            Console.WriteLine("Canvas geri yüklendi.");
        }
    }
}
