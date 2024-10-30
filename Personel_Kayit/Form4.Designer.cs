namespace Personel_Kayit
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txKullanıcıAdı
            // 
            this.txKullanıcıAdı.Location = new System.Drawing.Point(362, 143);
            this.txKullanıcıAdı.Name = "txKullanıcıAdı";
            this.txKullanıcıAdı.Size = new System.Drawing.Size(140, 34);
            this.txKullanıcıAdı.TabIndex = 2;
            // 
            // txSifre
            // 
            this.txSifre.Location = new System.Drawing.Point(362, 187);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(140, 34);
            this.txSifre.TabIndex = 3;
            this.txSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGirisYap.Location = new System.Drawing.Point(362, 227);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(140, 42);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 328);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSifre);
            this.Controls.Add(this.txKullanıcıAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txKullanıcıAdı;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGirisYap;
    }
}