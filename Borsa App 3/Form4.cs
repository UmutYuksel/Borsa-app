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
        }
        SqlConnection baglan = new SqlConnection("Data Source=HOPE;Initial Catalog=proje;Integrated Security=True");
        private void verilerinigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from data", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["kullanıcıad"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["tcno"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
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
