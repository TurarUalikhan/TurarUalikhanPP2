using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace C
{
    class Program
    {
        static void WhiteSpace(int level)
        {
            for(int i = 0; i< level * 4; i++)
            {
                Console.Write(" ");
            }
        }
        static void print(string path, int level)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            DirectoryInfo[] directoryInfos = d.GetDirectories();
            FileInfo[] fileInfos = d.GetFiles();

            foreach(FileInfo f in fileInfos)
            {
                WhiteSpace(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo dInfo in directoryInfos)
            {
                WhiteSpace(level);
                Console.WriteLine(dInfo.Name);
                print(dInfo.FullName, level + 1);
            }

        }
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Intel";
            print(path, 0);

        }
    }
}
