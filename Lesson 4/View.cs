using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public abstract class View
    {
        public abstract void WriteLine(string s);
        public abstract string ReadLine();
    }

    public class ConsoleView: View
    {
        public override void WriteLine(string s)
        {
            System.Console.WriteLine(s);
        }
        public override string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }


    public class View2 : View
    {
        public override void WriteLine(string s)
        {
            System.Console.Write($">>> {s} ");
        }
        public override string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
