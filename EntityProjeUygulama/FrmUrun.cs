using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI 
                               select new 
                               { x.ID,
                                   x.AD 
                               }).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM,
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = tXUrunAdi.Text;
            t.MARKA = txMarka.Text;
            t.STOK = Convert.ToInt16(txStok.Text);
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txFiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txId.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txId.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = tXUrunAdi.Text;
            urun.STOK = short.Parse(txStok.Text);
            urun.MARKA = txMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tXUrunAdi.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
