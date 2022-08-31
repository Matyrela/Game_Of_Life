using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        public static void Main(String[] args)
        {
            bool[,] b = LeerArchivo.archivo("C:\\Users\\matia\\Desktop\\Game_Of_Life\\assets\\board.txt");
            int width = b.GetLength(0);
            int height = b.GetLength(1);

            while (true)
            {
                Console.Clear();
                b = PrintBoard.print(b, width, height);
            }
        }
    }
}
