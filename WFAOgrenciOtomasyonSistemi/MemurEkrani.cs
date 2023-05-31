using OgrenciVeri.Siniflar;
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
    public partial class MemurEkrani : Form
    {
        private readonly OgrenciVerileri _veri;

        public MemurEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
        }

        private void pbOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            new OgrenciIslemleri(_veri).ShowDialog();
        }

        private void pbDonemIslemleri_Click(object sender, EventArgs e)
        {
            if (_veri.Ogrenciler.Count <= 0)
            {
                MessageBox.Show("Sistemde kayıtlı öğrenci bulunmamaktadır!");
                return;
            }

            new DonemIslemleri(_veri).ShowDialog();
        }

        private void pbDersIslemleri_Click(object sender, EventArgs e)
        {
            new DersIslemleri(_veri).ShowDialog();
        }
    }
}
