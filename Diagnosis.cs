using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahamdiri
{
    public partial class Diagnosis : Form
    {
        public string saran;
        private string _kondisi;

        public string kondisi { get { return _kondisi; } set { _kondisi = value; } }

        HistoriResult result = new HistoriResult();

        public Diagnosis()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHistori_Click(object sender, EventArgs e)
        {
            Histori newHistori = new Histori();
            newHistori.Show();
        }

        public void Diagnose(int nilai, string keluhan)
        {
            tbKeluhan.Text = keluhan;
            if(nilai<=10)
            {
                kondisi = result.Diagnosa[0];
                saran = result.Saran[0];
            }
            else if(nilai<=15)
            {
                kondisi = result.Diagnosa[1];
                saran = result.Saran[1];
            }
            else if (nilai <= 20)
            {
                kondisi = result.Diagnosa[2];
                saran = result.Saran[2];
            }
            else if (nilai <= 25)
            {
                kondisi = result.Diagnosa[3];
                saran = result.Saran[3];
            }

            lblSaran.Text = saran;
            lblKondisi.Text = kondisi;
        }
        // Menambah hasil Diagnosa ke DB
        public void tambah()
        {
            string z = DateTime.Now.ToString("D");
            using (var db = new DiagnosaEntity())
            {
                DiagnosaDB DiagnosaPasien = new DiagnosaDB()
                {
                    // yang mau disimpen -> || tanggal || kondisi || keluhan || saran ||
                    Tanggal = z,
                    Diagnosa = kondisi,
                    Keluhan = tbKeluhan.Text,
                    Saran = saran,
                };

                db.DiagnosaDBs.Add(DiagnosaPasien);
                db.SaveChanges();
            }
        }

    }
}
