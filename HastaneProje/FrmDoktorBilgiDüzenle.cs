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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        Context context = new Context();

        public string TC;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mtxTc.Text = TC;

            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",context.Connection());
            cmd.Parameters.AddWithValue("@p1",mtxTc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { 

                txAd.Text = reader[1].ToString();
                txSoyad.Text = reader[2].ToString();
                cmbBrans.Text = reader[3].ToString();
                txSifre.Text = reader[5].ToString();
            }
            context.Connection().Close();   

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",context.Connection());
            cmd.Parameters.AddWithValue("@p1",txAd.Text);
            cmd.Parameters.AddWithValue("@p2",txSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4",txSifre.Text);
            cmd.Parameters.AddWithValue("@p5",mtxTc.Text);
            cmd.ExecuteNonQuery();
            context.Connection().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }
    }
}
