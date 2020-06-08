using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            var tokens_n = Console.ReadLine().Split(' ');
            var initialJumpPower = Convert.ToInt32(tokens_n[1]);
            var height_temp = Console.ReadLine().Split(' ');
            var heightOfHurdles = Array.ConvertAll(height_temp, Int32.Parse);
            var maxHurdleHeight = heightOfHurdles.Max();
            if (maxHurdleHeight <= initialJumpPower)
                Console.WriteLine(0);
            else
                Console.WriteLine(maxHurdleHeight - initialJumpPower);
    }
}
