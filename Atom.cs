using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class Atom : Matter
    {
        private Vector2D position;

        public Atom(Element _element, Vector2D _pos) : base(_element)
        {
            position = _pos;
        }

        public Vector2D Position
        {
            get
            {
                return position;
            }
        }
    }
}
