using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorEx1
{
    class StudentIterator : IStudentIterator
    {
        StudentRepository aggregate;
        int currentindex;
        public StudentIterator(StudentRepository aggregate) => this.aggregate = aggregate;
        public Student Current() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count())
                return true;
            return false;
        }
        public Student Next()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);
            return new Student();
        }
    }
}
