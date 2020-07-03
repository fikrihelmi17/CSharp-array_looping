using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_looping
{
    public partial class Form1 : Form
    {
        int k = 0;
        int jumlah;
        string[] kode;
        string[] nama;
        string[] jenis;
        string[] pengarang;
        string[] penerbit;
        string[] tahunTerbit;
        int[] stok;
        int i = 0;

        //double na;
        //double nm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            jumlah = Convert.ToInt32(txtJumlah.Text);

            kode = new string[jumlah + k];
            nama = new string[jumlah + k];
            jenis = new string[jumlah + k];
            pengarang = new string[jumlah + k];
            penerbit = new string[jumlah + k];
            tahunTerbit = new string[jumlah + k];
            stok = new int[jumlah + k];
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            

            if (i <= jumlah - 1)
            {
                kode[i + k] = txtKode.Text;
                nama[i + k] = txtNama.Text;
                jenis[i + k] = cmbJenis.Text;
                pengarang[i + k] = txtPengarang.Text;
                penerbit[i + k] = txtPenerbit.Text;
                tahunTerbit[i + k] = txtTahun.Text;
                stok[i + k] = Convert.ToInt32(txtStok.Text);

                i++;
            }
            else
            {
                MessageBox.Show("Data tidak boleh lebih dari " + jumlah);
            }

            txtKode.Clear();
            txtNama.Clear();
            cmbJenis.ResetText();
            txtPengarang.Clear();
            txtPenerbit.Clear();
            txtKode.Focus();
            txtTahun.Text = "";
            txtStok.Text = "";
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            
            for (int j = 0; j < jumlah; j++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j + k].Cells[0].Value = j + 1 + k;
                dataGridView1.Rows[j + k].Cells[1].Value = kode[j + k];
                dataGridView1.Rows[j + k].Cells[2].Value = nama[j + k];
                dataGridView1.Rows[j + k].Cells[3].Value = pengarang[j + k];   
                dataGridView1.Rows[j + k].Cells[4].Value = stok[j + k];
                dataGridView1.Rows[j + k].Cells[5].Value = DateTime.Now.ToString("dd/MMMM/yyyy");
            }
            k = k + jumlah;
            i = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtKode.Clear();
            txtNama.Clear();
            cmbJenis.ResetText();
            txtPengarang.Clear();
            txtPenerbit.Clear();
            txtKode.Focus();
            txtTahun.Text = "";
            txtStok.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
