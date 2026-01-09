using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Linq;
using Entity;


namespace KutuphaneOtomasyonu4.UserControls
{
    public partial class UCKitaplar : UserControl
    {
        kitaplarBLL _bll = new kitaplarBLL();   
        public UCKitaplar()
        {
            InitializeComponent();
            KitaplariYukle();
        }

        List<Entity.kitaplar> tumKitaplar;

        void KitaplariYukle()
        {
            dgvKitaplar.AutoGenerateColumns = true; // 👈 otomatik sütun oluştur

            tumKitaplar = _bll.TumKitaplariGetir();
            dgvKitaplar.DataSource = tumKitaplar;
        }
        

        private void UCKitaplar_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        void KitaplariListele()
        {
            kitaplarBLL bll = new kitaplarBLL();

            List<kitaplar> liste = bll.TumKitaplariGetir();

            dgvKitaplar.DataSource = liste;
        }


        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower();

            var filtreliListe = tumKitaplar.Where(k =>
                k.KitapAdi.ToLower().Contains(aranan) ||
                k.Yazar.ToLower().Contains(aranan) ||
                k.Tur.ToLower().Contains(aranan)
            ).ToList();

            dgvKitaplar.DataSource = filtreliListe;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
