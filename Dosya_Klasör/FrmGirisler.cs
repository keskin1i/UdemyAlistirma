using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Klasör
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        string dosyaAdi, dosyaYolu;
        StreamWriter sw;

        private void button5_Click(object sender, EventArgs e)
        {
            dosyaAdi = txDosyaAdi.Text;
            sw = File.CreateText(dosyaYolu + "\\" + dosyaAdi+".txt");
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    listBox1.Items.Add(line);
                    line = streamReader.ReadLine();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları | *.txt";
            saveFileDialog1.Title = " Metin belgesi kayıt";
            saveFileDialog1.ShowDialog();

            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
            streamWriter.WriteLine(richTextBox1.Text);
            streamWriter.Close();
            MessageBox.Show("Kayıt Oluşturuldu");
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(openFile.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                txDosyaYolu.Text = dosyaYolu;
            }
        }
    }
}
