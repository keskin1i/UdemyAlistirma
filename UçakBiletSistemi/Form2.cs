using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçakBiletSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txAdSoyad.Text);
            int sayi2 = Convert.ToInt32(textBox1.Text);

            lblToplama.Text = (sayi1 + sayi2).ToString();
            lblÇarpma.Text = (sayi1 * sayi2).ToString();
            lblÇıkarma.Text = (sayi1 - sayi2).ToString();
            lblBölme.Text = (sayi1/sayi2).ToString();
        }
    }
}
