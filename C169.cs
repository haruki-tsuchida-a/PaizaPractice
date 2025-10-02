namespace PaizaPractice
{
    internal class C169
    {
        static void Test(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var X = int.Parse(Console.ReadLine());
            int totalPoint = 0;
            for (int i = 1; i <= 7; i++)
            {
                totalPoint += N;
                N = (N * X) / 100; // 小数点以下切り捨て
            }
            Console.WriteLine(totalPoint);
        }
    }
}