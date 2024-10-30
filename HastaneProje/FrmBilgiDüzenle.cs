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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string tcNo;

        Context context = new Context();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
           
            mtxTc.Text = tcNo;
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1",mtxTc.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {

                txAd.Text = reader[1].ToString();
                txSoyad.Text = reader[2].ToString();
                mTxTelefon.Text = reader[4].ToString();
                txSifre.Text = reader[5].ToString();
                cmbxCinsiyet.Text = reader[6].ToString();

               
            }
            sqlCommand.Connection.Close();
          

        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6 ",context.Connection());

            sqlCommand.Parameters.AddWithValue("@p1",txAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", mTxTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txSifre.Text);
            sqlCommand.Parameters.AddWithValue("@p5", cmbxCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@p6", mtxTc.Text);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            MessageBox.Show("Bilgileriniz Güncellendi");
        }
        
    }
}
