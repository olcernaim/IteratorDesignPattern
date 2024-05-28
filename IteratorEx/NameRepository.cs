using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorEx
{
    public class NameRepository : Container
    {
        public static string[] names = { "Robert", "John", "Julie", "Lora" };

        public Iterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : Iterator
        {
            int index;
            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public Object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
