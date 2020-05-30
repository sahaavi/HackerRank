using System;
using System.Text;

class Solution {

    static string superReducedString(string s) {

        var sb = new StringBuilder();
        sb.Append(s[0]);
    
        for(int i=1;i<s.Length;i++){
               if (sb.Length > 0 && s[i] == sb[sb.Length - 1])
                sb = sb.Remove(sb.Length - 1, 1);
            else
                sb.Append(s[i]);
        }
        
        return sb.ToString();

    }

    static void Main(string[] args) {

        string s = Console.ReadLine();

        string result = superReducedString(s);

        Console.WriteLine(result == "" ? "Empty String" : result);
    }
}
