using System;

class Solution {

    static long aVeryBigSum(long[] ar) {
        long finalSum=0L;
        for (int i = 0; i < ar.Length; i++)
            finalSum += ar[i];
        return finalSum;
    }

    static void Main(string[] args) {
         int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar);

        Console.WriteLine(result);

       
    }
}
