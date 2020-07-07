using System;
using System.Linq;

namespace _271_A_Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int y = Convert.ToInt32(s) + 1;
            string s1 = y.ToString();


            while (s1.Distinct().Count() != s1.Length)
            {
                y = y + 1;
                s1 = y.ToString();
            }

            Console.WriteLine(s1);
        }
    }
}
