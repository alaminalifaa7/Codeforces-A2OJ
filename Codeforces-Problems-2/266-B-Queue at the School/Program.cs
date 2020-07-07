using System;

namespace _266_B_Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');

            int n = int.Parse(token[0]);
            int t = int.Parse(token[1]);

            string s = Console.ReadLine();
            char[] c = s.ToCharArray();

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if(c[j] == 'B' && c[j+1] == 'G')
                    {
                        char temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                        j += 1;
                    }
                }
            }

            foreach (var item in c)
            {
                Console.Write(item);
            }
        }
    }
}
