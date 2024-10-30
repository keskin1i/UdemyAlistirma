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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        Context _context = new Context();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tbl_Doktorlar ",_context.Connection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşı Combobaxa Aktarma
            SqlCommand command = new SqlCommand("Select BransAd From Tbl_Brans", _context.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbBrans.Items.Add(sqlDataReader[0]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)",_context.Connection());
            cmd.Parameters.AddWithValue("@d1", txAd.Text);
            cmd.Parameters.AddWithValue("@d2", txSoyad.Text);
            cmd.Parameters.AddWithValue("@d3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@d4", mtxTc.Text);
            cmd.Parameters.AddWithValue("@d5", txSifre.Text);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Doktor Ekleme işlemi Yapıldı");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1",_context.Connection());
            cmd.Parameters.AddWithValue("@p1",mtxTc.Text);  
            cmd.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3.DoktorSifre=@d5 where DoktorTC=@d4 ",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@d1",txAd.Text);
            sqlCommand.Parameters.AddWithValue("@d2", txSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@d3",cmbBrans.Text);
            sqlCommand.Parameters.AddWithValue("@d4", mtxTc.Text);
            sqlCommand.Parameters.AddWithValue("@d5",txSifre.Text);
            sqlCommand.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Doktor Güncellendi");

        }
    }
}
