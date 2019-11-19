using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class Univers
    {
        private Vector2D size;
        private ElementFactory elementFactory;
        private List<Matter> matters;

        public Univers(Vector2D _size)
        {
            size = _size;
            matters = new List<Matter>();
        }

        public void AddCarbon(Vector2D pos)
        {
            Atom atom = new Atom(elementFactory.GetElement("Carbon"), pos);
            matters.Add(atom);
        }

        public void AddHydrogen(Vector2D pos)
        {
            Atom atom = new Atom(elementFactory.GetElement("Hydrogen"), pos);
            matters.Add(atom);
        }

        public void AddLithium(Vector2D pos)
        {
            Atom atom = new Atom(elementFactory.GetElement("Lithium"), pos);
            matters.Add(atom);
        }
    }
}
