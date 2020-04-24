using System;

class Solution {

    static void Main(string[] args) {
        

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        var sameLocationPossible = "";
        if (x1 < x2 && v1 < v2)
            sameLocationPossible = "NO";

        else if (x2 < x1 && v2 < v1)
            sameLocationPossible = "NO";

        else if (x2 < x1)
        {
            //v2 > v1
            var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        else
        {
            //v1 > v2
            var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        Console.WriteLine(sameLocationPossible); 
    }

 }

