using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap05
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyCD quanly = new QuanLyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("**********QLCD**********");
                Console.WriteLine("1. Them CD:");
                Console.WriteLine("2.  Tinh gia thanh trung binh:");
                Console.WriteLine("3. Sap xep giam gia thanh:");
                Console.WriteLine("4. Sap xep tang tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("0. Thoat");

                Console.WriteLine("------------------------");
                Console.Write("Ban chon:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma cd:");
                        cd.Macd = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD:");
                        cd.Tuacd = Console.ReadLine();
                        Console.Write("Nhap ca si:");
                        cd.Casy = Console.ReadLine();
                        Console.Write("Nhap so bai hat:");
                        cd.Sobaihat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh:");
                        cd.Giathanh = int.Parse(Console.ReadLine());
                        quanly.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanly.TinhTB();
                        Console.WriteLine("Gia thanh trung binh : {0:#,##0.00}", kq);
                        break;
                    case 3: //s
                        quanly.SapXepGiamGiaThanh();
                        Console.WriteLine("Da sap them theo gia thanh giam dan");
                        break;
                    case 4:
                        quanly.SapXepTangTuaCD();
                        Console.WriteLine("Da sap tang dan theo tua cd");
                        break;
                    case 5:
                        quanly.Xuat();
                        break;

                }

            } while (chon != 0);
            Console.ReadLine();
        }
    }
}
