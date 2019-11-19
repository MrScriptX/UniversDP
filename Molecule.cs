using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class Molecule : Matter
    {
        private Vector2D pos;

        public Molecule(List<Element> _elements, Vector2D _pos) : base(_elements)
        {
            pos = _pos;

            if (_elements.Count < 2)
                throw new System.ArgumentException("Molecule Invalid !");
        }

        public Vector2D Position
        {
            get
            {
                return pos;
            }
        }
    }
}
