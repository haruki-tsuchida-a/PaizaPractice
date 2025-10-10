using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class c013
    {
        static void ec(string[] args)
        {
            string n = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            List<int> r = new List<int>();

            for (int i = 0; i < m; i++)
            {
                string a = Console.ReadLine();
                if (a.Contains(n))
                {
                    continue;
                }

                r.Add(int.Parse(a));
            }

            if (r.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                foreach (var item in r)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
