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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void btnKulupİslemleri_Click(object sender, EventArgs e)
        {
            FrmKulup frmKulup = new FrmKulup();
            frmKulup.Show();
            this.Hide();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void btnDersİslemleri_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.Show();
            this.Hide();
        }

        private void btnOgrenciİslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm  = new FrmOgrenci();
            frm.Show();
            this.Hide();
        }

        private void btnOgretmenler_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm = new FrmSinavNotlar();
            frm.Show();
            this.Hide();
        }
    }
}
