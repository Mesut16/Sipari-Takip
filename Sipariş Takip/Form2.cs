using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Takip
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxKod.Text) || string.IsNullOrEmpty(tbxName.Text) || kategori_name.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }
            int kat_id = 0;
            string selectedProduct = kategori_name.SelectedItem.ToString();
            if (selectedProduct == "HYDRAULIC")
                kat_id = 10;
            else if (selectedProduct == "KALIPER SENSÖR KAPAKLARI")
                kat_id=110;
            else if (selectedProduct == "WABCO")
                kat_id = 210;
            else if (selectedProduct == "BP")
                kat_id = 310;
            else if (selectedProduct == "BREMBO")
                kat_id = 410;
            else if (selectedProduct == "Z CAM")
                kat_id = 510;
            else if (selectedProduct == "IVECO")
                kat_id = 610;

            Urunler urunler = new Urunler();
            urunler.UrunEkle(new Urun
            {
                urun_kodu = tbxKod.Text,
                urun_adi = tbxName.Text,
                kategori_id = Convert.ToInt32(kat_id)
            });
            MessageBox.Show("Ürün Başarıyla Eklendi");
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 =new Form1();
            this.Hide(); 
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
