using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    public class GajiKaryawan : Karyawan
    {
        private decimal gajiMingguan;

        public GajiKaryawan(string Depan, string Belakang, string ssn, decimal gaji)
            : base(Depan, Belakang, ssn)
        {
            GajiMingguan = gaji;
        }
        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                gajiMingguan = ((value >= 0) ? value : 0);
            }
        }
        public override decimal Pendapatan()
        {
            return GajiMingguan;
        }
        public override string ToString()
        {
            return string.Format("Nama Karyawan : {0}\n{1}: {2:C}", base.ToString(), "Gaji Mingguan", GajiMingguan);
        }
    }
}