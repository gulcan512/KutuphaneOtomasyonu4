using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace DALL
{
    public class kullanicilarDALL
    {
        public kullanicilar GirisYap(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"SELECT id, ad, soyad, kullaniciAdi, sifre 
                       FROM kullanicilar 
                       WHERE kullaniciAdi = @kullaniciAdi 
                       AND sifre = @sifre";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new kullanicilar
                            {
                                Id = reader.GetInt32("id"),
                                Ad = reader.GetString("ad"),
                                Soyad = reader.GetString("soyad"),
                                KullaniciAdi = reader.GetString("kullaniciAdi"),
                                Sifre = reader.GetString("sifre")
                            };
                        }
                    }
                }
            }
            return null;
        }
        public bool UyeOl(kullanicilar kullanici)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"INSERT INTO kullanicilar
                       (ad, soyad, kullaniciAdi, sifre)
                       VALUES
                       (@ad, @soyad, @kullaniciAdi, @sifre)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ad", kullanici.Ad);
                    cmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullanici.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool KullaniciAdiVarMi(string kullaniciAdi)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM kullanicilar WHERE kullaniciAdi = @kullaniciAdi";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                    return sayi > 0;
                }
            }
        }

        public bool PersonelGirisKontrol(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"SELECT COUNT(*) 
                       FROM kullanicilar 
                       WHERE kullaniciAdi = @kullaniciAdi 
                       AND sifre = @sifre 
                       AND rol = 'admin'";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                    return sayi > 0;
                }
            }
        }


    }
}
    
