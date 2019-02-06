using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace D
{
    class Program
    {
        static void CCD(string path, string path1)
        {
            string newpath = Path.Combine(path, "text.txt");
            File.Create(newpath);
            File.Copy(newpath, path1);
            File.Delete(newpath);
        }
        static void Main(string[] args)
        {
            CCD(@"C:\Users\Turar\Desktop\path1", @"C: \Users\Turar\Desktop\path2");
        }
    }
}
