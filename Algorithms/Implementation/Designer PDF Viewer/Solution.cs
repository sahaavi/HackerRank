using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            var h_temp = Console.ReadLine().Split(' ');
            var inputHeights = Array.ConvertAll(h_temp, Int32.Parse);
            var alphabetHeight = new Dictionary<char, int>();

            var alphabet = 'a';
            foreach (var height in inputHeights)
            {
                alphabetHeight.Add(alphabet++, height);
            }

            var maxAlphabetHeight = 0;
            string word = Console.ReadLine();
            foreach (var letter in word)
            {
                if (alphabetHeight[letter] > maxAlphabetHeight)
                {
                    maxAlphabetHeight = alphabetHeight[letter];
                }
            }

            var areaOfSelectedText = maxAlphabetHeight * word.Length;
            Console.WriteLine(areaOfSelectedText);
    }
}
