
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOnayBekleniyor = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.cmbStokSecimiSatinAlma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiktarStokSatinAlma = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBirimFiyatStokSatinAlma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncikisyap = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridViewEmirlerim = new System.Windows.Forms.DataGridView();
            this.cmbParaBirimi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullaniciStoklari)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmirlerim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(260, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesabınızdaki Para:";
            // 
            // para_yükleme_b1
            // 
            this.para_yükleme_b1.ForeColor = System.Drawing.Color.Black;
            this.para_yükleme_b1.Location = new System.Drawing.Point(156, 28);
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
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bakiye İşlemleri";
            // 
            // hesap_is_tb1
            // 
            this.hesap_is_tb1.Location = new System.Drawing.Point(6, 30);
            this.hesap_is_tb1.Name = "hesap_is_tb1";
            this.hesap_is_tb1.Size = new System.Drawing.Size(76, 20);
            this.hesap_is_tb1.TabIndex = 10;
            // 
            // cmbStokSecimi
            // 
            this.cmbStokSecimi.FormattingEnabled = true;
            this.cmbStokSecimi.Location = new System.Drawing.Point(3, 18);
            this.cmbStokSecimi.Name = "cmbStokSecimi";
            this.cmbStokSecimi.Size = new System.Drawing.Size(121, 21);
            this.cmbStokSecimi.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stok Seçimi";
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.White;
            this.txtMiktar.Location = new System.Drawing.Point(130, 17);
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
            this.label9.Location = new System.Drawing.Point(127, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Miktar";
            // 
            // btnMiktarKaydet
            // 
            this.btnMiktarKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnMiktarKaydet.Location = new System.Drawing.Point(362, 18);
            this.btnMiktarKaydet.Name = "btnMiktarKaydet";
            this.btnMiktarKaydet.Size = new System.Drawing.Size(97, 23);
            this.btnMiktarKaydet.TabIndex = 20;
            this.btnMiktarKaydet.Text = "Sisteme Ekle";
            this.btnMiktarKaydet.UseVisualStyleBackColor = true;
            this.btnMiktarKaydet.Click += new System.EventHandler(this.btnMiktarKaydet_Click);
            // 
            // gridViewKullaniciStoklari
            // 
            this.gridViewKullaniciStoklari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewKullaniciStoklari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKullaniciStoklari.Location = new System.Drawing.Point(3, 45);
            this.gridViewKullaniciStoklari.Name = "gridViewKullaniciStoklari";
            this.gridViewKullaniciStoklari.Size = new System.Drawing.Size(1354, 413);
            this.gridViewKullaniciStoklari.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBirimFiyat);
            this.panel1.Controls.Add(this.gridViewKullaniciStoklari);
            this.panel1.Controls.Add(this.cmbStokSecimi);
            this.panel1.Controls.Add(this.btnMiktarKaydet);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 475);
            this.panel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(244, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birim Fiyat";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.BackColor = System.Drawing.Color.White;
            this.txtBirimFiyat.Location = new System.Drawing.Point(247, 18);
            this.txtBirimFiyat.Multiline = true;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 21);
            this.txtBirimFiyat.TabIndex = 23;
            this.txtBirimFiyat.Text = "0";
            this.txtBirimFiyat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(260, 53);
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
            this.lblOnayBekleniyor.Location = new System.Drawing.Point(384, 53);
            this.lblOnayBekleniyor.Name = "lblOnayBekleniyor";
            this.lblOnayBekleniyor.Size = new System.Drawing.Size(0, 13);
            this.lblOnayBekleniyor.TabIndex = 25;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.ForeColor = System.Drawing.Color.Black;
            this.lblBakiye.Location = new System.Drawing.Point(386, 30);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 13);
            this.lblBakiye.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmbParaBirimi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblBakiye);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblOnayBekleniyor);
            this.panel2.Controls.Add(this.para_yükleme_b1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.hesap_is_tb1);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 106);
            this.panel2.TabIndex = 27;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.ForeColor = System.Drawing.Color.Black;
            this.btnSatinAl.Location = new System.Drawing.Point(344, 54);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(97, 25);
            this.btnSatinAl.TabIndex = 28;
            this.btnSatinAl.Text = "Ürün Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // cmbStokSecimiSatinAlma
            // 
            this.cmbStokSecimiSatinAlma.FormattingEnabled = true;
            this.cmbStokSecimiSatinAlma.Location = new System.Drawing.Point(5, 57);
            this.cmbStokSecimiSatinAlma.Name = "cmbStokSecimiSatinAlma";
            this.cmbStokSecimiSatinAlma.Size = new System.Drawing.Size(121, 21);
            this.cmbStokSecimiSatinAlma.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Stok Seçimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(129, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Miktar";
            // 
            // txtMiktarStokSatinAlma
            // 
            this.txtMiktarStokSatinAlma.BackColor = System.Drawing.Color.White;
            this.txtMiktarStokSatinAlma.Location = new System.Drawing.Point(132, 56);
            this.txtMiktarStokSatinAlma.Multiline = true;
            this.txtMiktarStokSatinAlma.Name = "txtMiktarStokSatinAlma";
            this.txtMiktarStokSatinAlma.Size = new System.Drawing.Size(100, 22);
            this.txtMiktarStokSatinAlma.TabIndex = 31;
            this.txtMiktarStokSatinAlma.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtBirimFiyatStokSatinAlma);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSatinAl);
            this.panel3.Controls.Add(this.cmbStokSecimiSatinAlma);
            this.panel3.Controls.Add(this.txtMiktarStokSatinAlma);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 91);
            this.panel3.TabIndex = 33;
            // 
            // txtBirimFiyatStokSatinAlma
            // 
            this.txtBirimFiyatStokSatinAlma.BackColor = System.Drawing.Color.White;
            this.txtBirimFiyatStokSatinAlma.Location = new System.Drawing.Point(238, 56);
            this.txtBirimFiyatStokSatinAlma.Multiline = true;
            this.txtBirimFiyatStokSatinAlma.Name = "txtBirimFiyatStokSatinAlma";
            this.txtBirimFiyatStokSatinAlma.Size = new System.Drawing.Size(100, 22);
            this.txtBirimFiyatStokSatinAlma.TabIndex = 34;
            this.txtBirimFiyatStokSatinAlma.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(235, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Birim Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ürün Satın Alma";
            // 
            // btncikisyap
            // 
            this.btncikisyap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncikisyap.Location = new System.Drawing.Point(1061, 938);
            this.btncikisyap.Name = "btncikisyap";
            this.btncikisyap.Size = new System.Drawing.Size(96, 24);
            this.btncikisyap.TabIndex = 34;
            this.btncikisyap.Text = "Çıkış Yap";
            this.btncikisyap.UseVisualStyleBackColor = true;
            this.btncikisyap.Click += new System.EventHandler(this.btncikisyap_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1374, 503);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1366, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stok Ekleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1366, 477);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bakiye İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridViewEmirlerim);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1366, 477);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Ürün Satın Alma";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridViewEmirlerim
            // 
            this.gridViewEmirlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEmirlerim.Location = new System.Drawing.Point(6, 100);
            this.gridViewEmirlerim.Name = "gridViewEmirlerim";
            this.gridViewEmirlerim.Size = new System.Drawing.Size(1354, 371);
            this.gridViewEmirlerim.TabIndex = 36;
            // 
            // cmbParaBirimi
            // 
            this.cmbParaBirimi.FormattingEnabled = true;
            this.cmbParaBirimi.Items.AddRange(new object[] {
            "ABD DOLARI",
            "EURO",
            "İNGİLİZ STERLİNİ"});
            this.cmbParaBirimi.Location = new System.Drawing.Point(89, 30);
            this.cmbParaBirimi.Name = "cmbParaBirimi";
            this.cmbParaBirimi.Size = new System.Drawing.Size(61, 21);
            this.cmbParaBirimi.TabIndex = 27;
            // 
            // uye_islem_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 974);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btncikisyap);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "uye_islem_form";
            this.Text = "ÜYE İŞLEM ALANI";
            this.Load += new System.EventHandler(this.uye_islem_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullaniciStoklari)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmirlerim)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.ComboBox cmbStokSecimiSatinAlma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiktarStokSatinAlma;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncikisyap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBirimFiyatStokSatinAlma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridViewEmirlerim;
        private System.Windows.Forms.ComboBox cmbParaBirimi;
    }
}