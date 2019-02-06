using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(Console.ReadLine(), Console.ReadLine()); 
            Console.WriteLine(st.getName() + " " + st.getId() + " " + st.inc());
        }
    }
}
