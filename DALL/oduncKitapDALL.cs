using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DALL
{
    public class oduncKitapDALL
    {
        
        public int KullaniciIdGetir(string kullaniciAdi)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"SELECT id FROM kullanicilar
                               WHERE kullaniciAdi = @kullaniciAdi";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    object sonuc = cmd.ExecuteScalar();
                    return sonuc != null ? Convert.ToInt32(sonuc) : 0;
                }
            }
        }

        
        public int KitapIdGetir(string kitapAdi)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"SELECT id FROM kitaplar
                               WHERE kitapAdi = @kitapAdi";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kitapAdi", kitapAdi);

                    object sonuc = cmd.ExecuteScalar();
                    return sonuc != null ? Convert.ToInt32(sonuc) : 0;
                }
            }
        }

        
        public bool OduncEkle(int kullaniciId, int kitapId)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"INSERT INTO oduncKitap
                               (kullaniciId, kitapId, oduncTarihi, IadeEdildi)
                               VALUES
                               (@kullaniciId, @kitapId, @oduncTarihi, @iadeEdildi)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    cmd.Parameters.AddWithValue("@kitapId", kitapId);
                    cmd.Parameters.AddWithValue("@oduncTarihi", DateTime.Now);
                    cmd.Parameters.AddWithValue("@iadeEdildi", false);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool KitapIadeEt(int kullaniciId, int kitapId)
        {
            using (MySqlConnection conn = DbBaglanti.BaglantiGetir())
            {
                conn.Open();

                string sql = @"
        UPDATE oduncKitap
        SET 
            IadeEdildi = 1,
            IadeTarihi = NOW()
        WHERE 
            kullaniciId = @kullaniciId
            AND kitapId = @kitapId
            AND IadeEdildi = 0";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    cmd.Parameters.AddWithValue("@kitapId", kitapId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}
   
