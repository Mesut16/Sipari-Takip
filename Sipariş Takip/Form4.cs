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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        #region
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSirketAdi.Text) || string.IsNullOrEmpty(tbxSiparisAdet.Text) || string.IsNullOrEmpty(tbxMusteriTelefon.Text) || string.IsNullOrEmpty(tbxUrunKodu.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }

            if (!IsTelefonValid(tbxMusteriTelefon.Text))
            {
                MessageBox.Show("Geçersiz telefon numarası. Lütfen 11 haneli ve sadece sayılardan oluşan bir telefon numarası giriniz.");
                return;
            }

            Siparisler siparisManager = new Siparisler();

            if (!siparisManager.UrunKoduVarMi(tbxUrunKodu.Text))
            {
                MessageBox.Show("Geçersiz ürün kodu. Lütfen geçerli bir ürün kodu giriniz.");
                return;
            }

            try
            {
                SiparisTakip yeniSiparis = new SiparisTakip
                {
                    SirketAdi = tbxSirketAdi.Text,
                    SiparisAdet = int.Parse(tbxSiparisAdet.Text),
                    MusteriTelefon = tbxMusteriTelefon.Text,
                    SiparisTarihi = dtpSiparisTarihi.Value,
                    TeslimTarihi = dtpTeslimTarihi.Value,
                    UrunKodu = tbxUrunKodu.Text
                };

                siparisManager.SiparisEkle(yeniSiparis);

                MessageBox.Show("Sipariş başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private bool IsTelefonValid(string telefon)
        {
            // Telefon numarasının 11 haneli ve sadece sayılardan oluştuğunu kontrol eder
            return telefon.Length == 11 && telefon.All(char.IsDigit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
