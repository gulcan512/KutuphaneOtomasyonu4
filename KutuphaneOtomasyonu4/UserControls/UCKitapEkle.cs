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
using Entity;

namespace KutuphaneOtomasyonu4.UserControls
{
    public partial class UCKitapEkle : UserControl
    {
        public UCKitapEkle()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            // 🔐 PERSONEL KONTROLÜ (YENİ EKLENEN KISIM)
            string personelKAdi = txtPersonelKAdi.Text;
            string personelSifre = txtPersonelSifre.Text;

            if (string.IsNullOrWhiteSpace(personelKAdi) || string.IsNullOrWhiteSpace(personelSifre))
            {
                MessageBox.Show("Personel kullanıcı adı ve şifre giriniz");
                return;
            }

            kullanicilarBLL kbll = new kullanicilarBLL();
            bool personelMi = kbll.PersonelGirisKontrol(personelKAdi, personelSifre);

            if (!personelMi)
            {
                MessageBox.Show("Personel bilgileri hatalı");
                return;
            }



                // 🔹 Form kontrolü
                if (string.IsNullOrWhiteSpace(txtKitapAdi3.Text) ||
                string.IsNullOrWhiteSpace(txtYazarAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSayfa.Text) ||
                cmbTur.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Lütfen tüm alanları doldurun",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                int sayfaSayisi;
                if (!int.TryParse(txtSayfa.Text, out sayfaSayisi))
                {
                    MessageBox.Show(
                        "Sayfa sayısı sayı olmalıdır",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // 🔹 Entity oluştur
                kitaplar yeniKitap = new kitaplar
                {
                    KitapAdi = txtKitapAdi3.Text,
                    Yazar = txtYazarAdi.Text,
                    SayfaSayisi = sayfaSayisi,
                    Tur = cmbTur.SelectedItem.ToString()
                };

                // 🔹 BLL çağır
                kitaplarBLL bll = new kitaplarBLL();
                bool sonuc = bll.KitapEkle(yeniKitap);

                if (sonuc)
                {
                    MessageBox.Show(
                        "Kitap başarıyla eklendi",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // 🔹 Temizle
                    txtKitapAdi3.Clear();
                    txtYazarAdi.Clear();
                    txtSayfa.Clear();
                    cmbTur.SelectedIndex = -1;

                    // 🔹 PERSONEL ALANLARINI DA TEMİZLE (BONUS)
                    txtPersonelKAdi.Clear();
                    txtPersonelSifre.Clear();
                }
                else
                {
                    MessageBox.Show(
                        "Kitap eklenemedi",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
       
        private void UCKitapEkle_Load(object sender, EventArgs e)
        {

        }
    }
    }

