using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Takip
{
    public class Siparisler
    {
        private string connectionString = "Server=tcp:hastane.database.windows.net,1433;Initial Catalog=sipariş takip;Persist Security Info=False;User ID=mesut;Password=Bilmiyorum123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<SiparisTakip> GetAll()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip;", connection);
            SqlDataReader reader = command.ExecuteReader();

            List<SiparisTakip> siparisler = new List<SiparisTakip>();
            while (reader.Read())
            {
                SiparisTakip siparis = new SiparisTakip
                {
                    SiparisId = Convert.ToInt32(reader["siparis_id"]),
                    SirketAdi = reader["sirket_adi"].ToString(),
                    SiparisAdet = Convert.ToInt32(reader["siparis_adet"]),
                    HazirlananAdet = Convert.ToInt32(reader["hazirlanan_adet"]),
                    MusteriTelefon = reader["musteriTelefon"].ToString(),
                    SiparisTarihi = Convert.ToDateTime(reader["siparisTarihi"]),
                    TeslimTarihi = Convert.ToDateTime(reader["teslimTarihi"]),
                    UrunKodu = reader["urun_kodu"].ToString(),
                    TeslimDurumu = reader["teslimDurumu"].ToString()
                };
                siparisler.Add(siparis);
            }

            reader.Close();
            connection.Close();
            return siparisler;
        }

        public bool UrunKoduVarMi(string urunKodu)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM urun WHERE urun_kodu = @urun_kodu", connection);
                command.Parameters.AddWithValue("@urun_kodu", urunKodu);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }


        public void SiparisEkle(SiparisTakip siparis)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO SiparisTakip (sirket_adi, siparis_adet, hazirlanan_adet, musteriTelefon, siparisTarihi, teslimTarihi, urun_kodu, teslimDurumu) VALUES (@sirket_adi, @siparis_adet, 0, @musteriTelefon, @siparisTarihi, @teslimTarihi, @urun_kodu, 'TeslimEdilmedi')", connection);
                command.Parameters.AddWithValue("@sirket_adi", siparis.SirketAdi);
                command.Parameters.AddWithValue("@siparis_adet", siparis.SiparisAdet);
                command.Parameters.AddWithValue("@musteriTelefon", siparis.MusteriTelefon);
                command.Parameters.AddWithValue("@siparisTarihi", siparis.SiparisTarihi);
                command.Parameters.AddWithValue("@teslimTarihi", siparis.TeslimTarihi);
                command.Parameters.AddWithValue("@urun_kodu", siparis.UrunKodu);
                command.ExecuteNonQuery();
            }
        }

        public void SiparisGuncelle(SiparisTakip yeniSiparis)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE SiparisTakip SET sirket_adi = @sirket_adi, siparis_adet = @siparis_adet, hazirlanan_adet = @hazirlanan_adet, musteriTelefon = @musteriTelefon, urun_kodu = @urun_kodu, teslimDurumu = @teslimDurumu WHERE siparis_id = @siparisId", connection);
                command.Parameters.AddWithValue("@sirket_adi", yeniSiparis.SirketAdi);
                command.Parameters.AddWithValue("@siparis_adet", yeniSiparis.SiparisAdet);
                command.Parameters.AddWithValue("@hazirlanan_adet", yeniSiparis.HazirlananAdet);
                command.Parameters.AddWithValue("@musteriTelefon", yeniSiparis.MusteriTelefon);
                command.Parameters.AddWithValue("@urun_kodu", yeniSiparis.UrunKodu);
                command.Parameters.AddWithValue("@teslimDurumu", yeniSiparis.TeslimDurumu);
                command.Parameters.AddWithValue("@siparisId", yeniSiparis.SiparisId);
                command.ExecuteNonQuery();
            }
        }

            public void SiparisSil(string siparisId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM SiparisTakip WHERE siparis_id = @siparis_id", connection);
                    command.Parameters.AddWithValue("@siparis_id", siparisId);
                    command.ExecuteNonQuery();
                }
            }

        

    }
}
