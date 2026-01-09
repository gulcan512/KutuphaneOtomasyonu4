using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using Entity;

namespace BLL
{
    public class kitaplarBLL
    {
        kitaplarDALL _dal = new kitaplarDALL();

        public List<kitaplar> TumKitaplariGetir()
        {
            return _dal.TumKitaplariGetir();
        }

        public bool KitapEkle(kitaplar kitap)
        {
            if (string.IsNullOrWhiteSpace(kitap.KitapAdi) ||
                string.IsNullOrWhiteSpace(kitap.Yazar) ||
                kitap.SayfaSayisi <= 0 ||
                string.IsNullOrWhiteSpace(kitap.Tur))
            {
                return false;
            }

            return _dal.KitapEkle(kitap);
        }
    }
}

