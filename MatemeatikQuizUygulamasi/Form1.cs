
namespace MatemeatikQuizUygulamasi
{
    public partial class Form1 : Form
    {
        Random sayi = new Random();
        string[] islemler = ["+", "-", "*", "/"];
        int dogruSayaci = 0;
        int sure=30;
        public Form1()
        {
            InitializeComponent();
            sayici.Stop();
        }
        private void createNumber()
        {
            num1.Text = sayi.Next(1, 100) + "";
            num2.Text = sayi.Next(1, 100) + "";
            num3.Text = sayi.Next(1, 100) + "";
            num4.Text = sayi.Next(1, 100) + "";
            num5.Text = sayi.Next(1, 100) + "";
            num6.Text = sayi.Next(1, 100) + "";
            num7.Text = sayi.Next(1, 100) + "";
            num8.Text = sayi.Next(1, 100) + "";
            num9.Text = sayi.Next(1, 100) + "";
            num10.Text = sayi.Next(1, 100) + "";
        }
        private void createOperator()
        {
            islem1.Text = islemler[sayi.Next(3)];
            islem2.Text = islemler[sayi.Next(3)];
            islem3.Text = islemler[sayi.Next(3)];
            islem4.Text = islemler[sayi.Next(3)];
            islem5.Text = islemler[sayi.Next(3)];
        }
        private void setTime(int time)
        {
            sure = time;
            sayac.Text = time + " saniye...";
            sayici.Start();
        }
        private void clearResult()
        {
            sonuc1.Value = 0;
            sonuc2.Value = 0;
            sonuc3.Value = 0;
            sonuc4.Value = 0;
            sonuc5.Value = 0;

            sonuc1.ForeColor = Color.White;
            sonuc2.ForeColor = Color.White;
            sonuc3.ForeColor = Color.White;
            sonuc4.ForeColor = Color.White;
            sonuc5.ForeColor = Color.White;
        }
        private void hesapla()
        {
            int cvp1 = 0;
            switch (islem1.Text)
            {
                case "+":
                    cvp1 = Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text); break;
                case "-":
                    cvp1 = Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text); break;
                case "*":
                    cvp1 = Convert.ToInt32(num1.Text) * Convert.ToInt32(num2.Text); break;
                case "/":
                    cvp1 = Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text); break;
            }
            if (sonuc1.Value == cvp1)
            {
                sonuc1.ForeColor = Color.Green;
                dogruSayaci++;
            }
            else sonuc1.ForeColor = Color.Red;

            int cvp2 = 0;
            switch (islem2.Text)
            {
                case "+":
                    cvp2 = Convert.ToInt32(num3.Text) + Convert.ToInt32(num4.Text); break;
                case "-":
                    cvp2 = Convert.ToInt32(num3.Text) - Convert.ToInt32(num4.Text); break;
                case "*":
                    cvp2 = Convert.ToInt32(num3.Text) * Convert.ToInt32(num4.Text); break;
                case "/":
                    cvp2 = Convert.ToInt32(num3.Text) + Convert.ToInt32(num4.Text); break;
            }
            if (sonuc2.Value == cvp2)
            {
                sonuc2.ForeColor = Color.Green;
                dogruSayaci++;
            }
            else sonuc2.ForeColor = Color.Red;

            int cvp3 = 0;
            switch (islem3.Text)
            {
                case "+":
                    cvp3 = Convert.ToInt32(num5.Text) + Convert.ToInt32(num6.Text); break;
                case "-":
                    cvp3 = Convert.ToInt32(num5.Text) - Convert.ToInt32(num6.Text); break;
                case "*":
                    cvp3 = Convert.ToInt32(num5.Text) * Convert.ToInt32(num6.Text); break;
                case "/":
                    cvp3 = Convert.ToInt32(num5.Text) + Convert.ToInt32(num6.Text); break;
            }
            if (sonuc3.Value == cvp3)
            {
                sonuc3.ForeColor = Color.Green;
                dogruSayaci++;
            }
            else sonuc3.ForeColor = Color.Red;

            int cvp4 = 0;
            switch (islem4.Text)
            {
                case "+":
                    cvp4 = Convert.ToInt32(num7.Text) + Convert.ToInt32(num8.Text); break;
                case "-":
                    cvp4 = Convert.ToInt32(num7.Text) - Convert.ToInt32(num8.Text); break;
                case "*":
                    cvp4 = Convert.ToInt32(num7.Text) * Convert.ToInt32(num8.Text); break;
                case "/":
                    cvp4 = Convert.ToInt32(num7.Text) + Convert.ToInt32(num8.Text); break;
            }
            if (sonuc4.Value == cvp4)
            {
                sonuc4.ForeColor = Color.Green;
                dogruSayaci++;
            }
            else sonuc4.ForeColor = Color.Red;

            int cvp5 = 0;
            switch (islem5.Text)
            {
                case "+":
                    cvp5 = Convert.ToInt32(num9.Text) + Convert.ToInt32(num10.Text); break;
                case "-":
                    cvp5 = Convert.ToInt32(num9.Text) - Convert.ToInt32(num10.Text); break;
                case "*":
                    cvp5 = Convert.ToInt32(num9.Text) * Convert.ToInt32(num10.Text); break;
                case "/":
                    cvp5 = Convert.ToInt32(num9.Text) / Convert.ToInt32(num10.Text); break;
            }
            if (sonuc5.Value == cvp5)
            {
                sonuc5.ForeColor = Color.Green;
                dogruSayaci++;
            }
            else sonuc5.ForeColor = Color.Red;

        }
        private void resultControl()
        {
            hesapla();
            MessageBox.Show(dogruSayaci + " Adet dogru cevabiniz var ", "Kontrol", MessageBoxButtons.OK);
            clearResult();
            dogruSayaci = 0;
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            createNumber();
            createOperator();
            setTime(30);
            
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            resultControl();
        }

        private void sayici_Tick(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                sure--;
                sayac.Text = sure + " saniye...";
            }
            else if (sure == 0)
            {
                sayici.Stop();
                resultControl();
                sure = -1;
            } 

        }
    }
}
