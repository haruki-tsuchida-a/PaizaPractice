using System;

namespace PaizaPractice
{
    internal class td
    {
        static void ain(string[] args)
        {
            //0～9のダイヤル距離
            int[] dialDistances = { 12, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var input = Console.ReadLine();
            int total = 0;

            foreach (char c in input)
            {
                //入力値が数字だったら合計を足す
                if (char.IsDigit(c))
                {
                    int num = int.Parse(c.ToString());
                    total += dialDistances[num] * 2;
                }
            }

            Console.WriteLine(total);
        }
    }
}
