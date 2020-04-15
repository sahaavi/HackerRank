using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_n = ReadLine().Split(' ');
        var k = int.Parse(tokens_n[1]);
        var ar_temp = ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var billChargedToAnna = int.Parse(ReadLine());
        WriteLine(BonAppetit(k, billChargedToAnna, ar));
    }

    static string BonAppetit(int allergicFoodIndex, int annasChargedBill, int[] ar)
    {
        var sharedFoodItemsBill = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (i != allergicFoodIndex)
                sharedFoodItemsBill += ar[i];
        }

        var annasShare = sharedFoodItemsBill / 2;
        return annasChargedBill == annasShare ? "Bon Appetit" : (annasChargedBill - annasShare).ToString();
    }
}
