using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class cdfd
    {
        static void cdfcc(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int N = int.Parse(firstLine[0]);
            int K = int.Parse(firstLine[1]);

            var winningNumbers = new HashSet<string>(Console.ReadLine().Split(' '));
            var votes = Console.ReadLine().Split(' ');

            var result = new List<int>();
            for (int i = 0; i < K; i++)
            {
                if (winningNumbers.Contains(votes[i]))
                {
                    result.Add(i + 1);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                foreach (var id in result)
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}
