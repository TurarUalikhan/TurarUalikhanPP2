
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace example
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] fsis = d.GetFileSystemInfos();
            for (int i = 0; i < fsis.Length; i++)
            {
                if (fsis[i].GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (fsis[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(i.ToString() + "." + fsis[i].Name);
            }
        }
        public static void Main(String[] args)
        {
            string path = @"C:\Users\emfor\Desktop";
            DirectoryInfo d = new DirectoryInfo(@"C: \Users\emfor\Desktop");
            int cursor = 0;
            int n = d.GetFileSystemInfos().Length;
            print(d, cursor);
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                FileSystemInfo[] fsis = d.GetFileSystemInfos();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        d = new DirectoryInfo(fsis[cursor].FullName);
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))
                    {
                        Console.Clear();
                        StreamReader sr = new StreamReader(fsis[cursor].FullName);
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();
                    }

                  
}
                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (d.Parent != null)
                    {
                        d = d.Parent;
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        break;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Delete)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        DirectoryInfo temp = new DirectoryInfo(fsis[cursor].FullName);
                        if (temp.GetFileSystemInfos().Length == 0)
                        {
                            Directory.Delete(temp.FullName);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Are you sure? If you want to delete then press Y if not press any other key");
                            ConsoleKeyInfo k = Console.ReadKey();
                            if (k.Key == ConsoleKey.Y)
                            {
                                Directory.Delete(temp.FullName, true);
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))
                    {
                        File.Delete(fsis[cursor].FullName);
                    }
                }
                if (keyInfo.Key == ConsoleKey.R)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string fileN = fsis[cursor].Name;
                        string fullN = fsis[cursor].FullName;
                        int len = fileN.Length;
                        string newName = "";
                        for (int i = 0; i < fullN.Length - len; i++)
                        {
                            newName = newName + fullN[i];
                        }
                        newName = newName + s;
                        Directory.Move(fullN, newName);
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string fileN = fsis[cursor].Name;
                        string fullN = fsis[cursor].FullName;
                        int len = fileN.Length;
                        string newName = "";
                        for (int i = 0; i < fullN.Length - len; i++)
                        {
                            newName = newName + fullN[i];
                        }
                        newName = newName + s;
                        File.Move(fullN, newName);
                    }
                }
                Console.Clear();
                print(d, cursor);

            }
        }
    }
}