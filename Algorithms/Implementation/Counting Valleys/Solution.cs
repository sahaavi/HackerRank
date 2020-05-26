using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int countingValleys(int n, string s) {
        int seaLevel=0;
        int valleyCount = 0;
        var isValleyActive = false;
        char[] arr;
        arr = s.ToCharArray(0, n);
            for(int i=0; i<n; i++){
                if(s[i]=='U'){
                    seaLevel++;
                }
                else{
                    seaLevel--;
                }
                if (!isValleyActive && seaLevel < 0)
                {
                    isValleyActive = true;
                }

                if (isValleyActive && seaLevel == 0)
                {
                    valleyCount++;
                    isValleyActive = false;
                }
            }
            return valleyCount;
    }

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine(result);

    }
}
