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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=BonusOkul;User ID=sa;Password=123456;Encrypt=False");

        DataSet1TableAdapters.TBLNOTLARTableAdapter _ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _ds.NotListesi(Convert.ToInt32(txOgrenciİd.Text));
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLDERSLER", sqlConnection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            ds.Fill(dataTable);
            cmbxDers.DisplayMember = "DERSID";
            cmbxDers.DisplayMember = "DERSAD";
            cmbxDers.DataSource = dataTable;
            sqlConnection.Close();

           
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbxDers.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txOgrenciİd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();            
            txSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
      
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, proje;
            double ortalama;
            string durum;

            sinav1 = Convert.ToInt16(txSinav1.Text);
            sinav2 = Convert.ToInt16(txSinav2.Text);
            sinav3 = Convert.ToInt16(txSinav3.Text);
            proje = Convert.ToInt16(txProje.Text);
            

            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txOrtalama.Text = ortalama.ToString();
            if (ortalama > 50)
            {
                txDurum.Text = "True";
            }
            else 
            {
                txDurum.Text = "False";
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _ds.NotGuncelle(byte.Parse(cmbxDers.Text), int.Parse(txOgrenciİd.Text),byte.Parse(txSinav1.Text),
                byte.Parse(txSinav2.Text),byte.Parse(txSinav3.Text),byte.Parse(txProje.Text),decimal.Parse(txOrtalama.Text),bool.Parse(txDurum.Text),int.Parse(notid.ToString()));
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
        }
    }
}
