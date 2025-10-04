using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class t
    {
        static void te(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            List<char> firstList = first.ToList();
            List<char> secondList = second.ToList();

            for (int i = 0; i < N; i++)
            {
                if (firstList.SequenceEqual(secondList))
                {
                    Console.WriteLine("Yes");
                    return;
                }

                //間違えたポイント
                //firstList.Remove(0);
                //List.Removeはi番目の要素に該当する文字全てを削除してしまうため、RemoveAtを使用する必要がある
                // 先頭を末尾に移動

                char target = firstList[0];
                firstList.RemoveAt(0);
                firstList.Add(target);
            }

            Console.WriteLine("No");
        }
    }
}
