using System;

class Solution {
    static void plusMinus(int[] arr) {
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeroNumbers = 0;

        for (int arr_i = 0; arr_i < arr.Length; arr_i++)
        {
            if (arr[arr_i] > 0)
                ++positiveNumbers;
            else if (arr[arr_i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
        }
        Console.WriteLine((double)positiveNumbers / arr.Length);
        Console.WriteLine((double)negativeNumbers / arr.Length);
        Console.WriteLine((double)zeroNumbers / arr.Length);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
