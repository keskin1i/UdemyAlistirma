namespace Dosya_Klasör
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.txAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(228, 76);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(212, 36);
            this.txAd.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ad :";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(228, 118);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(212, 36);
            this.txSoyad.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(119, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Soyad :";
            // 
            // mtxTc
            // 
            this.mtxTc.Location = new System.Drawing.Point(228, 160);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(212, 36);
            this.mtxTc.TabIndex = 29;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // txSifre
            // 
            this.txSifre.Location = new System.Drawing.Point(228, 244);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(212, 36);
            this.txSifre.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(228, 202);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(212, 36);
            this.cmbBrans.TabIndex = 37;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGüncelle.Location = new System.Drawing.Point(228, 286);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(212, 51);
            this.btnGüncelle.TabIndex = 38;
            this.btnGüncelle.Text = "Bilgi Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(527, 418);
            this.Controls.Add(this.btnGüncelle);
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
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnGüncelle;
    }
}