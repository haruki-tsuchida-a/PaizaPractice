using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class T
    {
        static void te(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var second = Console.ReadLine();
            var lists = new List<string>();
            var target = new List<string>();

            for (int i = 0; i < N; i++)
            {
                lists.Add(Console.ReadLine());
                if (lists[i].Contains(second))
                {
                    target.Add(lists[i]);
                }
            }

            if (target.Count == 0)
            {
                Console.WriteLine("None");
                return;
            }
            for (int i = 0; i < target.Count; i++)
            {

                Console.WriteLine(target[i]);
            }
        }
    }
}
