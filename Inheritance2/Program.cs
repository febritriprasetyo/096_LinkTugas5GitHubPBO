using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat instance objek KomisiKaryawan
            KomisiTambahanKaryawan karyawan = new KomisiTambahanKaryawan("Bob", "Lewis", "333-33-333", 5000.00M, .04M, 300.00M);
            //menampilkan data KomisiKaryawan
            Console.WriteLine("Informasi karyawan diperoleh dengan properti dan metode : \n");
            Console.WriteLine("Nama Depan adalah {0}", karyawan.NamaDepan);
            Console.WriteLine("Nama Belakang adalah {0}", karyawan.NamaBelakang);
            Console.WriteLine("Social security number adalah {0}", karyawan.SocialSecurityNumber);
            Console.WriteLine("Penjualan Kotornya adalah {0:C}", karyawan.PenjualanKotor);
            Console.WriteLine("Tingkat Komisinya adalah {0:F2}", karyawan.TingkatKomisi);
            Console.WriteLine("Gaji Pokoknya adalah {0:C}", karyawan.GajiPokok);
            Console.WriteLine("Pendapatanya adalah {0:C}", karyawan.Pendapatan());

            karyawan.PenjualanKotor = 5000.00M; //menetapkan penjualan kotor
            karyawan.TingkatKomisi = .04M; //menetapkan tingkat  komisi
            karyawan.GajiPokok = 1000.00M; //menetapkan gaji pokok
            Console.WriteLine("\n{0}:\n\n{1}", "Informasi karyawan yang diperbarui diperoleh dari ToString", karyawan);
            Console.WriteLine("Pendapatan : {0:C}", karyawan.Pendapatan());
            Console.ReadLine();
        }
    }
}