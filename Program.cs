// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();
        //Console.WriteLine(GetData("test.txt"));
        string directionStr = GetData("input.txt");
        string[] directions = directionStr.Split("\n");

        int position = 50;
        char dir = ' ';
        int moves = 0;
        int count = 0;

        for (int i = 0; i < directions.Length - 1; i++)
        {
                dir = directions[i][0];
                moves = Convert.ToInt32(directions[i].Substring(1));
                if (dir == 'L')
                {
                    moves = 0 - moves;
                }
                position = (position + moves) % 100;
                if (position < 0)
                {
                    position = 100 + position;
                }
                Console.WriteLine($"Turning {moves}, current position is {position}");
                if (position == 0)
                {
                    count++;
                }
        }
        
        Console.WriteLine(count);


    }

    static string GetData(string filename)
    {
        return System.IO.File.ReadAllText(filename);
    }
}
