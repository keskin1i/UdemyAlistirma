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

namespace Personel_Kayit
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection _sqlConnection = new SqlConnection(
        "Data Source=DESKTOP-2KELP5G;Initial Catalog=PersonelVeriTabani;User ID=sa;Password=123456;");
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAd = @p1 and Sifre = @p2",_sqlConnection); 
            cmd.Parameters.AddWithValue("@p1",txKullanıcıAdı.Text);
            cmd.Parameters.AddWithValue("@p2",txSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }

            _sqlConnection.Close();
        }
    }
}
