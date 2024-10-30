using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Proje
{
    public partial class Form1 : Form
    {
        //Bu Projede veri tabanı olarak Microsoft Access kullanılmıştır.

        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\User\\Desktop\Kitaplik.mdb;Persist Security Info=False;");
       
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From Kitaplar",oleDbConnection);
            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string Durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur,SayfaSayisi,Durum) values (@p1,@p2,@p3,@p4,@p5)",oleDbConnection);
            cmd.Parameters.AddWithValue("@p1",txKitapAd.Text);
            cmd.Parameters.AddWithValue("@p2", txYazar.Text);
            cmd.Parameters.AddWithValue("@p3", cmbTur.Text);
            cmd.Parameters.AddWithValue("@p4", txSayfa.Text);
            cmd.Parameters.AddWithValue("@p5", durum);
            cmd.ExecuteNonQuery();
            oleDbConnection.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi.");
            listele();
        }

        string durum = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                durum = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                durum = "1";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;    
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand oleDbCommand = new OleDbCommand("Delete from Kitaplar where Kitapid=@p1",oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@p1",txKitapid.Text);
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
            MessageBox.Show("Kitap Sistemden Silindi");
            listele();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();
            OleDbCommand oleDbCommand = new OleDbCommand("Update Kitaplar Set KitapAd=@p1,Yazar=@p2,Tur=@p3,SayfaSayisi=@p4,Durum=@p5 where Kitapid=@p6",oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@p1",txKitapAd.Text);
            oleDbCommand.Parameters.AddWithValue("@p2", txYazar.Text);
            oleDbCommand.Parameters.AddWithValue("@p3",cmbTur.Text);
            oleDbCommand.Parameters.AddWithValue("@p4",txSayfa.Text);
            if (radioButton1.Checked == true)
            {
                oleDbCommand.Parameters.AddWithValue("@p5", "0");//"0" yerine kaydette kullandığımız durum ifdeside kullanılabilir.
            }
            if (radioButton2.Checked == true) 
            {
                oleDbCommand.Parameters.AddWithValue("@p5", "1");
            }
           
            oleDbCommand.Parameters.AddWithValue("@p6", txKitapid.Text);
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
            MessageBox.Show("Kitap Bilgileri Güncellendi.");
            listele();

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            OleDbCommand oleDb = new OleDbCommand("Select * From Kitaplar where KitapAd=@p1",oleDbConnection);
            oleDb.Parameters.AddWithValue("@p1", txKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDb);
            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void txKitapBul_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand oleDb = new OleDbCommand("Select * From Kitaplar where KitapAd like '%"+txKitapBul.Text+"%'", oleDbConnection);          
            DataTable dt = new DataTable();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDb);
            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
