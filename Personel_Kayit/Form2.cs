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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection _sqlConnection = new SqlConnection(
           "Data Source=DESKTOP-2KELP5G;Initial Catalog=PersonelVeriTabani;User ID=sa;Password=123456;");
        private void Form2_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            _sqlConnection.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",_sqlConnection);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblPerSayısı.Text = dr1[0].ToString();
            }
            _sqlConnection.Close();

            //Evli Personel Sayısı
            _sqlConnection.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=1", _sqlConnection);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) 
            { 
                lblEvliPersonel.Text = dr2[0].ToString();
            }
            _sqlConnection.Close();

            //Bekar Personel Sayısı
            _sqlConnection.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=0", _sqlConnection);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPer.Text = dr3[0].ToString();
            }
            _sqlConnection.Close();

            //Sehir Sayısı
            _sqlConnection.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel ", _sqlConnection);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirSayısı.Text = dr4[0].ToString();
            }
            _sqlConnection.Close();

            //Toplam Maaş
            _sqlConnection.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel ", _sqlConnection);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();
            }
            _sqlConnection.Close();

            //Ortalama Maaş
            //Toplam Maaş
            _sqlConnection.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel ", _sqlConnection);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();
            }
            _sqlConnection.Close();


        }
    }
}
