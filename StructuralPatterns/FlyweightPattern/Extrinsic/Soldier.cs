using FlyweightPattern.Instrinsic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Extrinsic
{
    public class Soldier
    {
        public int X { get; }
        public int Y { get; }

        public string Armor { get; }
        public string Weapon { get; }
        public string Emblem { get; }
        public string Climate { get; }
        public string House { get; }

        public SoldierType Type { get; }

        public Soldier(int x, int y, string armor, string weapon, string emblem, string climate, string house, SoldierType type)
        {
            X = x;
            Y = y;
            Armor = armor;
            Weapon = weapon;
            Emblem = emblem;
            Climate = climate;
            House = house;
            Type = type;
        }

        public void Draw()
        {
            Type.Render(Armor, Weapon, Emblem, Climate, House, X, Y);
        }
    }
}
