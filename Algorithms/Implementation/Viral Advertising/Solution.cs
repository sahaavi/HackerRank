using System;

class Solution {

    static int viralAdvertising(int n) {
        int shared=5;
        int liked=0;
        int cumulative=0;
        for(int i=0;i<n;i++){
            liked = shared/2;
            cumulative=cumulative+liked;
            shared=liked*3;
        }
        return cumulative;
    }

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n);

        Console.WriteLine(result);
    }
}
