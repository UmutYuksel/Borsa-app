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
            SqlCommand komut = new SqlCommand("Select *from data", baglan);
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
            }
            else
            {
                try
                {
                    baglan.Open();
                    string sql = "Select *from data where kullanıcıad=@adi AND sifre=@sifre";
                    SqlParameter prm1 = new SqlParameter("adi", kullancı_ad_tb1.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("sifre", sifre_tb1.Text.Trim());
                    SqlCommand komut = new SqlCommand(sql, baglan);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        uye_islem_form uye_islem = new uye_islem_form();
                        uye_islem.Show();

                    }
                    


                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz");
                }

            }







        }

        private void kayıt_b1_Click(object sender, EventArgs e)
        {
            if (ad_soyad_tb1.Text != "" && kullanıcı_ad_tb2.Text != "" && sifre_tb2.Text != "" && telefon_tb1.Text != "" && tcno_tb1.Text != "" && mail_tb1.Text != "" && adres_tb1.Text != "")
            {
                MessageBox.Show("Kayıt Başarılı");
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert Into data(adsoyad,kullanıcıad,sifre,tcno,telefon,mail,adres)Values ('" + ad_soyad_tb1.Text.ToString() + "','" + kullanıcı_ad_tb2.Text.ToString() + "','" + sifre_tb2.Text.ToString() + "','" + tcno_tb1.Text.ToString() + "','" + telefon_tb1.Text.ToString() + "','" + mail_tb1.Text.ToString() + "','" + adres_tb1.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                kayıt_ol();
            }
            else
                MessageBox.Show("Bilgilerinizi Boş Bırakmayınız");
        }
    }
}