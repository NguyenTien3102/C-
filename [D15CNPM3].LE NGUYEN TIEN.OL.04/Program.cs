using System;

namespace _D15CNPM3_.LE_NGUYEN_TIEN.OL._04
{
    class SinhVien 
    {
        // Định nghĩa các thành phần của lớp 
        // Fields 
        private string MaSV;
        private string HoTen;
        private float diemTL, diemTH;


        public void Nhap()
        {
            public int getMaSV()
            {
                return maSV;
            }

            public void setMaSV(int maSV)
            {
                this.maSV = maSV;
            }

            public String getTenSV()
            {
                return tenSV;
            }

            public void setTenSV(String tenSV)
            {
                this.tenSV = tenSV;
            }

            public float getDiemTL()
            {
                return diemTL;
            }

            public void setDiemTL(float diemTL)
            {
                this.diemTL = diemTL;
            }

            public float getDiemTH()
            {
                return diemTH;
            }

            public void setDiemTH(float diemTH)
            {
                this.diemTH = diemTH;
            }
            // tính điểm trung bình 
            public float tinhDiemTB()
            {
                return (diemTH + diemTL) / 2;
            }
            public void Xuat() 

            public String toString()
            {
                return maSV + " - " + tenSV + " diem Tb : " + tinhDiemTB();
            }
        }

    }
}
