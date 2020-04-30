using System;

class Solution {

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        
        int highestScore = scores[0];
        int lowestScore = scores[0];
        int highestScoreCount = 0;
        int lowestScoreCount = 0;

        for(int i=0; i<n; i++)
        {
            if(highestScore < scores[i])
            {
                highestScore = scores[i];
                highestScoreCount++;
            }
            else if(lowestScore > scores[i])
            {
                lowestScore = scores[i];
                lowestScoreCount++;
            }
        }
        Console.WriteLine(highestScoreCount +" "+ lowestScoreCount);
        
    }
}
