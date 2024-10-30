using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{

    //DataSet İşlemleri Kullanılmıştır.
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter _ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = _ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = _ds.DersListesi();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _ds.DersEkle(txDersAdi.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapıldı.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _ds.DersSilme(byte.Parse(txDersid.Text));
            MessageBox.Show("Silme İşlemi Gerçekleşti.");
            dataGridView1.DataSource = _ds.DersListesi();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            _ds.DersGuncelle(txDersAdi.Text,byte.Parse(txDersid.Text));
            MessageBox.Show("Güncelleme işlemi Gerçekleşti.");
            dataGridView1.DataSource = _ds.DersListesi();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txDersid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txDersAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
