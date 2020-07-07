using System;

namespace _620_A_Prof_Gukiz_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');

            int x1 = int.Parse(token[0]);
            int y1 = int.Parse(token[1]);
            
            string[] token1 = Console.ReadLine().Split(' ');

            int x2 = int.Parse(token1[0]);
            int y2 = int.Parse(token1[1]);

            int xdif = Math.Abs(x2 - x1);
            int ydif = Math.Abs(y2 - y1);

            if (ydif > xdif)
            {
                Console.WriteLine(ydif);
            }
            else
            {
                Console.WriteLine(xdif);
            }
        }
    }
}
