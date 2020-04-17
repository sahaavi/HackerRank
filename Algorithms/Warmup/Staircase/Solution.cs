using System;

class Solution {
    static void staircase(int n) {
        for (int i = 1; i <= n; i++)
        {
            var spaces = new String(' ', n - i);
            var hashes = new String('#', i);
            Console.WriteLine(spaces + hashes);
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
