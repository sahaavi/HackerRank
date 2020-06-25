using System;

class Solution
{
    private static int CamelCase()
    {
        var wordCount = 1;
        var nextChar = Console.Read();
        
        while (nextChar != -1)
        {
            if (char.IsUpper((char)nextChar))
                wordCount++;
            nextChar = Console.Read();
        }
        return wordCount;
    }

    static void Main(string[] args)
    {
        var result = CamelCase();
        Console.WriteLine(result);
    }
}
