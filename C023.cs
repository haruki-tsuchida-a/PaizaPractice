using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class eic
    {
        static void Main(string[] args)
        {
            // 当選番号の読み込み
            var chooseDigit = Console.ReadLine().Split(' ');
            var winningNumbers = new HashSet<string>(chooseDigit);

            // 購入枚数
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var ticket = Console.ReadLine().Split(' ');
                int match = 0;
                foreach (var num in ticket)
                {
                    if (winningNumbers.Contains(num))
                    {
                        match++;
                    }
                }
                Console.WriteLine(match);
            }
        }
    }
}
