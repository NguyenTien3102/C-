using System;

namespace LE_NGUYEN_TIEN.OL._03.T
{
    class Program
    {
        public static void main()
        {
            int[] arr;
            int n;
            Console.Write(" nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            // nhap phan tu cho array
            for ( int i=0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // arr = arr.OrderBy(x => x).ToArray
            {
                if (n == 2)
                    Console.Write("so da cho la so nguyen to");
                else
                    Console.Write("so da cho khong phai la so nguy to");
            }
            // xuat phan tu cho array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
