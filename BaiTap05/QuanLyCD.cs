using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap05
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;

        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if (n >= ds.Length)
                Console.WriteLine("Danh sach da day");
            else
            {
                if (!KiemTraTrungCD(cd.Macd))
                    ds[n++] = cd;
                else Console.WriteLine("Trung ma Cd");
            }
        }
        private bool KiemTraTrungCD(int macd)
        {
            for(int i = 0; i < n; i++)
            {
                if (ds[i].Macd == macd)
                {
                    return true;
                }
                
            }
            return false;
        }
        public double TinhTB()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += ds[i].Giathanh;
            }
            return (double)tong / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0, 10} {1,30} {2,30} {3,10} {4, 15}", "MaCD", "Tua CD", "Ca si", "So bai hat", "Gia thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepGiamGiaThanh()
        {
            CD sapxep;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (ds[i].Giathanh < ds[j].Giathanh)
                    {
                        sapxep = ds[i];
                        ds[i] = ds[j];
                        ds[j] = sapxep;
                    }
                        
                }
            }
        }
        public void SapXepTangTuaCD()
        {
            
            CD tang;
            for(int i = 0; i < n-1 ; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (ds[i].Tuacd.CompareTo(ds[j].Tuacd)>0)
                    {
                        
                        tang = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tang;
                    }
                }
            }
        }
    }
}
