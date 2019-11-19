using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univers
{
    class Matter
    {
        protected List<Element> elements;

        protected Matter(List<Element> _elements)
        {
            elements = _elements;
        }
    }
}
