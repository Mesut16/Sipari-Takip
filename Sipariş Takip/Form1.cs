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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            List<UrunKategori> urunKategoriList = dataManager.GetUrunKategoriList();
            urunlerDGV.DataSource = urunKategoriList;
        }

        private void urunlerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string id = urunlerDGV.CurrentRow.Cells[0].Value.ToString();
            Urunler urunler = new Urunler();
            urunler.UrunSil(id);
            MessageBox.Show("Ürün Başarıyla Silindi");
            DataManager dataManager = new DataManager();
            List<UrunKategori> urunKategoriList = dataManager.GetUrunKategoriList();
            urunlerDGV.DataSource = urunKategoriList;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide(); 
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
