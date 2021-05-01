
namespace Borsa_App
{
    partial class uye_islem_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.para_yükleme_b1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hesap_is_tb1 = new System.Windows.Forms.TextBox();
            this.cmbStokSecimi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMiktarKaydet = new System.Windows.Forms.Button();
            this.gridViewKullaniciStoklari = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOnayBekleniyor = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullaniciStoklari)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(283, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesabınızdaki Para:";
            // 
            // para_yükleme_b1
            // 
            this.para_yükleme_b1.ForeColor = System.Drawing.Color.Black;
            this.para_yükleme_b1.Location = new System.Drawing.Point(158, 267);
            this.para_yükleme_b1.Name = "para_yükleme_b1";
            this.para_yükleme_b1.Size = new System.Drawing.Size(98, 23);
            this.para_yükleme_b1.TabIndex = 6;
            this.para_yükleme_b1.Text = "Para Yükleme";
            this.para_yükleme_b1.UseVisualStyleBackColor = true;
            this.para_yükleme_b1.Click += new System.EventHandler(this.para_yükleme_b1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bakiye İşlemleri";
            // 
            // hesap_is_tb1
            // 
            this.hesap_is_tb1.Location = new System.Drawing.Point(29, 269);
            this.hesap_is_tb1.Name = "hesap_is_tb1";
            this.hesap_is_tb1.Size = new System.Drawing.Size(123, 20);
            this.hesap_is_tb1.TabIndex = 10;
            // 
            // cmbStokSecimi
            // 
            this.cmbStokSecimi.FormattingEnabled = true;
            this.cmbStokSecimi.Location = new System.Drawing.Point(13, 21);
            this.cmbStokSecimi.Name = "cmbStokSecimi";
            this.cmbStokSecimi.Size = new System.Drawing.Size(121, 21);
            this.cmbStokSecimi.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stok Seçimi";
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.White;
            this.txtMiktar.Location = new System.Drawing.Point(140, 20);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 19;
            this.txtMiktar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(137, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Miktar";
            // 
            // btnMiktarKaydet
            // 
            this.btnMiktarKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnMiktarKaydet.Location = new System.Drawing.Point(372, 21);
            this.btnMiktarKaydet.Name = "btnMiktarKaydet";
            this.btnMiktarKaydet.Size = new System.Drawing.Size(97, 23);
            this.btnMiktarKaydet.TabIndex = 20;
            this.btnMiktarKaydet.Text = "Sisteme Ekle";
            this.btnMiktarKaydet.UseVisualStyleBackColor = true;
            this.btnMiktarKaydet.Click += new System.EventHandler(this.btnMiktarKaydet_Click);
            // 
            // gridViewKullaniciStoklari
            // 
            this.gridViewKullaniciStoklari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKullaniciStoklari.Location = new System.Drawing.Point(13, 45);
            this.gridViewKullaniciStoklari.Name = "gridViewKullaniciStoklari";
            this.gridViewKullaniciStoklari.Size = new System.Drawing.Size(601, 150);
            this.gridViewKullaniciStoklari.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.gridViewKullaniciStoklari);
            this.panel1.Controls.Add(this.cmbStokSecimi);
            this.panel1.Controls.Add(this.btnMiktarKaydet);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 212);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(283, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Onay Bekleniyor?";
            // 
            // lblOnayBekleniyor
            // 
            this.lblOnayBekleniyor.AutoSize = true;
            this.lblOnayBekleniyor.BackColor = System.Drawing.Color.Transparent;
            this.lblOnayBekleniyor.ForeColor = System.Drawing.Color.Black;
            this.lblOnayBekleniyor.Location = new System.Drawing.Point(407, 292);
            this.lblOnayBekleniyor.Name = "lblOnayBekleniyor";
            this.lblOnayBekleniyor.Size = new System.Drawing.Size(0, 13);
            this.lblOnayBekleniyor.TabIndex = 25;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.ForeColor = System.Drawing.Color.Black;
            this.lblBakiye.Location = new System.Drawing.Point(409, 269);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 13);
            this.lblBakiye.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(257, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(254, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birim Fiyat";
            // 
            // uye_islem_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 457);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblOnayBekleniyor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hesap_is_tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.para_yükleme_b1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "uye_islem_form";
            this.Text = "ÜYE İŞLEM ALANI";
            this.Load += new System.EventHandler(this.uye_islem_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullaniciStoklari)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button para_yükleme_b1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hesap_is_tb1;
        private System.Windows.Forms.ComboBox cmbStokSecimi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMiktarKaydet;
        private System.Windows.Forms.DataGridView gridViewKullaniciStoklari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOnayBekleniyor;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}