using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "ali", "Mehmet", "fatih", "ramazan", "engin", "suna" };
            //label1.Text = kisiler[4];

            //araba rb = new araba("Bmw");
           
            //rb.hız = 300;

            //label1.Text = rb.Marka;

            Random random = new Random();

            int s1, s2, s3, s4;

            s1 = random.Next(1, 5);
            s2 = random.Next(1, 5);
            s3 = random.Next(1, 5);
            s4 = random.Next(1, 5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor= Color.Red;
            }
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            Form2 form2 = new Form2();
            form2.mesaj = textBox1.Text;
            form2.Show();
            this.Hide();


        }

        private void aksiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
