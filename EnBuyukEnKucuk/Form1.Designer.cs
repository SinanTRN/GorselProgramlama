namespace EnBuyukEnKucuk
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSayi1 = new System.Windows.Forms.Label();
            this.textSayi1 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.textSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.Label();
            this.textSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi3 = new System.Windows.Forms.Label();
            this.textKucuk = new System.Windows.Forms.TextBox();
            this.txtEnKucuk = new System.Windows.Forms.Label();
            this.textBuyuk = new System.Windows.Forms.TextBox();
            this.txtEnBuyuk = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.AutoSize = true;
            this.txtSayi1.Location = new System.Drawing.Point(31, 44);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(36, 13);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.Text = "Sayı 1";
            // 
            // textSayi1
            // 
            this.textSayi1.Location = new System.Drawing.Point(72, 41);
            this.textSayi1.Name = "textSayi1";
            this.textSayi1.Size = new System.Drawing.Size(100, 20);
            this.textSayi1.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(168, 138);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // textSayi2
            // 
            this.textSayi2.Location = new System.Drawing.Point(72, 77);
            this.textSayi2.Name = "textSayi2";
            this.textSayi2.Size = new System.Drawing.Size(100, 20);
            this.textSayi2.TabIndex = 4;
            // 
            // txtSayi2
            // 
            this.txtSayi2.AutoSize = true;
            this.txtSayi2.Location = new System.Drawing.Point(31, 80);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(36, 13);
            this.txtSayi2.TabIndex = 3;
            this.txtSayi2.Text = "Sayı 2";
            // 
            // textSayi3
            // 
            this.textSayi3.Location = new System.Drawing.Point(72, 112);
            this.textSayi3.Name = "textSayi3";
            this.textSayi3.Size = new System.Drawing.Size(100, 20);
            this.textSayi3.TabIndex = 6;
            // 
            // txtSayi3
            // 
            this.txtSayi3.AutoSize = true;
            this.txtSayi3.Location = new System.Drawing.Point(31, 115);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(36, 13);
            this.txtSayi3.TabIndex = 5;
            this.txtSayi3.Text = "Sayı 3";
            // 
            // textKucuk
            // 
            this.textKucuk.Location = new System.Drawing.Point(72, 183);
            this.textKucuk.Name = "textKucuk";
            this.textKucuk.Size = new System.Drawing.Size(100, 20);
            this.textKucuk.TabIndex = 8;
            // 
            // txtEnKucuk
            // 
            this.txtEnKucuk.AutoSize = true;
            this.txtEnKucuk.Location = new System.Drawing.Point(6, 186);
            this.txtEnKucuk.Name = "txtEnKucuk";
            this.txtEnKucuk.Size = new System.Drawing.Size(61, 13);
            this.txtEnKucuk.TabIndex = 7;
            this.txtEnKucuk.Text = "Küçük Sayı";
            // 
            // textBuyuk
            // 
            this.textBuyuk.Location = new System.Drawing.Point(72, 211);
            this.textBuyuk.Name = "textBuyuk";
            this.textBuyuk.Size = new System.Drawing.Size(100, 20);
            this.textBuyuk.TabIndex = 10;
            this.textBuyuk.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.AutoSize = true;
            this.txtEnBuyuk.Location = new System.Drawing.Point(6, 214);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.Size = new System.Drawing.Size(60, 13);
            this.txtEnBuyuk.TabIndex = 9;
            this.txtEnBuyuk.Text = "Büyük Sayı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(168, 237);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 331);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.textBuyuk);
            this.Controls.Add(this.txtEnBuyuk);
            this.Controls.Add(this.textKucuk);
            this.Controls.Add(this.txtEnKucuk);
            this.Controls.Add(this.textSayi3);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.textSayi2);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.textSayi1);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSayi1;
        private System.Windows.Forms.TextBox textSayi1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox textSayi2;
        private System.Windows.Forms.Label txtSayi2;
        private System.Windows.Forms.TextBox textSayi3;
        private System.Windows.Forms.Label txtSayi3;
        private System.Windows.Forms.TextBox textKucuk;
        private System.Windows.Forms.Label txtEnKucuk;
        private System.Windows.Forms.TextBox textBuyuk;
        private System.Windows.Forms.Label txtEnBuyuk;
        private System.Windows.Forms.Button btnTemizle;
    }
}

