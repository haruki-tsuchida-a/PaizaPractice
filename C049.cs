using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class Tes
    {
        static void Test(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int result = 0;
            int current = 1;

            for (int i = 0; i < N; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in list)
            {
                result += Math.Abs(item - current);
                current = item;
            }

            Console.WriteLine(result);
        }
    }
}
