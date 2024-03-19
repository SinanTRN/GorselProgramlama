using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ÜrünlerDal ürünler = new ÜrünlerDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataalanı.DataSource = ürünler.yazdir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ürünler.ekle(new Ürünler
            {
                İsim = txtIsim.Text,
                Stok = Convert.ToInt32(txtStok.Text),
                Fiyat = Convert.ToInt32(txtFiyat.Text)
            });
            dataalanı.DataSource = ürünler.yazdir();
            MessageBox.Show("Ürün eklendi...");
        }

        private void dataalanı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIsimGuncelle.Text = dataalanı.CurrentRow.Cells[1].Value.ToString();
            txtStokGuncelle.Text = dataalanı.CurrentRow.Cells[2].Value.ToString();
            txtFiyatGuncelle.Text = dataalanı.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ürünler ürün = new Ürünler
            {
                Id = Convert.ToInt32(dataalanı.CurrentRow.Cells[0].Value),
                İsim = txtIsimGuncelle.Text,
                Stok = Convert.ToInt32(txtStokGuncelle.Text),
                Fiyat = Convert.ToInt32(txtFiyatGuncelle.Text)

            };
            ürünler.guncelle(ürün);
            dataalanı.DataSource = ürünler.yazdir();
            MessageBox.Show("Güncelleme yapıldı...");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Ürünler ürün = new Ürünler
            {
                Id = Convert.ToInt32(dataalanı.CurrentRow.Cells[0].Value)
            };
            ürünler.sil(ürün);
            dataalanı.DataSource = ürünler.yazdir();
            MessageBox.Show("Ürün silindi...");
        }
    }
}
