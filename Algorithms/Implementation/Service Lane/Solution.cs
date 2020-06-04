using System;

class Solution
{
    static void ServiceLane(int[] serviceLaneWidths, int[][] cases)
    {
        for (int i = 0; i < cases.Length; i++)
        {
            var entryIndex = cases[i][0];
            var exitIndex = cases[i][1];

            var minWidth = 3;//for truck
            for (int j = entryIndex; j <= exitIndex; j++)
            {
                if (serviceLaneWidths[j] < minWidth)
                    minWidth = serviceLaneWidths[j];

                //a portion of service lane is allowing only bikes so no more traversal is required.
                if (minWidth == 1)
                    break;
            }
            Console.WriteLine(minWidth);
        }
    }
    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        var t = int.Parse(tokens_n[1]);
        var width_temp = Console.ReadLine().Split(' ');
        var width = Array.ConvertAll(width_temp, Int32.Parse);
        var cases = new int[t][];
        for (var cases_i = 0; cases_i < t; cases_i++)
        {
            var cases_temp = Console.ReadLine().Split(' ');
            cases[cases_i] = Array.ConvertAll(cases_temp, Int32.Parse);
        }
        ServiceLane(width, cases);
    }
}
