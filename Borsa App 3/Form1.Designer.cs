
namespace Borsa_App
{
    partial class frm_login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.giris_b1 = new System.Windows.Forms.Button();
            this.kullancı_ad_tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre_tb1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kayıt_b1 = new System.Windows.Forms.Button();
            this.adres_tb1 = new System.Windows.Forms.TextBox();
            this.mail_tb1 = new System.Windows.Forms.TextBox();
            this.tcno_tb1 = new System.Windows.Forms.TextBox();
            this.telefon_tb1 = new System.Windows.Forms.TextBox();
            this.sifre_tb2 = new System.Windows.Forms.TextBox();
            this.kullanıcı_ad_tb2 = new System.Windows.Forms.TextBox();
            this.ad_soyad_tb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BORSA APP GİRİŞ PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.giris_b1);
            this.panel1.Controls.Add(this.kullancı_ad_tb1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sifre_tb1);
            this.panel1.Location = new System.Drawing.Point(66, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 239);
            this.panel1.TabIndex = 1;
            // 
            // giris_b1
            // 
            this.giris_b1.Location = new System.Drawing.Point(166, 140);
            this.giris_b1.Name = "giris_b1";
            this.giris_b1.Size = new System.Drawing.Size(75, 23);
            this.giris_b1.TabIndex = 3;
            this.giris_b1.Text = "Giriş Yap";
            this.giris_b1.UseVisualStyleBackColor = true;
            this.giris_b1.Click += new System.EventHandler(this.giris_b1_Click);
            // 
            // kullancı_ad_tb1
            // 
            this.kullancı_ad_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kullancı_ad_tb1.Location = new System.Drawing.Point(44, 62);
            this.kullancı_ad_tb1.Name = "kullancı_ad_tb1";
            this.kullancı_ad_tb1.Size = new System.Drawing.Size(197, 20);
            this.kullancı_ad_tb1.TabIndex = 1;
            this.kullancı_ad_tb1.Text = "Kullanıcı Adı";
            this.kullancı_ad_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullancı_ad_tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "GİRİŞ YAP";
            // 
            // sifre_tb1
            // 
            this.sifre_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sifre_tb1.Location = new System.Drawing.Point(44, 100);
            this.sifre_tb1.Name = "sifre_tb1";
            this.sifre_tb1.PasswordChar = '*';
            this.sifre_tb1.Size = new System.Drawing.Size(197, 20);
            this.sifre_tb1.TabIndex = 2;
            this.sifre_tb1.Text = "Şifre";
            this.sifre_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifre_tb1.Enter += new System.EventHandler(this.sifre_tb1_Enter);
            this.sifre_tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifre_tb1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.kayıt_b1);
            this.panel2.Controls.Add(this.adres_tb1);
            this.panel2.Controls.Add(this.mail_tb1);
            this.panel2.Controls.Add(this.tcno_tb1);
            this.panel2.Controls.Add(this.telefon_tb1);
            this.panel2.Controls.Add(this.sifre_tb2);
            this.panel2.Controls.Add(this.kullanıcı_ad_tb2);
            this.panel2.Controls.Add(this.ad_soyad_tb1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(434, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 291);
            this.panel2.TabIndex = 2;
            // 
            // kayıt_b1
            // 
            this.kayıt_b1.Location = new System.Drawing.Point(160, 254);
            this.kayıt_b1.Name = "kayıt_b1";
            this.kayıt_b1.Size = new System.Drawing.Size(75, 23);
            this.kayıt_b1.TabIndex = 9;
            this.kayıt_b1.Text = "Kayıt Ol";
            this.kayıt_b1.UseVisualStyleBackColor = true;
            this.kayıt_b1.Click += new System.EventHandler(this.kayıt_b1_Click);
            // 
            // adres_tb1
            // 
            this.adres_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.adres_tb1.Location = new System.Drawing.Point(38, 219);
            this.adres_tb1.Name = "adres_tb1";
            this.adres_tb1.Size = new System.Drawing.Size(197, 20);
            this.adres_tb1.TabIndex = 8;
            this.adres_tb1.Text = "Adres";
            this.adres_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mail_tb1
            // 
            this.mail_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mail_tb1.Location = new System.Drawing.Point(38, 193);
            this.mail_tb1.Name = "mail_tb1";
            this.mail_tb1.Size = new System.Drawing.Size(197, 20);
            this.mail_tb1.TabIndex = 7;
            this.mail_tb1.Text = "E-Mail";
            this.mail_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tcno_tb1
            // 
            this.tcno_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tcno_tb1.Location = new System.Drawing.Point(38, 167);
            this.tcno_tb1.Name = "tcno_tb1";
            this.tcno_tb1.Size = new System.Drawing.Size(197, 20);
            this.tcno_tb1.TabIndex = 6;
            this.tcno_tb1.Text = "TC Kimlik No";
            this.tcno_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefon_tb1
            // 
            this.telefon_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefon_tb1.Location = new System.Drawing.Point(38, 140);
            this.telefon_tb1.Name = "telefon_tb1";
            this.telefon_tb1.Size = new System.Drawing.Size(197, 20);
            this.telefon_tb1.TabIndex = 5;
            this.telefon_tb1.Text = "Telefon No";
            this.telefon_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sifre_tb2
            // 
            this.sifre_tb2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sifre_tb2.Location = new System.Drawing.Point(38, 114);
            this.sifre_tb2.Name = "sifre_tb2";
            this.sifre_tb2.Size = new System.Drawing.Size(197, 20);
            this.sifre_tb2.TabIndex = 4;
            this.sifre_tb2.Text = "Şifre";
            this.sifre_tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kullanıcı_ad_tb2
            // 
            this.kullanıcı_ad_tb2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kullanıcı_ad_tb2.Location = new System.Drawing.Point(38, 88);
            this.kullanıcı_ad_tb2.Name = "kullanıcı_ad_tb2";
            this.kullanıcı_ad_tb2.Size = new System.Drawing.Size(197, 20);
            this.kullanıcı_ad_tb2.TabIndex = 3;
            this.kullanıcı_ad_tb2.Text = "Kullanıcı Adı";
            this.kullanıcı_ad_tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ad_soyad_tb1
            // 
            this.ad_soyad_tb1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ad_soyad_tb1.Location = new System.Drawing.Point(38, 62);
            this.ad_soyad_tb1.Name = "ad_soyad_tb1";
            this.ad_soyad_tb1.Size = new System.Drawing.Size(197, 20);
            this.ad_soyad_tb1.TabIndex = 2;
            this.ad_soyad_tb1.Text = "Ad Soyad";
            this.ad_soyad_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "KAYIT OL";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Borsa_App_3.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.Text = "LOGİN EKRANI";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kullancı_ad_tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button giris_b1;
        private System.Windows.Forms.TextBox sifre_tb1;
        private System.Windows.Forms.Button kayıt_b1;
        private System.Windows.Forms.TextBox adres_tb1;
        private System.Windows.Forms.TextBox mail_tb1;
        private System.Windows.Forms.TextBox tcno_tb1;
        private System.Windows.Forms.TextBox telefon_tb1;
        private System.Windows.Forms.TextBox sifre_tb2;
        private System.Windows.Forms.TextBox kullanıcı_ad_tb2;
        private System.Windows.Forms.TextBox ad_soyad_tb1;
    }
}

