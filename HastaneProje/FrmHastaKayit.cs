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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        Context context = new Context();
        private void btnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", txAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", mtxTc.Text );
            sqlCommand.Parameters.AddWithValue("@p4", mTxTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txSifre.Text);
            sqlCommand.Parameters.AddWithValue("@p6", cmbxCinsiyet.Text );
            sqlCommand.ExecuteNonQuery();
            context.Connection().Close();

            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz : " + txSifre.Text);

        }
    }
}
