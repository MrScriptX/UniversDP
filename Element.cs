using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class Element
    {
        private string name;
        private string symbol;
        private float mass;

        public Element(string _name, string _symbol, float _mass)
        {
            name = _name;
            symbol = _symbol;
            mass = _mass;
        }

        public string Name { get; }
        public string Symbol { get; }
        public float Mass { get; }
    }
}
