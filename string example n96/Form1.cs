using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_example_n96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            string mesaj = $"Toplam {lblMesaj.Text.Length} karakter vardır.";

            MessageBox.Show(mesaj);
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = $"Merhaba Dünya, Ben {txtMesaj.Text}!";
        }

        private void btnMetin_Click(object sender, EventArgs e)
        {
            string mesaj1 = "Merhaba Dünya";
            string mesaj2 = ", Ben Hilal De Souza";
            //string yeniMesaj = mesaj1 + mesaj2;

            string yeniMesaj = String.Concat(mesaj1, mesaj2);

            lblMesaj.Text = yeniMesaj;
        }

        private void btnSiraGetir_Click(object sender, EventArgs e)
        {
            //5. sıradaki harfi getir

            string mesaj = lblMesaj.Text;
            // mesaj[5]  char türündedir

            MessageBox.Show($"5. sıradaki harf : {mesaj[5]} ");
        }

        private void btnKacis1_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba ben \"Hilal De Souza\". \rNasılsın?";
            lblMesaj.Text = mesaj;
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string isim1 = "Ravza";
            string isim2 = "Ravza";
            string isim3 = "Hilal";

            bool durum1 = isim1.Equals(isim2);
            bool durum2 = isim1 == isim2;

            bool durum3 = isim1.Equals(isim3);
            bool durum4 = isim1 == isim3;

            string mesaj = $"durum1 :{durum1}  --> durum2 :{durum2} \rdurum3  :{durum3}  --> durum4 :{durum4}";
            MessageBox.Show(mesaj);
        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 200;

            string mesaj = $"{a} * {b} = {c}";
            MessageBox.Show(mesaj);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isim1 = "Nursevim";
            string isim2 = "Ravza";
            string isim3 = "Hilal";
            string isim4 = "Yezda";

            int sonuc = String.Compare(isim1, isim2);
            MessageBox.Show($"Sonuç :{sonuc}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 7); //başlangıç,adet

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);
            MessageBox.Show($"{txtMesaj.Text} ----> {durum}");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("Hilal De Souza", txtMesaj.Text);
            lblMesaj.Text = mesaj;
        }

        private void btnSplite_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = lblMesaj.Text.Split(' ').ToList(); //boşluk sembolüne göre ayırır
        }
    }
}
