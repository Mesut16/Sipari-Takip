using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sipariş_Takip
{
    public partial class Form3 : Form
    {
        private Siparisler siparisManager;

        public Form3()
        {
            InitializeComponent();
            siparisManager = new Siparisler();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadSiparisler();
        }

        private void LoadSiparisler()
        {
            List<SiparisTakip> siparisList = siparisManager.GetAll();
            dgvSiparisler.DataSource = siparisList;
            SetDataGridViewRowColors();
        }

        private void SetDataGridViewRowColors()
        {
            foreach (DataGridViewRow row in dgvSiparisler.Rows)
            {
                string teslimDurumu = row.Cells["TeslimDurumu"].Value.ToString();
                if (teslimDurumu == "TeslimEdildi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (teslimDurumu == "TeslimEdilmedi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void dgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSiparisler.Rows[e.RowIndex];
                tbxName.Text = row.Cells["SirketAdi"].Value.ToString();
                tbxAdet.Text = row.Cells["SiparisAdet"].Value.ToString();
                tbxHazir.Text = row.Cells["HazirlananAdet"].Value.ToString();
                tbxTel.Text = row.Cells["MusteriTelefon"].Value.ToString();
                tbxKod.Text = row.Cells["UrunKodu"].Value.ToString();
                cbxTeslim.Text = row.Cells["TeslimDurumu"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz siparişi seçiniz.");
                return;
            }

            if (string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxAdet.Text) || string.IsNullOrEmpty(tbxHazir.Text) || string.IsNullOrEmpty(tbxTel.Text) || string.IsNullOrEmpty(tbxKod.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }

            if (!IsTelefonValid(tbxTel.Text))
            {
                MessageBox.Show("Geçersiz telefon numarası. Lütfen 11 haneli ve sadece sayılardan oluşan bir telefon numarası giriniz.");
                return;
            }

            if (!siparisManager.UrunKoduVarMi(tbxKod.Text))
            {
                MessageBox.Show("Geçersiz ürün kodu. Lütfen geçerli bir ürün kodu giriniz.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Siparişi güncellemek istediğinize emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SiparisTakip siparisTakip = new SiparisTakip
                    {
                        SiparisId = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells["SiparisId"].Value),
                        SirketAdi = tbxName.Text,
                        SiparisAdet = Convert.ToInt32(tbxAdet.Text),
                        HazirlananAdet = Convert.ToInt32(tbxHazir.Text),
                        MusteriTelefon = tbxTel.Text,
                        UrunKodu = tbxKod.Text,
                        TeslimDurumu = cbxTeslim.Text
                    };

                    siparisManager.SiparisGuncelle(siparisTakip);

                    MessageBox.Show("Sipariş başarıyla güncellendi.");
                    LoadSiparisler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void siaprisSil_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz siparişi seçiniz.");
                return;
            }

            string siparisId = dgvSiparisler.CurrentRow.Cells["SiparisId"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bu siparişi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                siparisManager.SiparisSil(siparisId);
                MessageBox.Show("Sipariş başarıyla silindi.");
                LoadSiparisler();
            }
        }

        private bool IsTelefonValid(string telefon)
        {
            return telefon.Length == 11 && telefon.All(char.IsDigit);
        }

        private void siparisEkle_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            LoadSiparisler();
        }

        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dgvSiparisler.Rows)
            {
                string teslimDurumu = row.Cells["TeslimDurumu"].Value.ToString();
                if (teslimDurumu == "TeslimEdildi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (teslimDurumu == "TeslimEdilmedi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    // Diğer durumlar için varsayılan renkleri kullanabilirsiniz
                    row.DefaultCellStyle.BackColor = dgvSiparisler.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dgvSiparisler.DefaultCellStyle.ForeColor;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string filterText = tbxFiltre.Text.Trim();

            // Veri kaynağı olarak kullanılan List'i alın
            List<SiparisTakip> filteredList = siparisManager.GetAll();

            // Eğer filtre metni boş değilse, filtreleme işlemini gerçekleştir
            if (!string.IsNullOrEmpty(filterText))
            {
                filteredList = filteredList.Where(siparis =>
                    siparis.SirketAdi.ToLower().Contains(filterText.ToLower()) ||
                    siparis.MusteriTelefon.ToLower().Contains(filterText.ToLower()) ||
                    siparis.UrunKodu.ToLower().Contains(filterText.ToLower()) ||
                    siparis.TeslimDurumu.ToLower().Contains(filterText.ToLower())
                ).ToList();
            }

            // Filtrelenmiş listeyi DataGridView'e ata
            dgvSiparisler.DataSource = filteredList;

            // Satır renklerini güncelle
            ApplyRowColors();

            // Filtre sonucunun olup olmadığını kontrol et
            if (filteredList.Count == 0)
            {
                MessageBox.Show("Filtreleme sonucu bulunamadı.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
