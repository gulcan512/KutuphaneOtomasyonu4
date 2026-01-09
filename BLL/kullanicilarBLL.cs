using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using Entity;



namespace BLL
{
    public class kullanicilarBLL
    {
        private kullanicilarDALL _dal = new kullanicilarDALL();

        public kullanicilar GirisYap(string kullaniciAdi, string sifre)
        {
            return _dal.GirisYap(kullaniciAdi, sifre);
        }

        public bool UyeOl(kullanicilar kullanici)
        {
            if (_dal.KullaniciAdiVarMi(kullanici.KullaniciAdi))
            {
                return false;
            }

            return _dal.UyeOl(kullanici);
        }

        public bool PersonelGirisKontrol(string kullaniciAdi, string sifre)
        {
            kullanicilarDALL dal = new kullanicilarDALL();
            return dal.PersonelGirisKontrol(kullaniciAdi, sifre);
        }

    }

}



