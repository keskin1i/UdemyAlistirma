using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, Dogru = 0, Yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                Dogru++;
                lblDogruSayisi.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlisSayisi.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakiSoru.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                Dogru++;
                lblDogruSayisi.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlisSayisi.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakiSoru.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                Dogru++;
                lblDogruSayisi.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlisSayisi.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakiSoru.Enabled = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label2.Text = btnA.Text;
            if (label1.Text == label2.Text)
            {
                Dogru++;
                lblDogruSayisi.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlisSayisi.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonrakiSoru.Enabled = true;
        }

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            soruNo++;
            lblSoruSayisi.Text = soruNo.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnSonrakiSoru.Enabled = false;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kuruldu?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label1.Text = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangisi Ege Bölgesinde bulunmayan bir şehirdir?";
                btnA.Text = "Adana";
                btnB.Text = "Aydın";
                btnC.Text = "İzmir";
                btnD.Text = "Manisa";
                label1.Text = "Adana";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "2+2 Kaç eder?";
                btnA.Text = "1";
                btnB.Text = "3";
                btnC.Text = "7";
                btnD.Text = "4";
                label1.Text = "4";
                btnSonrakiSoru.Text = "Sonuçlar";
               
            }
            if (soruNo == 4)
            {

                    lblSoruSayisi.Text = (soruNo-1).ToString();
                    richTextBox1.Text = "Doğru Sayınız : " +  lblDogruSayisi.Text + "\n" + "Yanlış Sayınız : " + lblYanlisSayisi.Text + "\n" + "Toplam Soru Sayısı : " +lblSoruSayisi.Text;
                    btnA.Enabled = false;
                    btnB.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                    btnSonrakiSoru.Enabled = false;

                
            }
        }
    }
}
