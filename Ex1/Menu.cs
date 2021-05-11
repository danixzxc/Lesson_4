using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Menu
    {
        public static void Start()
        {
            int total = 0;
            Random r = new Random();
            int[] mas = new int[20];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-10000, 10000);
                Console.WriteLine(mas[i]);
            }
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] % 3 == 0 && mas[i + 1] % 3 != 0 ||
                   mas[i] % 3 != 0 && mas[i + 1] % 3 == 0)
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
