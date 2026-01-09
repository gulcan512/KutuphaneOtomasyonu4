using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
namespace BLL
{
    public class oduncKitapBLL
    {
        private oduncKitapDALL _dal = new oduncKitapDALL();

        public bool OduncAl(string kullaniciAdi, string kitapAdi)
        {
            int kullaniciId = _dal.KullaniciIdGetir(kullaniciAdi);
            if (kullaniciId == 0)
                return false;

            
            int kitapId = _dal.KitapIdGetir(kitapAdi);
            if (kitapId == 0)
                return false;

            return _dal.OduncEkle(kullaniciId, kitapId);
        }

        public bool KitapIadeEt(string kullaniciAdi, string kitapAdi)
        {
            int kullaniciId = _dal.KullaniciIdGetir(kullaniciAdi);
            if (kullaniciId == 0)
                return false;

            int kitapId = _dal.KitapIdGetir(kitapAdi);
            if (kitapId == 0)
                return false;

            return _dal.KitapIadeEt(kullaniciId, kitapId);
        }

    }
}
    

