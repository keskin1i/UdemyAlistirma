namespace Kitaplik_Proje
{
    partial class Form2
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
            this.txSayi1 = new System.Windows.Forms.TextBox();
            this.txSayi2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı2 :";
            // 
            // txSayi1
            // 
            this.txSayi1.Location = new System.Drawing.Point(153, 100);
            this.txSayi1.Name = "txSayi1";
            this.txSayi1.Size = new System.Drawing.Size(146, 22);
            this.txSayi1.TabIndex = 2;
            // 
            // txSayi2
            // 
            this.txSayi2.Location = new System.Drawing.Point(153, 128);
            this.txSayi2.Name = "txSayi2";
            this.txSayi2.Size = new System.Drawing.Size(146, 22);
            this.txSayi2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(153, 168);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 32);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayı2 :";
            // 
            // Form2
            // 
            this.AcceptButton = this.btnHesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txSayi2);
            this.Controls.Add(this.txSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txSayi1;
        private System.Windows.Forms.TextBox txSayi2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label3;
    }
}