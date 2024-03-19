namespace UrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataalanı = new System.Windows.Forms.DataGridView();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStokGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsimGuncelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataalanı)).BeginInit();
            this.SuspendLayout();
            // 
            // dataalanı
            // 
            this.dataalanı.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataalanı.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataalanı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataalanı, "dataalanı");
            this.dataalanı.Name = "dataalanı";
            this.dataalanı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataalanı_CellClick);
            this.dataalanı.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // serviceController1
            // 
            this.serviceController1.MachineName = "SinanTURAN";
            this.serviceController1.ServiceName = "MSSQL$SINANINSQL";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtIsim
            // 
            resources.ApplyResources(this.txtIsim, "txtIsim");
            this.txtIsim.Name = "txtIsim";
            // 
            // txtStok
            // 
            resources.ApplyResources(this.txtStok, "txtStok");
            this.txtStok.Name = "txtStok";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtFiyat
            // 
            resources.ApplyResources(this.txtFiyat, "txtFiyat");
            this.txtFiyat.Name = "txtFiyat";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.btnGuncelle, "btnGuncelle");
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtFiyatGuncelle
            // 
            resources.ApplyResources(this.txtFiyatGuncelle, "txtFiyatGuncelle");
            this.txtFiyatGuncelle.Name = "txtFiyatGuncelle";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtStokGuncelle
            // 
            resources.ApplyResources(this.txtStokGuncelle, "txtStokGuncelle");
            this.txtStokGuncelle.Name = "txtStokGuncelle";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtIsimGuncelle
            // 
            resources.ApplyResources(this.txtIsimGuncelle, "txtIsimGuncelle");
            this.txtIsimGuncelle.Name = "txtIsimGuncelle";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnSil
            // 
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtFiyatGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStokGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIsimGuncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataalanı);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataalanı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataalanı;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtFiyatGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStokGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsimGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
    }
}

