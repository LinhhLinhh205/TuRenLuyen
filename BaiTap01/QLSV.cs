using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class QLSV
    {
        private int maSV;
        private string hoTen;
        private float diemLT;
        private float diemTH;

        public QLSV()
        {
            maSV = 0;
            hoTen = " ";
            diemLT = 0;
            diemTH = 0;
        }
        public QLSV(int MaSV, string HoTen, float DiemLT, float DiemTH)
        {
            this.maSV = MaSV;
            this.hoTen = HoTen;
            this.diemLT = DiemLT;
            this.diemTH = DiemTH;
        }
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public float DiemLT
        {
            get { return diemLT; }
            set { diemLT = value; }
        }
        public float DiemTH
        {
            get { return diemTH; }
            set { diemTH = value; }
        }
        public float DiemTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public string ToString()
        {
            return $"{maSV}-{hoTen}-{diemLT}-{diemTH}-{DiemTB()}";
        }
    }
}
