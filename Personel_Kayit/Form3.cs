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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection _sqlConnection = new SqlConnection(
          "Data Source=DESKTOP-2KELP5G;Initial Catalog=PersonelVeriTabani;User ID=sa;Password=123456;");
        private void Form3_Load(object sender, EventArgs e)
        {
            //Personel Şehir grafik 1
            _sqlConnection.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel Group By PerSehir", _sqlConnection);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read()) 
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            
            _sqlConnection.Close();

            //Personel Meslek - Maas grafik 2
            _sqlConnection.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel group by PerMeslek ", _sqlConnection);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }

            _sqlConnection.Close();
        }
    }
}
