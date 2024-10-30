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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota : " + comboBox1.Text+" - "+comboBox2.Text+" \nTarih : "+dateTimePicker1.Text+" \nSaat : "
                +maskedTextBox1.Text+"\n"+ "\n Ad Soyad :" + txAdSoyad.Text+"\n TC :"+maskedTextBox2.Text+" \nTelefon :"+maskedTextBox3.Text );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var degis = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = degis;

        }
    }
}
