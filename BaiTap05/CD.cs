using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap05
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casy;
        private int sobaihat;
        private int giathanh;

        public CD()
        {

        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd,string tuacd,string casy,int sobaihat,int giathanh)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casy = casy;
            this.sobaihat = sobaihat;
            this.giathanh = giathanh;
        }
        public int Macd
        {
            get { return macd; }
            set { macd = value; }
        }
        public string Tuacd
        {
            get { return tuacd; }
            set { tuacd = value; }
        }
        public string Casy
        {
            get { return casy; }
            set { casy = value; }
        }
        public int Sobaihat
        {
            get { return sobaihat; }
            set { sobaihat = value; }
        }
        public int Giathanh
        {
            get { return giathanh; }
            set { giathanh = value; }
        }
        public string ToString()
        {
            return string.Format("{0, 10} {1,30} {2,30} {3,10} {4, 15:#,##0}", macd,tuacd, casy, sobaihat, giathanh);
        }


    }
}
