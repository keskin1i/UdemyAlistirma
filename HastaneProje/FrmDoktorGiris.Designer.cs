namespace Dosya_Klasör
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txHastaGSifre = new System.Windows.Forms.TextBox();
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGirisYap.Location = new System.Drawing.Point(195, 185);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 43);
            this.btnGirisYap.TabIndex = 13;
            this.btnGirisYap.Text = "Giriş";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txHastaGSifre
            // 
            this.txHastaGSifre.Location = new System.Drawing.Point(195, 143);
            this.txHastaGSifre.Name = "txHastaGSifre";
            this.txHastaGSifre.Size = new System.Drawing.Size(212, 36);
            this.txHastaGSifre.TabIndex = 11;
            // 
            // mtxTc
            // 
            this.mtxTc.Location = new System.Drawing.Point(195, 101);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(212, 36);
            this.mtxTc.TabIndex = 10;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(485, 290);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txHastaGSifre);
            this.Controls.Add(this.mtxTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorGiris";
            this.Text = "Doktor Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txHastaGSifre;
        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}