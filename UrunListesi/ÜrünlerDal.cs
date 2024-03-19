using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunListesi
{
    public class ÜrünlerDal
    {
        SqlConnection connection = new SqlConnection(@"server=SINANTURAN\SINANINSQL; initial catalog=Ürünler; integrated security=true");
        public List<Ürünler> yazdir()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select *from Ürünler", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Ürünler> ürünler = new List<Ürünler>();
            while (reader.Read())
            {
                Ürünler ürün = new Ürünler()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    İsim = reader["Isim"].ToString(),
                    Stok= Convert.ToInt32(reader["Stok"]),
                    Fiyat = Convert.ToInt32(reader["Fiyat"])
                };
                ürünler.Add(ürün);
            }
            reader.Close();
            connection.Close();
            return ürünler;
        }
        public void ekle(Ürünler ürün)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Insert into Ürünler values(@İsim,@Stok,@Fiyat)", connection);
            command.Parameters.AddWithValue("İsim",ürün.İsim);
            command.Parameters.AddWithValue("Stok",ürün.Stok);
            command.Parameters.AddWithValue("Fiyat",ürün.Fiyat);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void guncelle(Ürünler ürün)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Update Ürünler set Isim=@Isim , Stok=@Stok, Fiyat=@Fiyat where Id=@Id", connection);
            command.Parameters.AddWithValue("Isim", ürün.İsim);
            command.Parameters.AddWithValue("Stok", ürün.Stok);
            command.Parameters.AddWithValue("Fiyat", ürün.Fiyat);
            command.Parameters.AddWithValue("Id", ürün.Id);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void sil(Ürünler ürün)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Delete from Ürünler where Id=@Id", connection);
            command.Parameters.AddWithValue("Id", ürün.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
