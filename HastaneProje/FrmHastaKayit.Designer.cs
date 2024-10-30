namespace Dosya_Klasör
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayıtYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxTc
            // 
            this.mtxTc.Location = new System.Drawing.Point(192, 113);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(212, 36);
            this.mtxTc.TabIndex = 3;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tel No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // txSifre
            // 
            this.txSifre.Location = new System.Drawing.Point(192, 209);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(212, 36);
            this.txSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifre :";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(192, 71);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(212, 36);
            this.txSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(83, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad :";
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(192, 29);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(212, 36);
            this.txAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ad :";
            // 
            // mTxTelefon
            // 
            this.mTxTelefon.Location = new System.Drawing.Point(192, 160);
            this.mTxTelefon.Mask = "(999) 000-0000";
            this.mTxTelefon.Name = "mTxTelefon";
            this.mTxTelefon.Size = new System.Drawing.Size(212, 36);
            this.mTxTelefon.TabIndex = 4;
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(192, 251);
            this.cmbxCinsiyet.MaxDropDownItems = 6;
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(212, 36);
            this.cmbxCinsiyet.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet :";
            // 
            // btnKayıtYap
            // 
            this.btnKayıtYap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKayıtYap.Location = new System.Drawing.Point(192, 293);
            this.btnKayıtYap.Name = "btnKayıtYap";
            this.btnKayıtYap.Size = new System.Drawing.Size(212, 51);
            this.btnKayıtYap.TabIndex = 18;
            this.btnKayıtYap.Text = "Kayıt Yap";
            this.btnKayıtYap.UseVisualStyleBackColor = false;
            this.btnKayıtYap.Click += new System.EventHandler(this.btnKayıtYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayıtYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(444, 390);
            this.Controls.Add(this.btnKayıtYap);
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
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTxTelefon;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayıtYap;
    }
}