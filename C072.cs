using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class fdeef
    {
        static void dfe(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var attack = int.Parse(firstLine[0]);
            var defense = int.Parse(firstLine[1]);
            var agility = int.Parse(firstLine[2]);

            var conditions = new List<(string, int, int, int, int, int, int)>();

            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                var name = elements[0];
                var minAtack = int.Parse(elements[1]);
                var maxAtack = int.Parse(elements[2]);
                var minDefense = int.Parse(elements[3]);
                var maxDefense = int.Parse(elements[4]);
                var minAgility = int.Parse(elements[5]);
                var maxAgility = int.Parse(elements[6]);
                conditions.Add((name, minAtack, maxAtack, minDefense, maxDefense, minAgility, maxAgility));
            }
            int count = 0;
            foreach (var condition in conditions)
            {
                var name = condition.Item1;
                var minAtack = condition.Item2;
                var maxAtack = condition.Item3;
                var minDefense = condition.Item4;
                var maxDefense = condition.Item5;
                var minAgility = condition.Item6;
                var maxAgility = condition.Item7;
                if (attack >= minAtack && attack <= maxAtack &&
                    defense >= minDefense && defense <= maxDefense &&
                    agility >= minAgility && agility <= maxAgility)
                {
                    Console.WriteLine(name);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no evolution");
            }
        }
    }
}