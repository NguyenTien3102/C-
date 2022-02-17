using System;

namespace _D15CNPM3_.LE_NGUYEN_TIEN.OL._04
{
    class SinhVien 
    {
        // Định nghĩa các thành phần của lớp 
        // Fields 
        private string MaSV;
        private string HoTen;
        private string DTB;
        private string Lop;


        public void Nhap()
        {
            Console.Write("Ma SV: ");
            MaSV = Console.ReadLine();
            Console.Write("Ten SV: ");
            HoTen = Console.ReadLine();
            Console.Write("DTB: ");
            DTB = Console.ReadLine();
            Console.Write("Lop: ");
            Lop = Console.WriteLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"{MaSV}\t{HoTen}\t{DTB}");
        }

    }
}
