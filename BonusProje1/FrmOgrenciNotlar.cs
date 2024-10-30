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

namespace BonusProje1
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=BonusOkul;User ID=sa;Password=123456;Encrypt=False");
        public string numara;
     
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM From TBLNOTLAR\r\n " +
                "INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID WHERE OGRID=@P1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", numara);
            this.Text = numara.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

    }
}
