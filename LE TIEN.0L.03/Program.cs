using System;

namespace LE_TIEN._0L._03
{
    class Program
    {
        public static void main()
        {
            int a, b, c;
            double delta, x1, x2;
            Console.Write(" nhap gia tri cua a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" nhap gia tri cua b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" nhap gia tri cua c: ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                Console.Write("phuong trinh co nghiem duy nhat.\n");
                x1 = -b / (2 * a);
                x2 = x1;
                Console.Write("nghiem duy nhat caur phuong trinh la = {0}\n", x1);
            }
            else if (delta > 0)
            {
                Console.Write("phuong trinh co hai nghiem phan biet.\n");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.Write("nghiem thu nhat x1: {0}\n", x1);
                Console.Write("nghiem thu hai x2: {0}\n", x2);
            }
            else
                Console.Write("phuong trinh vo nghiem\n\n");

        }
    }
}
