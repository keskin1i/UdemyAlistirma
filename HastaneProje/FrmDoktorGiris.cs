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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        Context _context = new Context();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC = @p1 and DoktorSifre = @p2 ",_context.Connection());
            sqlCommand.Parameters.AddWithValue("@p1",mtxTc.Text);
            sqlCommand.Parameters.AddWithValue("@p2",txHastaGSifre.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.tc = mtxTc.Text;
                frmDoktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }


        }
    }
}
