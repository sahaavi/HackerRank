using System;

class Solution
{
    static int IntroTutorial(int v, int[] arr)
    {
        var i = 0;
        for (; i < arr.Length; i++)
        {
            if (arr[i] == v)
                break;
        }
        return i;
    }

    static void Main(String[] args)
    {
        var v = int.Parse(Console.ReadLine())
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);
        var result = IntroTutorial(v, arr);
        Console.WriteLine(result);
    }
}
