using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        var t = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                var numberOfCycles = int.Parse(Console.ReadLine());
                var finalHeightOfSapling = 1;
                bool isSpring = true;
                while (numberOfCycles > 0)
                {
                    if (isSpring)
                    {
                        finalHeightOfSapling *= 2;
                        isSpring = false;
                    }
                    else
                    {
                        finalHeightOfSapling++;
                        isSpring = true;
                    }
                    numberOfCycles--;
                }
                Console.WriteLine(finalHeightOfSapling);
            }
    }
}
