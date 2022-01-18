using System;

namespace LE_NGUYEN_TIEN._0L._02_
{
    class Program
    {
        public static void nhap so nguyen duong n va hien thi ra man hinh
        {
            int[] arr;
        int n;
        Console.Write(" nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            // nhap phan tu cho array
            for(int i=0;i<arr.Langth; i++)
            {
            Console.Write($"arr[{i}] = ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            }
    //arr = arr.OrderBy(x => x). ToArray();

    // Xuaat phan tu cho array
    for (int i = 0; i<Array.Length; i++)
        { 
          console.Write($"{arr[i]} ")
           }
         }
    }
}
