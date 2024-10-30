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

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }
        SqlConnection _sqlConnection = new SqlConnection(
            "Data Source=DESKTOP-2KELP5G;Initial Catalog=PersonelVeriTabani;User ID=sa;Password=123456;");
        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _sqlConnection.Open();

            SqlCommand command = new SqlCommand(
                "insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) Values (@p1,@p2,@p3,@p4,@p5,@p6)",_sqlConnection);

            command.Parameters.AddWithValue("@p1", txPersonelAd.Text);
            command.Parameters.AddWithValue("@p2", txSoyad.Text);
            command.Parameters.AddWithValue("@p3", cmbxSehir.Text);
            command.Parameters.AddWithValue("@p4", maskedtxMaas.Text);
            command.Parameters.AddWithValue("@p5", txMeslek.Text);
            command.Parameters.AddWithValue("@p6", label1.Text);

            command.ExecuteNonQuery();



            _sqlConnection.Close();
            MessageBox.Show("Personel added");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text= "False";
            }
        }

        void Temizle()
        {
            txPersonelAd.Text = "";
            txSoyad.Text = "";
            maskedtxMaas.Text = "";
            cmbxSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txMeslek.Text = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txPersonelId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txPersonelAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbxSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedtxMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label1.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Delete From Tbl_Personel Where Personelid=@k1 ",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@k1",txPersonelId.Text);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

            MessageBox.Show("deleted");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            _sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 Where Personelid=@a7",_sqlConnection) ;
            sqlCommand.Parameters.AddWithValue("@a1",txPersonelAd.Text);
            sqlCommand.Parameters.AddWithValue("@a2",txSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@a3", cmbxSehir.Text);
            sqlCommand.Parameters.AddWithValue("@a4", maskedtxMaas.Text);
            sqlCommand.Parameters.AddWithValue("@a5",label1.Text);
            sqlCommand.Parameters.AddWithValue("@a6",txMeslek.Text);
            sqlCommand.Parameters.AddWithValue("@a7", txPersonelId.Text);
            sqlCommand.ExecuteNonQuery ();
            _sqlConnection.Close();
            MessageBox.Show("Record updated");

        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void Grafikler_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
