using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
       
    class Program
    {

        static void Main(string[] args)
        {
            int maSV = 232423;
            string hoTen = "linh";
            float diemLT = 9;
            float diemTH = 8;
            QLSV sv1 = new QLSV(maSV, hoTen, diemLT, diemTH);
            sv1.DiemTB();

            maSV = 345544;
            hoTen = "kieu";
            diemLT = 7;
            diemTH = 9;
            QLSV sv2 = new QLSV(maSV, hoTen, diemLT, diemTH);
            sv2.DiemTB();

            Console.Write("Nhap masv:");
            maSV = int.Parse(Console.ReadLine());
            Console.Write("nhap ho ten:");
            hoTen = Console.ReadLine();
            Console.Write("Nhap diem LT:");
            diemLT = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem TH:");
            diemTH = float.Parse(Console.ReadLine());
            QLSV sv3 = new QLSV(maSV, hoTen, diemLT, diemTH);
            sv3.DiemTB();

            Console.WriteLine($"{"MaSV",-20}{"HoTen",-15}{"DiemLT",10}{"DiemTH",15} {"DiemTB",20}");
            Console.WriteLine($"{sv1.MaSV,-20}{sv1.HoTen,-15}{sv1.DiemLT,10}{sv1.DiemTH,15}{sv1.DiemTB(),20}");
            Console.WriteLine($"{sv2.MaSV,-20}{sv2.HoTen,-15}{sv2.DiemLT,10}{sv2.DiemTH,15}{sv2.DiemTB(),20}");
            Console.WriteLine($"{sv3.MaSV,-20}{sv3.HoTen,-15}{sv3.DiemLT,10}{sv3.DiemTH,15}{sv3.DiemTB(),20}");
            
            Console.ReadLine();




        }
    }
}
