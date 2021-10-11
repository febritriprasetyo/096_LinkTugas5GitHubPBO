using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    public class KomisiTambahanKaryawan : KomisiKaryawan
    {
        private decimal gajiPokok;

        public KomisiTambahanKaryawan(string Depan, string Belakang, string ssn, decimal penjualan, decimal tingkat, decimal gaji)
            : base(Depan, Belakang, ssn, penjualan, tingkat)
        {
            GajiPokok = gaji;
        }
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                gajiPokok = (value >= 0) ? value : 0;
            }
        }
        public override decimal Pendapatan()
        {
            return GajiPokok * base.Pendapatan();
        }
        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}", "Gaji-Pokok", base.ToString(), "\nGaji Pokok", GajiPokok);
        }
    }
}