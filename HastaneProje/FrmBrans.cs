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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        Context _context = new Context();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
           

            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_Brans",_context.Connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Brans (BransAd) values (@b1)",_context.Connection());
            cmd.Parameters.AddWithValue("@b1", txBransAd.Text);
            cmd.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Branş eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From Tbl_Brans where Bransid=@b1",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@b1",txId.Text);
            sqlCommand.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Brans set BransAd=@b1 where Bransid=@b2",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@b1", txId.Text);
            sqlCommand.Parameters.AddWithValue("@b2",txBransAd.Text);
            sqlCommand.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
