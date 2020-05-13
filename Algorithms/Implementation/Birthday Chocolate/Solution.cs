using System;
using static System.Console;

class Solution
{

    static void Main(String[] args)
    {
        //No need to capture number of squares in the choclate bar. I use array's length property instead.
        ReadLine();
        var s_temp = Console.ReadLine().Split(' ');
        var choclateBarValues = Array.ConvertAll(s_temp, Int32.Parse);
        var tokens_d = Console.ReadLine().Split(' ');
        var birthday = Convert.ToInt32(tokens_d[0]);
        var birthMonth = Convert.ToInt32(tokens_d[1]);
        var result = Solve(choclateBarValues, birthday, birthMonth);
        WriteLine(result);
    }

    static int Solve(int[] choclateBarValues, int birthday, int birthMonth)
    {
        var totalWays = 0;

        if (choclateBarValues.Length >= birthMonth)
        {
            var barPartSum = 0;
            for (int i = 0; i < birthMonth; i++)
                barPartSum += choclateBarValues[i];

            if (barPartSum == birthday)
                totalWays++;

            for (int i = 0; i < choclateBarValues.Length - birthMonth; i++)
            {
                barPartSum = barPartSum - choclateBarValues[i] + choclateBarValues[i + birthMonth];

                if (barPartSum == birthday)
                    totalWays++;
            }
        }
        return totalWays;
    }
}
