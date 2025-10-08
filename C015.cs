using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class e
    {
        static void ce(string[] args)
        {
            var firstLine = int.Parse(Console.ReadLine());
            int point = 0;
            for (int i = 0; i < firstLine; i++)
            {
                var line = Console.ReadLine().Split(' ');
                string a = line[0];
                int b = int.Parse(line[1]);


                //間違えたポイント
                //3がつく日を３で割り切れる日と勘違いしていた
                //5がつく日を５で割り切れる日と勘違いしていた
                if (a.Contains("3"))
                {
                    point += (int)Math.Floor(b * 0.03);
                }
                else if (a.Contains("5"))
                {
                    point += (int)Math.Floor(b * 0.05);
                }
                else
                {
                    point += (int)Math.Floor(b * 0.01);
                }
            }

            Console.WriteLine(point);
        }
    }
}
