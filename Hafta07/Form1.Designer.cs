namespace Hafta07
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
            dgvOgrenciler = new DataGridView();
            groupBox1 = new GroupBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSoyisim = new TextBox();
            label3 = new Label();
            txtIsim = new TextBox();
            label2 = new Label();
            txtNumara = new TextBox();
            label1 = new Label();
            btnAra = new Button();
            txtAra = new TextBox();
            lblSayi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(308, 64);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.Size = new Size(527, 374);
            dgvOgrenciler.TabIndex = 0;
            dgvOgrenciler.CellClick += dgvOgrenciler_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyisim);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 201);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "\U0001f9d1‍🎓Öğrenci";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9.75F);
            btnGuncelle.Location = new Point(209, 151);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9.75F);
            btnSil.Location = new Point(144, 151);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(59, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9.75F);
            btnEkle.Location = new Point(73, 151);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(65, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(73, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 25);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(15, 123);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // txtSoyisim
            // 
            txtSoyisim.Font = new Font("Segoe UI", 9.75F);
            txtSoyisim.Location = new Point(73, 89);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(211, 25);
            txtSoyisim.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(15, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 0;
            label3.Text = "Soyisim";
            // 
            // txtIsim
            // 
            txtIsim.Font = new Font("Segoe UI", 9.75F);
            txtIsim.Location = new Point(73, 58);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(211, 25);
            txtIsim.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 0;
            label2.Text = "İsim";
            // 
            // txtNumara
            // 
            txtNumara.Font = new Font("Segoe UI", 9.75F);
            txtNumara.Location = new Point(76, 25);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(208, 25);
            txtNumara.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 0;
            label1.Text = "Numara";
            // 
            // btnAra
            // 
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAra.Location = new Point(760, 35);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAra.Location = new Point(308, 35);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(446, 23);
            txtAra.TabIndex = 4;
            // 
            // lblSayi
            // 
            lblSayi.AutoSize = true;
            lblSayi.Location = new Point(12, 268);
            lblSayi.Name = "lblSayi";
            lblSayi.Size = new Size(0, 15);
            lblSayi.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(lblSayi);
            Controls.Add(txtAra);
            Controls.Add(btnAra);
            Controls.Add(groupBox1);
            Controls.Add(dgvOgrenciler);
            Name = "Form1";
            Text = "SQLite Denemeleri";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOgrenciler;
        private GroupBox groupBox1;
        private Button btnEkle;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSoyisim;
        private Label label3;
        private TextBox txtIsim;
        private Label label2;
        private TextBox txtNumara;
        private Label label1;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnAra;
        private TextBox txtAra;
        private Label lblSayi;
    }
}
