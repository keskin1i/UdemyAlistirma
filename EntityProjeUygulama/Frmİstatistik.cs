using DevExpress.Data.Linq.Helpers;
using EntityProjeUygulama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçakBiletSistemi
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            lblToplamKategori.Text = db.TBLKATEGORI.Count().ToString();
            lblToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblAktifMusteri.Text = db.TBLMUSTERI.Count(x=>x.DURUM==true).ToString();
            lblPasifMusteri.Text = db.TBLMUSTERI.Count(x=>x.DURUM==false).ToString();
            lblToplamStokSayisi.Text = db.TBLURUN.Sum(y=>y.STOK).ToString();
            lblKasadakiTutar.Text = db.TBLSATIS.Sum(y => y.FIYAT).ToString() + "TL";
            lblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            lblBeyazEsyaSayisi.Text = db.TBLURUN.Count(x=>x.KATEGORI==1).ToString();
            label21.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            lblSehirSayisi.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETİR().FirstOrDefault();

        }
    }
}
