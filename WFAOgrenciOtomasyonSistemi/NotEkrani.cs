using OgrenciVeri.Siniflar;
using OkulVeri.Enumlar;
using OkulVeri.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAOgrenciOtomasyonSistemi
{
    public partial class NotEkrani : Form
    {
        private readonly OgrenciVerileri _veri;

        public NotEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
            OgrencileriYukle();
        }

        private void OgrencileriYukle()
        {
            cbOgrenciler.DataSource = _veri.Ogrenciler;
        }

        private void cbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOgrenciler.SelectedItem == null || cbDonemler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen öncelikle öğrenci ve dönem seçiniz!");
                return;
            }

            pnlNotGirisEkrani.Show();
        }

        private void btnOgrenciyeDonemDersiEkle_Click(object sender, EventArgs e)
        {
            var ogrenci = (Ogrenci)cbOgrenciler.SelectedItem;
            var donem = (Donem)cbDonemler.SelectedItem;
            var ders = (Ders)cbDersler.SelectedItem;
            ders.VizeNotu = Convert.ToDouble(txtVizeNotu.Text);
            ders.FinalNotu = Convert.ToDouble(txtFinalNotu.Text);
            ders.DersNotu = (ders.VizeNotu * 0.4) + (ders.FinalNotu * 0.6);
            txtDersNotu.Text = ders.DersNotu.ToString();
            ders.HarfNotu = HarfNotuAta(ders);

            var guncelDonem = ogrenci.Donemler.First(x => x == donem);
            guncelDonem.Dersler.Add(ders);
            dgvOgrenciDersler.DataSource = guncelDonem.Dersler;
        }

        private HarfNotu HarfNotuAta(Ders ders)
        {
            switch (ders.DersNotu)
            {
                case < 50:
                    return HarfNotu.FF;
                case < 55:
                    return HarfNotu.DD;
                case < 60:
                    return HarfNotu.DC;
                case < 70:
                    return HarfNotu.CC;
                case < 80:
                    return HarfNotu.CB;
                case < 85:
                    return HarfNotu.BB;
                case < 90:
                    return HarfNotu.BA;
                default:
                    return HarfNotu.AA;
            }
        }

        private void cbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ogrenci = (Ogrenci)cbOgrenciler.SelectedItem;
            cbDonemler.DataSource = ogrenci.Donemler;
        }

        private void cbDonemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var donem = (Donem)cbDonemler.SelectedItem;
            cbDersler.DataSource = donem.Dersler;
        }
    }
}
