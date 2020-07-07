using System;


namespace _59_A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int u=0,l=0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    u += 1;
                }
                else
                {
                    l += 1;
                }
                
            }

            if (u > l)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s.ToLower());
            }
            
        }
    }
}
