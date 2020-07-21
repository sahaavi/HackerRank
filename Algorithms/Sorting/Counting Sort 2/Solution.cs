using System;
class Solution
{
    static int[] countingSort(int[] inputNumbers)
    {
        var numberFrequency = new int[100];
        for (var i = 0; i < inputNumbers.Length; i++)
            numberFrequency[inputNumbers[i]] += 1;

        for (var i = 1; i < 100; i++)
            numberFrequency[i] += numberFrequency[i - 1];

        var sortedOutput = new int[inputNumbers.Length];

        for (var i = 0; i < inputNumbers.Length; i++)
        {
            var num = inputNumbers[i];
            var position = numberFrequency[num];
            numberFrequency[num] -= 1;
            sortedOutput[position - 1] = num;
        }
        return sortedOutput;
    }

    static void Main(String[] args)
    {

        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = countingSort(arr);
        Console.WriteLine(string.Join(" ", result));
    }
}
