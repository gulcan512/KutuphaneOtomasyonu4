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
    public partial class UCOdunc : UserControl
    {
        public UCOdunc()
        {
            InitializeComponent();
        }

        private void UCOdunc_Load(object sender, EventArgs e)
        {

        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            // 🔹 Boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKitapAdi.Text))
            {
                MessageBox.Show(
                    "Lütfen kullanıcı adı ve kitap adını girin",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            oduncKitapBLL bll = new oduncKitapBLL();

            bool sonuc = bll.OduncAl(
                txtKullaniciAdi.Text.Trim(),
                txtKitapAdi.Text.Trim()
            );

            if (sonuc)
            {
                MessageBox.Show(
                    "Kitap başarıyla ödünç alındı",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtKullaniciAdi.Clear();
                txtKitapAdi.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Kullanıcı adı veya kitap adı hatalı",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
    }

