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


namespace KutuphaneOtomasyonu4
{
    public partial class FormGiris : Form
    {
        // Üye ol / giriş modu kontrolü
        bool uyeOlModu = false;

        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            // İlk açılışta sadece giriş alanları görünsün
            UyeOlModunuKapat();
        }

        // ====== MOD KONTROL METOTLARI ======

        void UyeOlModunuAc()
        {
            uyeOlModu = true;

            txtAd.Visible = true;
            txtSoyad.Visible = true;
            lblAd.Visible = true;
            lblSoyad.Visible = true;

            btnGiris.Text = "Üye Ol";
            btnUyeOl.Text = "Giriş Ekranına Dön";
        }

        void UyeOlModunuKapat()
        {
            uyeOlModu = false;

            txtAd.Visible = false;
            txtSoyad.Visible = false;
            lblAd.Visible = false;
            lblSoyad.Visible = false;

            btnGiris.Text = "Giriş Yap";
            btnUyeOl.Text = "Üye Ol";
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (!uyeOlModu)
            {
                // Üye ol moduna geç
                UyeOlModunuAc();
            }
            else
            {
                // Giriş ekranına dön
                UyeOlModunuKapat();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullanicilarBLL km = new kullanicilarBLL();

            if (!uyeOlModu)
            {
                // ===== GİRİŞ YAP =====
                kullanicilar kullanici = km.GirisYap(
                    txtKullaniciAdi.Text,
                    txtSifre.Text
                );

                if (kullanici != null)
                {
                    MessageBox.Show(
                        "Giriş başarılı",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    FrmAnaSayfa frm = new FrmAnaSayfa();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Kullanıcı adı veya şifre hatalı",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                // 👇 ÖNCE FORMDA KONTROL
                if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                    string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    MessageBox.Show(
                        "Lütfen tüm alanları doldurun",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                kullanicilar yeniKullanici = new kullanicilar
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                };

                // 👇 BLL'YE GÖNDER
                bool sonuc = km.UyeOl(yeniKullanici);

                if (sonuc)
                {
                    MessageBox.Show(
                        "Üyelik başarılı, giriş yapabilirsiniz",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();

                    UyeOlModunuKapat();
                }
                else
                {
                    MessageBox.Show(
                        "Bu kullanıcı adı zaten kullanılıyor",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

            }
        }
    }
}
        
    


          

        
    

