using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class KomisiTambahanKaryawan
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string SocialSecurityNumber;
        private decimal penjualanKotor; //penjualan mingguan kotor
        private decimal tingkatKomisi; //persentase komisi
        private decimal gajiPokok; //gaji pokok per minggu

        //konstruktor enam parameter
        public KomisiTambahanKaryawan(string namaDepan, string namaBelakang, string socialSecurityNumber, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
        {
            //panggilan implisit ke konstruktor objek terjadi di sini
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            SocialSecurityNumber = socialSecurityNumber;
            PenjualanKotor = penjualanKotor; //memvalidasi penjualan kotor
            TingkatKomisi = tingkatKomisi; //memvalidasi tingkat komisi
            GajiPokok = gajiPokok; //memvalidasi gaji pokok
        }
        public void setNamaDepan(string namaDepan)
        {
            NamaDepan = namaDepan;
        }
        public string getNamaDepan()
        {
            return NamaDepan;
        }
        public void setNamaBelakang(string namaBelakang)
        {
            NamaBelakang = namaBelakang;
        }
        public string getNamaBelakang()
        {
            return NamaBelakang;
        }
        public void setSocialSecurityNumber(string socialSecurityNumber)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }
        public string getSocialSecurityNumber()
        {
            return SocialSecurityNumber;
        }
        //properti yang mendapatkan dan menetapkan komisi penjualan kotor karyawan
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value < 0) ? 0 : value; //memvalidasi
            }
        }
        //properti yang mendapatkan dan menetapkan tingkat komisi komisi karyawan
        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                tingkatKomisi = (value > 0 && value < 1) ? value : 0; //memvalidasi
            }
        }
        //properti yang mendapatkan dan menetapkan KomisiTambahanKaryawan gaji pokok
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                gajiPokok = (value < 0) ? 0 : value; //memvalidasi
            }
        }
        //menghitung komisi gaji pegawai
        public decimal Pendapatan()
        {
            return gajiPokok + (tingkatKomisi * penjualanKotor);
        }
        //mengembalikan representasi string dari objek KomisiKaryawan
        public override string ToString()
        {
            return string.Format("Nama Karyawan : {0} {1} \nSocial security number : {2} \nPenjualan Kotor : {3} \nTingkat Komisi : {4} \nGaji Pokok : {5}", NamaDepan, NamaBelakang, SocialSecurityNumber, penjualanKotor, tingkatKomisi, gajiPokok);
        }
    }
}