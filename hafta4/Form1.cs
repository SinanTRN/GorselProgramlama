using System.Windows.Forms;

namespace hafta4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void basitDialogOlay(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj buraya yazýlacak", "Baþlýk buraya yazýlacak");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Mesajýmýz", "Baþlýk", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                textBox1.Text = "Evet/Hayýr dialogda Evet'e týklandý";
            }
            else
            {
                textBox1.Text = "Evet/Hayýr dialogda Hayýr'a týklandý";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj", "Baþlýk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Bir dosya seçiniz...";
            dialog.Filter = "Tüm Dosyalar|*.*| pdf dosyalarý|*.pdf";

            DialogResult sonuc = dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dosyanýz kaydediliyor";
            dialog.Filter = "Metin dosyalarý|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.Color.ToString();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.Font.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            datetime.Value =DateTime.Now.AddDays(10);
        }


    }
}
