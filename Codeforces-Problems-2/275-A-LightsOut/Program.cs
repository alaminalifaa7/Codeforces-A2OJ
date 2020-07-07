using System;

namespace _275_A_LightsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] OnArray = new int[,]
               {
                    {1, 1, 1},
                    {1, 1, 1},
                    {1, 1, 1},
               };

            int[,] PressedArray = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    PressedArray[i, j] = Convert.ToInt32(s[j]);
                }
                
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(PressedArray[i,j] % 2 != 0)
                    {
                        OnArray[i, j] = 1 - OnArray[i, j];

                        if(j+1 < 3)
                        {
                            OnArray[i, j + 1] = 1 - OnArray[i, j + 1];
                        }
                        if(j-1 != -1)
                        {
                            OnArray[i, j - 1] = 1 - OnArray[i, j - 1];
                        }
                        if(i+1 < 3)
                        {
                            OnArray[i + 1, j] = 1 - OnArray[i + 1, j];
                        }
                        if(i -1 != -1)
                        {
                            OnArray[i - 1, j] = 1 - OnArray[i - 1, j];
                        }
                        
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {   if(i!=0)
                    Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(OnArray[i,j]);
                }
            }
        }
    }
}
