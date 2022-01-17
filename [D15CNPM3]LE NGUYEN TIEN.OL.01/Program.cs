using System;

namespace _D15CNPM3_LE_NGUYEN_TIEN.OL._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // chuong trinh giai phuong trinh bac nhat ax + b = 0 voi ax + b = 0 

            double a, b, x;

            Console.Write("Nhap a = "); a = Double.Parse(Console.ReadLine());

            Console.Write("Nhap b = "); b = Double.Parse(Console.ReadLine());

            if (a == 0)

            {

                if (b == 0) Console.WriteLine("Phuong trinh co vo so nghiem");

                else Console.WriteLine("Phuong trinh vo nghiem");

            }

            else

            {

                x = (-b / a);

                Console.WriteLine("Phuong trinh co nghiem duy nhat x = " + x);

            }

            Console.ReadLine();
        }
    }
}
