using HastaneProje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context = HastaneProje.Context;

namespace Dosya_Klasör
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        Context _context = new Context();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = tc;

            //Ad Soyad Çekme
            SqlCommand sqlCommand = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1",lblTcNo.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0] + " " + reader[1];
                
            }

            _context.Connection().Close();  

            //Randevu Geçmişi

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc,_context.Connection());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //Branşları Çekme

            SqlCommand cmd = new SqlCommand("Select BransAd From Tbl_Brans", _context.Connection());
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmbBranş.Items.Add(dataReader[0]);
            }

        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", _context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1",cmbBranş.Text);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbDoktor.Items.Add(dataReader[0] + "" + dataReader[1]);
            }
            _context.Connection().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" 
                + cmbBranş.Text + "'" + " and RandevuDoktor='"+cmbDoktor+"' and RandevuDurum=0", _context.Connection());   
            dataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void lnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle frmBilgi = new FrmBilgiDüzenle();
            frmBilgi.tcNo = lblTcNo.Text;
            frmBilgi.Show();
          

           
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            txId.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",_context.Connection());
            cmd.Parameters.AddWithValue("@p1",lblTcNo.Text);
            cmd.Parameters.AddWithValue("@p2",rchSikayet.Text);
            cmd.Parameters.AddWithValue("@p3",txId.Text);
            cmd.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Randevu Alındı");

        }
    }
}
