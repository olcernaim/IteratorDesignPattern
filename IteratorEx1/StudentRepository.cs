using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorEx1
{
    public class StudentRepository : Container
    {
        List<Student> StudentList = new List<Student>();
        public void Add(Student Model)
        {
            StudentList.Add(Model);
        }
        public Student GetItem(int index)
        {
            return StudentList[index];
        }

        public int Count() { return StudentList.Count; }
        public IStudentIterator CreateIterator()
        {
            return new StudentIterator(this);
        }
    }
}
