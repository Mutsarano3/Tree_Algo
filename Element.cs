using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbre
{
    public class Element
    {
        public Element next;
        public Element previous;
        public int data;
        public Element(int value)
        {
            next = null;
            previous = null;
            data = value;
      
        }

    }
}
