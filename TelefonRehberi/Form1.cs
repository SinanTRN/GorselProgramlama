using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        System.Data.DataTable tablo;

        void kisileriGetir()
        {
            conn = new SqlConnection(@"server=SINANTURAN\SINANINSQL; initial catalog=dbRehber; integrated security=true");
            adapter = new SqlDataAdapter("Select *FROM Kisiler", conn);
            tablo = new System.Data.DataTable();
            conn.Open();
            adapter.Fill(tablo);
            dgvKisiler.DataSource = tablo;
            conn.Close();
            kisileriSay();
        }
        void kisileriSay()
        {
            label4.Text="Telefon rehberinde "+dgvKisiler.Rows.Count+" kişi var...";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kisileriGetir();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!alanlariKontrolEt()) return;
            cmd = new SqlCommand("Insert into Kisiler(Ad,Soyad,Telefon) values (@Ad,@Soyad,@Telefon)",conn);
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            kisileriGetir();
            MessageBox.Show(txtAd.Text+" "+txtSoyad.Text+" eklendi...");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!alanlariKontrolEt()) return;
            cmd = new SqlCommand("Update Kisiler set Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon where Id=@id", conn);
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@id", dgvKisiler.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            kisileriGetir();
            MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " Güncellendi...");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ad = dgvKisiler.CurrentRow.Cells[1].Value+"";
            string soyad = dgvKisiler.CurrentRow.Cells[2].Value + "";
            cmd = new SqlCommand("DELETE Kisiler where Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", dgvKisiler.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            kisileriGetir();
            MessageBox.Show(ad+" "+soyad+" Silindi...");

        }
        private void dgvKisiler_CellEnter(object sender,DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgvKisiler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = "Ad like '" + txtAra.Text + "%'";
                dgvKisiler.DataSource = dv;
            }
            catch (Exception) { }

        }
        private bool alanlariKontrolEt()
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return false;
            }
            return true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel= new Microsoft.Office.Interop.Excel.Application();
            //exceli görünür hale getir
            excel.Visible = true;
            //excel yeni bir çalışma sayfası açma
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            //Başlangıç yerini seç 
            Worksheet sheet1 = (Worksheet)workbook.Worksheets[1];
            //Başlangıç sütununu seç
            int StartCol = 1;
            //Başlangıç satırını seç
            int StartRow= 1;
            
            for(int j = 0; j < dgvKisiler.ColumnCount; j++)
            {
                //Excel hücrelerine veri aktarma
                Range range = (Range)sheet1.Cells[StartRow, StartCol + j];
                range.Value2 = dgvKisiler.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvKisiler.RowCount; i++)
            {
                for (int j = 0; j < dgvKisiler.ColumnCount; j++)
                {
                    Range range = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    range.Value2 = dgvKisiler.Rows[i].Cells[j].Value;
                }
            }

            // Tüm sütunları otomatik genişlik yap
            Range columnsRange = sheet1.UsedRange.Columns;
            columnsRange.EntireColumn.AutoFit();

        }
    }
}
