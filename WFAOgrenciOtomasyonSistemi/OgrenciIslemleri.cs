using OgrenciVeri.Koleksiyonlar;
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
    public partial class OgrenciIslemleri : Form
    {
        private readonly OgrenciVerileri _veri;

        public OgrenciIslemleri(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            dgvOgrenciler.AutoGenerateColumns = false;
            dgvOgrenciler.DataSource = _veri.Ogrenciler;
            KontrolEt();
        }

        private void KontrolEt()
        {
            if (_veri.Ogrenciler.Count > 0)
            {
                btnGuncelle.Show();
                btnOgrenciSil.Show();
            }
            else
            {
                btnGuncelle.Hide();
                btnOgrenciSil.Hide();
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            string ad = txtOgrenciAd.Text.Trim();
            string soyad = txtOgrenciSoyad.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Öğrenci adı/soyadı boş bırakılamaz!");
                return;
            }

            _veri.Ogrenciler.Add(new Ogrenci(ad, soyad));
            MessageBox.Show($"{ad} {soyad} başarıyla eklendi!");

            Temizle(gbOgrenciEkle);
        }

        private void Temizle(GroupBox gbox)
        {
            foreach (var item in gbox.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
                return;

            var ogrenci = SecilenOgrenci();

            DialogResult dr = MessageBox.Show($"{ogrenci.OgrenciAd} {ogrenci.OgrenciSoyad} adlı öğrenciyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
                _veri.Ogrenciler.Remove(ogrenci);
            else
                MessageBox.Show("Öğrenci silme işlemi iptal edildi!");

            KontrolEt();
        }

        private Ogrenci SecilenOgrenci()
        {
            var row = dgvOgrenciler.SelectedRows[0];
            var ogrenci = (Ogrenci)row.DataBoundItem;

            return ogrenci;
        }

        Ogrenci? guncellenecekOgrenci;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Öğrenci Seçilmedi!");
                return;
            }

            gbOgrenciGuncelle.Show();

            if (btnGuncelle.Text == "Güncelle")
            {
                var ogrenci = SecilenOgrenci();
                guncellenecekOgrenci = ogrenci;
                txtGuncellenecekAd.Text = ogrenci.OgrenciAd;
                txtGuncellenecekSoyad.Text = ogrenci.OgrenciSoyad;
                txtGuncellenecekOgrenciNo.Text = ogrenci.OgrenciNo;
                dtpKayitTarihi.Value = ogrenci.KayitTarihi;
                btnGuncelle.Text = "İptal";
                dgvOgrenciler.Enabled = false;
            }
            else
            {
                Sifirla();
            }
        }
        private void btnOgrenciyiKaydet_Click(object sender, EventArgs e)
        {
            if (guncellenecekOgrenci != null)
            {
                guncellenecekOgrenci.OgrenciAd = txtGuncellenecekAd.Text;
                guncellenecekOgrenci.OgrenciSoyad = txtGuncellenecekSoyad.Text;
                guncellenecekOgrenci.OgrenciNo = txtGuncellenecekOgrenciNo.Text;
                guncellenecekOgrenci.KayitTarihi = dtpKayitTarihi.Value;
                _veri.Ogrenciler.ResetBindings();
                gbOgrenciGuncelle.Hide();
                Sifirla();
            }
        }

        private void Sifirla()
        {
            btnGuncelle.Text = "Güncelle";
            Temizle(gbOgrenciGuncelle);
            dgvOgrenciler.Enabled = true;
            dtpKayitTarihi.Value = DateTime.Now;
            guncellenecekOgrenci = null;
        }
    }
}
