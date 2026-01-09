using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class oduncKitap
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int KitapId { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
        public bool IadeEdildi { get; set; }
    }
}
