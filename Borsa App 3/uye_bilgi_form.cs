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
using Borsa_App;

namespace Borsa_app2
{
    public partial class uye_bilgi_form : Form
    {
        public uye_bilgi_form()
        {
            InitializeComponent();
            CenterToScreen();
        }
        SqlConnection baglan = new SqlConnection("Data Source=HOPE;Initial Catalog=proje;Integrated Security=True");
        private void verilerinigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Kullanicilar", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["KullaniciAd"].ToString());
                ekle.SubItems.Add(oku["Sifre"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TCNo"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                listView1.Items.Add(ekle);

             }
            baglan.Close();
        }
        private void Apanel_b_Click(object sender, EventArgs e)
        {
            admin_form admin_panel = new admin_form();
            admin_panel.Show();
                this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerinigöster();
        }
    }
}
