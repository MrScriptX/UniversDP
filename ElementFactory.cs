using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class ElementFactory
    {
        public Element GetElement(string name)
        {
            switch(name)
            {
                case "Carbon":
                    return new Carbon();
                case "Lithium":
                    return new Lithium();
                case "Hydrogen":
                    return new Hydrogen();
                default:
                    return null;
            }
        }
    }
}
