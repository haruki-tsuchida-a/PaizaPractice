using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class fer
    {
        static void ecfd(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(n => n).ToList();

            int totalScore = 0;
            int groupMax = numbers[0];

            for (int i = 1; i < N; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1)
                {
                    // 連続している場合、グループ最大値を更新
                    groupMax = numbers[i];
                }
                else
                {
                    // 連続が途切れたら、グループ最大値を加算し、新しいグループ開始
                    totalScore += groupMax;
                    groupMax = numbers[i];
                }
            }
            // 最後のグループの最大値を加算
            totalScore += groupMax;

            Console.WriteLine(totalScore);
        }
    }
}