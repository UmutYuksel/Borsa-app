using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa_App_3
{
    public partial class Form6 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=HOPE;Initial Catalog=proje;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            StokOnayDoldur();
            BakiyeOnayDoldur();
        }

        private void BakiyeOnayDoldur()
        {
            gridViewBakiyeOnay.DataSource = OnayBekleyenKullaniciBakiyeleriniGetir();
        }

        private DataTable OnayBekleyenKullaniciBakiyeleriniGetir()
        {
            baglan.Open();
            var query = @"select kb.Id, k.KullaniciAd, kb.Bakiye, kb.OnayliMi from KullaniciBakiye kb inner join Kullanicilar k on kb.KullaniciId = k.Id where OnayliMi=0";

            SqlCommand komut = new SqlCommand(query, baglan);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            baglan.Close();
            return dt;
        }

        private void StokOnayDoldur()
        {
            gridViewStokOnay.DataSource = OnayBekleyenKullaniciStoklariniGetir();
        }
        private DataTable OnayBekleyenKullaniciStoklariniGetir()
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
                where ks.OnayliMi = 0";

            SqlCommand komut = new SqlCommand(query, baglan);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            baglan.Close();
            return dt;
        }

        private void gridViewStokOnay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var kullaniciStokId = gridViewStokOnay.Rows[e.RowIndex].Cells["Id"].Value;
            var onayliMi = gridViewStokOnay.Rows[e.RowIndex].Cells["OnayliMi"].Value;

            baglan.Open();
            SqlCommand komut = new SqlCommand("Update KullaniciStoklari set OnayliMi = @OnayliMi where Id = @Id", baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@Id", Value = kullaniciStokId });
            komut.Parameters.Add(new SqlParameter { ParameterName = "@OnayliMi", Value = onayliMi });
            komut.ExecuteNonQuery();
            baglan.Close();

            StokOnayDoldur();
        }

        private void gridViewBakiyeOnay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var kullaniciBakiyeId = gridViewBakiyeOnay.Rows[e.RowIndex].Cells["Id"].Value;
            var onayliMi = gridViewBakiyeOnay.Rows[e.RowIndex].Cells["OnayliMi"].Value;

            baglan.Open();
            SqlCommand komut = new SqlCommand("Update KullaniciBakiye set OnayliMi = @OnayliMi where Id = @Id", baglan);
            komut.Parameters.Add(new SqlParameter { ParameterName = "@Id", Value = kullaniciBakiyeId });
            komut.Parameters.Add(new SqlParameter { ParameterName = "@OnayliMi", Value = onayliMi });
            komut.ExecuteNonQuery();
            baglan.Close();

            BakiyeOnayDoldur();
        }
    }
}
