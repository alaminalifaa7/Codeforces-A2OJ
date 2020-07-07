using System;
using System.Collections.Generic;

namespace _110_A_Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count=0;


            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '4' || s[i] == '7')
                {
                    count++;
                }
            }
            if(count == 4 || count == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Dictionary<char, int> s1 = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!s1.ContainsKey(s[i]))
            //    {
            //        s1.Add(s[i], 1);
            //    }
            //    else
            //    {
            //        s1[s[i]] += 1;
            //    }
            //}


            //if( s1.ContainsKey('4') && s1.ContainsKey('7'))
            //{
            //     number = s1['4'] + s1['7'];
            //}

            //else if (s1.ContainsKey('4'))
            //{
            //    number = s1['4'];
            //}
            //else if (s1.ContainsKey('7'))
            //{
            //    number = s1['7'];
            //}
            //string s2 = number.ToString();
            //bool number1 =false;

            //for (int i = 0; i < s2.Length; i++)
            //{
            //    if (s2[i] == '4' || s2[i] == '7')
            //    {
            //        number1 = false;
            //    }
            //    else
            //    {
            //        number1 = true;
            //        break;
            //    }
            //}

            //if (number1)
            //{
            //    Console.WriteLine("NO");
            //}
            //else
            //{
            //    Console.WriteLine("YES");
            //}
            

        }
    }
}
