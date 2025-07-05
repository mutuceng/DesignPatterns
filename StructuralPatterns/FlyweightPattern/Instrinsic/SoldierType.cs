using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Instrinsic
{
    public class SoldierType
    {
        public string Name { get; set; }
        public string BodyModel { get; set; }
        public string Animation { get; set; }
        public string VisionRange { get; set; }


        public SoldierType(string name, string bodyModel, string animation, string visionRange)
        {
            Name = name;
            BodyModel = bodyModel;
            Animation = animation;
            VisionRange = visionRange;
        }

        public void Render(string armor, string weapon, string emblem, string climate, string house, int x, int y)
        {
            Console.WriteLine($"{house} hanesine ait {Name} {x},{y} konumunda çiziliyor.");
            Console.WriteLine($"Zırh: {armor}, Silah: {weapon}, İklim: {climate}, Sembol: {emblem}");
        }
    }
}
