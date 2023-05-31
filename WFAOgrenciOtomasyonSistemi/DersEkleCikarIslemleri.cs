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
    public partial class DersEkleCikarIslemleri : Form
    {
        private readonly OgrenciVerileri _veri;

        private readonly Ogrenci _secilenOgrenci;

        public DersEkleCikarIslemleri(OgrenciVerileri veri, Ogrenci secilenOgrenci)
        {
            _veri = veri;
            _secilenOgrenci = secilenOgrenci;
            InitializeComponent();
            BilgileriYukle();
            DersleriYukle();
        }

        private void BilgileriYukle()
        {
            lblOgrenciAdSoyad.Text = $"{_secilenOgrenci.OgrenciAd} {_secilenOgrenci.OgrenciSoyad}";
            cbOgrenciDonemSec.Items.Clear();
            cbOgrenciDonemSec.DataSource = _secilenOgrenci.Donemler;
        }

        private void DersleriYukle()
        {
            pnlDersler.Controls.Clear();

            int genislik = 150;
            int konumX = 25;
            int konumY = 25;

            for (int i = 0; i < _veri.Dersler.Count; i++)
            {
                if (konumX > (pnlDersler.Width - genislik))
                {
                    konumX = 25;
                    konumY += 75;
                }

                pnlDersler.Controls.Add(new CheckBox { Name = $"chbDers{i}", Text = _veri.Dersler[i].DersAdi, AutoSize = true, Size = new Size(genislik, 25), Location = new Point(konumX, konumY), Tag = i }); ;

                konumX += 275;
            }
        }

        private void btnDersKayit_Click(object sender, EventArgs e)
        {
            if (!(pnlDersler.Controls.OfType<CheckBox>().Any(x => x.Checked)))
            {
                MessageBox.Show("Ders seçilmediği için kayıt işlemi yapılamaz!");
                return;
            }

            var secilenDonem = _secilenOgrenci.Donemler.First(x => x == (Donem)cbOgrenciDonemSec.SelectedItem);

            secilenDonem.Dersler.Clear();

            foreach (var item in pnlDersler.Controls.OfType<CheckBox>())
            {
                if (item.Checked)
                {
                    secilenDonem.Dersler.Add(_veri.Dersler[(int)item.Tag]);
                }
            }

            MessageBox.Show($"{string.Join(",\r\n", secilenDonem.Dersler)} dersleri başarıyla eklendi.");
        }
    }
}
