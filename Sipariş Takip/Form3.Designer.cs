namespace Sipariş_Takip
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.tbxHazir = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxKod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxTeslim = new System.Windows.Forms.ComboBox();
            this.siparisEkle = new System.Windows.Forms.Button();
            this.siaprisSil = new System.Windows.Forms.Button();
            this.tbxFiltre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 282);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 51;
            this.dgvSiparisler.RowTemplate.Height = 24;
            this.dgvSiparisler.Size = new System.Drawing.Size(1461, 420);
            this.dgvSiparisler.TabIndex = 0;
            this.dgvSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1527, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şirket Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1527, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş Adet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1527, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hazırlanan Adet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1527, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon Numarası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1527, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün Kodu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1527, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teslim Durumu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(1650, 305);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(205, 27);
            this.tbxName.TabIndex = 8;
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(1650, 351);
            this.tbxAdet.Multiline = true;
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(205, 27);
            this.tbxAdet.TabIndex = 9;
            // 
            // tbxHazir
            // 
            this.tbxHazir.Location = new System.Drawing.Point(1650, 393);
            this.tbxHazir.Multiline = true;
            this.tbxHazir.Name = "tbxHazir";
            this.tbxHazir.Size = new System.Drawing.Size(205, 27);
            this.tbxHazir.TabIndex = 10;
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(1650, 437);
            this.tbxTel.Multiline = true;
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(205, 27);
            this.tbxTel.TabIndex = 11;
            // 
            // tbxKod
            // 
            this.tbxKod.Location = new System.Drawing.Point(1650, 480);
            this.tbxKod.Multiline = true;
            this.tbxKod.Name = "tbxKod";
            this.tbxKod.Size = new System.Drawing.Size(205, 27);
            this.tbxKod.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1726, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTeslim
            // 
            this.cbxTeslim.FormattingEnabled = true;
            this.cbxTeslim.Items.AddRange(new object[] {
            "TeslimEdildi",
            "TeslimEdilmedi"});
            this.cbxTeslim.Location = new System.Drawing.Point(1650, 525);
            this.cbxTeslim.Name = "cbxTeslim";
            this.cbxTeslim.Size = new System.Drawing.Size(205, 24);
            this.cbxTeslim.TabIndex = 16;
            // 
            // siparisEkle
            // 
            this.siparisEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siparisEkle.Location = new System.Drawing.Point(56, 810);
            this.siparisEkle.Name = "siparisEkle";
            this.siparisEkle.Size = new System.Drawing.Size(231, 97);
            this.siparisEkle.TabIndex = 17;
            this.siparisEkle.Text = "Sipariş Ekle";
            this.siparisEkle.UseVisualStyleBackColor = false;
            this.siparisEkle.Click += new System.EventHandler(this.siparisEkle_Click);
            // 
            // siaprisSil
            // 
            this.siaprisSil.Location = new System.Drawing.Point(323, 810);
            this.siaprisSil.Name = "siaprisSil";
            this.siaprisSil.Size = new System.Drawing.Size(231, 97);
            this.siaprisSil.TabIndex = 18;
            this.siaprisSil.Text = "Sipariş Sil";
            this.siaprisSil.UseVisualStyleBackColor = true;
            this.siaprisSil.Click += new System.EventHandler(this.siaprisSil_Click);
            // 
            // tbxFiltre
            // 
            this.tbxFiltre.Location = new System.Drawing.Point(1135, 228);
            this.tbxFiltre.Multiline = true;
            this.tbxFiltre.Name = "tbxFiltre";
            this.tbxFiltre.Size = new System.Drawing.Size(235, 29);
            this.tbxFiltre.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1376, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(567, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(408, 54);
            this.label7.TabIndex = 21;
            this.label7.Text = "SİPARİŞ LİSTESİ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 54);
            this.button3.TabIndex = 23;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1790, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 59);
            this.button4.TabIndex = 24;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxFiltre);
            this.Controls.Add(this.siaprisSil);
            this.Controls.Add(this.siparisEkle);
            this.Controls.Add(this.cbxTeslim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxKod);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxHazir);
            this.Controls.Add(this.tbxAdet);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.TextBox tbxHazir;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxKod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxTeslim;
        private System.Windows.Forms.Button siparisEkle;
        private System.Windows.Forms.Button siaprisSil;
        private System.Windows.Forms.TextBox tbxFiltre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}