﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int sayi1 = Convert.ToInt16(txSayi1.Text);
            //    int sayi2 = Convert.ToInt16(txSayi2.Text);
            //    int toplam = sayi1 + sayi2;
            //    MessageBox.Show(toplam.ToString());
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Lütfen Değerlerinizi Kontrol Edin.");
            //}



            try
            {
                int s1, s2, sonuc;

                s1 = Convert.ToInt16(txSayi1.Text);
                s2 = Convert.ToInt16(txSayi2.Text);
                sonuc = s1 * s2;
                label3.Text = sonuc.ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
            finally
            {
                MessageBox.Show("Finally Kodları Çalıştı.");      
            }
          
          
        }
    }
}
