using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.FixedSingle;
            MaximizeBox = false;

        }
        private void txtD1V_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = 0, vize = 0, final = 0;
                if (!string.IsNullOrEmpty(txtD1V.Text) && !string.IsNullOrEmpty(txtD1F.Text))
                {
                    if (Convert.ToDouble(txtD1V.Text)>=0 && Convert.ToDouble(txtD1V.Text)<=100)
                        vize = Convert.ToDouble(txtD1V.Text);
                    if (Convert.ToDouble(txtD1F.Text) >= 0 && Convert.ToDouble(txtD1F.Text) <= 100)
                        final = Convert.ToDouble(txtD1F.Text);
                    try
                    {
                        value = ((vize * 4 + final * 6) / 10);
                        txtD1O.Text = value.ToString("0.00").Trim();
                        if (value < 45)
                        {
                            txtD1O.BackColor = Color.Red;
                            txtD1O.ForeColor = Color.White;
                        }
                        else if (value >= 45 && value < 50)
                        {
                            txtD1O.BackColor = Color.Blue;
                            txtD1O.ForeColor = Color.White;
                        }
                        else
                        {
                            txtD1O.BackColor = Color.Green;
                            txtD1O.ForeColor = Color.White;
                        }
                    }
                    catch (FormatException) { }
                }
            }
            catch (FormatException)
            {

            }

        }

        private void txtD1F_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = 0, vize = 0, final = 0;
                if (!string.IsNullOrEmpty(txtD1V.Text) && !string.IsNullOrEmpty(txtD1F.Text))
                {
                    vize = Convert.ToDouble(txtD1V.Text);
                    final = Convert.ToDouble(txtD1F.Text);
                    value = ((vize * 4 + final * 6) / 10);
                    txtD1O.Text = value.ToString("0.00").Trim();
                    if (value < 45)
                    {
                        txtD1O.BackColor = Color.Red;
                        txtD1O.ForeColor = Color.White;
                    }
                    else if (value >= 45 && value < 50)
                    {
                        txtD1O.BackColor = Color.Blue;
                        txtD1O.ForeColor = Color.White;
                    }
                    else
                    {
                        txtD1O.BackColor = Color.Green;
                        txtD1O.ForeColor = Color.White;
                    }
                }
            }
            catch (FormatException)
            {

            }

        }

        private void txtD2V_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = 0, vize = 0, final = 0;
                if (!string.IsNullOrEmpty(txtD2V.Text) && !string.IsNullOrEmpty(txtD2F.Text))
                {
                    vize = Convert.ToDouble(txtD2V.Text);
                    final = Convert.ToDouble(txtD2F.Text);
                    value = ((vize * 4 + final * 6) / 10);
                    txtD2O.Text = value.ToString("0.00").Trim();
                    if (value < 45)
                    {
                        txtD2O.BackColor = Color.Red;
                        txtD2O.ForeColor = Color.White;
                    }
                    else if (value >= 45 && value < 50)
                    {
                        txtD2O.BackColor = Color.Blue;
                        txtD2O.ForeColor = Color.White;
                    }
                    else
                    {
                        txtD2O.BackColor = Color.Green;
                        txtD2O.ForeColor = Color.White;
                    }
                }
            } catch(FormatException) { }

        }

        private void txtD2F_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = 0, vize = 0, final = 0;
                if (!string.IsNullOrEmpty(txtD2V.Text) && !string.IsNullOrEmpty(txtD2F.Text))
                {
                    vize = Convert.ToDouble(txtD2V.Text);
                    final = Convert.ToDouble(txtD2F.Text);
                    value = ((vize * 4 + final * 6) / 10);
                    txtD2O.Text = value.ToString("0.00").Trim();
                    if (value < 45)
                    {
                        txtD2O.BackColor = Color.Red;
                        txtD2O.ForeColor = Color.White;
                    }
                    else if (value >= 45 && value < 50)
                    {
                        txtD2O.BackColor = Color.Blue;
                        txtD2O.ForeColor = Color.White;
                    }
                    else
                    {
                        txtD2O.BackColor = Color.Green;
                        txtD2O.ForeColor = Color.White;
                    }
                }
            }
            catch (FormatException) { }

        }

        private void txtD3V_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = 0, vize = 0, final = 0;
                if (!string.IsNullOrEmpty(txtD3V.Text) && !string.IsNullOrEmpty(txtD3F.Text))
                {
                    vize = Convert.ToDouble(txtD3V.Text);
                    final = Convert.ToDouble(txtD3F.Text);
                    value = ((vize * 4 + final * 6) / 10);
                    txtD3O.Text = value.ToString("0.00").Trim();
                    if (value < 45)
                    {
                        txtD3O.BackColor = Color.Red;
                        txtD3O.ForeColor = Color.White;
                    }
                    else if (value >= 45 && value < 50)
                    {
                        txtD3O.BackColor = Color.Blue;
                        txtD3O.ForeColor = Color.White;
                    }
                    else
                    {
                        txtD3O.BackColor = Color.Green;
                        txtD3O.ForeColor = Color.White;
                    }
                }
            }
            catch (FormatException) { }
        }

        private void txtD3F_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = 0, vize = 0, final = 0;
                if (!string.IsNullOrEmpty(txtD3V.Text) && !string.IsNullOrEmpty(txtD3F.Text))
                {
                    vize = Convert.ToDouble(txtD3V.Text);
                    final = Convert.ToDouble(txtD3F.Text);
                    value = ((vize * 4 + final * 6) / 10);
                    txtD3O.Text = value.ToString("0.00").Trim();
                    if (value < 45)
                    {
                        txtD3O.BackColor = Color.Red;
                        txtD3O.ForeColor = Color.White;
                    }
                    else if (value >= 45 && value < 50)
                    {
                        txtD3O.BackColor = Color.Blue;
                        txtD3O.ForeColor = Color.White;
                    }
                    else
                    {
                        txtD3O.BackColor = Color.Green;
                        txtD3O.ForeColor = Color.White;
                    }
                }
            }
            catch (FormatException) { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double d1o = 0, d2o = 0, d3o = 0;
                if (double.TryParse(txtD1O.Text, out d1o) && double.TryParse(txtD2O.Text, out d2o) && double.TryParse(txtD3O.Text, out d3o))
                {
                    double temp = (d1o + d2o + d3o) / 3;
                    txtGO.Text = temp.ToString("0.00").Trim();
                    if (temp < 50)
                    {
                        txtGO.BackColor = Color.Red;
                        txtGO.ForeColor = Color.White;
                        MessageBox.Show("Kaldı!!");
                    }
                    else
                    {
                        txtGO.BackColor = Color.Green;
                        txtGO.ForeColor = Color.White;
                        MessageBox.Show("Geçti!!");
                    }
                }
                else
                {
                    MessageBox.Show("Ortalama hesaplanamadı. Lütfen tüm değerleri doğru bir şekilde giriniz.");
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtD1V.Text = "";
            txtD1F.Text = "";
            txtD1O.Text = "";
            txtD2V.Text = "";
            txtD2F.Text = "";
            txtD2O.Text = "";
            txtD3V.Text = "";
            txtD3F.Text = "";
            txtD3O.Text = "";
            txtGO.Text = "";
            txtD1O.BackColor = Color.White;
            txtD2O.BackColor = Color.White;
            txtD3O.BackColor = Color.White;
            txtGO.BackColor = Color.White; 
            txtGO.ForeColor=Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtD1O.ReadOnly = true;
            txtD2O.ReadOnly = true;
            txtD3O.ReadOnly = true;
            txtGO.ReadOnly = true;
        }
    }
}
