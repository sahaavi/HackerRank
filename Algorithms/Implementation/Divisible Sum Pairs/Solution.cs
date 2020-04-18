using System;
using static System.Console;

class Solution
{
    static int DivisibleSumPairs(int k, int[] ar)
    {
        var divisiblePairCount = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = i + 1; j < ar.Length; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                    divisiblePairCount++;
            }
        }

        return divisiblePairCount;
    }

    static void Main(String[] args)
    {
        var tokens_n = ReadLine().Split(' ');
        var k = int.Parse(tokens_n[1]);
        var ar_temp = ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var result = DivisibleSumPairs(k, ar);
        WriteLine(result);
    }
}
