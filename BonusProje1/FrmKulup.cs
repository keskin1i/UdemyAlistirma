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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=BonusOkul;User ID=sa;Password=123456;Encrypt=False");

       void liste()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From TBLKULUPLER", sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
          liste();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLKULUPLER (KULUPAD) VALUES (@P1)",sqlConnection);
            cmd.Parameters.AddWithValue("@P1", txKulpAdi.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kulüp eklendi.");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           // Application.Exit();
           this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txKulüpID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txKulpAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

             

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete From TBLKULUPLER WHERE KULUPID=@P1",sqlConnection);
            cmd.Parameters.AddWithValue("@P1",txKulüpID.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kulüp silme işlemi gerçekleşti");
            liste();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Update TBLKULUPLER SET KULUPAD=@P1 WHERE KULUPID=@P2", sqlConnection);
            cmd.Parameters.AddWithValue("@P1", txKulpAdi.Text);
            cmd.Parameters.AddWithValue("@P2", txKulüpID.Text);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kulüp güncelleme işlemi gerçekleşti");
            liste();
        }
    }
}
