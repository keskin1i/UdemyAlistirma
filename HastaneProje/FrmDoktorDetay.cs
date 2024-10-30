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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        Context _context = new Context();
        public string tc;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = tc;

            //Doktor Ad Soyad
            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1",_context.Connection());
            command.Parameters.AddWithValue("@p1", lblTcNo.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0]+" "+reader[1];
            }
            _context.Connection().Close();  

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+lblAdSoyad.Text+"'",_context.Connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frmDoktorBilgi = new FrmDoktorBilgiDüzenle();
            frmDoktorBilgi.TC = lblTcNo.Text;
            frmDoktorBilgi.Show();
        }

        private void rchSikayet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
