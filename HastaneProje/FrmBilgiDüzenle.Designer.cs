namespace Dosya_Klasör
{
    partial class FrmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenle));
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.mTxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(194, 295);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(212, 51);
            this.btnBilgiGüncelle.TabIndex = 31;
            this.btnBilgiGüncelle.Text = "Bilgi Güncelle";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet :";
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(194, 253);
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(212, 36);
            this.cmbxCinsiyet.TabIndex = 6;
            // 
            // mTxTelefon
            // 
            this.mTxTelefon.Location = new System.Drawing.Point(194, 162);
            this.mTxTelefon.Mask = "(999) 000-0000";
            this.mTxTelefon.Name = "mTxTelefon";
            this.mTxTelefon.Size = new System.Drawing.Size(212, 36);
            this.mTxTelefon.TabIndex = 4;
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(194, 31);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(212, 36);
            this.txAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ad :";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(194, 73);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(212, 36);
            this.txSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(85, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Soyad :";
            // 
            // txSifre
            // 
            this.txSifre.Location = new System.Drawing.Point(194, 211);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(212, 36);
            this.txSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Şifre :";
            // 
            // mtxTc
            // 
            this.mtxTc.Location = new System.Drawing.Point(194, 115);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(212, 36);
            this.mtxTc.TabIndex = 3;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tel No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.btnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(470, 425);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxCinsiyet);
            this.Controls.Add(this.mTxTelefon);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.MaskedTextBox mTxTelefon;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}