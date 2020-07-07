using System;
using System.Linq;

namespace _32_B_Borze
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '.')
                {
                    Console.Write('0');
                }
                else if (s[i] == '-' && s[i+1] == '.')
                {
                    Console.Write('1');
                    i += 1;
                }
                else if (s[i] == '-' && s[i + 1] == '-')
                {
                    Console.Write('2');
                    i += 1;
                }
            }
           
        }
    }
}
