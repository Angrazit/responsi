using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4266
{
    internal class Karyawan
    {
        public string nim;
        public string nama;
        public int gajiBulanan;

        public string Nim
        {
            get { return nim; }
            set { nim = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gajiBulanan; }
            set { gajiBulanan = value; }
        }

        public Karyawan(string nim, string nama, int gajiBulanan)
        {
            this.nim = nim;
            this.nama = nama;
            this.gajiBulanan = gajiBulanan < 0 ? 0 : gajiBulanan;
        }

        public void tampilkanData()
        {
            Console.WriteLine("{0} {1}      {2}", nim, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            int kenaikan;

            kenaikan = gajiBulanan * 110;
            gajiBulanan = kenaikan / 100;

            
        }


    }
}
