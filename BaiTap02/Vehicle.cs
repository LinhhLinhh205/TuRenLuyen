using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Vehicle
    {
        private string tenchuxe;
        private string loaixe;
        private int dungtich;
        private int trigia;
        
        public Vehicle(string tenchuxe,string loaixe,int dungtich,int trigia)
        {
            this.tenchuxe = tenchuxe;
            this.loaixe = loaixe;
            this.dungtich = dungtich;
            this.trigia = trigia;
        }
        public string Tenchuxe
        {
            get { return tenchuxe; }
            set { tenchuxe = value; }
        }
        public string Loaixe
        {
            get { return loaixe; }
            set { loaixe = value; }
        }
        public int Dungtich
        {
            get { return dungtich; }
            set { dungtich = value; }
        }
        public int Trigia
        {
            get { return trigia; }
            set { trigia = value; }
        }
        public double Thue()
        {
            double thuephainop;
            if (dungtich < 100)
                thuephainop = 0.1 * trigia;
            else if (dungtich >= 100 && dungtich < 200)
                thuephainop = 0.3 * trigia;
            else thuephainop = 0.5 * trigia;
            return thuephainop;

        }


    }
}
