namespace Dosya_Klasör
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEkle.Location = new System.Drawing.Point(191, 251);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 51);
            this.btnEkle.TabIndex = 49;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(191, 167);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(212, 36);
            this.cmbBrans.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Branş :";
            // 
            // txSifre
            // 
            this.txSifre.Location = new System.Drawing.Point(191, 209);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(212, 36);
            this.txSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Şifre :";
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(191, 41);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(212, 36);
            this.txAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ad :";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(191, 83);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(212, 36);
            this.txSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(82, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Soyad :";
            // 
            // mtxTc
            // 
            this.mtxTc.Location = new System.Drawing.Point(191, 125);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(212, 36);
            this.mtxTc.TabIndex = 3;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 318);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSil.Location = new System.Drawing.Point(309, 251);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 51);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGüncelle.Location = new System.Drawing.Point(191, 308);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(212, 51);
            this.btnGüncelle.TabIndex = 52;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1443, 396);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxTc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
    }
}