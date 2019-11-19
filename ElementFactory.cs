using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class ElementFactory
    {
        private static ElementFactory instance;

        public ElementFactory()
        {
            instance = this;
        }

        public static ElementFactory GetElementFactory()
        {
            return instance;
        }

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
