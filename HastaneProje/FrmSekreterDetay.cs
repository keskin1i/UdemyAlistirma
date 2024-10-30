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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TcNumara;
      
        Context _context = new Context();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTcNoSekreter.Text = TcNumara;
           

            //Ad Soyad

            SqlCommand sqlCommand = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1",lblTcNoSekreter.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyadSekreter.Text = reader[0].ToString(); 
            }
            _context.Connection().Close();  

            //Branşları DataGride Aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Tbl_Brans", _context.Connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorları listeye aktarma
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", _context.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

            //Branşı Combobaxa Aktarma
            SqlCommand command = new SqlCommand("Select BransAd From Tbl_Brans",_context.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbBrans.Items.Add(sqlDataReader[0]);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@c1,@c2,@c3,@c4)",_context.Connection());
            command.Parameters.AddWithValue("@c1", mskTarih.Text);
            command.Parameters.AddWithValue("@c2", mskSaat.Text);
            command.Parameters.AddWithValue("@c3", cmbBrans.Text);
            command.Parameters.AddWithValue("@c4",cmbDoktor.Text);
            command.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",_context.Connection());
            command.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read()) 
            {
                cmbDoktor.Items.Add(sqlDataReader[0]+" " + sqlDataReader[1]);
            }
            _context.Connection().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",_context.Connection());
            cmd.Parameters.AddWithValue("@d1",rchDuyuru.Text);
            cmd.ExecuteNonQuery();
            _context.Connection().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans = new FrmBrans();
            frmBrans.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmRandevuListesi = new FrmRandevuListesi();
            frmRandevuListesi.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
