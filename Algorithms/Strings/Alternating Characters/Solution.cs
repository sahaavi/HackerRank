using System;

class Solution {


    static void Main(string[] args) {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int deleteCount =0;
            for(int i =0 ; i < s.Length-1; i++){
                if (s[i]==s[i+1]){
                    deleteCount++;
                }
            }

            Console.WriteLine(deleteCount);
        }
    }
}
