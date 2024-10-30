using HastaneProje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Klasör
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        Context context = new Context();

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frm = new FrmHastaKayit();
            frm.Show();
        }

        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1 and HastaSifre=@p2",context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1",mtxTc.Text);
            sqlCommand.Parameters.AddWithValue("@p2",txHastaGSifre.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc=mtxTc.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc Veya Şifre");
            }
            context.Connection().Close();
        }
    }
}
