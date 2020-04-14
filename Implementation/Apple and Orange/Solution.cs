using System;

class Solution
{
    static void Main(String[] args)
    {
        var applesFallingOnHouse = 0;
        var orangesFallingOnHouse = 0;

        var tokens_s = Console.ReadLine().Split(' ');
        var houseStart = int.Parse(tokens_s[0]);
        var houseEnd = int.Parse(tokens_s[1]);

        var tokens_a = Console.ReadLine().Split(' ');
        var appleTreePosition = int.Parse(tokens_a[0]);
        var OrangeTreePosition = int.Parse(tokens_a[1]);

        //No need to capture number of apples and oranges as I use foreach loop to iterate them.
        Console.ReadLine();

        var apple_temp = Console.ReadLine().Split(' ');
        var fallingApples = Array.ConvertAll(apple_temp, Int32.Parse);
        var orange_temp = Console.ReadLine().Split(' ');
        var fallingOranges = Array.ConvertAll(orange_temp, Int32.Parse);

        foreach (var fallingApple in fallingApples)
        {
            var fallingApplePosition = appleTreePosition + fallingApple;
            if (fallingApplePosition >= houseStart && fallingApplePosition <= houseEnd)
                ++applesFallingOnHouse;
        }

        foreach (var fallingOrange in fallingOranges)
        {
            var fallingOrangePosition = OrangeTreePosition + fallingOrange;
            if (fallingOrangePosition >= houseStart && fallingOrangePosition <= houseEnd)
                ++orangesFallingOnHouse;
        }

        Console.WriteLine(applesFallingOnHouse);
        Console.WriteLine(orangesFallingOnHouse);
    }
}
