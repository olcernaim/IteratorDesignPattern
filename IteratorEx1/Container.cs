using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorEx1
{
    public interface Container
    {
        IStudentIterator CreateIterator();
    }
}
