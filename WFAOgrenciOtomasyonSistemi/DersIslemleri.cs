using OgrenciVeri.Koleksiyonlar;
using OgrenciVeri.Siniflar;
using OkulVeri.Enumlar;
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
    public partial class DersIslemleri : Form
    {
        private readonly OgrenciVerileri _veri;

        public DersIslemleri(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
            dgvDersler.AutoGenerateColumns = false;
            dgvDersler.DataSource = _veri.Dersler;
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            string dersAdi = txtDersAdi.Text.Trim();
            string dersKodu = txtDersKodu.Text.Trim();
            int dersKredisi = (int)nudKredi.Value;

            if (string.IsNullOrEmpty(dersAdi) || string.IsNullOrEmpty(dersKodu) || dersKredisi == 0)
            {
                MessageBox.Show("Ders Adı/Kodu/Kredisi boş bırakılamaz!");
                return;
            }

            if (btnDersEkle.Text == "Dersi Ekle")
            {
                _veri.Dersler.Add(new Ders(dersKodu, dersAdi, dersKredisi));
                MessageBox.Show($"{dersAdi} başarıyla eklendi.");
                dgvDersler.Show();
                btnDersGuncelle.Show();
                btnDersSil.Show();
            }
            else if (guncellenecekDers != null)
            {
                guncellenecekDers.DersAdi = txtDersAdi.Text;
                guncellenecekDers.DersKodu = txtDersKodu.Text;
                guncellenecekDers.Kredi = (int)nudKredi.Value;
                _veri.Dersler.ResetBindings();
            }

            Sifirla();
        }

        private void Temizle(GroupBox gbox)
        {
            foreach (var item in gbox.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
                return;
            var ders = SecilenDers();

            DialogResult dr = MessageBox.Show($"{ders.DersAdi} dersini silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
                _veri.Dersler.Remove(ders);
            else
                MessageBox.Show("Ders silme işlemi iptal edildi.");
        }

        private Ders SecilenDers()
        {
            var row = dgvDersler.SelectedRows[0];
            var ders = (Ders)row.DataBoundItem;

            return ders;
        }

        Ders? guncellenecekDers;
        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ders Seçilmedi!");
                return;
            }

            btnDersEkle.Text = "Dersi Kaydet";

            if (btnDersGuncelle.Text == "Güncelle")
            {
                var ders = SecilenDers();
                guncellenecekDers = ders;
                txtDersAdi.Text = ders.DersAdi;
                txtDersKodu.Text = ders.DersKodu;
                nudKredi.Value = ders.Kredi;
                btnDersGuncelle.Text = "İptal";
                dgvDersler.Enabled = false;
            }
            else
            {
                Sifirla();
            }
        }

        private void Sifirla()
        {
            btnDersGuncelle.Text = "Güncelle";
            btnDersEkle.Text = "Dersi Ekle";
            Temizle(gbUniversiteyeDersEkle);
            dgvDersler.Enabled = true;
            nudKredi.Value = 0;
            guncellenecekDers = null;
        }
    }
}
