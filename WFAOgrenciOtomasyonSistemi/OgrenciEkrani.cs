using OgrenciVeri.Siniflar;
using OkulVeri.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAOgrenciOtomasyonSistemi
{
    public partial class OgrenciEkrani : Form
    {
        private readonly OgrenciVerileri _veri;

        public OgrenciEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
            KullanicilariYukle();
        }

        private void KullanicilariYukle()
        {
            cbKullanicilar.Items.Clear();
            cbKullanicilar.DataSource = _veri.Ogrenciler;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (cbKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Kullanıcı seçmediniz!");
                return;
            }

            var secilenOgrenci = (Ogrenci)cbKullanicilar.SelectedItem;
            MessageBox.Show($"{secilenOgrenci.OgrenciAd} {secilenOgrenci.OgrenciSoyad} Hoşgeldin!");
            pnlSecenekler.Show();
        }

        private void pbDersEkleCikar_Click(object sender, EventArgs e)
        {
            new DersEkleCikarIslemleri(_veri).ShowDialog();
        }

        private void pbNotGoruntule_Click(object sender, EventArgs e)
        {
            new NotGoruntulemeIslemleri(_veri).ShowDialog();
        }
    }
}
