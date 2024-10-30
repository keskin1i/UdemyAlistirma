using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NkatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> list = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txAd.Text;
            ent.Soyad = txSoyad.Text;
            ent.Sehir = txSehir.Text;   
            ent.Maas = short.Parse(txMaas.Text);
            ent.Gorev = txGorev.Text;
            LogicPersonel.LLPersonelCount(ent);
            MessageBox.Show("Personel eklendi");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
            entity.Id = Convert.ToInt32( txId.Text);
            LogicPersonel.LLPersonelSil(entity.Id);
            MessageBox.Show("Personel bilgileri silindi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = new EntityPersonel();
            entityPersonel.Id = Convert.ToInt32( txId.Text);
            entityPersonel.Ad = txAd.Text;
            entityPersonel.Soyad = txSoyad.Text;
            entityPersonel.Sehir = txSehir.Text;
            entityPersonel.Gorev = txGorev.Text;
            entityPersonel.Maas = short.Parse(txMaas.Text) ;

            LogicPersonel.LLPersonelGuncelle(entityPersonel);

            MessageBox.Show("Personel Güncelleme İşlemi Yapıldı.");

        }
    }
}
