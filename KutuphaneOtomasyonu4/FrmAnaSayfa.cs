using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using KutuphaneOtomasyonu4.UserControls;

namespace KutuphaneOtomasyonu4
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            EkranYukle(new UCAnaSayfa());
        }

        void EkranYukle(UserControl uc)
        {
            pnlIcerik.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            EkranYukle(new UCAnaSayfa());
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            EkranYukle(new UCKitaplar());
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            EkranYukle(new UCOdunc());
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            EkranYukle(new UCIade());
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            EkranYukle(new UCKitapEkle());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
        "Çıkış yapmak istediğinize emin misiniz?",
        "Emin misiniz?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pnlIcerik_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
