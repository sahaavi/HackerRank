using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        var totalTestCases = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < totalTestCases; a0++)
            {
                var tokens_n = Console.ReadLine().Split(' ');
                var cancellationThreshold = int.Parse(tokens_n[1]);
                var a_temp = Console.ReadLine().Split(' ');
                var studentEntryTimings = Array.ConvertAll(a_temp, Int32.Parse);
                var onTimeStudents = 0;
                foreach (var studentTiming in studentEntryTimings)
                {
                    if (studentTiming <= 0)
                        onTimeStudents++;

                    if (onTimeStudents == cancellationThreshold)
                        break;
                }

                if (onTimeStudents < cancellationThreshold)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
    }
}
