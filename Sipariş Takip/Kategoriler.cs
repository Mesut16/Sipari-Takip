using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Takip
{
    public class Kategoriler
    {
        public List<Kategori> GetAll()
        {
            SqlConnection connection = new SqlConnection("Server=tcp:hastane.database.windows.net,1433;Initial Catalog=sipariş takip;Persist Security Info=False;User ID=mesut;Password=Bilmiyorum123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM kategori;", connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Kategori> kategoriler = new List<Kategori>();
            while (reader.Read())
            {
                Kategori kategori = new Kategori
                {
                    kategori_id = Convert.ToInt32(reader["kategori_id"]),
                    kategori_adi = reader["kategori_adi"].ToString()
                };
                kategoriler.Add(kategori);
            }

            reader.Close();
            connection.Close();
            return kategoriler;
        }
    }

}
