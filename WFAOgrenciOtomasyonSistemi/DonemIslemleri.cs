using OgrenciVeri.Siniflar;
using OkulVeri.Koleksiyonlar;
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
    public partial class DonemIslemleri : Form
    {
        private readonly OgrenciVerileri _veri;

        private readonly BindingList<Donem> donemler;

        public DonemIslemleri(OgrenciVerileri veri)
        {
            _veri = veri;
            donemler = new BindingList<Donem>();
            InitializeComponent();
            dgvOgrenciListesi.AutoGenerateColumns = false;
            dgvSecilenOgrencininDonemleri.AutoGenerateColumns = false;
            DonemOlustur();
            Listele();
        }

        private void DonemOlustur()
        {
            for (int i = 0; i < 8; i++)
            {
                donemler.Add(new Donem());
            }
        }

        private void Listele()
        {
            foreach (var item in Controls.OfType<ComboBox>())
                item.Items.Clear();

            cbOgrenciListesi.DataSource = _veri.Ogrenciler;
            cbDonemListesi.DataSource = donemler;
        }

        private void btnDonemEkle_Click(object sender, EventArgs e)
        {
            if (cbOgrenciListesi.SelectedItem == null || cbDonemListesi.SelectedItem == null)
            {
                MessageBox.Show("Öğrenci/Dönem seçilmedi!");
                return;
            }
            var ogrenci = (Ogrenci)cbOgrenciListesi.SelectedItem;
            var donem = (Donem)cbDonemListesi.SelectedItem;

            if (btnDonemEkle.Text == "Dönem Ekle")
            {
                ogrenci.Donemler.Add(donem);

                dgvOgrenciListesi.DataSource = _veri.Ogrenciler.Where(x => x.Donemler.Count > 0).ToList();
            }
            else if (guncellenecekDonem != null)
            {
                guncellenecekDonem.DonemAdi = donem.DonemAdi;
                _veri.Donemler.ResetBindings();
            }

            Sifirla();
        }

        private void Sifirla()
        {
            btnDonemEkle.Text = "Dönem Ekle";
            btnDonemGuncelle.Text = "Güncelle";
            dgvSecilenOgrencininDonemleri.Enabled = true;
            Temizle();
            guncellenecekDonem = null;
            cbOgrenciListesi.Enabled = true;
        }

        private void Temizle()
        {
            foreach (var item in Controls.OfType<ComboBox>())
            {
                item.SelectedIndex = 0;
            }
        }

        private void btnDonemSil_Click(object sender, EventArgs e)
        {
            if (dgvSecilenOgrencininDonemleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçili dönem yok !");
                return;
            }

            var ogrenci = (Ogrenci)dgvOgrenciListesi.SelectedRows[0].DataBoundItem;
            var donem = (Donem)dgvSecilenOgrencininDonemleri.SelectedRows[0].DataBoundItem;

            DialogResult dr = MessageBox.Show($"{ogrenci.OgrenciAd} {ogrenci.OgrenciSoyad} adlı öğrenciden {donem.DonemAdi} silinecektir, onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                ogrenci.Donemler.Remove(donem);
            }
            else
            {
                MessageBox.Show("Dönem silme işlemi iptal edildi.");
            }
        }

        Donem? guncellenecekDonem;
        private void btnDonemGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvSecilenOgrencininDonemleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçili dönem yok !");
                return;
            }

            btnDonemEkle.Text = "Dönemi Kaydet";

            if (btnDonemGuncelle.Text == "Güncelle")
            {
                var donem = SecilenDonem();
                guncellenecekDonem = donem;
                cbOgrenciListesi.SelectedItem = tiklananOgrenci;
                cbOgrenciListesi.Enabled = false;
                cbDonemListesi.SelectedItem = donem;
                btnDonemGuncelle.Text = "İptal";
                dgvSecilenOgrencininDonemleri.Enabled = false;
            }
            else
            {
                Sifirla();
            }
        }

        private Donem SecilenDonem()
        {
            return (Donem)dgvSecilenOgrencininDonemleri.SelectedRows[0].DataBoundItem;
        }

        Ogrenci? tiklananOgrenci;
        private void dgvOgrenciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSecilenOgrencininDonemleri.DataSource = null;
            tiklananOgrenci = null;

            if (e.RowIndex >= 0)
            {
                tiklananOgrenci = (Ogrenci)dgvOgrenciListesi.Rows[e.RowIndex].DataBoundItem;
                dgvSecilenOgrencininDonemleri.DataSource = tiklananOgrenci.Donemler;
            }
            KontrolleriGoster();
        }

        private void KontrolleriGoster()
        {
            btnDonemGuncelle.Show();
            btnDonemSil.Show();
        }
    }
}
