namespace quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSayi = new TextBox();
            btnEkle = new Button();
            label2 = new Label();
            lblSayilar = new Label();
            lblToplam = new Label();
            label3 = new Label();
            label4 = new Label();
            lblOrtalama = new Label();
            label5 = new Label();
            lblEnKucuk = new Label();
            label6 = new Label();
            lblEnBuyuk = new Label();
            label7 = new Label();
            lblYakin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Bir sayı girin";
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(104, 35);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(134, 23);
            txtSayi.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(244, 35);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Sayı gir";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 35);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Girilen Sayılar";
            // 
            // lblSayilar
            // 
            lblSayilar.AutoSize = true;
            lblSayilar.Location = new Point(393, 70);
            lblSayilar.Name = "lblSayilar";
            lblSayilar.Size = new Size(10, 15);
            lblSayilar.TabIndex = 4;
            lblSayilar.Text = " ";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(104, 129);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(38, 15);
            lblToplam.TabIndex = 5;
            lblToplam.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Toplam:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 162);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Ortalama:";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(104, 162);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(38, 15);
            lblOrtalama.TabIndex = 8;
            lblOrtalama.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 188);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "En Küçük:";
            // 
            // lblEnKucuk
            // 
            lblEnKucuk.AutoSize = true;
            lblEnKucuk.Location = new Point(104, 188);
            lblEnKucuk.Name = "lblEnKucuk";
            lblEnKucuk.Size = new Size(38, 15);
            lblEnKucuk.TabIndex = 10;
            lblEnKucuk.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 216);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 11;
            label6.Text = "En Büyük:";
            // 
            // lblEnBuyuk
            // 
            lblEnBuyuk.AutoSize = true;
            lblEnBuyuk.Location = new Point(104, 216);
            lblEnBuyuk.Name = "lblEnBuyuk";
            lblEnBuyuk.Size = new Size(38, 15);
            lblEnBuyuk.TabIndex = 12;
            lblEnBuyuk.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 244);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "En Yakın";
            // 
            // lblYakin
            // 
            lblYakin.AutoSize = true;
            lblYakin.Location = new Point(104, 244);
            lblYakin.Name = "lblYakin";
            lblYakin.Size = new Size(38, 15);
            lblYakin.TabIndex = 14;
            lblYakin.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblYakin);
            Controls.Add(label7);
            Controls.Add(lblEnBuyuk);
            Controls.Add(label6);
            Controls.Add(lblEnKucuk);
            Controls.Add(label5);
            Controls.Add(lblOrtalama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblToplam);
            Controls.Add(lblSayilar);
            Controls.Add(label2);
            Controls.Add(btnEkle);
            Controls.Add(txtSayi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi;
        private Button btnEkle;
        private Label label2;
        private Label lblSayilar;
        private Label lblToplam;
        private Label label3;
        private Label label4;
        private Label lblOrtalama;
        private Label label5;
        private Label lblEnKucuk;
        private Label label6;
        private Label lblEnBuyuk;
        private Label label7;
        private Label lblYakin;
    }
}
