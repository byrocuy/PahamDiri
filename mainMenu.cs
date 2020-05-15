using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahamdiri
{
    public partial class mainMenu : Form
    {
        public string Nama;
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //kalau klik tombol about, nanti bakal keluar pahamdiri itu apa. Ya misalnya pahamdiri adalah kuis mental yadayada
            About about = new About();
            about.Show();
        }

        private void btnKuesioner_Click(object sender, EventArgs e)
        {
            formKuesioner newForm = new formKuesioner();
            newForm.Show();
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {
            Histori newForm = new Histori();
            newForm.Show();
        }
    }
}
