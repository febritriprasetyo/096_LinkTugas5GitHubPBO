using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class Karyawan : IPayable
    {
        private string namaDepan;
        private string namaBelakang;
        private string socialSecurityNumber;
        public Karyawan(string Depan, string Belakang, string ssn)
        {
            namaDepan = Depan;
            namaBelakang = Belakang;
            socialSecurityNumber = ssn;
        }
        public string NamaDepan
        {
            get
            {
                return namaDepan;
            }
        }
        public string NamaBelakang
        {
            get
            {
                return namaBelakang;
            }
        }
        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\nSocial Security Number : {2}", NamaDepan, NamaBelakang, SocialSecurityNumber);
        }
        public abstract decimal DapatkanJumlahPembayaran();
    }
}
