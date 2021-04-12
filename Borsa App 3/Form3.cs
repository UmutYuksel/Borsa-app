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
    public partial class uye_islem_form : Form
    {
        public uye_islem_form()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=HOPE;Initial Catalog=proje;Integrated Security=True");

        private void ürün_ekle()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from data", baglan);
            SqlDataReader oku = komut.ExecuteReader();


            baglan.Close();
        }
        private void stok_göster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from data", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["pamuk"].ToString();
                ekle.SubItems.Add(oku["petrol"].ToString());
                ekle.SubItems.Add(oku["buğday"].ToString());
                ekle.SubItems.Add(oku["arpa"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();
        }
        
        private void uye_islem_form_Load(object sender, EventArgs e)
        {
            
        }

        private void hg_ad_tb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void urun_ekle_b_Click(object sender, EventArgs e)
        {
            if (arpa_sayı_tb.Text != "" || petrol_sayı_tb.Text == "" || buğday_sayı_tb.Text == "" || pamuk_sayı_tb.Text == "")
            {
                MessageBox.Show("Ürünler Stoklara Eklenmiştir");
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert Into data(arpa,petrol,buğday,pamuk)Values ('" + arpa_sayı_tb.Text.ToString() + "','" + petrol_sayı_tb.Text.ToString() + "','" + buğday_sayı_tb.Text.ToString() + "','" + pamuk_sayı_tb.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                ürün_ekle();
            }
            else
                MessageBox.Show("Lütfen Ürün Sayısı Giriniz");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stok_göster();
        }
    }
}
