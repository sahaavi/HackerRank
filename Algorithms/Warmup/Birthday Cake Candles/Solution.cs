using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        ReadLine();
        var height_temp = ReadLine().Split(' ');
        var height = Array.ConvertAll(height_temp, int.Parse);
        var maxValue = height[0];
        var maxValueOccurence = 1;

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] == maxValue)
            {
                maxValueOccurence++;
                continue;
            }
            if (height[i] > maxValue)
            {
                maxValue = height[i];
                maxValueOccurence = 1;
            }
        }
        WriteLine(maxValueOccurence);
    }
}
