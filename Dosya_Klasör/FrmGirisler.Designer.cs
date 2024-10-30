namespace Dosya_Klasör
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDosyaYolu = new System.Windows.Forms.TextBox();
            this.txDosyaAdi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenFileDialog";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(12, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "SaveFileDialog";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(12, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "FolderBrowserDialog";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(559, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Yol Seç";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Location = new System.Drawing.Point(559, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Oluştur";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dosya Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dosya Yolu :";
            // 
            // txDosyaYolu
            // 
            this.txDosyaYolu.Location = new System.Drawing.Point(501, 42);
            this.txDosyaYolu.Name = "txDosyaYolu";
            this.txDosyaYolu.Size = new System.Drawing.Size(287, 22);
            this.txDosyaYolu.TabIndex = 7;
            // 
            // txDosyaAdi
            // 
            this.txDosyaAdi.Location = new System.Drawing.Point(501, 70);
            this.txDosyaAdi.Name = "txDosyaAdi";
            this.txDosyaAdi.Size = new System.Drawing.Size(287, 22);
            this.txDosyaAdi.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(198, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 228);
            this.listBox1.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.Location = new System.Drawing.Point(198, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 34);
            this.button6.TabIndex = 10;
            this.button6.Text = "Oluştur";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(501, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(287, 216);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.Location = new System.Drawing.Point(550, 404);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 34);
            this.button7.TabIndex = 12;
            this.button7.Text = "Oluştur";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(794, 42);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(562, 662);
            this.axAcroPDF1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 755);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txDosyaAdi);
            this.Controls.Add(this.txDosyaYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDosyaYolu;
        private System.Windows.Forms.TextBox txDosyaAdi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button7;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}

