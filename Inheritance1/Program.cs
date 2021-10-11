using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            KomisiKaryawan karyawan = new KomisiKaryawan("Sue", "Jones", "222-22-222", 10000.00M, .06M);

            Console.WriteLine("Informasi karyawan diperoleh dengan properti dan metode : \n");
            Console.WriteLine("Nama Depan adalah {0}", karyawan.NamaDepan);
            Console.WriteLine("Nama Belakang adalah {0}", karyawan.NamaBelakang);
            Console.WriteLine("No KTP adalah {0}", karyawan.NoKTP);
            Console.WriteLine("Penjual Kotor adalah {0:C}", karyawan.PenjualKotor);
            Console.WriteLine("Tarif Komisi adalah {0:F2}", karyawan.TarifKomisi);
            Console.WriteLine("Pendapatan adalah {0:C}", karyawan.Pendapatan());

            karyawan.PenjualKotor = 5000.00M; //set penjual kotor
            karyawan.TarifKomisi = .1M; //set tarif komisi
            Console.WriteLine("\n{0}:\n\n{1}", "Informasi terbaru karyawan diperoleh dari ToString", karyawan);
            Console.WriteLine("karyawan : {0:C}", karyawan.Pendapatan());
            Console.ReadLine();
        }
    }
}