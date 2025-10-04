using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class Test
    {
        static void M(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var N = int.Parse(firstLine[0]);
            var M = int.Parse(firstLine[1]);
            List<string> list = new List<string>();
            var secondLine = Console.ReadLine().Split(' ');


            for (int i = 0; i < M; i++)
            {
                list.Add(secondLine[i]);
            }

            //末尾からN文字を抽出

            for (int i = 0; i < list.Count - 1; i++)
            {
                string before = list[i].Substring(list[i].Length - N);

                string after = list[i + 1].Substring(0, N);

                if (before != after)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                }
            }

            Console.WriteLine("YES");




        }
    }
}
