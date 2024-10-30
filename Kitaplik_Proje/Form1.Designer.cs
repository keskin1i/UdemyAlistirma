namespace Kitaplik_Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txKitapid = new System.Windows.Forms.TextBox();
            this.txKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txSayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txKitapBul = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap id :";
            // 
            // txKitapid
            // 
            this.txKitapid.Enabled = false;
            this.txKitapid.Location = new System.Drawing.Point(253, 15);
            this.txKitapid.Name = "txKitapid";
            this.txKitapid.Size = new System.Drawing.Size(225, 34);
            this.txKitapid.TabIndex = 2;
            // 
            // txKitapAd
            // 
            this.txKitapAd.Location = new System.Drawing.Point(253, 55);
            this.txKitapAd.Name = "txKitapAd";
            this.txKitapAd.Size = new System.Drawing.Size(225, 34);
            this.txKitapAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Ad :";
            // 
            // txYazar
            // 
            this.txYazar.Location = new System.Drawing.Point(253, 95);
            this.txYazar.Name = "txYazar";
            this.txYazar.Size = new System.Drawing.Size(225, 34);
            this.txYazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar :";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Tiyatro",
            "Şiir"});
            this.cmbTur.Location = new System.Drawing.Point(253, 175);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(225, 37);
            this.cmbTur.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(260, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 33);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkiciEl";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(389, 218);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 33);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sıfır";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tür :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum : ";
            // 
            // txSayfa
            // 
            this.txSayfa.Location = new System.Drawing.Point(253, 135);
            this.txSayfa.Name = "txSayfa";
            this.txSayfa.Size = new System.Drawing.Size(225, 34);
            this.txSayfa.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sayfa :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(587, 47);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(143, 40);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(587, 185);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(143, 40);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(587, 139);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 40);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(587, 93);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(143, 40);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 732);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tür :";
            // 
            // txKitapBul
            // 
            this.txKitapBul.Location = new System.Drawing.Point(810, 244);
            this.txKitapBul.Name = "txKitapBul";
            this.txKitapBul.Size = new System.Drawing.Size(225, 34);
            this.txKitapBul.TabIndex = 21;
            this.txKitapBul.TextChanged += new System.EventHandler(this.txKitapBul_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kitap Adı :";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(587, 241);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(105, 40);
            this.btnBul.TabIndex = 22;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1088, 599);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txKitapBul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txSayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txKitapid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txKitapid;
        private System.Windows.Forms.TextBox txKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txKitapBul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBul;
    }
}

