using FlyweightPattern.Instrinsic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Flyweight_Factory
{
    public class SoldierFactory
    {
        private Dictionary<string, SoldierType> _types = new();

        public SoldierType GetSoldierType(string name, string bodyModel, string animation, string visionRange)
        {
            string key = name;
            if (!_types.ContainsKey(key))
            {
                _types[key] = new SoldierType(name, bodyModel, animation, visionRange);
            }
            return _types[key];
        }
    }
}
