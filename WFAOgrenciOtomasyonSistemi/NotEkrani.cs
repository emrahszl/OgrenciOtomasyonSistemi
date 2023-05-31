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
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                cbOgrenciler.DataSource = _veri.Ogrenciler.Where(x => x.Donemler.Count > 0).ToList();
                cbDonemler.DataSource = ((Ogrenci)cbOgrenciler.SelectedItem).Donemler;
                cbDersler.DataSource = ((Donem)cbDonemler.SelectedItem).Dersler;
                dgvOgrenciDersler.DataSource = ((Donem)cbDonemler.SelectedItem).Dersler.Where(x => x.DersNotu > 0).ToList(); //Öğrencinin dersine not ekleyeceğim zaman herkeste aynı ders gözüküyor.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                MessageBox.Show("Stack Trace: " + ex.StackTrace);
            }

        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            if (cbOgrenciler.SelectedItem == null || cbDonemler.SelectedItem == null || cbDersler.SelectedItem == null)
            {
                MessageBox.Show("Öğrenci, dönem veya ders seçilmedi!");
                return;
            }

            pnlNotGirisEkrani.Show();
            KontrolEt();
        }

        private void KontrolEt()
        {
            var secilenDers = (Ders)cbDersler.SelectedItem;

            if (secilenDers == null)
            {
                pnlNotGirisEkrani.Hide();
                return;
            }

            if (secilenDers.VizeNotu != 0)
            {
                txtVizeNotu.Text = secilenDers.VizeNotu.ToString();
                txtVizeNotu.Enabled = false;
            }
            if (secilenDers.FinalNotu != 0)
            {
                txtFinalNotu.Text = secilenDers.FinalNotu.ToString();
                txtFinalNotu.Enabled = false;
            }
        }

        private void btnDerseNotEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVizeNotu.Text) || string.IsNullOrEmpty(txtFinalNotu.Text))
            {
                MessageBox.Show("Vize/Final Notu girilmedi!");
                return;
            }
            if (txtVizeNotu.Enabled == false || txtFinalNotu.Enabled == false)
            {
                MessageBox.Show("İlgili derse ait not mevcut. Girilen notu güncellemek için lütfen \"Not Güncelle\" butonunu kullanınız.");
                return;
            }

            var secilenDers = (Ders)cbDersler.SelectedItem;
            secilenDers.VizeNotu = Convert.ToDouble(txtVizeNotu.Text);
            secilenDers.FinalNotu = Convert.ToDouble(txtFinalNotu.Text);
            secilenDers.DersNotu = secilenDers.VizeNotu * 0.4 + secilenDers.FinalNotu * 0.6;
            txtDersNotu.Text = secilenDers.DersNotu.ToString();
            secilenDers.HarfNotu = HarfNotuAta(secilenDers);
            dgvOgrenciDersler.DataSource = null;
            dgvOgrenciDersler.DataSource = ((Donem)cbDonemler.SelectedItem).Dersler.Where(x => x.DersNotu > 0);
            _veri.Dersler.ResetBindings();
            Sifirla();
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
            cbDonemler.DataSource = ((Ogrenci)cbOgrenciler.SelectedItem).Donemler;
        }

        private void cbDonemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDersler.DataSource = ((Donem)cbDonemler.SelectedItem).Dersler;
        }

        private void cbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciDersler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Notu güncellenecek ders seçilmedi!");
                return;
            }

            dgvOgrenciDersler.Enabled = false;
            btnDerseNotEkle.Text = "Kaydet";
            btnNotGuncelle.Text = "İptal";
            NotGirisiniAktifEt();

            if (btnNotGuncelle.Text == "Not Güncelle")
            {
                var seciliDers = (Ders)(dgvOgrenciDersler.SelectedRows[0].DataBoundItem);
                txtVizeNotu.Text = seciliDers.VizeNotu.ToString();
                txtFinalNotu.Text = seciliDers.FinalNotu.ToString();
            }
            else
            {
                Sifirla();
            }
        }

        private void Sifirla()
        {
            txtVizeNotu.Clear();
            txtFinalNotu.Clear();
            txtDersNotu.Clear();
            btnNotGuncelle.Text = "Not Güncelle";
            btnDerseNotEkle.Text = "Not Ekle";
            dgvOgrenciDersler.Enabled = true;
            KontrolEt();
        }

        private void NotGirisiniAktifEt()
        {
            txtVizeNotu.Enabled = true;
            txtFinalNotu.Enabled = true;
        }
    }
}
