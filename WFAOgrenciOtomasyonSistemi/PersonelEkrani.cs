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
    public partial class PersonelEkrani : Form
    {
        private readonly OgrenciVerileri _veri;

        public PersonelEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();

        }

        private void pbOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            new OgrenciIslemleri(_veri).ShowDialog();
        }

        private void pbDersIslemleri_Click(object sender, EventArgs e)
        {
            new DersIslemleri(_veri).ShowDialog();
        }

        private void pbDonemIslemleri_Click(object sender, EventArgs e)
        {
            new DonemIslemleri(_veri).ShowDialog();
        }
    }
}
