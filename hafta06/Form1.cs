using System.Data;
using System.Text;
using System.Text.Json;

namespace hafta06
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private List<Ogrenci> ogrenciler;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            ogrenciler = new List<Ogrenci>();
            dt.Columns.Add("Öðrenci No: ");
            dt.Columns.Add("Öðrenci Adý: ");
            dt.Columns.Add("Öðrenci Soyadý: ");
            dt.Columns.Add("Vize Notu: ");
            dt.Columns.Add("Final Notu: ");
            dt.Columns.Add("Geçme Notu: ");

            dgwOgrenciler.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciNo = txtOgrenciNo.Text;
            ogrenci.OgrenciAdi = txtOgrenciAdi.Text;
            ogrenci.OgrenciSoyadi = txtOgrenciSoyadi.Text;
            ogrenci.OgrenciVize = Convert.ToDouble(OgrenciVize.Value);
            ogrenci.OgrenciFinal = Convert.ToDouble(OgrenciFinal.Value);

            ogrenci.tabloyaEkle(dt);
            ogrenciler.Add(ogrenci);

            txtOgrenciNo.Text = "";
            txtOgrenciAdi.Text = "";
            txtOgrenciSoyadi.Text = "";
            OgrenciVize.Value = 0;
            OgrenciFinal.Value = 0;
        }

        private void kaydetTsmi_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Ogrenci>>(ogrenciler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               
                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }

        }

        private void yükleTsmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data=File.ReadAllText(dialog.FileName);
                ogrenciler = JsonSerializer.Deserialize<List<Ogrenci>>(data);
                foreach(Ogrenci ogr in ogrenciler)
                {
                    ogr.tabloyaEkle(dt);
                }
            }

        }
    }
}
