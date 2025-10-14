using System;

namespace PaizaPractice
{
    internal class dccfed
    {
        static void cdf(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ');
            var line = Console.ReadLine().Split(' ');

            var T = int.Parse(line[0]); // 初期所持金
            var Q = int.Parse(line[1]); // 注文数

            int money = T;

            for (int i = 0; i < Q; i++)
            {
                var tempLine = Console.ReadLine().Split();
                int itemIndex = int.Parse(tempLine[0]) - 1; // 1始まり→0始まり
                int count = int.Parse(tempLine[1]);
                int cost = int.Parse(numbers[itemIndex]) * count;

                if (money >= cost)
                {
                    money -= cost;
                }
            }

            Console.WriteLine(money);
        }
    }
}
