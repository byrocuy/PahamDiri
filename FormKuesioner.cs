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
    public partial class formKuesioner : Form
    {
        // nanti diatur biar si radionya mirip sama form2 di gugelform gitu
        // hasil diagnosis: angka-angka yang terpilih di radio dijumlahin, nanti angka totalnya dijadiin patokan
        // untuk diagnosis. <10=cukup baik, 10-15 biasa saja, 16-20 sedikit lelah, 21-25 cukup lelah
        // HistoriResult Result = new HistoriResult();

        int point1, point2, point3, point4, point5;

        public formKuesioner()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            point1 = 5;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            point1 = 3;
        }

        private void rbKurSet1_CheckedChanged(object sender, EventArgs e)
        {
            point1 = 2;
        }

        private void rbSetuju1_CheckedChanged(object sender, EventArgs e)
        {
            point1 = 4;
        }

        private void rbTiSet2_CheckedChanged(object sender, EventArgs e)
        {
            point2 = 1;
        }

        private void rbKurSet2_CheckedChanged(object sender, EventArgs e)
        {
            point2 = 2;
        }

        private void rbNetral2_CheckedChanged(object sender, EventArgs e)
        {
            point2 = 3;
        }

        private void rbSetuju2_CheckedChanged(object sender, EventArgs e)
        {
            point2 = 4;
        }

        private void rbSanSet2_CheckedChanged(object sender, EventArgs e)
        {
            point2 = 5;
        }

        private void rbTiSet3_CheckedChanged(object sender, EventArgs e)
        {
            point3 = 1;
        }

        private void rbKurSet3_CheckedChanged(object sender, EventArgs e)
        {
            point3 = 2;
        }

        private void rbNetral3_CheckedChanged(object sender, EventArgs e)
        {
            point3 = 3;
        }

        private void rbSetuju3_CheckedChanged(object sender, EventArgs e)
        {
            point3 = 4;
        }

        private void rbSanSet3_CheckedChanged(object sender, EventArgs e)
        {
            point3 = 5;
        }

        private void rbTiSet4_CheckedChanged(object sender, EventArgs e)
        {
            point4 = 1;
        }

        private void rbKurSet4_CheckedChanged(object sender, EventArgs e)
        {
            point4 = 2;
        }

        private void rbNetral4_CheckedChanged(object sender, EventArgs e)
        {
            point4 = 3;
        }

        private void rbSetuju4_CheckedChanged(object sender, EventArgs e)
        {
            point4 = 4;
        }

        private void rbSanSet4_CheckedChanged(object sender, EventArgs e)
        {
            point4 = 5;
        }

        private void rbTiSet5_CheckedChanged(object sender, EventArgs e)
        {
            point5 = 1;
        }

        private void rbKurSet5_CheckedChanged(object sender, EventArgs e)
        {
            point5 = 2;
        }

        private void rbNetral5_CheckedChanged(object sender, EventArgs e)
        {
            point5 = 3;
        }

        private void rbSetuju5_CheckedChanged(object sender, EventArgs e)
        {
            point5 = 4;
        }
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            point5 = 5;
        }

        private void rbTiSet1_CheckedChanged(object sender, EventArgs e)
        {
            point1 = 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // reset jawaban + form keluhan
        private void btnUlangi_Click(object sender, EventArgs e)
        {
            rtbKeluhKesah.Clear();

            // uncheck jawaban
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;
                }
            }
        }

        // iterasi uncheck jawaban
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int hasil = point1 + point2 + point3 + point4 + point5; 
            string keluhan = rtbKeluhKesah.Text;

            // menampilkan eror jika ada pertanyaan yang tidak dijawab
            if (!rbKurSet1.Checked && !rbNetral1.Checked && !rbSanSet1.Checked && !rbSetuju1.Checked && !rbTiSet1.Checked || String.IsNullOrEmpty(rtbKeluhKesah.Text))
            {
                MessageBox.Show("Harap isi semua pertanyaan dan keluhan!");
                return;
            }
            if (!rbKurSet2.Checked && !rbNetral2.Checked && !rbSanSet2.Checked && !rbSetuju2.Checked && !rbTiSet2.Checked || String.IsNullOrEmpty(rtbKeluhKesah.Text))
            {
                MessageBox.Show("Harap isi semua pertanyaan dan keluhan!");
                return;
            }
            if (!rbKurSet3.Checked && !rbNetral3.Checked && !rbSanSet3.Checked && !rbSetuju3.Checked && !rbTiSet3.Checked || String.IsNullOrEmpty(rtbKeluhKesah.Text))
            {
                MessageBox.Show("Harap isi semua pertanyaan dan keluhan!");
                return;
            }
            if (!rbKurSet4.Checked && !rbNetral4.Checked && !rbSanSet4.Checked && !rbSetuju4.Checked && !rbTiSet4.Checked || String.IsNullOrEmpty(rtbKeluhKesah.Text))
            {
                MessageBox.Show("Harap isi semua pertanyaan dan keluhan!");
                return;
            }
            if (!rbKurSet5.Checked && !rbNetral5.Checked && !rbSanSet5.Checked && !rbSetuju5.Checked && !rbTiSet5.Checked || String.IsNullOrEmpty(rtbKeluhKesah.Text))
            {
                MessageBox.Show("Harap isi semua pertanyaan dan keluhan!");
                return;
            }

            // Menampilkan form Diagnosis
            Diagnosis newDiag = new Diagnosis();

            // idk error terus disini tiap mau ngisi kuisioner lebih dari 1x
            newDiag.Show();
            newDiag.Diagnose(hasil, keluhan);
            newDiag.tambah();
        }
    }
}
