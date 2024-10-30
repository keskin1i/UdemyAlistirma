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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        Context context = new Context();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tbl_Duyurular ",context.Connection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
