using System;
using System.Linq;

namespace _158_A_Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int n = int.Parse(token[0]);
            int k = int.Parse(token[1]);
            int output = 0;
            string[] token1 = Console.ReadLine().Split(' ');

            int[] token2 = Array.ConvertAll(token1, int.Parse);

            for (int i = 0; i < token2.Length; i++)
            {
                if(token2[i] >= token2[k-1] && token2[i] > 0)
                {
                    output = output + 1;
                }

            }
            Console.WriteLine(output);

        }

    }
}
