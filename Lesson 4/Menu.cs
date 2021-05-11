using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
     public class Menu
    {
        public static void Start()
        {
            if (Authentification.Auth(new FileDb(), new View2()))
            {
                Console.WriteLine("Доступ разрешен");
            }
            else
            {
                Console.WriteLine("Доступ не разрешен");
            }
        }
    }
}
