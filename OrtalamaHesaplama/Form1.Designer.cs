namespace OrtalamaHesaplama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtD1V = new System.Windows.Forms.TextBox();
            this.txtD1F = new System.Windows.Forms.TextBox();
            this.txtD1O = new System.Windows.Forms.TextBox();
            this.txtD2O = new System.Windows.Forms.TextBox();
            this.txtD2F = new System.Windows.Forms.TextBox();
            this.txtD2V = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtD3O = new System.Windows.Forms.TextBox();
            this.txtD3F = new System.Windows.Forms.TextBox();
            this.txtD3V = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGO = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders1";
            // 
            // txtD1V
            // 
            this.txtD1V.Location = new System.Drawing.Point(67, 43);
            this.txtD1V.Name = "txtD1V";
            this.txtD1V.Size = new System.Drawing.Size(43, 20);
            this.txtD1V.TabIndex = 1;
            this.txtD1V.TextChanged += new System.EventHandler(this.txtD1V_TextChanged);
            // 
            // txtD1F
            // 
            this.txtD1F.Location = new System.Drawing.Point(126, 43);
            this.txtD1F.Name = "txtD1F";
            this.txtD1F.Size = new System.Drawing.Size(43, 20);
            this.txtD1F.TabIndex = 3;
            this.txtD1F.TextChanged += new System.EventHandler(this.txtD1F_TextChanged);
            // 
            // txtD1O
            // 
            this.txtD1O.Location = new System.Drawing.Point(219, 43);
            this.txtD1O.Name = "txtD1O";
            this.txtD1O.Size = new System.Drawing.Size(58, 20);
            this.txtD1O.TabIndex = 4;
            // 
            // txtD2O
            // 
            this.txtD2O.Location = new System.Drawing.Point(219, 79);
            this.txtD2O.Name = "txtD2O";
            this.txtD2O.Size = new System.Drawing.Size(58, 20);
            this.txtD2O.TabIndex = 8;
            // 
            // txtD2F
            // 
            this.txtD2F.Location = new System.Drawing.Point(126, 79);
            this.txtD2F.Name = "txtD2F";
            this.txtD2F.Size = new System.Drawing.Size(43, 20);
            this.txtD2F.TabIndex = 7;
            this.txtD2F.TextChanged += new System.EventHandler(this.txtD2F_TextChanged);
            // 
            // txtD2V
            // 
            this.txtD2V.Location = new System.Drawing.Point(67, 79);
            this.txtD2V.Name = "txtD2V";
            this.txtD2V.Size = new System.Drawing.Size(43, 20);
            this.txtD2V.TabIndex = 6;
            this.txtD2V.TextChanged += new System.EventHandler(this.txtD2V_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ders2";
            // 
            // txtD3O
            // 
            this.txtD3O.Location = new System.Drawing.Point(219, 114);
            this.txtD3O.Name = "txtD3O";
            this.txtD3O.Size = new System.Drawing.Size(58, 20);
            this.txtD3O.TabIndex = 12;
            // 
            // txtD3F
            // 
            this.txtD3F.Location = new System.Drawing.Point(126, 114);
            this.txtD3F.Name = "txtD3F";
            this.txtD3F.Size = new System.Drawing.Size(43, 20);
            this.txtD3F.TabIndex = 11;
            this.txtD3F.TextChanged += new System.EventHandler(this.txtD3F_TextChanged);
            // 
            // txtD3V
            // 
            this.txtD3V.Location = new System.Drawing.Point(67, 114);
            this.txtD3V.Name = "txtD3V";
            this.txtD3V.Size = new System.Drawing.Size(43, 20);
            this.txtD3V.TabIndex = 10;
            this.txtD3V.TextChanged += new System.EventHandler(this.txtD3V_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ders3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Genel Ortalama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGO
            // 
            this.txtGO.Location = new System.Drawing.Point(219, 150);
            this.txtGO.Name = "txtGO";
            this.txtGO.Size = new System.Drawing.Size(58, 20);
            this.txtGO.TabIndex = 14;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(177, 195);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 23);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vize";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ortalama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(384, 319);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtGO);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtD3O);
            this.Controls.Add(this.txtD3F);
            this.Controls.Add(this.txtD3V);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtD2O);
            this.Controls.Add(this.txtD2F);
            this.Controls.Add(this.txtD2V);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtD1O);
            this.Controls.Add(this.txtD1F);
            this.Controls.Add(this.txtD1V);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ortalama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtD1V;
        private System.Windows.Forms.TextBox txtD1F;
        private System.Windows.Forms.TextBox txtD1O;
        private System.Windows.Forms.TextBox txtD2O;
        private System.Windows.Forms.TextBox txtD2F;
        private System.Windows.Forms.TextBox txtD2V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtD3O;
        private System.Windows.Forms.TextBox txtD3F;
        private System.Windows.Forms.TextBox txtD3V;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtGO;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

