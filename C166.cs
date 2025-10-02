using System;
class Program
{
    //2025/10/02
    //ちょうどの支払い
    static void Test()
    {
        int input = int.Parse(Console.ReadLine());

        int result = 0;
        result += Judge(ref input, 500);
        result += Judge(ref input, 100);
        result += Judge(ref input, 50);
        result += Judge(ref input, 10);
        result += Judge(ref input, 5);
        result += Judge(ref input, 1);
        Console.WriteLine(result);
    }



    public static int Judge(ref int input, int money)
    {
        int count = 0;

        while (input >= money)
        {
            input -= money;
            count++;
        }

        return count;
    }
}