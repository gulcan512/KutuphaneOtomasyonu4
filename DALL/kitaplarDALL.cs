using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace DALL
{
    public class kitaplarDALL
    {
        public List<kitaplar> TumKitaplariGetir()
        {
            List<kitaplar> liste = new List<kitaplar>();

            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"SELECT id, kitapAdi, yazar, sayfaSayisi, tur 
                               FROM kitaplar";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add(new kitaplar
                        {
                            Id = dr.GetInt32("id"),
                            KitapAdi = dr.GetString("kitapAdi"),
                            Yazar = dr.GetString("yazar"),
                            SayfaSayisi = dr.GetInt32("sayfaSayisi"),
                            Tur = dr.GetString("tur")
                        });
                    }
                }
            }
            return liste;
        }

        
        public bool KitapEkle(kitaplar kitap)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"INSERT INTO kitaplar
                           (kitapAdi, yazar, sayfaSayisi, tur)
                           VALUES
                           (@kitapAdi, @yazar, @sayfaSayisi, @tur)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kitapAdi", kitap.KitapAdi);
                    cmd.Parameters.AddWithValue("@yazar", kitap.Yazar);
                    cmd.Parameters.AddWithValue("@sayfaSayisi", kitap.SayfaSayisi);
                    cmd.Parameters.AddWithValue("@tur", kitap.Tur);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

    
