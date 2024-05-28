using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorEx
{
    public interface Iterator
    {
        public bool hasNext();
        public Object next();
    }
}
