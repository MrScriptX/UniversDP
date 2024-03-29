﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class Univers
    {
        private Vector2D size;
        private List<Matter> matters;

        public Univers(Vector2D _size)
        {
            size = _size;
            matters = new List<Matter>();
        }

        public void AddCarbon(Vector2D pos)
        {
            Atom atom = new Atom(new Carbon(), pos);
            matters.Add(atom);
        }

        public void AddHydrogen(Vector2D pos)
        {
            Atom atom = new Atom(new Hydrogen(), pos);
            matters.Add(atom);
        }

        public void AddLithium(Vector2D pos)
        {
            Atom atom = new Atom(new Lithium(), pos);
            matters.Add(atom);
        }
    }
}
