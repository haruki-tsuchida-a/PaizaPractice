using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class test
    {
        //2025/10/03
        //文字列の比較
        static void Test(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string S = Console.ReadLine();
                string T = Console.ReadLine();

                // 文字列を並べ替えて一致するか判定
                char[] sArr = S.ToCharArray();
                char[] tArr = T.ToCharArray();
                Array.Sort(sArr);
                Array.Sort(tArr);


                //間違えたポイント
                //sArr == tArrではダメ
                //char型は参照型だから同じ値でもfalseになってしまうから比較するときはnew stringで文字列に変換してから比較する
                if (new string(sArr) == new string(tArr))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
