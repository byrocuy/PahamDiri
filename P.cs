using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pahamdiri
{
    class Akun : IPasien
    {
        private string _nama;
        public string Nama { get { return _nama; }
            set
            { 
                _nama = value; 
            }
        }
        public string Pekerjaan { get; set; }
        public string NoHp { get; set; }

        public Akun(string nama, string pekerjaan, string noHp)
        {
            Nama = nama;
            Pekerjaan = pekerjaan;
            NoHp = noHp;
        }

        public void tambah()
        {
            using (var db = new PasienModel())
            {
                // DataPasien = database2
                DataPasien newPasien = new DataPasien
                {
                    Nama = Nama,
                    Pekerjaan = Pekerjaan,
                    No_Hp = NoHp
                };
                db.DataPasiens.Add(newPasien);
                db.SaveChanges();
            }
        }
    }
}
