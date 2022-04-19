using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4266
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Karyawan anggota1 = new Karyawan("21.11.6624", "Zitha", 1500000);
            Karyawan anggota2 = new Karyawan("21.11.4266", "Angga", 1000000);

            Console.WriteLine("No Nim   / Nama      Gaji Bulanan");
            Console.WriteLine("=================================");
            Console.Write("");anggota1.tampilkanData();
            Console.Write("");anggota2.tampilkanData();
            Console.WriteLine();

            anggota1.naikGaji();
            anggota2.naikGaji();

            Console.WriteLine("asyik naik gaji 10%");
            Console.WriteLine();
            Console.WriteLine("No Nim   / Nama      Gaji Bulanan");
            Console.WriteLine("=================================");
            Console.Write("");anggota1.tampilkanData();
            Console.Write("");anggota2.tampilkanData();
            Console.ReadKey();
        }
    }
}
