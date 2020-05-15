using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahamdiri
{
    public partial class Nama : Form
    {

        public Nama()
        {
            InitializeComponent();
        }
            
        public void Add(string nama, string job, string noHp)
        {
            Akun pasien = new Akun(nama, job, noHp);
            pasien.tambah();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNama.Text) && !String.IsNullOrEmpty(tbNoTelp.Text) && !String.IsNullOrEmpty(tbPekerjaan.Text))
            {
                Add(tbNama.Text, tbPekerjaan.Text, tbNoTelp.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nama, Pekerjaan, dan No Hp harus diisi!");
                return;
            }
        }

        // buat reset
        private void BtnReset_Click(object sender, EventArgs e)
        {
            tbNama.Clear();
            tbNoTelp.Clear();
            tbPekerjaan.Clear();
        }
    }
}
