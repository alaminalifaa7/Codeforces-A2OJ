using System;
using System.Linq;

namespace _69_A_Young_Physicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sumX = 0;
            int sumY = 0;
            int sumZ = 0;

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split(' ');

                int[] token1 = Array.ConvertAll(token, int.Parse);

                sumX = sumX + token1[0];
                sumY = sumY + token1[1];
                sumZ = sumZ + token1[2];

            }
            if (sumX == 0 && sumY == 0 && sumZ == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
