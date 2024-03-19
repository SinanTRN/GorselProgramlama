namespace hafta06
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
            dgwOgrenciler = new DataGridView();
            groupBox1 = new GroupBox();
            btnEkle = new Button();
            OgrenciFinal = new NumericUpDown();
            OgrenciVize = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOgrenciSoyadi = new TextBox();
            txtOgrenciAdi = new TextBox();
            txtOgrenciNo = new TextBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            dosyaTsmi = new ToolStripMenuItem();
            yükleTsmi = new ToolStripMenuItem();
            kaydetTsmi = new ToolStripMenuItem();
            yardımTsmi = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgwOgrenciler).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OgrenciFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OgrenciVize).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dgwOgrenciler
            // 
            dgwOgrenciler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOgrenciler.Location = new Point(244, 45);
            dgwOgrenciler.Name = "dgwOgrenciler";
            dgwOgrenciler.Size = new Size(646, 393);
            dgwOgrenciler.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(OgrenciFinal);
            groupBox1.Controls.Add(OgrenciVize);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtOgrenciSoyadi);
            groupBox1.Controls.Add(txtOgrenciAdi);
            groupBox1.Controls.Add(txtOgrenciNo);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 393);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(99, 184);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 23);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // OgrenciFinal
            // 
            OgrenciFinal.Location = new Point(99, 141);
            OgrenciFinal.Name = "OgrenciFinal";
            OgrenciFinal.Size = new Size(120, 23);
            OgrenciFinal.TabIndex = 5;
            // 
            // OgrenciVize
            // 
            OgrenciVize.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            OgrenciVize.Location = new Point(99, 112);
            OgrenciVize.Name = "OgrenciVize";
            OgrenciVize.Size = new Size(120, 23);
            OgrenciVize.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 1;
            label5.Text = "Final Notu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Vize Notu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 1;
            label3.Text = "Öğrenci Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci No";
            // 
            // txtOgrenciSoyadi
            // 
            txtOgrenciSoyadi.Location = new Point(99, 80);
            txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            txtOgrenciSoyadi.Size = new Size(120, 23);
            txtOgrenciSoyadi.TabIndex = 3;
            txtOgrenciSoyadi.TextChanged += textBox1_TextChanged;
            // 
            // txtOgrenciAdi
            // 
            txtOgrenciAdi.Location = new Point(99, 51);
            txtOgrenciAdi.Name = "txtOgrenciAdi";
            txtOgrenciAdi.Size = new Size(120, 23);
            txtOgrenciAdi.TabIndex = 2;
            txtOgrenciAdi.TextChanged += textBox1_TextChanged;
            // 
            // txtOgrenciNo
            // 
            txtOgrenciNo.Location = new Point(99, 22);
            txtOgrenciNo.Name = "txtOgrenciNo";
            txtOgrenciNo.Size = new Size(120, 23);
            txtOgrenciNo.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(226, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { dosyaTsmi, yardımTsmi });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(902, 24);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // dosyaTsmi
            // 
            dosyaTsmi.DropDownItems.AddRange(new ToolStripItem[] { yükleTsmi, kaydetTsmi });
            dosyaTsmi.Name = "dosyaTsmi";
            dosyaTsmi.Size = new Size(51, 20);
            dosyaTsmi.Text = "Dosya";
            // 
            // yükleTsmi
            // 
            yükleTsmi.Name = "yükleTsmi";
            yükleTsmi.Size = new Size(180, 22);
            yükleTsmi.Text = "Yükle";
            yükleTsmi.Click += yükleTsmi_Click;
            // 
            // kaydetTsmi
            // 
            kaydetTsmi.Name = "kaydetTsmi";
            kaydetTsmi.Size = new Size(180, 22);
            kaydetTsmi.Text = "Kaydet";
            kaydetTsmi.Click += kaydetTsmi_Click;
            // 
            // yardımTsmi
            // 
            yardımTsmi.Name = "yardımTsmi";
            yardımTsmi.Size = new Size(56, 20);
            yardımTsmi.Text = "Yardım";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgwOgrenciler);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwOgrenciler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OgrenciFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)OgrenciVize).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwOgrenciler;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOgrenciAdi;
        private TextBox txtOgrenciNo;
        private NumericUpDown OgrenciFinal;
        private NumericUpDown OgrenciVize;
        private TextBox txtOgrenciSoyadi;
        private Button btnEkle;
        private Label label5;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dosyaTsmi;
        private ToolStripMenuItem yükleTsmi;
        private ToolStripMenuItem kaydetTsmi;
        private ToolStripMenuItem yardımTsmi;
    }
}
