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
    public partial class Histori : Form
    {
        public Histori()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //di listbox ditampilkan Pengisian ke-n + Tanggal Pengisian
            //misal: Isian ke-3, 12-2-2020 (kalo susah, gausah pakek tanggal)
            //nanti pas salah satu isian listbox diklik, bakal keluar messagebox yang isinya histori lengkap
            //misalnya, dapet poin berapa, didiagnosis apa, sama keluh kesah yang ditulisnya apa
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Histori_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'database2DataSet.DataPasien' table. You can move, or remove it, as needed.
            //this.dataPasienTableAdapter.Fill(this.database2DataSet.DataPasien);
            // TODO: This line of code loads data into the 'database1DataSet.DiagnosaDB' table. You can move, or remove it, as needed.
            this.diagnosaDBTableAdapter.Fill(this.database1DataSet.DiagnosaDB);

        }
    }
}
