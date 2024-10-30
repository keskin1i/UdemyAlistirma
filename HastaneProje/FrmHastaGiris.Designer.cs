namespace Dosya_Klasör
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.txHastaGSifre = new System.Windows.Forms.TextBox();
            this.lnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // mtxTc
            // 
            this.mtxTc.Location = new System.Drawing.Point(174, 177);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(212, 36);
            this.mtxTc.TabIndex = 3;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // txHastaGSifre
            // 
            this.txHastaGSifre.Location = new System.Drawing.Point(174, 219);
            this.txHastaGSifre.Name = "txHastaGSifre";
            this.txHastaGSifre.Size = new System.Drawing.Size(212, 36);
            this.txHastaGSifre.TabIndex = 4;
            this.txHastaGSifre.UseSystemPasswordChar = true;
            // 
            // lnkUyeOl
            // 
            this.lnkUyeOl.AutoSize = true;
            this.lnkUyeOl.Location = new System.Drawing.Point(407, 180);
            this.lnkUyeOl.Name = "lnkUyeOl";
            this.lnkUyeOl.Size = new System.Drawing.Size(75, 28);
            this.lnkUyeOl.TabIndex = 5;
            this.lnkUyeOl.TabStop = true;
            this.lnkUyeOl.Text = "Üye Ol";
            this.lnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUyeOl_LinkClicked);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGirisYap.Location = new System.Drawing.Point(174, 261);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 43);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(515, 388);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lnkUyeOl);
            this.Controls.Add(this.txHastaGSifre);
            this.Controls.Add(this.mtxTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.TextBox txHastaGSifre;
        private System.Windows.Forms.LinkLabel lnkUyeOl;
        private System.Windows.Forms.Button btnGirisYap;
    }
}