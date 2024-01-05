using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten chu xe:");
            string tenchuxe = Console.ReadLine();
            Console.Write("Nhap loai xe:");
            string loaixe = Console.ReadLine();
            Console.Write("Nhap dung tich:");
            int dungtich = int.Parse(Console.ReadLine());
            Console.Write("Nhap tri gia:");
            int trigia = int.Parse(Console.ReadLine());

            Vehicle xe1 = new Vehicle(tenchuxe, loaixe, dungtich, trigia);

            Console.Write("Nhap ten chu xe:");
            tenchuxe = Console.ReadLine();
            Console.Write("Nhap loai xe:");
            loaixe = Console.ReadLine();
            Console.Write("Nhap dung tich:");
            dungtich = int.Parse(Console.ReadLine());
            Console.Write("Nhap tri gia:");
            trigia = int.Parse(Console.ReadLine());

            Vehicle xe2 = new Vehicle(tenchuxe, loaixe, dungtich, trigia);

            Console.WriteLine($"{"Ten chu xe",-20}{"Loai xe",-15}{"Dung tich",10}{"Tri gia",20}");
            Console.WriteLine($"{xe1.Tenchuxe,-20}{xe1.Loaixe,-15}{xe1.Dungtich,10}{xe1.Trigia,20}");
            Console.WriteLine($"{xe2.Tenchuxe,-20}{xe2.Loaixe,-15}{xe2.Dungtich,10}{xe2.Trigia,20}");
            Console.ReadLine();


        }
    }
}
