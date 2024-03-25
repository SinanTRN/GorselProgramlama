using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Hafta07
{
    public partial class Form1 : Form
    {
        System.Data.DataTable ogrenciler;
        SQLiteConnection baglanti;
        public Form1()
        {
            InitializeComponent();

            string baglanti_metni = "Data Source=okul.db;Version=3;";

            try
            {
                baglanti = new SQLiteConnection(baglanti_metni);
                baglanti.Open();
                tabloGuncelle();

                //MessageBox.Show("SQLite Baðlantýsý kuruldu",
                //               "Baðlantý saðlandý",
                //               MessageBoxButtons.OK,
                //               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite Baðlantısı kurulamadı",
                                "Bağlantı hatası",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Close();

                    //MessageBox.Show("SQLite Baðlantýsý baþarýyla kapatýldý.",
                    //               "Baðlantý sonlandýrýldý",
                    //               MessageBoxButtons.OK,
                    //               MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQLite Baðlantýsý sonlandýrýlýrken hata ile karþýlaþýldý",
                                    "Baðlantý sonlandýrma hatasý",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        public void tabloGuncelle()
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Ogrenci";

            ogrenciler = new DataTable();
                ogrenciler.Columns.Add("ID");
                ogrenciler.Columns.Add("Numara");
                ogrenciler.Columns.Add("isim");
                ogrenciler.Columns.Add("Soyisim");
                ogrenciler.Columns.Add("Email");

            var okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ogrenciler.Rows.Add(new object[] { okuyucu.GetInt32(0) ,
                                                   okuyucu.GetString(1),
                                                    okuyucu.GetString(2),
                                                    okuyucu.GetString(3),
                                                    okuyucu.IsDBNull(4) ? "" : okuyucu.GetString(4)});

            }
            dgvOgrenciler.DataSource = ogrenciler;
            kisileriSay();
        }
        void kisileriSay()
        {
            int sayi = dgvOgrenciler.Rows.Count - 1;
            lblSayi.Text = "Öğrenci listesinde " + sayi  + " kişi var...";
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells[0].Value);

                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = $"DELETE FROM ogrenci WHERE ID = {id}";

                int eklenen_sayisi = komut.ExecuteNonQuery();
                if (eklenen_sayisi > 0)
                    tabloGuncelle();
            }
            catch (Exception ex) { }


            txtNumara.Text = "";
            txtIsim.Text = "";
            txtSoyisim.Text = "";
            txtEmail.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO ogrenci (numara,isim,soyisim,email) VALUES(\"{txtNumara.Text}\", \"{txtIsim.Text}\", \"{txtSoyisim.Text}\", \"{txtEmail.Text}\")";


            int eklenen_sayisi = komut.ExecuteNonQuery();
            if (eklenen_sayisi > 0)
                tabloGuncelle();

            txtNumara.Text = "";
            txtIsim.Text = "";
            txtSoyisim.Text = "";
            txtEmail.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvOgrenciler.SelectedRows[0].Cells[0].Value);

                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = $"UPDATE ogrenci SET numara=\"{txtNumara.Text}\",isim=\"{txtIsim.Text}\",soyisim=\"{txtSoyisim.Text}\",email=\"{txtEmail.Text}\" WHERE ID={id}";

                int eklenen_sayisi = komut.ExecuteNonQuery();
                if (eklenen_sayisi > 0)
                    tabloGuncelle();
            }
            catch (Exception ex) { }
        }
        private void dgvOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtNumara.Text = dgvOgrenciler.SelectedRows[0].Cells[1].Value.ToString();
                txtIsim.Text = dgvOgrenciler.SelectedRows[0].Cells[2].Value.ToString();
                txtSoyisim.Text = dgvOgrenciler.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text = dgvOgrenciler.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = ogrenciler.DefaultView;
                dv.RowFilter = "Ad like '" + txtAra.Text + "%'";
                dgvOgrenciler.DataSource = dv;
            }
            catch (Exception) { }
        }
    }
}
