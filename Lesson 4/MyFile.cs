using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{
    class MyFile
    {
        public static string[] GetFile()
        {
            string path = @"C:\Users\Intel\source\repos\Lesson 4\Lesson 4\bin\Debug\file.txt";
            string[] lines = new string[0];
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
            }
            return lines;
        }
    }
}
