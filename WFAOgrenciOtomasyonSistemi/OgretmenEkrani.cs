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
    public partial class OgretmenEkrani : Form
    {
        private readonly OgrenciVerileri _veri;

        public OgretmenEkrani(OgrenciVerileri veri)
        {
            _veri = veri;
            InitializeComponent();
        }

        private void pbNotGir_Click(object sender, EventArgs e)
        {
            if (_veri.Ogrenciler.Count <= 0)
            {
                MessageBox.Show("Sistemde kayıtlı öğrenci bulunmamaktadır!");
                return;
            }

            new NotEkrani(_veri).ShowDialog();
        }
    }
}
