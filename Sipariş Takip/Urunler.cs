using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Takip
{
    public class Urunler
    {
        SqlConnection _connection = new SqlConnection("Server=tcp:hastane.database.windows.net,1433;Initial Catalog=sipariş takip;Persist Security Info=False;User ID=mesut;Password=Bilmiyorum123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public List<Urun> GetAll()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT*FROM urun;", _connection);
            
            SqlDataReader reader =  command.ExecuteReader();
        
            List<Urun> urunler = new List<Urun>();
            List<Kategori> kategoris = new List<Kategori>();
            while (reader.Read()) {
                Urun urun = new Urun
                {
                    urun_id = Convert.ToInt32(reader["urun_id"]),
                    urun_kodu = reader["urun_kodu"].ToString(),
                    urun_adi = reader["urun_adi"].ToString(),
                    kategori_id = Convert.ToInt32(reader["kategori_id"]),
                };
                urunler.Add(urun);
            }

            reader.Close();
            _connection.Close();
            return urunler;
        }

        public void UrunEkle(Urun urun)
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand command = new SqlCommand("INSERT INTO urun (urun_kodu, urun_adi, kategori_id) VALUES (@urun_kodu, @urun_adi, @kategori_id)", _connection);
            command.Parameters.AddWithValue("@urun_kodu", urun.urun_kodu);
            command.Parameters.AddWithValue("@urun_adi", urun.urun_adi);
            command.Parameters.AddWithValue("@kategori_id", urun.kategori_id);
            command.ExecuteNonQuery();
            _connection.Close();


        }

        public void UrunSil(string id)
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand command = new SqlCommand("DELETE FROM urun WHERE urun_kodu = @urun_kodu", _connection);
            command.Parameters.AddWithValue("@urun_kodu", id);
            command.ExecuteNonQuery();
            _connection.Close();


        }

    }
}
