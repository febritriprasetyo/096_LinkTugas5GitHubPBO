using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class KomisiKaryawan : object
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string NoKTP;
        private decimal penjualKotor;
        private decimal tarifKomisi;
        public KomisiKaryawan(string namaDepan, string namaBelakang, string noKTP, decimal penjualKotor, decimal tarifKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NoKTP = noKTP;
            PenjualKotor = penjualKotor; //Validasi data penjual kotor
            TarifKomisi = tarifKomisi; //Validasi tarif komisi
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
        public void setNoKTP(string noKTP)
        {
            NoKTP = noKTP;
        }
        public string getNoKTP()
        {
            return NoKTP;
        }
        public decimal PenjualKotor
        {
            get
            {
                return penjualKotor;
            }
            set
            {
                penjualKotor = (value < 0) ? 0 : value;
            }
        }
        public decimal TarifKomisi
        {
            get
            {
                return tarifKomisi;
            }
            set
            {
                tarifKomisi = (value > 0 && value < 1) ? value : 0;
            }
        }
        public decimal Pendapatan()
        {
            return TarifKomisi * PenjualKotor;
        }
        public override string ToString()
        {
            return string.Format("Nama Karyawan : {0} {1} \nNo KTP : {2} \nPenjual Kotor : {3} \nTarif Komisi : {4}", NamaDepan, NamaBelakang, NoKTP, penjualKotor, tarifKomisi);
        }
    }
}