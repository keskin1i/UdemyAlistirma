﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UçakBiletSistemi;

namespace EntityProjeUygulama
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun();
            frmUrun.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Frmİstatistik frmİstatistik = new Frmİstatistik();
            frmİstatistik.Show();
            this.Hide();
        }
    }
}
