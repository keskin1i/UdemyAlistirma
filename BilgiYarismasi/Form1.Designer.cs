namespace BilgiYarismasi
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.lblSoruNo1 = new System.Windows.Forms.Label();
            this.lblYanlisSayisi = new System.Windows.Forms.Label();
            this.lblDogruSayisi = new System.Windows.Forms.Label();
            this.lblSoruSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDogru1 = new System.Windows.Forms.Label();
            this.btnSonrakiSoru = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 184);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(12, 215);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(236, 31);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(254, 215);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(236, 31);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(254, 252);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(236, 31);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(12, 252);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(236, 31);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblSoruNo1
            // 
            this.lblSoruNo1.AutoSize = true;
            this.lblSoruNo1.Location = new System.Drawing.Point(579, 44);
            this.lblSoruNo1.Name = "lblSoruNo1";
            this.lblSoruNo1.Size = new System.Drawing.Size(65, 16);
            this.lblSoruNo1.TabIndex = 5;
            this.lblSoruNo1.Text = "Soru No : ";
            // 
            // lblYanlisSayisi
            // 
            this.lblYanlisSayisi.AutoSize = true;
            this.lblYanlisSayisi.Location = new System.Drawing.Point(680, 110);
            this.lblYanlisSayisi.Name = "lblYanlisSayisi";
            this.lblYanlisSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblYanlisSayisi.TabIndex = 6;
            this.lblYanlisSayisi.Text = "0";
            // 
            // lblDogruSayisi
            // 
            this.lblDogruSayisi.AutoSize = true;
            this.lblDogruSayisi.Location = new System.Drawing.Point(680, 77);
            this.lblDogruSayisi.Name = "lblDogruSayisi";
            this.lblDogruSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblDogruSayisi.TabIndex = 7;
            this.lblDogruSayisi.Text = "0";
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.AutoSize = true;
            this.lblSoruSayisi.Location = new System.Drawing.Point(680, 44);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblSoruSayisi.TabIndex = 8;
            this.lblSoruSayisi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yanlış :";
            // 
            // lblDogru1
            // 
            this.lblDogru1.AutoSize = true;
            this.lblDogru1.Location = new System.Drawing.Point(594, 77);
            this.lblDogru1.Name = "lblDogru1";
            this.lblDogru1.Size = new System.Drawing.Size(50, 16);
            this.lblDogru1.TabIndex = 10;
            this.lblDogru1.Text = "Doğru :";
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.Location = new System.Drawing.Point(539, 145);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(236, 31);
            this.btnSonrakiSoru.TabIndex = 11;
            this.btnSonrakiSoru.Text = "Sonraki Soru";
            this.btnSonrakiSoru.UseVisualStyleBackColor = true;
            this.btnSonrakiSoru.Click += new System.EventHandler(this.btnSonrakiSoru_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BilgiYarismasi.Properties.Resources.red_light_gif;
            this.pictureBox2.Location = new System.Drawing.Point(660, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgiYarismasi.Properties.Resources.green_light_gif;
            this.pictureBox1.Location = new System.Drawing.Point(544, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "-";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "-";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSonrakiSoru);
            this.Controls.Add(this.lblDogru1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoruSayisi);
            this.Controls.Add(this.lblDogruSayisi);
            this.Controls.Add(this.lblYanlisSayisi);
            this.Controls.Add(this.lblSoruNo1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblSoruNo1;
        private System.Windows.Forms.Label lblYanlisSayisi;
        private System.Windows.Forms.Label lblDogruSayisi;
        private System.Windows.Forms.Label lblSoruSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDogru1;
        private System.Windows.Forms.Button btnSonrakiSoru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

