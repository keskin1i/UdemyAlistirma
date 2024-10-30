namespace Personel_Kayit
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedtxMaas = new System.Windows.Forms.MaskedTextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.txPersonelId = new System.Windows.Forms.TextBox();
            this.lblPersonelId = new System.Windows.Forms.Label();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.txMeslek = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmbxSehir = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txPersonelAd = new System.Windows.Forms.TextBox();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grafikler = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedtxMaas);
            this.groupBox1.Controls.Add(this.lblMaas);
            this.groupBox1.Controls.Add(this.txPersonelId);
            this.groupBox1.Controls.Add(this.lblPersonelId);
            this.groupBox1.Controls.Add(this.lblMeslek);
            this.groupBox1.Controls.Add(this.txMeslek);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.cmbxSehir);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.lblSehir);
            this.groupBox1.Controls.Add(this.txSoyad);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txPersonelAd);
            this.groupBox1.Controls.Add(this.lblPersonelAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // maskedtxMaas
            // 
            this.maskedtxMaas.Location = new System.Drawing.Point(114, 161);
            this.maskedtxMaas.Mask = "0000";
            this.maskedtxMaas.Name = "maskedtxMaas";
            this.maskedtxMaas.Size = new System.Drawing.Size(109, 22);
            this.maskedtxMaas.TabIndex = 18;
            this.maskedtxMaas.ValidatingType = typeof(int);
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(18, 169);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(47, 16);
            this.lblMaas.TabIndex = 17;
            this.lblMaas.Text = "Maaş :";
            // 
            // txPersonelId
            // 
            this.txPersonelId.Location = new System.Drawing.Point(114, 47);
            this.txPersonelId.Name = "txPersonelId";
            this.txPersonelId.Size = new System.Drawing.Size(109, 22);
            this.txPersonelId.TabIndex = 16;
            // 
            // lblPersonelId
            // 
            this.lblPersonelId.AutoSize = true;
            this.lblPersonelId.Location = new System.Drawing.Point(18, 51);
            this.lblPersonelId.Name = "lblPersonelId";
            this.lblPersonelId.Size = new System.Drawing.Size(81, 16);
            this.lblPersonelId.TabIndex = 15;
            this.lblPersonelId.Text = "Personel Id :";
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(15, 227);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(51, 16);
            this.lblMeslek.TabIndex = 14;
            this.lblMeslek.Text = "Meslek";
            // 
            // txMeslek
            // 
            this.txMeslek.Location = new System.Drawing.Point(114, 224);
            this.txMeslek.Name = "txMeslek";
            this.txMeslek.Size = new System.Drawing.Size(109, 22);
            this.txMeslek.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 195);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbxSehir
            // 
            this.cmbxSehir.FormattingEnabled = true;
            this.cmbxSehir.Location = new System.Drawing.Point(114, 131);
            this.cmbxSehir.Name = "cmbxSehir";
            this.cmbxSehir.Size = new System.Drawing.Size(109, 24);
            this.cmbxSehir.TabIndex = 10;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(15, 199);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 16);
            this.lblDurum.TabIndex = 9;
            this.lblDurum.Text = "Durum :";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(18, 143);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(44, 16);
            this.lblSehir.TabIndex = 6;
            this.lblSehir.Text = "Şehir :";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(114, 103);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(109, 22);
            this.txSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(18, 109);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 16);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad : ";
            // 
            // txPersonelAd
            // 
            this.txPersonelAd.Location = new System.Drawing.Point(114, 75);
            this.txPersonelAd.Name = "txPersonelAd";
            this.txPersonelAd.Size = new System.Drawing.Size(109, 22);
            this.txPersonelAd.TabIndex = 1;
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Location = new System.Drawing.Point(18, 76);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(90, 16);
            this.lblPersonelAd.TabIndex = 0;
            this.lblPersonelAd.Text = "Personel Ad : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Grafikler);
            this.groupBox2.Controls.Add(this.btnİstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Grafikler
            // 
            this.Grafikler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grafikler.Location = new System.Drawing.Point(62, 262);
            this.Grafikler.Name = "Grafikler";
            this.Grafikler.Size = new System.Drawing.Size(121, 35);
            this.Grafikler.TabIndex = 6;
            this.Grafikler.Text = "btnGrafikler";
            this.Grafikler.UseVisualStyleBackColor = false;
            this.Grafikler.Click += new System.EventHandler(this.Grafikler_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnİstatistik.Location = new System.Drawing.Point(62, 221);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(121, 35);
            this.btnİstatistik.TabIndex = 5;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = false;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTemizle.Location = new System.Drawing.Point(62, 180);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 35);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGüncelle.Location = new System.Drawing.Point(62, 139);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(121, 35);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSil.Location = new System.Drawing.Point(62, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKaydet.Location = new System.Drawing.Point(62, 57);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 35);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListele.Location = new System.Drawing.Point(62, 16);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 35);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şehir :";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Personel_Kayit.Properties.Resources.Takvim;
            this.pictureBox1.Location = new System.Drawing.Point(649, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(62, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Raporlar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txPersonelAd;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cmbxSehir;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.TextBox txMeslek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txPersonelId;
        private System.Windows.Forms.Label lblPersonelId;
        private System.Windows.Forms.Button Grafikler;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedtxMaas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

