using System;
using System.Text;
using System.Threading;
public class PrintBoard
{
    public static bool[,] print(bool[,] b, int width, int height)
    {
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (b[x, y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
        b = nextGen.calcNext(b);
        Thread.Sleep(200);
        return b;
    }
}