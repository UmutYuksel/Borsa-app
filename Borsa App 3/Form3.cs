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
        public int KullaniciId { get; set; }

        public uye_islem_form()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=HOPE;Initial Catalog=proje;Integrated Security=True");

        private void ürün_ekle()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Kullanicilar", baglan);
            SqlDataReader oku = komut.ExecuteReader();


            baglan.Close();
        }


        private void uye_islem_form_Load(object sender, EventArgs e)
        {
            StokListesiDoldur();
            KullaniciStokDoldur();
            KullaniciBakiyeDoldur();
        }

        private void KullaniciBakiyeDoldur()
        {
            var bakiye = KullanıcıBakiyeGetir();
            lblBakiye.Text = bakiye.Bakiye.ToString();
            lblOnayBekleniyor.Text = bakiye.OnayliMi ? "Hayır" : "Evet";
        }

        private BakiyeBilgileri KullanıcıBakiyeGetir()
        {
            var bakiyeItem = new BakiyeBilgileri();
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("select top (1) Bakiye, OnayliMi from KullaniciBakiye where KullaniciId = @KullaniciId", baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId });
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                bakiyeItem.Bakiye = float.Parse(oku["Bakiye"].ToString());
                bakiyeItem.OnayliMi = bool.Parse(oku["OnayliMi"].ToString());
            }
            baglan.Close();
            return bakiyeItem;
        }

        private void StokListesiDoldur()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cmbStokSecimi.ValueMember = "Id";
                cmbStokSecimi.DisplayMember = "StokAdi";
                cmbStokSecimi.Items.Add(new StokItem { Id = int.Parse(oku["Id"].ToString()), StokAdi = oku["StokAdi"].ToString() });

            }
            baglan.Close();
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




        private void btnMiktarKaydet_Click(object sender, EventArgs e)
        {
            var selectedItem = (StokItem)cmbStokSecimi.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Lütfen listeden stok seçimi yapınız.");
                return;
            }

            if (!int.TryParse(txtMiktar.Text, out int miktar))
            {
                MessageBox.Show("Lütfen geçerli bir miktar girişi yapınız.");
                return;
            }

            if (miktar <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük bir miktar girişi yapınız.");
                return;
            }

            StokKaydet(selectedItem, miktar);
        }

        private void StokKaydet(StokItem selectedItem, int miktar)
        {
            var dt = KullaniciStoklariniGetir(selectedItem.Id);

            if (dt.Rows.Count != 0)
            {
                miktar = miktar + int.Parse(dt.Rows[0]["Miktar"].ToString());
                baglan.Open();
                SqlCommand komut = new SqlCommand("update KullaniciStoklari set Miktar = @Miktar, OnayliMi=0 where KullaniciId = @KullaniciId and StokId = @StokId", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@StokId", Value = selectedItem.Id },
                new SqlParameter { ParameterName = "@Miktar", Value = miktar }
            });

                komut.ExecuteNonQuery();
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into KullaniciStoklari (KullaniciId, StokId, Miktar) values (@KullaniciId, @StokId, @Miktar)", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@StokId", Value = selectedItem.Id },
                new SqlParameter { ParameterName = "@Miktar", Value = miktar }
            });

                komut.ExecuteNonQuery();
                baglan.Close();
            }

            KullaniciStokDoldur();
        }

        private void KullaniciStokDoldur()
        {
            DataTable dt = KullaniciStoklariniGetir();

            gridViewKullaniciStoklari.DataSource = dt;

        }

        private DataTable KullaniciStoklariniGetir(int stokId = 0)
        {
            baglan.Open();
            var query = @"
                select 
	                ks.Id,
	                k.KullaniciAd,
	                s.StokAdi,
	                ks.Miktar,
	                ks.OnayliMi	
                from Kullanicilar k
                inner join KullaniciStoklari  ks
                on k.Id = ks.KullaniciId
                inner join Stoklar s
                on ks.StokId = s.Id
                where ks.KullaniciId = @KullaniciId ";

            if (stokId != 0)
            {
                query += "and StokId = @StokId";
            }

            SqlCommand komut = new SqlCommand(query, baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId });
            if (stokId != 0)
            {
                komut.Parameters.Add(new SqlParameter { ParameterName = "@StokId", Value = stokId });
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            baglan.Close();
            return dt;
        }
        private void KullanıcıBakiyeYükleme(float bakiye)
        {
            var mevcutBakiye = KullanıcıBakiyeGetir();
            baglan.Open();
            if (mevcutBakiye.Bakiye == 0)
            {
                SqlCommand komut = new SqlCommand("insert into KullaniciBakiye (KullaniciId, Bakiye) values (@KullaniciId, @Bakiye)", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@Bakiye", Value = bakiye },

            });

                komut.ExecuteNonQuery();

            }
            else
            {
                mevcutBakiye.Bakiye += bakiye;
                SqlCommand komut = new SqlCommand("Update KullaniciBakiye  set Bakiye = @Bakiye, OnayliMi = 0 Where KullaniciId = @KullaniciId", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@Bakiye", Value = mevcutBakiye.Bakiye },

            });
                komut.ExecuteNonQuery();
            }
            baglan.Close();

            KullaniciBakiyeDoldur();

        }
        private void para_yükleme_b1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(hesap_is_tb1.Text, out float bakiye))
            {
                MessageBox.Show("Uygun formatta para girişi yapınız.");
                return;
            }
            if (bakiye <= 0)
            {
                MessageBox.Show("0'dan büyük miktarda para girişi yapınız.");
                return;
            }
            KullanıcıBakiyeYükleme(bakiye);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class StokItem
    {
        public int Id { get; set; }
        public string StokAdi { get; set; }
    }
    public class BakiyeBilgileri
    {
        public int Id { get; set; }
        public float Bakiye { get; set; }
        public bool OnayliMi { get; set; }
    }
}
