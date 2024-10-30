using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=BonusOkul;User ID=sa;Password=123456;Encrypt=False");

        DataSet1TableAdapters.TBLOGRENCILERTableAdapter _ds = new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
        string c = "";
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLKULUPLER",sqlConnection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            ds.Fill(dataTable);
            cmbxKulup.DisplayMember = "KULUPID";
            cmbxKulup.DisplayMember = "KULUPAD";
            cmbxKulup.DataSource = dataTable;
            sqlConnection.Close();

            dataGridView1.DataSource = _ds.OgrenciListele();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {

          

            _ds.OgrenciEkle(txOgrenciAdi.Text, txSoyad.Text, byte.Parse(cmbxKulup.Text), c);
            MessageBox.Show("Öğrenci ekleme işlemi yapıldı.");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _ds.OgrenciListele();
        }

        private void cmbxKulup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txOgrenciİd.Text = cmbxKulup.SelectedValue.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _ds.OgrenciSil(int.Parse(txOgrenciİd.Text));
            MessageBox.Show("Silme İşlemi Gerçekleşti.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txOgrenciİd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txOgrenciAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txSoyad.Text = dataGridView1.Rows[e.RowIndex ].Cells[2].Value.ToString();
            cmbxKulup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           

            if (c == "Erkek")
            {
                radioButton1.Checked = true;
            }
            if (c == "Kız")
            {
                radioButton2.Checked = true;
            }
            c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            _ds.OgrenciGuncelleme(txOgrenciAdi.Text,txSoyad.Text,byte.Parse(cmbxKulup.Text),c,Convert.ToInt32(txOgrenciİd.Text));
            MessageBox.Show("Öğrenci Güncellendi.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Erkek";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
            if (radioButton2.Checked == true)
            {
                c = "Kız";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource =  _ds.OgrenciGetir(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource =  _ds.OgrenciGetir("like '%"+textBox1.Text+"%'");
           
            

        }
    }
}
