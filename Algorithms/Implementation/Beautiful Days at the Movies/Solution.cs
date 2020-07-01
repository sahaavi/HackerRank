using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        var userInput = Console.ReadLine().Split();
        var i = int.Parse(userInput[0]);
        var j = int.Parse(userInput[1]);
        var k = int.Parse(userInput[2]);
        var beautifulDays = 0;

        for (int c = i; c <= j; c++)
        {
            var reverseString = new string(c.ToString().Reverse().ToArray());
            var reverseNumber = int.Parse(reverseString);
            var d = Math.Abs(c - reverseNumber);
            var r = d % k;

            if (r == 0)
                beautifulDays++;
        }
        Console.WriteLine(beautifulDays);

    }
}
