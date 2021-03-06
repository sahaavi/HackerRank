using System;

class Solution
{
    static void Main(string[] args)
    {
        var queryCount = int.Parse(Console.ReadLine());

        for (var i = 0; i < queryCount; i++)
        {
            var nextIndex = 0;
            var searchPattern = "hackerrank";

            var nextChar = Console.Read();
            //special handling for hacker rank execution environment. I went crazy to figure out this condition
            //hacker rank uses \n line feed character (ASCII code 10) for changing line for next test case and -1 as end of file which marks the end of last test case 
            //In Windows it is \r\n so while running on my computer I compare it against 13 only.

            while (nextChar != 10 && nextChar != -1)
            {
                if (nextIndex < 10 && (char)nextChar == searchPattern[nextIndex])
                    nextIndex++;

                nextChar = Console.Read();
            }
            if (nextIndex == 10)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
