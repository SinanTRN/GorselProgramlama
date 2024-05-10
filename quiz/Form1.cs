namespace quiz
{
    public partial class Form1 : Form
    {
        int[] dizi = new int[10];
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private int enKucuk(int[] dizi) 
        {
            int temp = dizi[0];
            for (int i = 1; i < sayac; i++)
            {
                if (dizi[i] < temp) temp = dizi[i];
            }
            return temp;
        }
        private int enBuyuk(int[] dizi)
        {
            int temp = dizi[0];
            for (int i = 1; i < sayac; i++)
            {
                if (dizi[i] > temp) temp = dizi[i];
            }
            return temp;
        }
        private int enYakin(int[] dizi, int ortalama)
        {
            int temp = Math.Abs(dizi[0] - ortalama);
            int index = 0;
            for (int i = 1; i < sayac; i++)
            {
                if (Math.Abs(dizi[i] - ortalama) < temp)
                {
                    temp = Math.Abs(dizi[i] - ortalama);
                    index = i;
                }
            }
            return dizi[index];

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int temp = 0;
            int toplam = 0;
            if (txtSayi.Text != "")
                temp = Convert.ToInt32(txtSayi.Text);
            if (sayac < 10)
            {
                dizi[sayac++] = temp;
                lblSayilar.Text= lblSayilar.Text+"," + temp;
            }

            for (int i = 0; i < dizi.Length; i++) toplam += dizi[i];
            lblToplam.Text = toplam+"";
            int ortalama =toplam/ sayac;
            lblOrtalama.Text = ortalama.ToString();
            lblEnKucuk.Text = enKucuk(dizi).ToString();
            lblEnBuyuk.Text=enBuyuk(dizi).ToString();
            lblYakin.Text=enYakin(dizi,ortalama).ToString();

            txtSayi.Text = "";

        }
    }
}
