using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBuyukEnKucuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enBuyuk=0, enKucuk=0;
            sayi1 = Convert.ToInt32(textSayi1.Text);
            sayi2 = Convert.ToInt32(textSayi2.Text);
            sayi3=Convert.ToInt32(textSayi3.Text);
            if (sayi1 >= sayi2 && sayi1 >= sayi3) enBuyuk = sayi1;
            if (sayi2 >= sayi1 && sayi2 >= sayi3) enBuyuk = sayi2;
            if (sayi3 >= sayi1 && sayi3 >= sayi2) enBuyuk = sayi3;

            if (sayi1 <= sayi2 && sayi1 <= sayi3) enKucuk = sayi1;
            if (sayi2 <= sayi1 && sayi2 <= sayi3) enKucuk = sayi2;
            if (sayi3 <= sayi1 && sayi3 <= sayi2) enKucuk = sayi3;
            
            textBuyuk.Text = enBuyuk.ToString();
            textKucuk.Text = enKucuk.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textSayi1.Text = "";
            textSayi2.Text = "";
            textSayi3.Text = "";
            textBuyuk.Text = "";
            textKucuk.Text = "";
        }
    }
}
