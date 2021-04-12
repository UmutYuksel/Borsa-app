
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
            this.para_miktari_tb = new System.Windows.Forms.TextBox();
            this.para_yükleme_b1 = new System.Windows.Forms.Button();
            this.para_cekme_b1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hesap_is_tb1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urun_ekle_b = new System.Windows.Forms.Button();
            this.pamuk_sayı_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.petrol_sayı_tb = new System.Windows.Forms.TextBox();
            this.arpa_sayı_tb = new System.Windows.Forms.TextBox();
            this.buğday_sayı_tb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesabınızdaki Para:";
            // 
            // para_miktari_tb
            // 
            this.para_miktari_tb.BackColor = System.Drawing.Color.White;
            this.para_miktari_tb.Location = new System.Drawing.Point(119, 26);
            this.para_miktari_tb.Multiline = true;
            this.para_miktari_tb.Name = "para_miktari_tb";
            this.para_miktari_tb.ReadOnly = true;
            this.para_miktari_tb.Size = new System.Drawing.Size(100, 22);
            this.para_miktari_tb.TabIndex = 3;
            // 
            // para_yükleme_b1
            // 
            this.para_yükleme_b1.ForeColor = System.Drawing.Color.Black;
            this.para_yükleme_b1.Location = new System.Drawing.Point(15, 123);
            this.para_yükleme_b1.Name = "para_yükleme_b1";
            this.para_yükleme_b1.Size = new System.Drawing.Size(98, 23);
            this.para_yükleme_b1.TabIndex = 6;
            this.para_yükleme_b1.Text = "Para Yükleme";
            this.para_yükleme_b1.UseVisualStyleBackColor = true;
            // 
            // para_cekme_b1
            // 
            this.para_cekme_b1.ForeColor = System.Drawing.Color.Black;
            this.para_cekme_b1.Location = new System.Drawing.Point(121, 123);
            this.para_cekme_b1.Name = "para_cekme_b1";
            this.para_cekme_b1.Size = new System.Drawing.Size(98, 23);
            this.para_cekme_b1.TabIndex = 7;
            this.para_cekme_b1.Text = "Para Çekme";
            this.para_cekme_b1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hesap İşlemleri";
            // 
            // hesap_is_tb1
            // 
            this.hesap_is_tb1.Location = new System.Drawing.Point(96, 97);
            this.hesap_is_tb1.Name = "hesap_is_tb1";
            this.hesap_is_tb1.Size = new System.Drawing.Size(123, 20);
            this.hesap_is_tb1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buğday_sayı_tb);
            this.groupBox1.Controls.Add(this.arpa_sayı_tb);
            this.groupBox1.Controls.Add(this.petrol_sayı_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.urun_ekle_b);
            this.groupBox1.Controls.Add(this.pamuk_sayı_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 148);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sisteme Ürün Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // urun_ekle_b
            // 
            this.urun_ekle_b.ForeColor = System.Drawing.Color.Black;
            this.urun_ekle_b.Location = new System.Drawing.Point(141, 114);
            this.urun_ekle_b.Name = "urun_ekle_b";
            this.urun_ekle_b.Size = new System.Drawing.Size(97, 23);
            this.urun_ekle_b.TabIndex = 3;
            this.urun_ekle_b.Text = "Sisteme Ekle";
            this.urun_ekle_b.UseVisualStyleBackColor = true;
            this.urun_ekle_b.Click += new System.EventHandler(this.urun_ekle_b_Click);
            // 
            // pamuk_sayı_tb
            // 
            this.pamuk_sayı_tb.Location = new System.Drawing.Point(117, 13);
            this.pamuk_sayı_tb.Name = "pamuk_sayı_tb";
            this.pamuk_sayı_tb.Size = new System.Drawing.Size(121, 20);
            this.pamuk_sayı_tb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 333);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 89);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pamuk";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Petrol";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Buğday";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Arpa";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(169, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Stokları Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PAMUK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "BUĞDAY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "PETROL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ARPA";
            // 
            // petrol_sayı_tb
            // 
            this.petrol_sayı_tb.Location = new System.Drawing.Point(117, 37);
            this.petrol_sayı_tb.Name = "petrol_sayı_tb";
            this.petrol_sayı_tb.Size = new System.Drawing.Size(121, 20);
            this.petrol_sayı_tb.TabIndex = 17;
            // 
            // arpa_sayı_tb
            // 
            this.arpa_sayı_tb.Location = new System.Drawing.Point(117, 63);
            this.arpa_sayı_tb.Name = "arpa_sayı_tb";
            this.arpa_sayı_tb.Size = new System.Drawing.Size(121, 20);
            this.arpa_sayı_tb.TabIndex = 18;
            this.arpa_sayı_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buğday_sayı_tb
            // 
            this.buğday_sayı_tb.Location = new System.Drawing.Point(117, 88);
            this.buğday_sayı_tb.Name = "buğday_sayı_tb";
            this.buğday_sayı_tb.Size = new System.Drawing.Size(121, 20);
            this.buğday_sayı_tb.TabIndex = 19;
            // 
            // uye_islem_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hesap_is_tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.para_cekme_b1);
            this.Controls.Add(this.para_yükleme_b1);
            this.Controls.Add(this.para_miktari_tb);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "uye_islem_form";
            this.Text = "ÜYE İŞLEM ALANI";
            this.Load += new System.EventHandler(this.uye_islem_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox para_miktari_tb;
        private System.Windows.Forms.Button para_yükleme_b1;
        private System.Windows.Forms.Button para_cekme_b1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hesap_is_tb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button urun_ekle_b;
        private System.Windows.Forms.TextBox pamuk_sayı_tb;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arpa_sayı_tb;
        private System.Windows.Forms.TextBox petrol_sayı_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buğday_sayı_tb;
    }
}