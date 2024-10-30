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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Context _context =new Context();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", mtxTc.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txHastaGSifre.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                FrmSekreterDetay frmSekreter = new FrmSekreterDetay();
                frmSekreter.TcNumara = mtxTc.Text;
                frmSekreter.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }

        }
    }
}
