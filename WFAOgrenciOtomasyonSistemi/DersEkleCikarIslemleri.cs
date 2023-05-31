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
        }

        private void BilgileriYukle()
        {
            lblOgrenciAdSoyad.Text = $"{_secilenOgrenci.OgrenciAd} {_secilenOgrenci.OgrenciSoyad}";
            cbOgrenciDonemSec.Items.Clear();
            cbOgrenciDonemSec.DataSource = _secilenOgrenci.Donemler;
        }
    }
}
