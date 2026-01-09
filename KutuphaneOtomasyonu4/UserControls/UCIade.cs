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

namespace KutuphaneOtomasyonu4.UserControls
{
    public partial class UCIade : UserControl
    {
        public UCIade()
        {
            InitializeComponent();
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi2.Text) ||
       string.IsNullOrWhiteSpace(txtKitapAdi2.Text))
            {
                MessageBox.Show(
                    "Kullanıcı adı ve kitap adı giriniz",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            oduncKitapBLL bll = new oduncKitapBLL();

            bool sonuc = bll.KitapIadeEt(
                txtKullaniciAdi2.Text,
                txtKitapAdi2.Text
            );

            if (sonuc)
            {
                MessageBox.Show(
                    "Kitap başarıyla iade edildi",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtKullaniciAdi2.Clear();
                txtKitapAdi2.Clear();
            }
            else
            {
                MessageBox.Show(
                    "İade edilecek kayıt bulunamadı",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UCIade_Load(object sender, EventArgs e)
        {

        }
    }
    }

