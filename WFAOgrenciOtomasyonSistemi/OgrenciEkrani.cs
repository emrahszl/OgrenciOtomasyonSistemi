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

        private readonly Ogrenci _secilenOgrenci;

        public OgrenciEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
            KullanicilariYukle();
            _secilenOgrenci = (Ogrenci)cbKullanicilar.SelectedItem;
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

            MessageBox.Show($"{_secilenOgrenci.OgrenciAd} {_secilenOgrenci.OgrenciSoyad} Hoşgeldin!");
            pnlSecenekler.Show();
        }

        private void pbDersEkleCikar_Click(object sender, EventArgs e)
        {
            new DersEkleCikarIslemleri(_veri, _secilenOgrenci).ShowDialog();
        }

        private void pbNotGoruntule_Click(object sender, EventArgs e)
        {
            new NotGoruntulemeIslemleri(_veri).ShowDialog();
        }

        private void OgrenciEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            pnlSecenekler.Hide();
        }
    }
}
