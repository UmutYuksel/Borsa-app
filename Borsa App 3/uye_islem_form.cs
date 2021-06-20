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
        private void uye_islem_form_Load(object sender, EventArgs e)
        {
            StokListesiDoldur();
            KullaniciStokDoldur();
            KullaniciBakiyeDoldur();
            CenterToScreen();
        }

        private void KullaniciBakiyeDoldur()
        {
            var bakiye = KullanıcıBakiyeGetir(KullaniciId);
            lblBakiye.Text = bakiye.Bakiye.ToString();
            lblOnayBekleniyor.Text = bakiye.OnayliMi ? "Hayır" : "Evet";
        }

        private BakiyeBilgileri KullanıcıBakiyeGetir(int kullaniciId)
        {
            var bakiyeItem = new BakiyeBilgileri();

            baglan.Open();
            SqlCommand komut = new SqlCommand("select top (1) Bakiye, OnayliMi from KullaniciBakiye where KullaniciId = @KullaniciId", baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId });
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

                cmbStokSecimiSatinAlma.ValueMember = "Id";
                cmbStokSecimiSatinAlma.DisplayMember = "StokAdi";
                cmbStokSecimiSatinAlma.Items.Add(new StokItem { Id = int.Parse(oku["Id"].ToString()), StokAdi = oku["StokAdi"].ToString() });

            }
            baglan.Close();
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


            if (!int.TryParse(txtBirimFiyat.Text, out int birimFiyat))
            {
                MessageBox.Show("Lütfen geçerli bir birim fiyat girişi yapınız.");
                return;
            }

            if (birimFiyat <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük birim fiyat girişi yapınız.");
                return;
            }

            StokKaydet(selectedItem, miktar, birimFiyat);
        }

        private void StokKaydet(StokItem selectedItem, int miktar, int birimFiyat)
        {
            var dt = KullaniciStoklariniGetir(selectedItem.Id);

            if (dt.Rows.Count != 0)
            {
                miktar = miktar + int.Parse(dt.Rows[0]["Miktar"].ToString());
                baglan.Open();
                SqlCommand komut = new SqlCommand("update KullaniciStoklari set Miktar = @Miktar, BirimFiyat = @BirimFiyat, OnayliMi=0 where KullaniciId = @KullaniciId and StokId = @StokId", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@StokId", Value = selectedItem.Id },
                new SqlParameter { ParameterName = "@Miktar", Value = miktar },
                new SqlParameter { ParameterName = "@BirimFiyat", Value = birimFiyat}
            });

                komut.ExecuteNonQuery();
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into KullaniciStoklari (KullaniciId, StokId, Miktar, BirimFiyat) values (@KullaniciId, @StokId, @Miktar, @BirimFiyat)", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@StokId", Value = selectedItem.Id },
                new SqlParameter { ParameterName = "@Miktar", Value = miktar },
                new SqlParameter { ParameterName = "@BirimFiyat", Value = birimFiyat}
            });

                komut.ExecuteNonQuery();
                baglan.Close();
            }

            KullaniciStokDoldur();
        }

        private void KullaniciStokDoldur()
        {
            DataTable dt = KullaniciStoklariniGetir(KullaniciId);

            gridViewKullaniciStoklari.DataSource = dt;

            gridViewKullaniciStoklari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewKullaniciStoklari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }

        private DataTable KullaniciStoklariniGetir(int kullaniciId, int stokId = 0)
        {
            baglan.Open();
            var query = @"
                select

                    ks.Id,
	                k.KullaniciAd,
	                s.StokAdi,
	                ks.Miktar,
                    ks.BirimFiyat,
	                ks.OnayliMi
                from Kullanicilar k
                inner join KullaniciStoklari ks
                on k.Id = ks.KullaniciId
                inner join Stoklar s
                on ks.StokId = s.Id
                where ks.KullaniciId = @KullaniciId";

            if (stokId != 0)
            {
                query += "and StokId = @StokId";
            }

            SqlCommand komut = new SqlCommand(query, baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId });
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
        private void KullanıcıBakiyeYükleme(float bakiye, string paraBirimi)
        {
            var mevcutBakiye = KullanıcıBakiyeEmirGetir(KullaniciId, paraBirimi);
            baglan.Open();
            if (mevcutBakiye.Bakiye == 0)
            {
                SqlCommand komut = new SqlCommand("insert into KullaniciBakiyeEmir (KullaniciId, Bakiye, GirisParaBirimi) values (@KullaniciId, @Bakiye, @GirisParaBirimi)", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@Bakiye", Value = bakiye },
                new SqlParameter { ParameterName = "@GirisParaBirimi", Value = paraBirimi },

            });

                komut.ExecuteNonQuery();

            }
            else
            {
                mevcutBakiye.Bakiye += bakiye;
                SqlCommand komut = new SqlCommand("Update KullaniciBakiyeEmir set Bakiye = @Bakiye Where KullaniciId = @KullaniciId and GirisParaBirimi = @GirisParaBirimi", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@Bakiye", Value = mevcutBakiye.Bakiye },
                new SqlParameter { ParameterName = "@GirisParaBirimi", Value = paraBirimi }
            });
                komut.ExecuteNonQuery();
            }
            baglan.Close();

            KullaniciBakiyeDoldur();

        }

        private BakiyeBilgileri KullanıcıBakiyeEmirGetir(int kullaniciId, string girisParaBirimi)
        {
            var bakiyeItem = new BakiyeBilgileri();

            baglan.Open();
            SqlCommand komut = new SqlCommand("select top (1) Bakiye, GirisParaBirimi from KullaniciBakiyeEmir where KullaniciId = @KullaniciId and GirisParaBirimi = @GirisParaBirimi", baglan);
            komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId },
                new SqlParameter { ParameterName = "@GirisParaBirimi", Value = girisParaBirimi },
            });
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                bakiyeItem.Bakiye = float.Parse(oku["Bakiye"].ToString());
                bakiyeItem.GirisParaBirimi = oku["GirisParaBirimi"].ToString(); 
            }
            baglan.Close();
            return bakiyeItem;
        }

        private void para_yükleme_b1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbParaBirimi.SelectedItem.ToString()))
            {
                MessageBox.Show("Yükleme yapılacak para birimini seçiniz.");
                return;
            }
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

            KullanıcıBakiyeYükleme(bakiye, cmbParaBirimi.SelectedItem.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMiktarStokSatinAlma.Text, out int miktar))
            {
                MessageBox.Show("Uygun formatta miktar girişi yapınız.");
                return;
            }

            if (!int.TryParse(txtBirimFiyatStokSatinAlma.Text, out int birimFiyat))
            {
                MessageBox.Show("Uygun formatta birim fiyat girişi yapınız.");
                return;
            }

            var selectedItem = (StokItem)cmbStokSecimiSatinAlma.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Lütfen listeden stok seçimi yapınız.");
                return;
            }
            var stokId = selectedItem.Id;

            SatinAl(stokId, miktar);

        } 

        private void SatinAl(int stokId, int miktar)
        {
            var stokHareketleri = StokHareketleriHesapla(stokId, miktar);
            SatisYap(stokHareketleri);
            KullaniciStokDoldur();
            KullaniciBakiyeDoldur();
        }

        private void SatisYap(List<StokHareketi> stokHareketleri)
        {
            if (BakiyeKontrol(stokHareketleri))
            {
                SatisBakiyeleriniDagit(stokHareketleri);
                StokHareketleriniYansit(stokHareketleri);
            }
            else
            {
                MessageBox.Show("Satış için bakiye yeterli değil.");
            }
        }

        private void StokHareketleriniYansit(List<StokHareketi> stokHareketleri)
        {
            if (stokHareketleri.Count == 0)
            {
                return;
            }
            var stokId = stokHareketleri.Select(x => x.StokId).Distinct().First();

            StokDegisimi(KullaniciId, stokId, stokHareketleri.Sum(x => x.Miktar));
            foreach (var stokHareketi in stokHareketleri)
            {
                StokDegisimi(stokHareketi.SaticiKullaniciId, stokHareketi.StokId, -1 * stokHareketi.Miktar);
            }
        }

        private void StokDegisimi(int kullaniciId, int stokId, int miktar)
        {
            var dt = KullaniciStoklariniGetir(kullaniciId, stokId);

            if (dt.Rows.Count != 0)
            {
                miktar = int.Parse(dt.Rows[0]["Miktar"].ToString()) + miktar;
                baglan.Open();

                SqlCommand komut = null;

                if (miktar != 0)
                {
                    komut = new SqlCommand("update KullaniciStoklari set Miktar = @Miktar where KullaniciId = @KullaniciId and StokId = @StokId", baglan);

                    komut.Parameters.AddRange(new SqlParameter[] {
                        new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId },
                        new SqlParameter { ParameterName = "@StokId", Value = stokId },
                        new SqlParameter { ParameterName = "@Miktar", Value = miktar },
                    });
                }
                else
                {
                    komut = new SqlCommand("DELETE KullaniciStoklari where KullaniciId = @KullaniciId and StokId = @StokId", baglan);

                    komut.Parameters.AddRange(new SqlParameter[] {
                        new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId },
                        new SqlParameter { ParameterName = "@StokId", Value = stokId }
                    });
                }

                komut.ExecuteNonQuery();
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into KullaniciStoklari (KullaniciId, StokId, Miktar, BirimFiyat, OnayliMi) values (@KullaniciId, @StokId, @Miktar, @BirimFiyat, 1)", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId },
                new SqlParameter { ParameterName = "@StokId", Value = stokId },
                new SqlParameter { ParameterName = "@Miktar", Value = miktar },
                new SqlParameter { ParameterName = "@BirimFiyat", Value = 0}
            });

                komut.ExecuteNonQuery();
                baglan.Close();
            }
        }

        private void SatisBakiyeleriniDagit(List<StokHareketi> stokHareketleri)
        {
            if (stokHareketleri.Count == 0)
            {
                return;
            }
            KullanıcıBakiyeYükleme(KullaniciId, -1 * stokHareketleri.Sum(x => x.Miktar * x.BirimFiyat));
            foreach (var stokHareketi in stokHareketleri)
            {
                KullanıcıBakiyeYükleme(stokHareketi.SaticiKullaniciId, stokHareketi.Miktar * stokHareketi.BirimFiyat);
            }
        }

        private void KullanıcıBakiyeYükleme(int kullaniciId, float bakiye)
        {
            var mevcutBakiye = KullanıcıBakiyeGetir(kullaniciId);
            baglan.Open();
            if (mevcutBakiye.Bakiye == 0)
            {
                SqlCommand komut = new SqlCommand("insert into KullaniciBakiye (KullaniciId, Bakiye) values (@KullaniciId, @Bakiye)", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId },
                new SqlParameter { ParameterName = "@Bakiye", Value = bakiye },

            });

                komut.ExecuteNonQuery();

            }
            else
            {
                mevcutBakiye.Bakiye += bakiye;
                SqlCommand komut = new SqlCommand("Update KullaniciBakiye  set Bakiye = @Bakiye, OnayliMi = 1 Where KullaniciId = @KullaniciId", baglan);

                komut.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter { ParameterName = "@KullaniciId", Value = kullaniciId },
                new SqlParameter { ParameterName = "@Bakiye", Value = mevcutBakiye.Bakiye },

            });
                komut.ExecuteNonQuery();
            }
            baglan.Close();
        }

        private bool BakiyeKontrol(List<StokHareketi> stokHareketleri)
        {
            var bakiye = KullanıcıBakiyeGetir(KullaniciId);
            return bakiye.Bakiye > stokHareketleri.Sum(x => x.BirimFiyat * x.Miktar);
        }

        private List<StokHareketi> StokHareketleriHesapla(int stokId, int miktar)
        {
            var stokHareketleri = new List<StokHareketi>();
            var stoklar = SatistakiStoklariGetir(stokId);
            var alinacakMiktar = miktar;
            for (int i = 0; i < stoklar.Rows.Count; i++)
            {

                if (alinacakMiktar == 0)
                {
                    break;
                }

                var row = stoklar.Rows[i];
                var alinabilenMiktar = int.Parse(row["Miktar"].ToString()) - alinacakMiktar;
                if (alinabilenMiktar < 0)
                {
                    alinacakMiktar = -1 * alinabilenMiktar;
                    alinabilenMiktar = miktar - alinacakMiktar;
                }
                else
                {
                    alinabilenMiktar = alinacakMiktar;
                    alinacakMiktar = 0;
                }

                stokHareketleri.Add(new StokHareketi
                {
                    SaticiKullaniciId = int.Parse(row["KullaniciId"].ToString()),
                    AliciKullaniciId = KullaniciId,
                    StokId = stokId,
                    BirimFiyat = int.Parse(row["BirimFiyat"].ToString()),
                    Miktar = alinabilenMiktar
                });
            }
            return stokHareketleri;
        }

        private DataTable SatistakiStoklariGetir(int stokId)
        {
            var query = "select * from KullaniciStoklari where OnayliMi = 1 and StokId = @StokId and KullaniciId != @KullaniciId order by BirimFiyat";
            baglan.Open();

            SqlCommand komut = new SqlCommand(query, baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@KullaniciId", Value = KullaniciId });
            komut.Parameters.Add(new SqlParameter { ParameterName = "@StokId", Value = stokId });

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            baglan.Close();
            return dt;
        }



        private void btncikisyap_Click(object sender, EventArgs e)
        {
            frm_login ana_ekran = new frm_login();
            ana_ekran.Show(); ;
            this.Close();
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
        public string GirisParaBirimi { get; set; }
        public bool OnayliMi { get; set; }
    }
    public class StokHareketi
    {
        public int SaticiKullaniciId { get; set; }
        public int AliciKullaniciId { get; set; }
        public int StokId { get; set; }
        public int Miktar { get; set; }
        public int BirimFiyat { get; set; }

    }
    class StokEmir
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int StokId { get; set; }
        public float Miktar { get; set; }
        public float BirimFiyat { get; set; }
        public DateTime Tarih { get; set; }
        public int Status { get; set; }
    }
}
