using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorEx1
{
    public interface IStudentIterator
    {
        bool HasItem();
        Student Next();
        Student Current();
    }
}
