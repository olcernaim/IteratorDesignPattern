using System;

namespace IteratorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.getIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
