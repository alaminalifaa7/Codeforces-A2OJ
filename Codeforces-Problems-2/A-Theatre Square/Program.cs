using System;

namespace A_Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] token = Console.ReadLine().Split(' ');

            var n = decimal.Parse(token[0]);
            var m = decimal.Parse(token[1]);
            var a = decimal.Parse(token[2]);

            Console.WriteLine(Math.Ceiling(n/a)* Math.Ceiling(m / a));
        }
    }
}
