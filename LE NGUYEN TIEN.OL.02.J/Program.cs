using System;

namespace LE_NGUYEN_TIEN.OL._02
{
    class Program
    {
        public static void matran() 
        {
            int[][] M = new int[2][];
            // nhap ma tran 
            for (int i = 0; i<2; i++)
            {
                // cap phat so cot cho hang thu i 
                M[i] = new int[3];
                for (int j = 0; j < M[i].Length; j++)
                {
                    Console.Write($"M[{i}][{j}] = ");
                    M[i][j] = Convert.ToInt32(Console.Readline());
                }
            }
            // hien thi ma tran 
            for (int i = 0; i < 2 ; i++)
            {
                for (int j = 0; j < M[i].Length; j++)
                {
                    Console.Write($"{M[i][j]} ");
                        }
                Console.Write("\n");
            }
        }
    }
}
