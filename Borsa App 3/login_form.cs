using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Borsa_App
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=HOPE;Initial Catalog=proje;Integrated Security=True");
        private void kayıt_ol()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Kullanicilar", baglan);
            SqlDataReader oku = komut.ExecuteReader();


            baglan.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void giris_b1_Click(object sender, EventArgs e)
        {
            if (kullancı_ad_tb1.Text == "admin" && sifre_tb1.Text == "admin")
            {
                admin_form admin_panel = new admin_form();
                admin_panel.Show();
                this.Hide();
                

            }
            else
            {
                try
                {
                    baglan.Open();
                    string sql = "Select top (1) * from kullanicilar where KullaniciAd=@adi AND sifre=@Sifre";
                    SqlParameter prm1 = new SqlParameter("adi", kullancı_ad_tb1.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("sifre", sifre_tb1.Text.Trim());
                    SqlCommand komut = new SqlCommand(sql, baglan);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);
                    baglan.Close();
                    if (dt.Rows.Count > 0)
                    {
                        uye_islem_form uye_islem = new uye_islem_form();
                        uye_islem.KullaniciId = int.Parse(dt.Rows[0]["Id"].ToString());
                        uye_islem.Show();
                        this.Hide();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz");
                    MessageBox.Show(ex.Message);
                }

            }







        }

        private void kayıt_b1_Click(object sender, EventArgs e)
        {
            if (ad_soyad_tb1.Text != "" && kullanıcı_ad_tb2.Text != "" && sifre_tb2.Text != "" && telefon_tb1.Text != "" && tcno_tb1.Text != "" && mail_tb1.Text != "" && adres_tb1.Text != "")
            {
                MessageBox.Show("Kayıt Başarılı");
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert Into Kullanicilar(AdSoyad,KullaniciAd,Sifre,TCNo,Telefon,Mail,Adres)Values ('" + ad_soyad_tb1.Text.ToString() + "','" + kullanıcı_ad_tb2.Text.ToString() + "','" + sifre_tb2.Text.ToString() + "','" + tcno_tb1.Text.ToString() + "','" + telefon_tb1.Text.ToString() + "','" + mail_tb1.Text.ToString() + "','" + adres_tb1.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                kayıt_ol();
            }
            else
                MessageBox.Show("Bilgilerinizi Boş Bırakmayınız");
        }

        private void sifre_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar==13)
            {
                giris_b1.PerformClick();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void sifre_tb1_Enter(object sender, EventArgs e)
        {
            sifre_tb1.Text = string.Empty;
        }

        private void sifre_tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_soyad_tb1_Enter(object sender, EventArgs e)
        {
           ad_soyad_tb1.Text = string.Empty;
        }

        private void kullanıcı_ad_tb2_Enter(object sender, EventArgs e)
        {
            kullanıcı_ad_tb2.Text = string.Empty;
        }

        private void sifre_tb2_Enter(object sender, EventArgs e)
        {
            sifre_tb2.Text = string.Empty;
        }

        private void telefon_tb1_Enter(object sender, EventArgs e)
        {
            telefon_tb1.Text = string.Empty;
        }

        private void tcno_tb1_Enter(object sender, EventArgs e)
        {
            tcno_tb1.Text = string.Empty;
        }

        private void mail_tb1_Enter(object sender, EventArgs e)
        {
            mail_tb1.Text = string.Empty;
        }

        private void adres_tb1_Enter(object sender, EventArgs e)
        {
            ad_soyad_tb1.Text = string.Empty;
        }
    }
}