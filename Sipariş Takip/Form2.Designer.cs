namespace Sipariş_Takip
{
    partial class Form2
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
            this.urun_kodu = new System.Windows.Forms.Label();
            this.tbxKod = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.urunEkle = new System.Windows.Forms.Button();
            this.kategori_name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urun_kodu
            // 
            this.urun_kodu.Location = new System.Drawing.Point(34, 94);
            this.urun_kodu.Name = "urun_kodu";
            this.urun_kodu.Size = new System.Drawing.Size(104, 31);
            this.urun_kodu.TabIndex = 0;
            this.urun_kodu.Text = "ÜRÜN KODU";
            this.urun_kodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.urun_kodu.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxKod
            // 
            this.tbxKod.Location = new System.Drawing.Point(169, 94);
            this.tbxKod.Multiline = true;
            this.tbxKod.Name = "tbxKod";
            this.tbxKod.Size = new System.Drawing.Size(224, 31);
            this.tbxKod.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(169, 172);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(224, 31);
            this.tbxName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "KATEGORİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(34, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "ÜRÜN ADI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(309, 333);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(160, 56);
            this.urunEkle.TabIndex = 17;
            this.urunEkle.Text = "Ürün EKLE";
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // kategori_name
            // 
            this.kategori_name.FormattingEnabled = true;
            this.kategori_name.Items.AddRange(new object[] {
            "HYDRAULIC",
            "KALIPER SENSÖR KAPAKLARI",
            "WABCO",
            "BP",
            "BREMBO",
            "Z CAM",
            "IVECO"});
            this.kategori_name.Location = new System.Drawing.Point(169, 242);
            this.kategori_name.Name = "kategori_name";
            this.kategori_name.Size = new System.Drawing.Size(224, 24);
            this.kategori_name.TabIndex = 18;
            this.kategori_name.Tag = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(431, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kategori_name);
            this.Controls.Add(this.urunEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxKod);
            this.Controls.Add(this.urun_kodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urun_kodu;
        private System.Windows.Forms.TextBox tbxKod;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.ComboBox kategori_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}