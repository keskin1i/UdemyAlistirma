namespace EntityProjeUygulama
{
    partial class FrmUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.txMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tXUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(178, 34);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(205, 30);
            this.txId.TabIndex = 1;
            // 
            // txMarka
            // 
            this.txMarka.Location = new System.Drawing.Point(178, 106);
            this.txMarka.Name = "txMarka";
            this.txMarka.Size = new System.Drawing.Size(205, 30);
            this.txMarka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MARKA :";
            // 
            // txStok
            // 
            this.txStok.Location = new System.Drawing.Point(180, 142);
            this.txStok.Name = "txStok";
            this.txStok.Size = new System.Drawing.Size(205, 30);
            this.txStok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOK :";
            // 
            // tXUrunAdi
            // 
            this.tXUrunAdi.Location = new System.Drawing.Point(178, 70);
            this.tXUrunAdi.Name = "tXUrunAdi";
            this.tXUrunAdi.Size = new System.Drawing.Size(205, 30);
            this.tXUrunAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ÜRÜN ADI :";
            // 
            // txFiyat
            // 
            this.txFiyat.Location = new System.Drawing.Point(180, 178);
            this.txFiyat.Name = "txFiyat";
            this.txFiyat.Size = new System.Drawing.Size(205, 30);
            this.txFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "FİYAT :";
            // 
            // txDurum
            // 
            this.txDurum.Location = new System.Drawing.Point(178, 214);
            this.txDurum.Name = "txDurum";
            this.txDurum.Size = new System.Drawing.Size(205, 30);
            this.txDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "DURUM :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "KATEGORİ :";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnListele.Location = new System.Drawing.Point(459, 46);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(170, 34);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSil.Location = new System.Drawing.Point(459, 132);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 34);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGuncelle.Location = new System.Drawing.Point(459, 172);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(170, 34);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEkle.Location = new System.Drawing.Point(459, 92);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(170, 34);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTemizle.Location = new System.Drawing.Point(459, 212);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(170, 34);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 261);
            this.dataGridView1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 33);
            this.comboBox1.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 575);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tXUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUrun";
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tXUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}