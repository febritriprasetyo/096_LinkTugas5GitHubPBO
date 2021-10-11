using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Faktur : IPayable
    {
        private string bagianNomor;
        private string bagianDeskripsi;
        private int kuantitas;
        private decimal hargaPeritem;

        public Faktur(string bagian, string deskripsi, int menghitung, decimal harga)
        {
            BagianNomor = bagian;
            BagianDeskripsi = deskripsi;
            Kuantitas = menghitung;
            HargaPeritem = harga;
        }
        public string BagianNomor
        {
            get
            {
                return bagianNomor;
            }
            set
            {
                bagianNomor = value;
            }
        }
        public string BagianDeskripsi
        {
            get
            {
                return bagianDeskripsi;
            }
            set
            {
                bagianDeskripsi = value;
            }
        }
        public int Kuantitas
        {
            get
            {
                return kuantitas;
            }
            set
            {
                kuantitas = (value < 0) ? 0 : value;
            }
        }
        public decimal HargaPeritem
        {
            get
            {
                return hargaPeritem;
            }
            set
            {
                hargaPeritem = (value < 0) ? 0 : value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}: \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}", "faktur", "Bagian Nomor", BagianNomor, BagianDeskripsi, "Kuantitas", Kuantitas, "Harga per item", HargaPeritem);
        }
        public decimal DapatkanJumlahPembayaran()
        {
            return Kuantitas * HargaPeritem;
        }
    }
}