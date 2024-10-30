using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dongoler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Merhaba Ankara");
            }
        }
    }
}
