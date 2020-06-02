using System;

class Solution
{
    static void Main(String[] args)
    {
        var numberOfTestCases = int.Parse(Console.ReadLine());
        for (int a0 = 0; a0 < numberOfTestCases; a0++)
        {
            var n = Console.ReadLine();
            var number = int.Parse(n);
            var digitCount = 0;
            foreach (var item in n)
            {
                if (item == '0')
                    continue;

                if (number % (int)char.GetNumericValue(item) == 0)
                    digitCount++;
            }
            Console.WriteLine(digitCount);
        }
    }
}
