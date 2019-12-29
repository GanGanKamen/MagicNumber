using System;
using System.Collections.Generic;
using FK_CLI;

namespace _1_5
{
    class Program
    {
        static int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static List<int> numList = new List<int>();
        static void Main(string[] args)
        {
            int a, b;
            int c, d, f, g, h, i;
            Console.Write("a = ?");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ?");
            b = int.Parse(Console.ReadLine());
            numList.AddRange(num);
            if ((a > 9 || a < 1) || (b > 9 || b < 1))
            {
                Console.Write("Impossible");
            }
            numList.Remove(a);
            numList.Remove(b);
            c = 15 - a - b;
            PossibltyCheck(c);
            g = 15 - c - 5;
            PossibltyCheck(g);
            d = 15 - a - g;
            PossibltyCheck(d);
            f = 15 - 5 - d;
            PossibltyCheck(f);
            i = 15 - c - f;
            PossibltyCheck(i);
            h = 15 - 5 - b;
            PossibltyCheck(h);
            Console.WriteLine(a.ToString() + b.ToString() + c.ToString());
            Console.WriteLine(d.ToString() + "5" + f.ToString());
            Console.WriteLine(g.ToString() + h.ToString() + i.ToString());
            Console.ReadKey();
        }

        static void PossibltyCheck(int num)
        {
            var ispossible = IsPossible(num);
            if(ispossible == false)
            {
                Console.Write("Impossible");
                Console.ReadKey();
            }
        }

        static bool IsPossible(int num)
        {
            int result = 0;
            for (int x = 0; x < numList.Count; x++)
            {
                if (num == numList[x])
                {
                    result += 1;
                }
            }
            if (result == 1)
            {
                numList.Remove(num);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}