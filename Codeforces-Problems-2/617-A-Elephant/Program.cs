using System;

namespace _617_A_Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());


            if(n%5 == 0)
            {
                Console.WriteLine(n / 5);
            }
                
            else
            {
                Console.WriteLine((n/5) +1);
            }

        }
    }
}
