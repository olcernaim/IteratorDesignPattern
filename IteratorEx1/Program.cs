using System;

namespace IteratorEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentList = new StudentRepository();

            Student std1 = new Student { StdNo = 1, Name = "Name1", Surname = "Surname1" };
            Student std2 = new Student { StdNo = 2, Name = "Name2", Surname = "Surname2" };
            Student std3 = new Student { StdNo = 3, Name = "Name3", Surname = "Surname3" };
            Student std4 = new Student { StdNo = 4, Name = "Name4", Surname = "Surname4" };

            studentList.Add(std1);
            studentList.Add(std2);
            studentList.Add(std3);
            studentList.Add(std4);

            IStudentIterator list = studentList.CreateIterator();

            while (list.HasItem())
            {
                Console.WriteLine("Student No is : " + list.Current().StdNo);
                Console.WriteLine("Name is : " + list.Current().Name);
                Console.WriteLine("Surname is : " + list.Current().Surname);
                Console.WriteLine("--------------------------------------------------------");
                list.Next();
            }

            Console.Read();
        }
    }
}
