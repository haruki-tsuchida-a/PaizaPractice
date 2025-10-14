using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class cd
    {
        static void cdd(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();

            if (s == t)
            {
                Console.WriteLine("NO");
            }
            else if (s.Length == t.Length)
            {
                string s2 = new string(s.OrderByDescending(c => c).ToArray());
                string t2 = new string(t.OrderByDescending(c => c).ToArray());
                if (s2 == t2)
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
